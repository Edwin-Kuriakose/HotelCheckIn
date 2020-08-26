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
    public partial class payment : Form
    {
        //form to handle payment and billing

        double pBill;
        public payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            pBill = 0.00;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }        

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //search for guest info by room # and last name
        private void Search_button_Click(object sender, EventArgs e)
        {
            //clear old search
            string temp1 = lnamebillTB.Text;
            string temp2 = rnbillTB.Text;
            clearBT.PerformClick();
            lnamebillTB.Text = temp1;
            rnbillTB.Text = temp2;

            //verifies required fields have been filled
            if (String.IsNullOrEmpty(lnamebillTB.Text) || String.IsNullOrEmpty(rnbillTB.Text))
            {
                
                MessageBox.Show("PLEASE FILL ALL FIELDS BEFORE SUBMITTING", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            if (!int.TryParse(rnbillTB.Text, out int ind) || ind < 1)
            {
                MessageBox.Show("ROOM NUMBER MUST BE AN INTEGER GREATER THAN 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            //int ind = int.Parse(rnbillTB.Text);            

            //avoids index out of bounds
            if (ind > Data.hilton.rooms.Count)
            {
                
                MessageBox.Show("CANNOT FIND ROOM", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            ind -= 1;                

            //create temp copy of guest info
            Guest temp = Data.hilton.rooms[ind].findGuest(lnamebillTB.Text);

            if(temp == null)
                MessageBox.Show("CANNOT FIND GUEST", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            else
            {                
                //populate guest info fields
                PartySize.Text = temp.partySize.ToString();
                FName.Text = temp.fName;
                StartDate.Text = temp.start.ToShortDateString();
                EndDate.Text = temp.end.ToShortDateString();
                pBill = temp.bill;
            }
        }

        private void Misc_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReturnB_Click(object sender, EventArgs e)
        {
            //clear fields and return to main menu
            clearBT.PerformClick();
            this.Hide();
            Data.form1.Show();
        }

        private void CalcBT_Click(object sender, EventArgs e)
        {
            double finalBill = pBill;

            //check for additional expenses
            if (!String.IsNullOrEmpty(Misc.Text))
            {
                if (!double.TryParse(Misc.Text, out double misc) || misc < 0)
                {
                    MessageBox.Show("EXPENSES MUST BE A DOUBLE GREATER THAN OR EQUAL TO 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    return;
                }

                finalBill += misc;
            }
                
            finalBill = Math.Round(finalBill, 2);
            //display final bill
            Bill.Text = "$" + finalBill.ToString();
            amtTB.Text = Bill.Text;
        }

        private void ClearBT_Click(object sender, EventArgs e)
        {
            rnbillTB.Text = String.Empty;
            lnamebillTB.Text = String.Empty;
            PartySize.Text = String.Empty;
            FName.Text = String.Empty;
            StartDate.Text = String.Empty;
            EndDate.Text = String.Empty;
            Misc.Text = String.Empty;
            Bill.Text = String.Empty;

            ccnTB.Text = String.Empty;
            expTB.Text = String.Empty;
            cvcTB.Text = String.Empty;
            addTB.Text = String.Empty;
            amtTB.Text = String.Empty;

            pBill = 0;
        }
    }
}
