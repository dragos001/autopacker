using Sanchez.Patcher.Source_files;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Drawing;

namespace Sanchez.Patcher
{
    public partial class pForm : Form
    {
        public pForm()


        {
            InitializeComponent();

            Globals.pForm = this;
        }

        private void pForm_Shown(object sender, EventArgs e)
        {
            if (Common.IsGameRunning())
                Common.EnableStart();
            else
                Networking.CheckNetwork();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Starter.Start();
            Application.Exit();
        }

        private void pForm_Load(object sender, EventArgs e)
        {

        }

       
        private void completeProgressText_Click(object sender, EventArgs e)
        {

        }   

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start(@"config.exe");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void completeProgress_Click(object sender, EventArgs e)
        {
            
        }

        private void pForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        Point lastPoint;

        private void pForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        //private void pForm_Load(object sender, EventArgs e)



    }
}
