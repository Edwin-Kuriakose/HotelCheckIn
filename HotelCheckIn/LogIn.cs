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
    //Log In form that makes sure only credentialed personel have access to software

    public partial class LogIn : Form
    {
        
        private const string userName = "User01";
        private const string passWord = "1234";

        public LogIn()
        {
            InitializeComponent();
        }

        private void enterBT_Click(object sender, EventArgs e)
        {
            string un = unTB.Text;
            string pw = pwTB.Text;

            //Authenticates username and password
            if (String.Equals(un, userName) && String.Equals(pw, passWord))
            {                
                this.Hide();
                Data.form1.Show();
            }
            else
            {
                
                MessageBox.Show("Incorrect Username or Password \nPlease Try Again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                unTB.Text = "";
                pwTB.Text = "";
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
