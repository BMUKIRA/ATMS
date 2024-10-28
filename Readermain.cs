using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CRT284UTESTDLL;

namespace CRT284U
{
    public partial class Readermain : Form
    {
        UInt32 Hdle = 0;

        public Readermain()
        {
            InitializeComponent();
            CPUAPDUCOMMAND.SelectedIndex = 0;
        }

        private void OpenCommBtn_Click(object sender, EventArgs e)
        {
            Hdle = DllClass.USBOpen();
            if (Hdle != 0)
            {
                CommPortStatusLabel.Text = "Connect Device Success";
            }
            else
            {
                CommPortStatusLabel.Text = "Connect Device Error";
            }
        }

        private void Readermain_Load(object sender, EventArgs e)
        {

        }

        private void CloseCommBtn_Click(object sender, EventArgs e)
        {
            if (Hdle != 0)
            {
                int i = DllClass.USBClose(Hdle);
                Hdle = 0;
                CommPortStatusLabel.Text = "Disconnect Device Success";
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            if (Hdle != 0)
            {

                byte Cm, Pm;
                UInt16 TxDataLen, RxDataLen;
                byte[] TxData = new byte[1024];
                byte[] RxData = new byte[1024];

                Cm = 0x30;
                Pm = 0x30;

                TxDataLen = 0;
                RxDataLen = 0;

                int i = DllClass.USB_ExeCommand(Hdle, Cm, Pm, TxDataLen, TxData, ref RxDataLen, RxData);
                if (i == 0)
                {
                    if (RxDataLen > 0)
                    {

                         MessageBox.Show("INITIALIZE OK", "INITIALIZE");
                    }
                    else
                    {
                         MessageBox.Show("Communication Error", "Caution");
                    }
                }
                else
                {
                    MessageBox.Show("Communication Error", "Caution");
                }
            }
            else
            {
                MessageBox.Show("Comm. port is not Opened", "Caution");
            }
        }

        private void IRStatus_Click(object sender, EventArgs e)
        {
            if (Hdle != 0)
            {

                byte Cm, Pm;
                UInt16 TxDataLen, RxDataLen;
                byte[] TxData = new byte[1024];
                byte[] RxData = new byte[1024];

                Cm = 0x31;
                Pm = 0x30;

                TxDataLen = 0;
                RxDataLen = 0;

                int i = DllClass.USB_ExeCommand(Hdle, Cm, Pm, TxDataLen, TxData, ref RxDataLen, RxData);
                if (i == 0)
                {
                    if (RxDataLen > 0)
                    {
                        switch (RxData[0])
                        {
                            case 89:
                                MessageBox.Show("One Card in the reader", "Status");
                                break;
                            case 78:
                                MessageBox.Show("No Card in the reader", "Status");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Communication Error", "Caution");
                    }
                }
                else
                {
                    MessageBox.Show("Communication Error", "Caution");
                }
            }
            else
            {
                MessageBox.Show("Comm. port is not Opened", "Caution");
            }
        }

        private void ICTestTypeBtn_Click(object sender, EventArgs e)
        {
            if (Hdle != 0)
            {

                byte Cm, Pm;
                UInt16 TxDataLen, RxDataLen;
                byte[] TxData = new byte[1024];
                byte[] RxData = new byte[1024];

                Cm = 0x31;
                Pm = 0x31;

                TxDataLen = 0;
                RxDataLen = 0;

                int i = DllClass.USB_ExeCommand(Hdle, Cm, Pm, TxDataLen, TxData, ref RxDataLen, RxData);
                if (i == 0)
                {
                    if (RxDataLen > 0)
                    {
                        switch (RxData[0])
                        {
                            case 78:
                                switch (RxData[1])
                                {
                                    case 48:
                                        MessageBox.Show("No Card In The Reader", "AutoTestCardType");
                                        break;
                                    case 49:
                                        MessageBox.Show("Unknow Type", "AutoTestCardType");
                                        break;
                                    case 50:
                                        MessageBox.Show("The card is not on the IC card operation position", "AutoTestCardType");
                                        break;
                                }
                                break;
                            case 48:
                                switch (RxData[1])
                                {
                                    case 48:
                                        MessageBox.Show("RF S50", "AutoTestCardType");
                                        break;
                                    case 49:
                                        MessageBox.Show("RF S70", "AutoTestCardType");
                                        break;
                                    case 50:
                                        MessageBox.Show("RF UL", "AutoTestCardType");
                                        break;
                                    case 52:
                                        MessageBox.Show("TYPE A CPU", "AutoTestCardType");
                                        break;
                                    case 53:
                                        MessageBox.Show("TYPE B CPU", "AutoTestCardType");
                                        break;
                                    case 57:
                                        MessageBox.Show("RF Card But Unknow Type", "AutoTestCardType");
                                        break;
                                }
                                break;
                            case 49:
                                switch (RxData[1])
                                {
                                    case 48:
                                        MessageBox.Show("CPU Card(T=0)", "AutoTestCardType");
                                        break;
                                    case 49:
                                        MessageBox.Show("CPU Card(T=1)", "AutoTestCardType");
                                        break;
                                }
                                break;
                            case 50:
                                switch (RxData[1])
                                {
                                    case 48:
                                        MessageBox.Show("24C01", "AutoTestCardType");
                                        break;
                                    case 49:
                                        MessageBox.Show("24C02", "AutoTestCardType");
                                        break;
                                    case 50:
                                        MessageBox.Show("24C04", "AutoTestCardType");
                                        break;
                                    case 51:
                                        MessageBox.Show("24C08", "AutoTestCardType");
                                        break;
                                    case 52:
                                        MessageBox.Show("24C16", "AutoTestCardType");
                                        break;
                                    case 53:
                                        MessageBox.Show("24C32", "AutoTestCardType");
                                        break;
                                    case 54:
                                        MessageBox.Show("24C64", "AutoTestCardType");
                                        break;
                                    case 55:
                                        MessageBox.Show("24C128", "AutoTestCardType");
                                        break;
                                    case 56:
                                        MessageBox.Show("24C256", "AutoTestCardType");
                                        break;
                                }
                                break;
                            case 51:
                                switch (RxData[1])
                                {
                                    case 48:
                                        MessageBox.Show("SLE4442", "AutoTestCardType");
                                        break;
                                    case 49:
                                        MessageBox.Show("SLE4428", "AutoTestCardType");
                                        break;
                                }
                                break;
                            case 52:
                                switch (RxData[1])
                                {
                                    case 48:
                                        MessageBox.Show("AT88S102", "AutoTestCardType");
                                        break;
                                    case 49:
                                        MessageBox.Show("AT88S1608", "AutoTestCardType");
                                        break;
                                    case 50:
                                        MessageBox.Show("AT45D041", "AutoTestCardType");
                                        break;
                                    case 51:
                                        MessageBox.Show("AT88S1608", "AutoTestCardType");
                                        break;
                                }
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Communication Error", "Caution");
                    }
                }
                else
                {
                    MessageBox.Show("Communication Error", "Caution");
                }
            }
            else
            {
                MessageBox.Show("Comm. port is not Opened", "Caution");
            }
        }

        private void CPUColdResetBtn_Click(object sender, EventArgs e)
        {
            if (Hdle != 0)
            {

                string StrBuf = "";
                int n;

                byte Cm, Pm;
                UInt16 TxDataLen, RxDataLen;
                byte[] TxData = new byte[1024];
                byte[] RxData = new byte[1024];

                CPUResetText.Text = "";

                Cm = 0x37;
                Pm = 0x30;

                TxDataLen = 1;
                RxDataLen = 0;

                if (CPUModeOption1.Checked)
                {
                    TxData[0] = 0x30;
                }
                else
                {
                    TxData[0] = 0x31;
                }

                int i = DllClass.USB_ExeCommand(Hdle, Cm, Pm, TxDataLen, TxData, ref RxDataLen, RxData);
                if (i == 0)
                {

                    if (RxDataLen > 0)
                    {
                        switch (RxData[0])
                        {
                            case 89:

                                for (n = 3; n < RxDataLen; n++)
                                {
                                    StrBuf += RxData[n].ToString("X2");
                                }
                                CPUResetText.Text = StrBuf;
                                MessageBox.Show("Cold Reset OK (T=0)", "Cold Reset");
                                break;
                            case 90:

                                for (n = 3; n < RxDataLen; n++)
                                {
                                    StrBuf += RxData[n].ToString("X2");
                                }
                                CPUResetText.Text = StrBuf;
                                MessageBox.Show("Cold Reset OK (T=1)", "Cold Reset");
                                break;

                            case 78:
                                MessageBox.Show("Cold Reset Error", "Cold Reset");
                                break;
                            case 69:
                                MessageBox.Show("No Card In The Reader", "Cold Reset");
                                break;
                            case 87:
                                MessageBox.Show("The card is not at the IC card position", "Cold Reset");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Communication Error", "Caution");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Communication Error", "Caution");
                }
            }
            else
            {
                MessageBox.Show("Comm. port is not Opened", "Caution");
            }
        }

        private void CPUWarmResetBtn_Click(object sender, EventArgs e)
        {
            if (Hdle != 0)
            {

                byte Cm, Pm;
                UInt16 TxDataLen, RxDataLen;
                byte[] TxData = new byte[1024];
                byte[] RxData = new byte[1024];

                CPUResetText.Text = "";

                Cm = 0x37;
                Pm = 0x2f;

                TxDataLen = 0;
                RxDataLen = 0;

                int i = DllClass.USB_ExeCommand(Hdle, Cm, Pm, TxDataLen, TxData, ref RxDataLen, RxData);
                if (i == 0)
                {

                    if (RxDataLen > 0)
                    {
                        switch (RxData[0])
                        {
                            case 89:
                                int n;
                                string StrBuf = "";

                                for (n = 3; n < RxDataLen; n++)
                                {
                                    StrBuf += RxData[n].ToString("X2");
                                }
                                CPUResetText.Text = StrBuf;
                                MessageBox.Show("Warm Reset OK ", "Warm Reset");
                                break;
                            case 78:
                                MessageBox.Show("Warm Reset Error", "Warm Reset");
                                break;
                            case 69:
                                MessageBox.Show("No Card In The Reader", "Warm Reset");
                                break;
                            case 87:
                                MessageBox.Show("The card is not at the IC card position", "Warm Reset");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Communication Error", "Caution");
                    }
                }
                else
                {
                    MessageBox.Show("Communication Error", "Caution");
                }
            }
            else
            {
                MessageBox.Show("Comm. port is not Opened", "Caution");
            }

        }

        private void SendAPDUbtn_Click(object sender, EventArgs e)
        {
            if (Hdle != 0)
            {

                byte Cm, Pm;
                UInt16 TxDataLen, RxDataLen;
                byte[] TxData = new byte[1024];
                byte[] RxData = new byte[1024];

                Cm = 0x37;
                if (CPUModeOption3.Checked)
                {
                    Pm = 0x31;
                }
                else
                {
                    Pm = 0x32;
                }


                TxDataLen = (UInt16)(CPUAPDUCOMMAND.Text.Length / 2);
                RxDataLen = 0;
                TxData[0] =(byte) (TxDataLen / 256);
                TxData[1] = (byte) (TxDataLen % 256);

                CpuBackText.Text = "";

                for (int N = 0; N < (CPUAPDUCOMMAND.Text.Length / 2); N++)
                {
                    TxData[N+2] = byte.Parse(CPUAPDUCOMMAND.Text.Substring(N * 2, 2), NumberStyles.HexNumber);
                }
                TxDataLen = (UInt16) (TxDataLen + 2);
                int i = DllClass.USB_ExeCommand(Hdle, Cm, Pm, TxDataLen, TxData, ref RxDataLen, RxData);
                if (i == 0)
                {

                    if (RxDataLen > 0)
                    {
                        switch (RxData[0])
                        {
                            case 89:
                                int n;
                                string StrBuf = "";

                                for (n = 3; n < RxDataLen; n++)
                                {
                                    StrBuf += RxData[n].ToString("X2");
                                }
                                CpuBackText.Text = StrBuf;
                                MessageBox.Show("Send APDU Success", "C-APDU");
                                break;
                            case 78:
                                MessageBox.Show("C-APDU Error", "C-APDU");
                                break;
                            case 69:
                                MessageBox.Show("No Card In The Reader", "C-APDU");
                                break;
                            case 87:
                                MessageBox.Show("The card is not at the IC card position", "C-APDU");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Communication Error", "Caution");
                    }
                }
                else
                {
                    MessageBox.Show("Communication Error", "Caution");
                }
            }
            else
            {
                MessageBox.Show("Comm. port is not Opened", "Caution");
            }
        }

        private void CPUDownbtn_Click(object sender, EventArgs e)
        {
            if (Hdle != 0)
            {

                byte Cm, Pm;
                UInt16 TxDataLen, RxDataLen;
                byte[] TxData = new byte[1024];
                byte[] RxData = new byte[1024];

                Cm = 0x33;
                Pm = 0x31;

                TxDataLen = 0;
                RxDataLen = 0;

                int i = DllClass.USB_ExeCommand(Hdle, Cm, Pm, TxDataLen, TxData, ref RxDataLen, RxData);
                if (i == 0)
                {
                    if (RxDataLen > 0)
                    {
                        switch (RxData[0])
                        {
                            case 89:
                                MessageBox.Show("Power Off OK", "Power Off");
                                break;
                            case 78:
                                MessageBox.Show("Power Off Error", "Power Off");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Communication Error", "Caution");
                    }
                }
                else
                {
                    MessageBox.Show("Communication Error", "Caution");
                }
            }
            else
            {
                MessageBox.Show("Comm. port is not Opened", "Caution");
            }
        }

        private void MagReadBtn_Click(object sender, EventArgs e)
        {
            if (Hdle != 0)
            {

                Track1DataTxt.Text = "";
                Track2DataTxt.Text = "";
                Track3DataTxt.Text = "";
                int i = -1;

                byte Cm, Pm;
                UInt16 TxDataLen, RxDataLen;
                byte[] TxData = new byte[1024];
                byte[] RxData = new byte[1024];

                Cm = 0x45;
                Pm = 0x30;
                TxData[0] = 0x30;
                if (ReadTrack1.Checked == true && ReadTrack2.Checked == true && ReadTrack3.Checked == true)
                {
                    TxData[1] = 0x37;
                }
                else if (ReadTrack1.Checked == true && ReadTrack2.Checked == true && ReadTrack3.Checked == false)
                {
                    TxData[1] = 0x34;
                }
                else if (ReadTrack1.Checked == false && ReadTrack2.Checked == true && ReadTrack3.Checked == true)
                {
                    TxData[1] = 0x35;
                }
                else if (ReadTrack1.Checked == true && ReadTrack2.Checked == false && ReadTrack3.Checked == true)
                {
                    TxData[1] = 0x36;
                }
                else if (ReadTrack1.Checked == true && ReadTrack2.Checked == false && ReadTrack3.Checked == false)
                {
                    TxData[1] = 0x31;
                }
                else if (ReadTrack1.Checked == false && ReadTrack2.Checked == true && ReadTrack3.Checked == false)
                {
                    TxData[1] = 0x32;
                }
                else if (ReadTrack1.Checked == false && ReadTrack2.Checked == false && ReadTrack3.Checked == true)
                {
                    TxData[1] = 0x33;
                }
                else
                {
                    TxData[1] = 0x30;
                }
                TxDataLen = 2;
                RxDataLen = 0;

                 i = DllClass.USB_ExeCommand(Hdle, Cm, Pm, TxDataLen, TxData, ref RxDataLen, RxData);
                if (i == 0)
                {
                    int n;
                    int weizhi1 = 0;
                    int weizhi2 = 0; 
                    int weizhi3 = 0;
                    string Tra1Buf = "";
                    string Tra2Buf = "";
                    string Tra3Buf = "";

                    for (n = 0; n < RxDataLen; n++)
                    {
                        if (RxData[n] == 31)
                        {
                            weizhi1 = n;
                            break;
                        }
                    }
                    for (n = weizhi1 + 1; n < RxDataLen; n++)
                    {
                        if (RxData[n] == 31)
                        {
                            weizhi2 = n;
                            break;
                        }
                    }
                    for (n = weizhi2 + 1; n < RxDataLen; n++)
                    {
                        if (RxData[n] == 31)
                        {
                            weizhi3 = n;
                            break;
                        }
                    }
                    switch (RxData[weizhi1 + 1])
                    {
                        case 89:
                            for (n = weizhi1 + 2; n < weizhi2 - 1; n++)
                            {
                                //Tra1Buf += RxData[n].ToString(); 
                                Tra1Buf += (char)RxData[n];
                            }
                            Track1DataTxt.Text = Tra1Buf;
                            break;
                        case 78:
                            Track1DataTxt.Text = "Read/Parity Error" + Environment.NewLine;
                            switch (RxData[weizhi1 + 2])
                            {
                                case 225:
                                    Track1DataTxt.Text = Track1DataTxt.Text + "No start bits (STX)";
                                    break;
                                case 226:
                                    Track1DataTxt.Text = Track1DataTxt.Text + "No stop bits (ETX)";
                                    break;
                                case 227:
                                    Track1DataTxt.Text = Track1DataTxt.Text + "Byte Parity Error(Parity))";
                                    break;
                                case 228:
                                    Track1DataTxt.Text = Track1DataTxt.Text + "Parity Bit Error(LRC)";
                                    break;
                                case 229:
                                    Track1DataTxt.Text = Track1DataTxt.Text + "Card Track Data is Blank";
                                    break;
                            }
                            break;
                        case 79:
                            Track1DataTxt.Text = "No Read for this Track" + Environment.NewLine + "Card Track Data is 0xE0";
                            break;
                        case 0:
                            Track1DataTxt.Text = "No Read Operation" + Environment.NewLine + "Card Track Data is 0x00";
                            break;
                    }
                    switch (RxData[weizhi2 + 1])
                    {
                        case 89:
                            for (n = weizhi2 + 2; n < weizhi3 - 1; n++)
                            {
                                //Tra1Buf += RxData[n].ToString(); 
                                Tra2Buf += (char)RxData[n];
                            }
                            Track2DataTxt.Text = Tra2Buf;
                            break;
                        case 78:
                            Track2DataTxt.Text = "Read/Parity Error" + Environment.NewLine;
                            switch (RxData[weizhi2 + 2])
                            {
                                case 225:
                                    Track2DataTxt.Text = Track2DataTxt.Text + "No start bits (STX)";
                                    break;
                                case 226:
                                    Track2DataTxt.Text = Track2DataTxt.Text + "No stop bits (ETX)";
                                    break;
                                case 227:
                                    Track2DataTxt.Text = Track2DataTxt.Text + "Byte Parity Error(Parity))";
                                    break;
                                case 228:
                                    Track2DataTxt.Text = Track2DataTxt.Text + "Parity Bit Error(LRC)";
                                    break;
                                case 229:
                                    Track2DataTxt.Text = Track2DataTxt.Text + "Card Track Data is Blank";
                                    break;
                            }
                            break;
                        case 79:
                            Track2DataTxt.Text = "No Read for this Track" + Environment.NewLine + "Card Track Data is 0xE0";
                            break;
                        case 0:
                            Track2DataTxt.Text = "No Read Operation" + Environment.NewLine + "Card Track Data is 0x00";
                            break;
                    }
                    switch (RxData[weizhi3 + 1])
                    {
                        case 89:
                            for (n = weizhi3 + 2; n < RxDataLen - 1; n++)
                            {
                                //Tra1Buf += RxData[n].ToString(); 
                                Tra3Buf += (char)RxData[n];
                            }
                            Track3DataTxt.Text = Tra3Buf;
                            break;
                        case 78:
                            Track3DataTxt.Text = "Read/Parity Error" + Environment.NewLine;
                            switch (RxData[weizhi3 + 2])
                            {
                                case 225:
                                    Track3DataTxt.Text = Track3DataTxt.Text + "No start bits (STX)";
                                    break;
                                case 226:
                                    Track3DataTxt.Text = Track3DataTxt.Text + "No stop bits (ETX)";
                                    break;
                                case 227:
                                    Track3DataTxt.Text = Track3DataTxt.Text + "Byte Parity Error(Parity))";
                                    break;
                                case 228:
                                    Track3DataTxt.Text = Track3DataTxt.Text + "Parity Bit Error(LRC)";
                                    break;
                                case 229:
                                    Track3DataTxt.Text = Track3DataTxt.Text + "Card Track Data is Blank";
                                    break;
                            }
                            break;
                        case 79:
                            Track3DataTxt.Text = "No Read for this Track" + Environment.NewLine + "Card Track Data is 0xE0";
                            break;
                        case 0:
                            Track3DataTxt.Text = "No Read Operation" + Environment.NewLine + "Card Track Data is 0x00";
                            break;
                    }
                    MessageBox.Show("Mag-Card Read OK", "Mag-Card Read");
                }
                else
                {
                    MessageBox.Show("Mag-Card Read Error", "Mag-Card Read");
                }
            }
            else
            {
                MessageBox.Show("Comm. port is not Opened", "Caution");
            }
        }

        private void ClearBufferBtn_Click(object sender, EventArgs e)
        {
            if (Hdle != 0)
            {

                byte Cm, Pm;
                UInt16 TxDataLen, RxDataLen;
                byte[] TxData = new byte[1024];
                byte[] RxData = new byte[1024];

                Cm = 0x45;
                Pm = 0x39;

                TxDataLen = 0;
                RxDataLen = 0;

                int i = DllClass.USB_ExeCommand(Hdle, Cm, Pm, TxDataLen, TxData, ref RxDataLen, RxData);
                if (i == 0)
                {
                    if (RxDataLen > 0)
                    {
                        switch (RxData[0])
                        {
                            case 89:
                                MessageBox.Show("Clear Buffer OK", "Clear Buffer");
                                break;
                            case 78:
                                MessageBox.Show("Clear Buffer Error", "Clear Buffer");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Communication Error", "Caution");
                    }
                }
                else
                {
                    MessageBox.Show("Communication Error", "Caution");
                }
            }
            else
            {
                MessageBox.Show("Comm. port is not Opened", "Caution");
            }
        }

    }
}