using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ECOLAB.IOT.WinFormApp.ChildWinForm;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using ECOLAB.IOT.Common.Win32;

namespace ECOLAB.IOT.WinFormApp
{
    public partial class Frm_Main : Form
    {
        //[STAThread]
        //static void Main()
        //{
        //    // To customize application configuration such as set high DPI settings or default font,
        //    // see https://aka.ms/applicationconfiguration.
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Frm_Login objFrm = new Frm_Login();

        //    ServiceCollectionExtension.GetCurrentServiceCollection()
        //        .ConfigureService().Build();

        //    DialogResult result = objFrm.ShowDialog();

        //    if (result == DialogResult.OK)//login sucessful
        //    {
        //        //show main windows
        //        Frm_Main obj = new Frm_Main();
        //        Application.Run(obj);

        //    }
        //    else
        //    {
        //        Application.Exit();
        //    }
        //}
        public Frm_Main()
        {
            InitializeComponent();
        }
        public void LoadFrom(object from)
        {
            if (this.panel_Main.Controls.Count>0)
            {
                this.panel_Main.Controls.RemoveAt(0);
            }
            Form f = from as Form;
            f.TopLevel = false;
            f.Dock=DockStyle.Fill;
            this.panel_Main.Controls.Add(f);
            this.panel_Main.Tag = f;
            f.Show();

        }

        private void button_SerialCOM_Click(object sender, EventArgs e)
        {
            LoadFrom(new BurnFile());
        }

        private void button_DashBorad_Click(object sender, EventArgs e)
        {
            LoadFrom(new BurnSNAndPSK());
        }

        private void button_Main_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_Main_MouseDown(object sender, MouseEventArgs e)
        {
            MoveWinForm();
        }

        private void MoveWinForm()
        {
            Win32SafeNativeMethods.ReleaseCapture();
            Win32SafeNativeMethods.SendMessage(this.Handle, Win32SafeNativeMethods.WM_SYSCOMMAND, Win32SafeNativeMethods.SC_MOVE + Win32SafeNativeMethods.HTCAPTION, 0);
        }

        private void panel_Header_MouseDown(object sender, MouseEventArgs e)
        {
            MoveWinForm();
        }

        private void panel_Side_MouseDown(object sender, MouseEventArgs e)
        {
            MoveWinForm();
        }
    }
}
