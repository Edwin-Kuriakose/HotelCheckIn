namespace HotelCheckIn
{
    partial class reserve
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reserve));
            this.startCal = new System.Windows.Forms.MonthCalendar();
            this.endCal = new System.Windows.Forms.MonthCalendar();
            this.CheckIn = new System.Windows.Forms.Label();
            this.CheckOut = new System.Windows.Forms.Label();
            this.avail = new System.Windows.Forms.Button();
            this.availRooms = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rnrTB = new System.Windows.Forms.TextBox();
            this.cOutTB = new System.Windows.Forms.TextBox();
            this.cInTB = new System.Windows.Forms.TextBox();
            this.pSizeTB = new System.Windows.Forms.TextBox();
            this.lNameTB = new System.Windows.Forms.TextBox();
            this.fNameTB = new System.Windows.Forms.TextBox();
            this.outL = new System.Windows.Forms.Label();
            this.inL = new System.Windows.Forms.Label();
            this.pSizeL = new System.Windows.Forms.Label();
            this.lNameL = new System.Windows.Forms.Label();
            this.fNameL = new System.Windows.Forms.Label();
            this.roomInfoGB = new System.Windows.Forms.GroupBox();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.capTB = new System.Windows.Forms.TextBox();
            this.priceL = new System.Windows.Forms.Label();
            this.capL = new System.Windows.Forms.Label();
            this.rnL = new System.Windows.Forms.Label();
            this.rnTB = new System.Windows.Forms.TextBox();
            this.newguestB = new System.Windows.Forms.Button();
            this.returnB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.roomInfoGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // startCal
            // 
            this.startCal.Location = new System.Drawing.Point(55, 138);
            this.startCal.Name = "startCal";
            this.startCal.TabIndex = 1;
            this.startCal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.StartCal_DateChanged);
            // 
            // endCal
            // 
            this.endCal.Location = new System.Drawing.Point(55, 363);
            this.endCal.Name = "endCal";
            this.endCal.TabIndex = 2;
            this.endCal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.EndCal_DateChanged);
            // 
            // CheckIn
            // 
            this.CheckIn.AutoSize = true;
            this.CheckIn.Location = new System.Drawing.Point(55, 101);
            this.CheckIn.Name = "CheckIn";
            this.CheckIn.Size = new System.Drawing.Size(50, 13);
            this.CheckIn.TabIndex = 3;
            this.CheckIn.Text = "Check In";
            // 
            // CheckOut
            // 
            this.CheckOut.AutoSize = true;
            this.CheckOut.Location = new System.Drawing.Point(55, 327);
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Size = new System.Drawing.Size(58, 13);
            this.CheckOut.TabIndex = 4;
            this.CheckOut.Text = "Check Out";
            // 
            // avail
            // 
            this.avail.Location = new System.Drawing.Point(55, 575);
            this.avail.Name = "avail";
            this.avail.Size = new System.Drawing.Size(227, 23);
            this.avail.TabIndex = 5;
            this.avail.Text = "Check Availability";
            this.avail.UseVisualStyleBackColor = true;
            this.avail.Click += new System.EventHandler(this.avail_Click);
            // 
            // availRooms
            // 
            this.availRooms.FormattingEnabled = true;
            this.availRooms.Location = new System.Drawing.Point(334, 85);
            this.availRooms.Name = "availRooms";
            this.availRooms.Size = new System.Drawing.Size(269, 251);
            this.availRooms.TabIndex = 6;
            this.availRooms.SelectedIndexChanged += new System.EventHandler(this.availRooms_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rnrTB);
            this.groupBox1.Controls.Add(this.cOutTB);
            this.groupBox1.Controls.Add(this.cInTB);
            this.groupBox1.Controls.Add(this.pSizeTB);
            this.groupBox1.Controls.Add(this.lNameTB);
            this.groupBox1.Controls.Add(this.fNameTB);
            this.groupBox1.Controls.Add(this.outL);
            this.groupBox1.Controls.Add(this.inL);
            this.groupBox1.Controls.Add(this.pSizeL);
            this.groupBox1.Controls.Add(this.lNameL);
            this.groupBox1.Controls.Add(this.fNameL);
            this.groupBox1.Location = new System.Drawing.Point(704, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 394);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Guest Reservation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Room Number";
            // 
            // rnrTB
            // 
            this.rnrTB.Location = new System.Drawing.Point(98, 212);
            this.rnrTB.Name = "rnrTB";
            this.rnrTB.ReadOnly = true;
            this.rnrTB.Size = new System.Drawing.Size(100, 20);
            this.rnrTB.TabIndex = 10;
            this.rnrTB.TabStop = false;
            this.rnrTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cOutTB
            // 
            this.cOutTB.Location = new System.Drawing.Point(100, 329);
            this.cOutTB.Name = "cOutTB";
            this.cOutTB.ReadOnly = true;
            this.cOutTB.Size = new System.Drawing.Size(100, 20);
            this.cOutTB.TabIndex = 9;
            this.cOutTB.TabStop = false;
            this.cOutTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cInTB
            // 
            this.cInTB.Location = new System.Drawing.Point(100, 271);
            this.cInTB.Name = "cInTB";
            this.cInTB.ReadOnly = true;
            this.cInTB.Size = new System.Drawing.Size(100, 20);
            this.cInTB.TabIndex = 8;
            this.cInTB.TabStop = false;
            this.cInTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pSizeTB
            // 
            this.pSizeTB.Location = new System.Drawing.Point(98, 153);
            this.pSizeTB.Name = "pSizeTB";
            this.pSizeTB.Size = new System.Drawing.Size(100, 20);
            this.pSizeTB.TabIndex = 7;
            this.pSizeTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lNameTB
            // 
            this.lNameTB.Location = new System.Drawing.Point(98, 89);
            this.lNameTB.Name = "lNameTB";
            this.lNameTB.Size = new System.Drawing.Size(100, 20);
            this.lNameTB.TabIndex = 6;
            this.lNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // fNameTB
            // 
            this.fNameTB.Location = new System.Drawing.Point(98, 37);
            this.fNameTB.Name = "fNameTB";
            this.fNameTB.Size = new System.Drawing.Size(100, 20);
            this.fNameTB.TabIndex = 5;
            this.fNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // outL
            // 
            this.outL.AutoSize = true;
            this.outL.Location = new System.Drawing.Point(20, 335);
            this.outL.Name = "outL";
            this.outL.Size = new System.Drawing.Size(58, 13);
            this.outL.TabIndex = 4;
            this.outL.Text = "Check Out";
            // 
            // inL
            // 
            this.inL.AutoSize = true;
            this.inL.Location = new System.Drawing.Point(20, 271);
            this.inL.Name = "inL";
            this.inL.Size = new System.Drawing.Size(50, 13);
            this.inL.TabIndex = 3;
            this.inL.Text = "Check In";
            // 
            // pSizeL
            // 
            this.pSizeL.AutoSize = true;
            this.pSizeL.Location = new System.Drawing.Point(18, 153);
            this.pSizeL.Name = "pSizeL";
            this.pSizeL.Size = new System.Drawing.Size(54, 13);
            this.pSizeL.TabIndex = 2;
            this.pSizeL.Text = "Party Size";
            // 
            // lNameL
            // 
            this.lNameL.AutoSize = true;
            this.lNameL.Location = new System.Drawing.Point(18, 89);
            this.lNameL.Name = "lNameL";
            this.lNameL.Size = new System.Drawing.Size(58, 13);
            this.lNameL.TabIndex = 1;
            this.lNameL.Text = "Last Name";
            // 
            // fNameL
            // 
            this.fNameL.AutoSize = true;
            this.fNameL.Location = new System.Drawing.Point(18, 37);
            this.fNameL.Name = "fNameL";
            this.fNameL.Size = new System.Drawing.Size(57, 13);
            this.fNameL.TabIndex = 0;
            this.fNameL.Text = "First Name";
            // 
            // roomInfoGB
            // 
            this.roomInfoGB.Controls.Add(this.priceTB);
            this.roomInfoGB.Controls.Add(this.capTB);
            this.roomInfoGB.Controls.Add(this.priceL);
            this.roomInfoGB.Controls.Add(this.capL);
            this.roomInfoGB.Controls.Add(this.rnL);
            this.roomInfoGB.Controls.Add(this.rnTB);
            this.roomInfoGB.Location = new System.Drawing.Point(334, 374);
            this.roomInfoGB.Name = "roomInfoGB";
            this.roomInfoGB.Size = new System.Drawing.Size(282, 188);
            this.roomInfoGB.TabIndex = 8;
            this.roomInfoGB.TabStop = false;
            this.roomInfoGB.Text = "Room Info";
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(132, 137);
            this.priceTB.Name = "priceTB";
            this.priceTB.ReadOnly = true;
            this.priceTB.Size = new System.Drawing.Size(100, 20);
            this.priceTB.TabIndex = 5;
            this.priceTB.TabStop = false;
            this.priceTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // capTB
            // 
            this.capTB.Location = new System.Drawing.Point(133, 80);
            this.capTB.Name = "capTB";
            this.capTB.ReadOnly = true;
            this.capTB.Size = new System.Drawing.Size(100, 20);
            this.capTB.TabIndex = 4;
            this.capTB.TabStop = false;
            this.capTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.capTB.TextChanged += new System.EventHandler(this.CapTB_TextChanged);
            // 
            // priceL
            // 
            this.priceL.AutoSize = true;
            this.priceL.Location = new System.Drawing.Point(21, 144);
            this.priceL.Name = "priceL";
            this.priceL.Size = new System.Drawing.Size(84, 13);
            this.priceL.TabIndex = 3;
            this.priceL.Text = "Price (Per Night)";
            // 
            // capL
            // 
            this.capL.AutoSize = true;
            this.capL.Location = new System.Drawing.Point(22, 87);
            this.capL.Name = "capL";
            this.capL.Size = new System.Drawing.Size(48, 13);
            this.capL.TabIndex = 2;
            this.capL.Text = "Capacity";
            // 
            // rnL
            // 
            this.rnL.AutoSize = true;
            this.rnL.Location = new System.Drawing.Point(21, 32);
            this.rnL.Name = "rnL";
            this.rnL.Size = new System.Drawing.Size(75, 13);
            this.rnL.TabIndex = 1;
            this.rnL.Text = "Room Number";
            // 
            // rnTB
            // 
            this.rnTB.Location = new System.Drawing.Point(132, 29);
            this.rnTB.Name = "rnTB";
            this.rnTB.ReadOnly = true;
            this.rnTB.Size = new System.Drawing.Size(100, 20);
            this.rnTB.TabIndex = 0;
            this.rnTB.TabStop = false;
            this.rnTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // newguestB
            // 
            this.newguestB.Location = new System.Drawing.Point(704, 535);
            this.newguestB.Name = "newguestB";
            this.newguestB.Size = new System.Drawing.Size(282, 23);
            this.newguestB.TabIndex = 9;
            this.newguestB.Text = "Create Reservation";
            this.newguestB.UseVisualStyleBackColor = true;
            this.newguestB.Click += new System.EventHandler(this.NewguestB_Click);
            // 
            // returnB
            // 
            this.returnB.BackColor = System.Drawing.Color.Red;
            this.returnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnB.Location = new System.Drawing.Point(13, 13);
            this.returnB.Name = "returnB";
            this.returnB.Size = new System.Drawing.Size(163, 32);
            this.returnB.TabIndex = 10;
            this.returnB.Text = "<--- Main Menu";
            this.returnB.UseVisualStyleBackColor = false;
            this.returnB.Click += new System.EventHandler(this.ReturnB_Click);
            // 
            // reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 632);
            this.Controls.Add(this.returnB);
            this.Controls.Add(this.newguestB);
            this.Controls.Add(this.roomInfoGB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.availRooms);
            this.Controls.Add(this.avail);
            this.Controls.Add(this.CheckOut);
            this.Controls.Add(this.CheckIn);
            this.Controls.Add(this.endCal);
            this.Controls.Add(this.startCal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "reserve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservations - Third Lotus";
            this.Load += new System.EventHandler(this.Reserve_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.roomInfoGB.ResumeLayout(false);
            this.roomInfoGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar startCal;
        private System.Windows.Forms.MonthCalendar endCal;
        private System.Windows.Forms.Label CheckIn;
        private System.Windows.Forms.Label CheckOut;
        private System.Windows.Forms.Button avail;
        private System.Windows.Forms.ListBox availRooms;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label outL;
        private System.Windows.Forms.Label inL;
        private System.Windows.Forms.Label pSizeL;
        private System.Windows.Forms.Label lNameL;
        private System.Windows.Forms.Label fNameL;
        private System.Windows.Forms.GroupBox roomInfoGB;
        private System.Windows.Forms.Label rnL;
        private System.Windows.Forms.TextBox rnTB;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.TextBox capTB;
        private System.Windows.Forms.Label priceL;
        private System.Windows.Forms.Label capL;
        private System.Windows.Forms.TextBox cOutTB;
        private System.Windows.Forms.TextBox cInTB;
        private System.Windows.Forms.TextBox pSizeTB;
        private System.Windows.Forms.TextBox lNameTB;
        private System.Windows.Forms.TextBox fNameTB;
        private System.Windows.Forms.Button newguestB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rnrTB;
        private System.Windows.Forms.Button returnB;
    }
}