using BalikProjesi.Models;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace BalikProjesi.Services
{
    public class ReaderServices
    {
        private static SerialPort serialPort;
        private byte[] btdata;
        private string data;
        private string tagID;
        private string tagType;
        private int status;
        private bool _continue;
        private byte[] numArray;
        private ReaderResponseModel responseModel;


        public ReaderServices()
        {
            serialPort = new SerialPort();
            data = string.Empty;
            tagID = string.Empty;
            tagType = string.Empty;
            _continue = false;
        }
        public void openPort(string com = "COM5")
        {
            serialPort.PortName = com;
            serialPort.BaudRate = 115200;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(Fun_DataReceived);

            serialPort.Open();
        }
        public async Task<ReaderResponseModel> SendCmdToReaderAsync(string comPort, int command, int owner = 0)
        {   
            if(!serialPort.IsOpen){
                openPort(comPort);
            }
            _continue = true;

            while (_continue)
            {
                if (command == 0)//Kart oku
                {
                    status = 0;
                    ReadTagMemory("TID");
                    status = 1;
                    ReadTagMemory("USER");
                }
                else if (command == 1)
                {
                    ChangeTagOwner(owner);
                }
                await Task.Delay(1000); 

                if(responseModel != null)
                {
                    _continue = false;
                }
            }

            return responseModel;
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

            if (numArray.Length != 6)//rfid okuyucu hata kodu dönmediyse
            {
                if (status == 0)
                {
                    data = data.Substring(69);
                    tagID = data.Substring(0, 36);
                }
                else if (status == 1)
                {
                    if (data.IndexOf("4D 58 63 0B") != -1)//yukarıda hexe çeviridiğimiz için 77 88 99 11 olarak gözükmüyor
                        tagType = "Kasa";
                    else if (data.IndexOf("4D 58 63 16") != -1)
                        tagType = "Fileto Personeli";
                    else if (data.IndexOf("4D 58 63 21") != -1)
                        tagType = "Kontrol Personeli";
                    else
                        tagType = "Kartın henüz bir sahibi yok";
                }
                else if (status == 2)//kart sahibini değiştirdiğinde
                {
                    status = 0;
                    ReadTagMemory("TID");
                    status = 1;
                    ReadTagMemory("USER");
                }

                responseModel = new ReaderResponseModel();
                responseModel.TagId = tagID;
                responseModel.TagType = tagType;
                responseModel.ErrorCode = 0;
            }
            else
            {
                responseModel = new ReaderResponseModel();
                responseModel.TagId = "";
                responseModel.TagType = "";
                responseModel.ErrorCode = 1;
            }

            data = string.Empty;
            serialPort.Close();
        }

        private void ReadTagMemory(string memBank)
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

        private void ChangeTagOwner(int owner)
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

    }
}

        
