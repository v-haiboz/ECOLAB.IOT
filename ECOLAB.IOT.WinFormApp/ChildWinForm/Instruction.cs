﻿using CefSharp;
using CefSharp.WinForms;
using ECOLAB.IOT.Service;
using SHDocVw;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECOLAB.IOT.WinFormApp.ChildWinForm
{
    public partial class Instruction : Form
    {
        public Instruction()
        {
            InitializeComponent();
            
        }
        public ChromiumWebBrowser webview;
        private void Help_Load(object sender, EventArgs e)
        {
            string url = $"{AppDomain.CurrentDomain.BaseDirectory}Help/zh-cn/Instruction.html";

            if (CallerContext.currentCulture.Name.ToLower() == "en-us")
            {
                var path = $"{AppDomain.CurrentDomain.BaseDirectory}Help/en-us/Instruction.html";
                if (File.Exists(path))
                {
                    url = path;
                }
            }

            if (!File.Exists(url))
            {
                return;
            }
           
            webview = new ChromiumWebBrowser(url);
            webview.Dock = DockStyle.Fill;
            this.Controls.Add(webview);
            this.Tag = webview;
        }

        private void Instruction_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Cef.Shutdown();
            //webview.CloseDevTools();
            //webview.GetBrowser().CloseBrowser(true);
            //if (webview != null && !webview.Disposing)
            //{
            //    webview.Dispose();
            //}
        }
    }
}