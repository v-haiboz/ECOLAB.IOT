using ECOLAB.IOT.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECOLAB.IOT.WinFormApp.ChildWinForm
{
    public partial class AccountLogin : Form
    {
        public AccountLogin(Frm_Login frm_Login)
        {
            InitializeComponent();
            Frm_Login=frm_Login;
        }
        private Frm_Login Frm_Login;
        private void button_DMPAccountLogin_Click(object sender, EventArgs e)
        {
            if (Frm_Login != null)
            {
                var dmpAccountLogin = new DMPAccountLogin(Frm_Login);
                Frm_Login.OpenChildForm(dmpAccountLogin,null);
            }
        }

        private void button_ECOLABAcountLogin_Click(object sender, EventArgs e)
        {
            
        }
    }
}
