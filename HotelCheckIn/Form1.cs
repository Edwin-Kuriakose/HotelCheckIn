using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelCheckIn
{
    //Main Menu of Software
    public partial class Form1 : Form
    {
        
        //public int car;

        public Form1()
        {
            InitializeComponent();       
        }

        
        //reservation button
        private void Button1_Click(object sender, EventArgs e)
        {            
            
            this.Hide();
            Data.r1.Show();
        }

        //payment button
        private void Button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Data.p1.Show();
        }        

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }

        //returns to Log In screen
        private void ReturnB_Click(object sender, EventArgs e)
        {
            LogIn logn = new LogIn();
            this.Hide();
            logn.Show();
        }
    }
}
