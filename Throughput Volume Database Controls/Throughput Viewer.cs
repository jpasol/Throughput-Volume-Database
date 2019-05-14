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
            this.ColumnHeaderMouseClick += new DataGridViewCellMouseEventHandler(ShowMenuField);
            this.menuField.ItemClicked += new ToolStripItemClickedEventHandler(ToggleColumn);
            this.DataSourceChanged += new EventHandler(AddColumnToFieldControl);
            Optimizer.SetDoubleBuffered(this);

        }

        private void AddColumnToFieldControl(object sender, EventArgs e)
        {
            foreach (DataColumn column in ((DataTable)this.DataSource).Columns)
            {
                ToolStripMenuItem tempItem = new ToolStripMenuItem();
                tempItem.Checked = this.Columns[column.ColumnName].Visible;
                tempItem.Text = column.ColumnName;
                tempItem.Name = column.ColumnName;
                menuField.Items.Add(tempItem);
            }

        }

        private void ToggleColumn(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                bool Visible = ((ToolStripMenuItem)menuField.Items[e.ClickedItem.Text]).Checked;

                this.Columns[e.ClickedItem.Text].Visible = !Visible;
                this.Columns[e.ClickedItem.Text].DisplayIndex = this.Columns[menuField.Items[0].Text].DisplayIndex - 1;
                ((ToolStripMenuItem)menuField.Items[e.ClickedItem.Text]).Checked = !Visible;
            }
            catch
            {
            }

        }


        private void ShowMenuField(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                menuField.Items[0].Text = this.Columns[e.ColumnIndex].Name;
                menuField.Show(Cursor.Position);
            }
        }
    }
}
