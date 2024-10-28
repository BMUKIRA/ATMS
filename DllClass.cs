using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace CRT284UTESTDLL
{
    class DllClass
    {
        //打开串口
        [DllImport("CRT_284.dll")]
        public static extern UInt32 USBOpen();

        //关闭串口
        [DllImport("CRT_284.dll")]
        public static extern int USBClose(UInt32 ComHandle);

        [DllImport("CRT_284.dll")]
        public static extern int USB_ExeCommand(UInt32 ComHandle, byte TxCmCode, byte TxPmCode, UInt16 TxDataLen, byte[] TxData, ref UInt16 RxDataLen, byte[] RxData);

    }
}
