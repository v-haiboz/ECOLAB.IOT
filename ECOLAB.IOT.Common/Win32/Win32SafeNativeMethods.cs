namespace ECOLAB.IOT.Common.Win32
{
    using System;
    using System.Runtime.InteropServices;

    public static class Win32SafeNativeMethods
    {
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        public const int SC_RESTORE = 0xF120;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int IParam);

        [DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
        public static extern int SetForegroundWindow(IntPtr hwnd);
    }
}
