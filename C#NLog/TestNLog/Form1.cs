using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestNLog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Tex01_TextChanged(object sender, EventArgs e)
        {

        }
        private void Tex02_TextChanged(object sender, EventArgs e)
        {

        }

        private void But01_Click(object sender, EventArgs e)
        {
            Logger.Info(Tex01.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Logger.Debug(Tex02.Text);
        }
        private void But02_Click(object sender, EventArgs e)
        {
            Logger.Error(Tex03.Text);
        }


    }
}
