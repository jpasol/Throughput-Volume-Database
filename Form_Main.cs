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
            var fieldList = from DataColumn c in ThroughputVolume.AllVesselThroughputVolumeDatabase.AllVesselThroughputVolumeData.Columns
                                 select c.ColumnName;
            filterBuilder1.cmbFields.Items.AddRange(fieldList.ToArray<string>());
            filterBuilder1.buttonApply.Click += new EventHandler(ApplyFilterToDatagridview);
            throughput_Viewer1.KeyDown += new KeyEventHandler(GenerateReport);
        }

        private void GenerateReport(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.L)
            {
                Throughput_Volume_Update.ThroughputVolumeDatabase tempDB = new Throughput_Volume_Update.ThroughputVolumeDatabase();
                SelectedRowsToDB(tempDB);

                //int[] years = tempDB.AllVesselThroughputVolumeData.AsEnumerable()
                //    .Select(row => (int)row["Month"]).Distinct().ToArray();

                //AddNullMonthEntries(years, tempDB);

            }
        }

        private void AddNullMonthEntries(int[] years, Throughput_Volume_Update.ThroughputVolumeDatabase tempDB)
        {
            foreach (int year in years)
            {
                for (int i = 1; i <= 12; i++)
                {
                    DataRow tempRow = tempDB.AllVesselThroughputVolumeData.NewRow();
                    tempRow["Month"] = i;
                    tempDB.AllVesselThroughputVolumeData.Rows.Add(tempRow);
                }
            }
        }

        private void SelectedRowsToDB(Throughput_Volume_Update.ThroughputVolumeDatabase tempDB)
        {
            foreach (DataGridViewRow Row in throughput_Viewer1.SelectedRows)
            {
                var boundedRow = (Throughput_Volume_Update.ThroughputVolumeDatabase.AllVesselThroughputVolumeDataRow)((DataRowView)Row.DataBoundItem).Row;
                DataRow tempRow = tempDB.AllVesselThroughputVolumeData.NewRow();
                tempRow.ItemArray = boundedRow.ItemArray;

                tempDB.AllVesselThroughputVolumeData.Rows.Add(tempRow);
            }
        }

        private void ApplyFilterToDatagridview(object sender, EventArgs e)
        {
            ((DataTable)throughput_Viewer1.DataSource).DefaultView.RowFilter = "";
            ((DataTable)throughput_Viewer1.DataSource).DefaultView.RowFilter = filterBuilder1.Filter;
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
