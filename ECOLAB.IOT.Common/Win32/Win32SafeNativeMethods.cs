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
        private const int WM_NCLBUTTONDOWN = 0XA1;   //.定义鼠標左鍵按下

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int IParam);

        [DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
        public static extern int SetForegroundWindow(IntPtr hwnd);

        [DllImport("User32.dll ", EntryPoint = "SetParent")]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

  　　  [DllImport("user32.dll ", EntryPoint = "ShowWindow")]
  　　  public static extern int ShowWindow(IntPtr hwnd, int nCmdShow);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern bool AllocConsole();


        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern bool FreeConsole();

        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        private static extern int SendMessage(int hwnd, int wMsg, int wParam, int lParam);

    }
}
