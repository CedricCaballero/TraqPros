using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrincipalBueno
{
    public partial class formConnected : Form
    {
        public formConnected()
        {
            InitializeComponent();
        }

        private void btnStartTest_Click(object sender, EventArgs e)
        {
            cpbGPS.Value = 100;
            cpbGPS.SubscriptText = "100";
            cpbDataTransmission.Value = 73;
            cpbDataTransmission.SubscriptText = "73";
            cpbBattery.Value = 10;
            cpbBattery.SubscriptText = "10";

            lbStarteGPS.Text = "Success";
            lbstartedDataTransmission.Text = "In Progress";
            lbStartedBattery.Text = "Low";
        }

        private void formConnected_Shown(object sender, EventArgs e)
        {
            cpbGPS.Value = 0;
            cpbGPS.SubscriptText = "0";
            cpbDataTransmission.Value = 0;
            cpbDataTransmission.SubscriptText = "0";
            cpbBattery.Value = 0;
            cpbBattery.SubscriptText = "0";
        }
    }
}
