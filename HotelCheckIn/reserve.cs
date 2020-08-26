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
    public partial class reserve : Form
    {
        //Form that handles checking and creating reservations
        public reserve()
        {
            InitializeComponent();
        }

        //checks which rooms are available during desired dates
        private void avail_Click(object sender, EventArgs e)
        {
            //clear listbox and read in which dates the client has chosen
            availRooms.Items.Clear();
            DateTime start = startCal.SelectionStart;
            DateTime end = endCal.SelectionStart;

            //Confirms end date is after start date
            if(DateTime.Compare(end, start) < 0)
            {
                
                MessageBox.Show("INCOMPATIBLE DATES CHOOSE AGAIN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }

            //searches for and creates list of rooms that are availble during desired dates
            for (int i = 0; i < Data.hilton.rooms.Count; i++)
            {
                if (Data.hilton.rooms[i].isAvailable(start,end))
                {
                    availRooms.Items.Add(Data.hilton.rooms[i]);
                }
            }
            
        }

        //populates info box as client clicks on different room options
        private void availRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Room temp = (Room)availRooms.SelectedItem;
            rnTB.Text = temp.roomNum.ToString();
            capTB.Text = temp.capacity.ToString();
            priceTB.Text = temp.price.ToString();

            rnrTB.Text = rnTB.Text;
        }

        private void Reserve_Load(object sender, EventArgs e)
        {

        }

        private void CapTB_TextChanged(object sender, EventArgs e)
        {

        }

        //displays dates chosen on calendar in reservation booking form
        private void StartCal_DateChanged(object sender, DateRangeEventArgs e)
        {
            cInTB.Text = startCal.SelectionStart.ToShortDateString();
        }

        private void EndCal_DateChanged(object sender, DateRangeEventArgs e)
        {
            cOutTB.Text = endCal.SelectionStart.ToShortDateString();
        }

        //handles registration of new guest
        private void NewguestB_Click(object sender, EventArgs e)
        {
            //Confirms all necessary fields have been filled in order to register
            if (String.IsNullOrEmpty(fNameTB.Text) || String.IsNullOrEmpty(lNameTB.Text) || String.IsNullOrEmpty(pSizeTB.Text) || String.IsNullOrEmpty(rnrTB.Text) || String.IsNullOrEmpty(cInTB.Text) || String.IsNullOrEmpty(cOutTB.Text))
            {
                
                MessageBox.Show("PLEASE FILL ALL FIELDS BEFORE SUBMITTING", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            if(!int.TryParse(pSizeTB.Text, out int pSizeInt) || pSizeInt < 1)
            {
                
                MessageBox.Show("PARTY SIZE MUST BE AN INTEGER GREATER THAN 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            
            //convert room number text to room index number for use in list
            int rnind = int.Parse(rnrTB.Text)-1;

            //Verifies that room chosen can fit everyone in guest's party
            if(pSizeInt > Data.hilton.rooms[rnind].capacity)
            {
                MessageBox.Show("YOUR PARTY IS TOO LARGE FOR THIS ROOM","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                return;
            }
            //register guest
            Data.hilton.rooms[rnind].addGuest(fNameTB.Text, lNameTB.Text, pSizeInt, rnind + 1, startCal.SelectionStart, endCal.SelectionStart);

            MessageBox.Show("RESERVATION SUCCESSFUL");

            //clears all fields 
            fNameTB.Text = String.Empty;
            lNameTB.Text = String.Empty;
            pSizeTB.Text = String.Empty;
            rnrTB.Text = String.Empty;

            rnTB.Text = String.Empty;
            capTB.Text = String.Empty;
            priceTB.Text = String.Empty;            

            availRooms.Items.Clear();

            startCal.SelectionStart = startCal.TodayDate;
            endCal.SelectionStart = endCal.TodayDate;

            cInTB.Text = String.Empty;
            cOutTB.Text = String.Empty;
        }

        private void ReturnB_Click(object sender, EventArgs e)
        {
            //clear fields 
            fNameTB.Text = String.Empty;
            lNameTB.Text = String.Empty;
            pSizeTB.Text = String.Empty;
            rnrTB.Text = String.Empty;

            rnTB.Text = String.Empty;
            capTB.Text = String.Empty;
            priceTB.Text = String.Empty;

            availRooms.Items.Clear();

            startCal.SelectionStart = startCal.TodayDate;
            endCal.SelectionStart = endCal.TodayDate;

            cInTB.Text = String.Empty;
            cOutTB.Text = String.Empty;

            //return to main menu
            this.Hide();
            Data.form1.Show();            
        }
    }
}
