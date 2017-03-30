using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace CodeJetSerialPortUtility
{
    public partial class Form1 : Form
    {
        private SerialPort m_Port;
        public Form1()
        {
            InitializeComponent();
            m_Port = new SerialPort();
            m_Port.DataReceived += new SerialDataReceivedEventHandler(m_Port_DataReceived);
            m_Port.PinChanged += new SerialPinChangedEventHandler(m_Port_PinChanged);
            m_Port.ErrorReceived += new SerialErrorReceivedEventHandler(m_Port_ErrorReceived);

            this.Location = new Point(166, 60);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            m_Port.Close();
            m_Port.DataReceived -= new SerialDataReceivedEventHandler(m_Port_DataReceived);
            m_Port.PinChanged -= new SerialPinChangedEventHandler(m_Port_PinChanged);
            m_Port.ErrorReceived -= new SerialErrorReceivedEventHandler(m_Port_ErrorReceived);
            m_Port.Dispose();
            base.OnClosing(e);
        }

        private delegate void ErrorReceivedDelegate(SerialErrorReceivedEventArgs e);
        private delegate void PinChangeDelegate(SerialPinChangedEventArgs e);
        private delegate void DataReceivedDelegate(SerialDataReceivedEventArgs e);

        void m_Port_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            if (InvokeRequired)
            {
                ErrorReceivedDelegate d = new ErrorReceivedDelegate(ErrorReceived);
                Invoke(d, new object[] { e });
            }
            else
            {
                ErrorReceived(e);
            }
        }

        private void ErrorReceived(SerialErrorReceivedEventArgs e)
        {
            switch (e.EventType)
            {
                case SerialError.Frame:
                    pictureBox_StatusError.BackColor = Color.Red;
                    break;
                case SerialError.Overrun:
                    pictureBox_StatusError.BackColor = Color.Orange;
                    break;
                case SerialError.RXOver:
                    pictureBox_StatusError.BackColor = Color.Blue;
                    break;
                case SerialError.RXParity:
                    pictureBox_StatusError.BackColor = Color.Purple;
                    break;
                case SerialError.TXFull:
                    pictureBox_StatusError.BackColor = Color.Yellow;
                    break;
            }
        }

        void m_Port_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
            if (InvokeRequired)
            {
                PinChangeDelegate d = new PinChangeDelegate(ChangePin);
                Invoke(d, new object[] { e });
            }
            else
            {
                ChangePin(e);
            }
        }

        private void ChangePin(SerialPinChangedEventArgs e)
        {
            switch (e.EventType)
            {
                case SerialPinChange.Break:
                    pictureBox_StatusBreak.BackColor = m_Port.BreakState ? Color.Red : Color.Silver;
                    break;
                case SerialPinChange.CDChanged:
                    pictureBox_StatusDcd.BackColor = m_Port.CDHolding ? Color.LightGreen : Color.Silver;
                    break;
                case SerialPinChange.CtsChanged:
                    pictureBox_StatusCts.BackColor = m_Port.CtsHolding ? Color.LightGreen :Color.Silver;
                    break;
                case SerialPinChange.DsrChanged:
                    pictureBox_StatusDsr.BackColor = m_Port.DsrHolding ? Color.LightGreen : Color.Silver;
                    break;
                case SerialPinChange.Ring:
                    pictureBox_StatusRing.BackColor = pictureBox_StatusRing.BackColor == Color.Red ? Color.Silver : Color.Red;
                    break;
            }
        }

        void m_Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (InvokeRequired)
            {
                DataReceivedDelegate d = new DataReceivedDelegate(UpdateTextBox);
                Invoke(d, new object[] { e });
            }
            else
            {
                UpdateTextBox(e);
            }
        }

        private void UpdateTextBox(SerialDataReceivedEventArgs e)
        {
            pictureBox_StatusError.BackColor = Color.Silver;
            pictureBox_StatusRxd.BackColor = Color.Yellow;
            pictureBox_StatusRxd.Invalidate();
            pictureBox_StatusRxd.Update();
            textBox_Rx.Text += m_Port.ReadExisting();
            System.Threading.Thread.Sleep(20);
            pictureBox_StatusRxd.BackColor = Color.Silver;
            pictureBox_StatusRxd.Invalidate();
            pictureBox_StatusTxd.Update();
        }

        private void comboBox_PortName_GotFocus(object sender, EventArgs e)
        {
            comboBox_PortName.Items.Clear();
            string[] names = SerialPort.GetPortNames();
            foreach (string s in names)
                comboBox_PortName.Items.Add(s);
        }

        private void SetPinStatuses()
        {
            pictureBox_StatusConnected.BackColor = m_Port.IsOpen ? Color.LightGreen : Color.Silver;
            pictureBox_StatusBreak.BackColor = m_Port.BreakState ? Color.Red : Color.Silver;
            pictureBox_StatusDcd.BackColor = m_Port.CDHolding ? Color.LightGreen : Color.Silver;
            pictureBox_StatusCts.BackColor = m_Port.CtsHolding ? Color.LightGreen :Color.Silver;
            pictureBox_StatusDsr.BackColor = m_Port.DsrHolding ? Color.LightGreen : Color.Silver;
            pictureBox_StatusRing.BackColor = Color.Silver;
                    
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_Port.IsOpen)
                    m_Port.Close();

                if (comboBox_PortName.SelectedItem != null)
                {
                    string name = (string)comboBox_PortName.SelectedItem;
                    m_Port.PortName = name;
                }

                if (comboBox_BaudRate.SelectedItem != null)
                {
                    int baud = int.Parse((string)comboBox_BaudRate.SelectedItem);
                    m_Port.BaudRate = baud;
                }

                if (radioButton_HSRTS.Checked)
                    m_Port.Handshake = Handshake.RequestToSend;
                else if (radioButton_HSXon.Checked)
                    m_Port.Handshake = Handshake.XOnXOff;
                else if (radioButton_HSRTSXon.Checked)
                    m_Port.Handshake = Handshake.RequestToSendXOnXOff;
                else m_Port.Handshake = Handshake.None;

                if (radioButton_ParityNone.Checked)
                    m_Port.Parity = Parity.None;
                else if (radioButton_ParityOdd.Checked)
                    m_Port.Parity = Parity.Odd;
                else if (radioButton_ParityEven.Checked)
                    m_Port.Parity = Parity.Even;
                else if (radioButton_ParityMark.Checked)
                    m_Port.Parity = Parity.Mark;
                else if (radioButton_ParitySpace.Checked)
                    m_Port.Parity = Parity.Space;
                else m_Port.Parity = Parity.None;

                if (radioButton_DataBits5.Checked)
                    m_Port.DataBits = 5;
                else if (radioButton_DataBits6.Checked)
                    m_Port.DataBits = 6;
                else if (radioButton_DataBits7.Checked)
                    m_Port.DataBits = 7;
                else m_Port.DataBits = 8;

                if (radioButton_Stop0.Checked)
                    m_Port.StopBits = StopBits.None;
                else if (radioButton_Stop15.Checked)
                    m_Port.StopBits = StopBits.OnePointFive;
                else if (radioButton_Stop2.Checked)
                    m_Port.StopBits = StopBits.Two;
                else m_Port.StopBits = StopBits.One;

                if (radioButton_CRLF.Checked)
                    m_Port.NewLine = "\r\n";
                else m_Port.NewLine = "\n";

                m_Port.Open();

                SetPinStatuses();
            }
            catch { }
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_BaudRate.SelectedItem != null)
                {
                    int baud = int.Parse((string)comboBox_BaudRate.SelectedItem);
                    m_Port.BaudRate = baud;
                }

                if (radioButton_HSRTS.Checked)
                    m_Port.Handshake = Handshake.RequestToSend;
                else if (radioButton_HSXon.Checked)
                    m_Port.Handshake = Handshake.XOnXOff;
                else if (radioButton_HSRTSXon.Checked)
                    m_Port.Handshake = Handshake.RequestToSendXOnXOff;
                else m_Port.Handshake = Handshake.None;

                if (radioButton_ParityNone.Checked)
                    m_Port.Parity = Parity.None;
                else if (radioButton_ParityOdd.Checked)
                    m_Port.Parity = Parity.Odd;
                else if (radioButton_ParityEven.Checked)
                    m_Port.Parity = Parity.Even;
                else if (radioButton_ParityMark.Checked)
                    m_Port.Parity = Parity.Mark;
                else if (radioButton_ParitySpace.Checked)
                    m_Port.Parity = Parity.Space;
                else m_Port.Parity = Parity.None;

                if (radioButton_DataBits5.Checked)
                    m_Port.DataBits = 5;
                else if (radioButton_DataBits6.Checked)
                    m_Port.DataBits = 6;
                else if (radioButton_DataBits7.Checked)
                    m_Port.DataBits = 7;
                else m_Port.DataBits = 8;

                if (radioButton_Stop0.Checked)
                    m_Port.StopBits = StopBits.None;
                else if (radioButton_Stop15.Checked)
                    m_Port.StopBits = StopBits.OnePointFive;
                else if (radioButton_Stop2.Checked)
                    m_Port.StopBits = StopBits.Two;
                else m_Port.StopBits = StopBits.One;

                if (radioButton_CRLF.Checked)
                    m_Port.NewLine = "\r\n";
                else m_Port.NewLine = "\n";

                SetPinStatuses();
            }
            catch { }
        }

        private void button_Send_Click(object sender, EventArgs e)
        {
            if (m_Port.IsOpen)
            {
                pictureBox_StatusTxd.BackColor = Color.Yellow;
                pictureBox_StatusTxd.Invalidate();
                pictureBox_StatusTxd.Update();
                m_Port.Write(textBox_Tx.Text);
                System.Threading.Thread.Sleep(20);
                pictureBox_StatusTxd.BackColor = Color.Silver;
                pictureBox_StatusTxd.Invalidate();
                pictureBox_StatusTxd.Update();
            }

            SetPinStatuses();
        }

        private void button_SendLine_Click(object sender, EventArgs e)
        {
            if (m_Port.IsOpen)
            {
                pictureBox_StatusTxd.BackColor = Color.Yellow;
                pictureBox_StatusTxd.Invalidate();
                pictureBox_StatusTxd.Update();
                string s = AddCommandChecksum(textBox_Tx.Text);
                m_Port.WriteLine(s);
                System.Threading.Thread.Sleep(20);
                pictureBox_StatusTxd.BackColor = Color.Silver;
                pictureBox_StatusTxd.Invalidate();
                pictureBox_StatusTxd.Update();
            }

            SetPinStatuses();
        }

        private void button_SendClear_Click(object sender, EventArgs e)
        {
            textBox_Tx.Text = "";
        }

        private void button_ReceiveClear_Click(object sender, EventArgs e)
        {
            textBox_Rx.Text = "";
        }

        private void button_SetNewLine_Click(object sender, EventArgs e)
        {
            if (radioButton_CRLF.Checked)
                m_Port.NewLine = "\r\n";
            else m_Port.NewLine = "\n";
        }

        private string AddCommandChecksum(string s)
        {
            if (s != null && checkBox_Checksum.Checked)
            {
                int sum = 0;
                foreach (char c in s)
                    sum += (int)c;
                return s + ((256 - (sum & 0xff)) % 256).ToString("X2");
            }
            else return s;
        }
    }
}