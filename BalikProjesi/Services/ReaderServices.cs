using BalikProjesi.Enums;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalikProjesi.Services
{
    public class ReaderServices : Form
    {
        private static SerialPort serialPort;
        private byte[] btdata;
        private string data;
        private string tagID;
        private string tagType;
        private int status;
        public bool _continue;
        private byte[] numArray;
        private TextBox idTextbox;
        private TextBox typeTextbox;
        private delegate void SetTextDeleg(int type);

        public ReaderServices()
        {
            serialPort = new SerialPort();
            data = string.Empty;
            tagID = string.Empty;
            tagType = string.Empty;
            _continue = false;
        }

        #region Public Methods
        public async Task WriteTagIdAndTypeToTextboxAsync(TextBox tagIdTextbox, TextBox tagTypeTextbox, string com = "COM5")
        {
            try
            {
                openPort(com);

                idTextbox = tagIdTextbox;
                typeTextbox = tagTypeTextbox;

                _continue = true;

                while (_continue)
                {

                    status = 0;
                    ReadTagMemoryCmd("TID");
                    status = 1;
                    ReadTagMemoryCmd("USER");

                    await Task.Delay(1000);
                }

                idTextbox.BeginInvoke(new SetTextDeleg(Fun_IsDataReceived), new object[] { 0 });
                typeTextbox.BeginInvoke(new SetTextDeleg(Fun_IsDataReceived), new object[] { 1 });

            }
            catch (Exception)
            {

            }

            closePort();

        }

        public async Task WriteTagIdToTextboxAsync(TextBox tagIdTextbox, string com = "COM5")
        {
            try
            {
                openPort(com);

                idTextbox = tagIdTextbox;

                _continue = true;

                while (_continue)
                {

                    status = 0;
                    ReadTagMemoryCmd("TID");

                    await Task.Delay(1000);
                }

                idTextbox.BeginInvoke(new SetTextDeleg(Fun_IsDataReceived), new object[] { 0 });

            }
            catch (Exception e)
            {

            }

            closePort();

        }

        //0: kasa
        //1: fileto
        //2: kontrol
        public async Task setTagOwner(int owner, string com = "COM5")
        {
            try
            {
                openPort(com);

                if (owner >= 0 && owner < 3)
                {
                    _continue = true;

                    while (_continue)
                    {
                        status = 2;
                        SetTagOwnerCmd(owner);

                        await Task.Delay(1000);
                    }
                }
            }
            catch (Exception)
            {

            }

            closePort();
        }

        public async Task<bool> checkTagIsDefined(string com = "COM5")
        {
            try
            {
                openPort(com);

                _continue = true;

                while (_continue)
                {
                    status = 1;
                    ReadTagMemoryCmd("USER");

                    await Task.Delay(1000);
                }

                closePort();

            }
            catch (Exception)
            {

            }

            if (tagType == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion


        #region Private Methods
        private void openPort(string com = "COM5")
        {
            if (!serialPort.IsOpen)
            {
                serialPort.PortName = com;
                serialPort.BaudRate = 115200;
                serialPort.DataReceived += new SerialDataReceivedEventHandler(Fun_DataReceived);

                serialPort.Open();
            }
        }


        private void closePort()
        {
            serialPort.Close();
            serialPort.Dispose();
            serialPort = new SerialPort();
        }
        private void Fun_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            numArray = new byte[serialPort.BytesToRead];
            serialPort.Read(numArray, 0, numArray.Length);
            string str;
            foreach (byte b in numArray)
            {
                str = string.Format(" {0:X2}", b);
                data += str;
            }

            if (numArray.Length > 6)//rfid okuyucu hata kodu dönmediyse
            {
                if (status == 0)
                {
                    data = data.Substring(69);
                    tagID = data.Substring(0, 36);
                }
                else if (status == 1)
                {
                    if (data.IndexOf("4D 58 63 0B") != -1)//yukarıda hexe çeviridiğimiz için 77 88 99 11 olarak gözükmüyor
                        tagType = InputEnums.Kasa;
                    else if (data.IndexOf("4D 58 63 16") != -1)
                        tagType = InputEnums.Fileto;
                    else if (data.IndexOf("4D 58 63 21") != -1)
                        tagType = InputEnums.Kontrol;
                    else
                        tagType = "";

                }
                else if (status == 2)//kart sahibini değiştirdiğinde
                {
                    
                }

                _continue = false;
            }

            data = string.Empty;
        }

        private void Fun_IsDataReceived(int type)
        {
            if (numArray.Length <= 6)
            {
                //textBox.Text = "Okuma Hatası";
            }
            else
            {
                if (type == 0)
                {
                    idTextbox.Text = tagID;
                }
                else if (type == 0)
                {
                    typeTextbox.Text = tagType;
                }

            }

        }

        private void ReadTagMemoryCmd(string memBank)
        {
            btdata = new byte[8];
            btdata[0] = 0xA0;   //Head
            btdata[1] = 0x06;   //Len
            btdata[2] = 255;    //Address
            btdata[3] = 0x81;   //Cmd
            if (memBank == "TID")
            {
                btdata[4] = 0x02;   //MemBank
            }
            else if (memBank == "USER")
            {
                btdata[4] = 0x03;   //MemBank
            }
            btdata[5] = 0;      //WordAdd
            btdata[6] = 0;      //WordLen
            btdata[7] = CheckSum(btdata, 0, 7); //Check

            serialPort.Write(btdata, 0, btdata.Length);
        }

        private void SetTagOwnerCmd(int owner)
        {
            byte ownerData;
            if (owner == 0)
                ownerData = 11;
            else if (owner == 1)
                ownerData = 22;
            else
                ownerData = 33;

            btdata = new byte[16];
            btdata[0] = 0xA0;   //Head
            btdata[1] = 14;     //Len
            btdata[2] = 255;    //Address
            btdata[3] = 0x82;   //Cmd
            btdata[4] = 0;      //PassWord
            btdata[5] = 0;      //PassWord
            btdata[6] = 0;      //PassWord
            btdata[7] = 0;      //PassWord
            btdata[8] = 0x03;   //MemBank
            btdata[9] = 0;      //WordAdd
            btdata[10] = 2;     //WordCnt
            btdata[11] = 77;    //Data
            btdata[12] = 88;    //Data
            btdata[13] = 99;    //Data
            btdata[14] = ownerData; //Data
            btdata[15] = CheckSum(btdata, 0, 15); //Check

            serialPort.Write(btdata, 0, btdata.Length);
        }

        private byte CheckSum(byte[] btAryBuffer, int nStartPos, int nLen)
        {
            byte num = 0;
            for (int index = nStartPos; index < nStartPos + nLen; ++index)
                num += btAryBuffer[index];
            return Convert.ToByte((int)~num + 1 & (int)byte.MaxValue);
        }

        #endregion
    }
}
