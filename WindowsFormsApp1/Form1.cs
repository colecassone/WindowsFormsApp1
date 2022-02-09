using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; 

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            PlayButton.Text = "START IN";
            
            Refresh();
            Thread.Sleep(1000);
            PlayButton.Text = "3";


            Refresh();
            Thread.Sleep(1000);
            PlayButton.Text = "2";

            Refresh();
            Thread.Sleep(1000);
            PlayButton.Text = "1";

            Refresh();
            Thread.Sleep(1000);
            PlayButton.Text = "GO";
           Go1.BackColor = Color.White;
            Go2.BackColor = Color.White;
            BackColor = Color.Green;
            Go3.BackColor = Color.White;
        }
    }
}
