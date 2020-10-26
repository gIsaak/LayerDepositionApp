using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;


namespace CU30Interface
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class CU30
    {

        #region structs and classes
        DeviceStruct     USB01 = new DeviceStruct();
        StringBuilder szResult = new StringBuilder(256);
        delphiIEE   EepromInfo = new delphiIEE();

        [StructLayout(LayoutKind.Sequential)]
        struct DeviceStruct { public uint USBInstance, USBVersion, DevID, EEID;}
        
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public class delphiIEE
        {
            public uint 
                USBVendorID,
                USBProductID,
                USBDeviceID,
                DeviceID,
                EEPromID,
                Version,
                SerialNumber,
                CustomerID;
                [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]    public string Company;
                [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]    public string Date;
                [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]    public string ProductStr;
                [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]    public string Customer;
                [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]    public string CustomerStr;
        }
        #endregion
        #region Function definitions of unmanaged DLL functions.

        [DllImport("cu30.dll",EntryPoint = "CU30Open", ExactSpelling=false, SetLastError=true,CallingConvention=CallingConvention.StdCall)]
        static extern void CU30Open([Out, MarshalAs(UnmanagedType.LPStr)] StringBuilder szResult,  ref DeviceStruct devStr);
        [DllImport("cu30.dll", EntryPoint = "Echo", ExactSpelling = false, SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        static extern uint CU30Echo(DeviceStruct devStr, uint b);
        [DllImport("cu30.dll", EntryPoint = "CU30Close", ExactSpelling = false, SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        static extern void CU30Close(DeviceStruct devStr);
        [DllImport("cu30.dll", EntryPoint = "GetUSBEEPromInfo", ExactSpelling = false, SetLastError = true, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        static extern void CU30GetEEPromInfo([Out, MarshalAs(UnmanagedType.LPStruct)] delphiIEE pEepromInfo, DeviceStruct devStr);
        [DllImport("cu30.dll", EntryPoint = "CU30DCDCon", ExactSpelling = false, SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        static extern void CU30DCDCon(DeviceStruct devStr);
        [DllImport("cu30.dll", EntryPoint = "CU30DCDCoff", ExactSpelling = false, SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        static extern void CU30DCDCoff(DeviceStruct devStr);
        [DllImport("cu30.dll", EntryPoint = "CU30Step", ExactSpelling = false, SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        static extern void CU30Step(DeviceStruct devStr, int Axis, int Vel, int Steps);
        [DllImport("cu30.dll", EntryPoint = "CU30Move", ExactSpelling = false, SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        static extern void CU30Move(DeviceStruct devStr, int Axis, int Speed, int Timeout);
        [DllImport("cu30.dll", EntryPoint = "CU30PiezoStop", ExactSpelling = false, SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        static extern void CU30Stop(DeviceStruct devStr);
        [DllImport("cu30.dll", EntryPoint = "CU30TestReady", ExactSpelling = false, SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        static extern uint CU30Ready(DeviceStruct devStr);
        
        #endregion
		#region CU30.dll use

		/// <summary>
		/// The method provides test access to the CU30.dll exposed functionality. The functions to be used in this 
		/// method must be defined in the region above. Note: The CU30.dll must be located in the same folder as the 
		/// .NET application.
		/// </summary>
		
        public StringBuilder  m_CU30Open(uint EEID )
        {
            USB01.EEID = EEID;         
            CU30Open(szResult, ref USB01);
            return szResult;
        }
        public String m_CU30GetEEPromInfo()
        {           
            CU30GetEEPromInfo(EepromInfo, USB01);
            string ret = String.Format("VID = {0:X4}{1}"  , EepromInfo.USBVendorID,Environment.NewLine);
            ret += String.Format("PID = {0:X4}{1}", EepromInfo.USBProductID, Environment.NewLine);
            ret += String.Format("bcdDevice = {0:X4}{1}", EepromInfo.USBDeviceID, Environment.NewLine);
            ret += String.Format("DeviceID = {0:X4}{1}", EepromInfo.DeviceID, Environment.NewLine);
            ret += String.Format("EEID = {0:d4}{1}", EepromInfo.EEPromID, Environment.NewLine);
            ret += String.Format("Version = {0:d4}{1}", EepromInfo.Version, Environment.NewLine);
            ret += String.Format("Serial Nr. = {0:d4}{1}", EepromInfo.SerialNumber, Environment.NewLine);
            ret += String.Format("CustomerID = {0:d4}{1}", EepromInfo.CustomerID, Environment.NewLine);
            ret += String.Format("Company = {0}{1}", EepromInfo.Company, Environment.NewLine);
            ret += String.Format("Date = {0}{1}", EepromInfo.Date, Environment.NewLine);
            ret += String.Format("ProductStr = {0}{1}", EepromInfo.ProductStr, Environment.NewLine);
            ret += String.Format("Customer = {0}{1}", EepromInfo.Customer, Environment.NewLine);
            ret += String.Format("CustomerStr = {0}{1}", EepromInfo.CustomerStr, Environment.NewLine);
            return ret;
        }
        public void m_CU30DCDCon()                              {                   CU30DCDCon( USB01);}
        public void m_CU30DCDCoff()                             {                   CU30DCDCoff(USB01);}
        public void m_CU30Move(int Axis, int Speed)             {    CU30Move(USB01, Axis,  Speed,100);}
        public void m_CU30Step(int Axis, int Speed, int Steps)  {  CU30Step(USB01, Axis, Speed, Steps);}
        public void m_CU30Stop()                                {                      CU30Stop(USB01);}
        public void m_CU30Close()                               {                     CU30Close(USB01);}
        public uint m_CU30Echo(uint echo)                       {         return CU30Echo(USB01, echo);}
        public uint m_CU30Ready()                               {              return CU30Ready(USB01);}

		#endregion
        
        // construktor
        public CU30()
        {
            // device settings
            USB01.USBInstance = 0;
            USB01.USBVersion = 1;
            USB01.DevID = 1;
            USB01.EEID = 0;
        }
	}
}
