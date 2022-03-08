using BalikProjesi.Enums;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BalikProjesi.Services
{
    public class RfIdService
    {
        private static SerialPort Sp;
        private string ComPort;
        private byte[] Btdata;
        private string Data;
        private string TagId;
        private string TagType;
        private int Status;
        public bool Continue;
        private TextBox IdTextBox;
        private TextBox TypeTextBox;
        private byte[] NumArray;

        public RfIdService()
        {
            ComPort = Properties.Settings.Default.Port;
            Sp= new SerialPort();
            Continue = false;
        }
        private void OpenPort()
        {
            if (!Sp.IsOpen)
            {
                Sp.PortName = ComPort;
                Sp.BaudRate = 115200;
                Sp.DataReceived += new SerialDataReceivedEventHandler(RfIdReceived);
                Sp.Open();
            }
        }
        private void ClosePort()
        {
            Sp.Close();
            Sp.Dispose();
            Sp = new SerialPort();
        }
        public async Task<string> GetTagId()
        {
            try
            {
                OpenPort();
                Continue = true;
                while (Continue)
                {
                    Status = 0;
                    ReadTagMemoryCmd("TID");
                    await Task.Delay(1000);
                }
                ClosePort();
                return TagId;
            }
            catch
            {
                ClosePort();
                return null;
            }
        }
        private void RfIdReceived(object sender, SerialDataReceivedEventArgs e)
        {
            NumArray = new byte[Sp.BytesToRead];
            Sp.Read(NumArray, 0, NumArray.Length);
            string str;
            foreach(byte b in NumArray)
            {
                str = string.Format(" {0:X2}", b);
                Data += str;
            }
            if (NumArray.Length > 6)
            {
                if(Status == 0)
                {
                    Data = Data.Substring(70);
                    TagId = Data.Substring(0, 35);
                }
                else if(Status == 1)
                {
                    if (Data.IndexOf("4D 58 63 0B") != -1)
                        TagType = InputEnums.Kasa;
                    else if (Data.IndexOf("4D 58 63 16") != -1)
                        TagType = InputEnums.Fileto;
                    else if (Data.IndexOf("4D 58 63 21") != -1)
                        TagType = InputEnums.Kontrol;
                    else
                        TagType = String.Empty;
                }
                else if (Status == 2)
                {

                }
                Continue = false;
            }
            Data = String.Empty;
        }


        private void ReadTagMemoryCmd(string MemBank)
        {
            Btdata = new byte[8];
            Btdata[0] = 0xA0;
            Btdata[1] = 0x06;
            Btdata[2] = 255;
            Btdata[3] = 0x81;
            if(MemBank == "TID")
            {
                Btdata[4] = 0x02;
            }
            else if(MemBank == "USER")
            {
                Btdata[4] = 0x03;
            }
            Btdata[5] = 0;
            Btdata[6] = 0;
            Btdata[7] = ChekSum(Btdata, 0, 7);
            Sp.Write(Btdata,0,Btdata.Length);
        }
        public async Task WriteTagandTypetoTextBoxAsync(TextBox TagIdTextBox,TextBox TagTypeTextBox = null)
        {
            try
            {
                OpenPort();
                
            }
        }
        private byte ChekSum(byte[] btdata, int nStartPos, int nLen)
        {
            byte num = 0;
            for (int index = nStartPos; index < nStartPos + nLen; ++index)
                num += btdata[index];
            return Convert.ToByte((int)~num + 1 & (int)byte.MaxValue);
        }
    }
}
