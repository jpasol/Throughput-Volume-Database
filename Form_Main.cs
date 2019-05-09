using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Throughput_Volume_Update;

namespace ThroughputVolumeDatabase
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();

            RetrieveData();
            this.Load += new EventHandler(FormLoad);

        }

        private void FormLoad(object sender, EventArgs e)
        {
            throughput_Viewer1.Refresh();
        }

        private AllVesselThroughputVolume ThroughputVolume;

        private void RetrieveData()
        {
            ThroughputVolume = new AllVesselThroughputVolume(1, 2019);
            throughput_Viewer1.DataSource = ThroughputVolume.AllVesselThroughputVolumeDatabase.AllVesselThroughputVolumeData;

        }




    }
}
