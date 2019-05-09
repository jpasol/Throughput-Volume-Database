using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Throughput_Volume_Database_Controls;

namespace Throughput_Volume_Database_Controls
{
    public partial class Throughput_Viewer : DataGridView
    {
        public Throughput_Viewer()
        {
            InitializeComponent();

            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToOrderColumns = true;
            this.AllowUserToResizeRows = false;
            this.AllowUserToResizeColumns = true;
            this.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.VirtualMode = true;
            this.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            this.RowHeadersVisible = false;
            Optimizer.SetDoubleBuffered(this);

        }



    }
}
