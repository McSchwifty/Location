namespace Location
{
    partial class FrmLocation
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
            this.lblInfoOne = new System.Windows.Forms.Label();
            this.lblInfoTwo = new System.Windows.Forms.Label();
            this.lblInfoThree = new System.Windows.Forms.Label();
            this.lblInfoFive = new System.Windows.Forms.Label();
            this.lblInfoFour = new System.Windows.Forms.Label();
            this.txtApt = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInfoOne
            // 
            this.lblInfoOne.AutoSize = true;
            this.lblInfoOne.Location = new System.Drawing.Point(13, 13);
            this.lblInfoOne.Name = "lblInfoOne";
            this.lblInfoOne.Size = new System.Drawing.Size(66, 13);
            this.lblInfoOne.TabIndex = 0;
            this.lblInfoOne.Text = "Apt. Number";
            // 
            // lblInfoTwo
            // 
            this.lblInfoTwo.AutoSize = true;
            this.lblInfoTwo.Location = new System.Drawing.Point(13, 44);
            this.lblInfoTwo.Name = "lblInfoTwo";
            this.lblInfoTwo.Size = new System.Drawing.Size(72, 13);
            this.lblInfoTwo.TabIndex = 1;
            this.lblInfoTwo.Text = "StreetNumber";
            // 
            // lblInfoThree
            // 
            this.lblInfoThree.AutoSize = true;
            this.lblInfoThree.Location = new System.Drawing.Point(13, 77);
            this.lblInfoThree.Name = "lblInfoThree";
            this.lblInfoThree.Size = new System.Drawing.Size(24, 13);
            this.lblInfoThree.TabIndex = 2;
            this.lblInfoThree.Text = "City";
            // 
            // lblInfoFive
            // 
            this.lblInfoFive.AutoSize = true;
            this.lblInfoFive.Location = new System.Drawing.Point(13, 153);
            this.lblInfoFive.Name = "lblInfoFive";
            this.lblInfoFive.Size = new System.Drawing.Size(64, 13);
            this.lblInfoFive.TabIndex = 3;
            this.lblInfoFive.Text = "Postal Code";
            // 
            // lblInfoFour
            // 
            this.lblInfoFour.AutoSize = true;
            this.lblInfoFour.Location = new System.Drawing.Point(13, 115);
            this.lblInfoFour.Name = "lblInfoFour";
            this.lblInfoFour.Size = new System.Drawing.Size(49, 13);
            this.lblInfoFour.TabIndex = 4;
            this.lblInfoFour.Text = "Province";
            // 
            // txtApt
            // 
            this.txtApt.Location = new System.Drawing.Point(103, 13);
            this.txtApt.Name = "txtApt";
            this.txtApt.Size = new System.Drawing.Size(100, 20);
            this.txtApt.TabIndex = 5;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(103, 44);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 20);
            this.txtStreet.TabIndex = 6;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(103, 77);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 7;
            // 
            // txtProvince
            // 
            this.txtProvince.Location = new System.Drawing.Point(103, 107);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(100, 20);
            this.txtProvince.TabIndex = 8;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(103, 145);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtPostalCode.TabIndex = 9;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(13, 226);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // FrmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtProvince);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtApt);
            this.Controls.Add(this.lblInfoFour);
            this.Controls.Add(this.lblInfoFive);
            this.Controls.Add(this.lblInfoThree);
            this.Controls.Add(this.lblInfoTwo);
            this.Controls.Add(this.lblInfoOne);
            this.Name = "FrmLocation";
            this.Text = "Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfoOne;
        private System.Windows.Forms.Label lblInfoTwo;
        private System.Windows.Forms.Label lblInfoThree;
        private System.Windows.Forms.Label lblInfoFive;
        private System.Windows.Forms.Label lblInfoFour;
        private System.Windows.Forms.TextBox txtApt;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.Button btnShow;
    }
}

