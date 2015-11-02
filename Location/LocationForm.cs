// Andrew MAcxkinnon
// Nov 2 2015
// ICS3UR
// Show your location using funtions
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Location
{
    public partial class FrmLocation : Form
    {
        public void Address(string apt,string street,string city, string province, string postal)
        {
            MessageBox.Show("You live at " + apt + " " + street + " " + city + "  " + province + " " + postal);
        }
        public void Address( string street, string city, string province, string postal)
        {
            Address(null,street,city,province,postal);
        }
        public FrmLocation()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string apt;
            string street;
            string city;
            string province;
            string postal;

            //Input

            apt = this.txtApt.Text;
            street = this.txtStreet.Text;
            city = this.txtCity.Text;
            province = this.txtProvince.Text;
            postal = this.txtPostalCode.Text;

            // Process

            Address(apt,street,city,province,postal);


        }
    }
}
