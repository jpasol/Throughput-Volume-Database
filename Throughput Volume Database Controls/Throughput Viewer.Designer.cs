namespace Throughput_Volume_Database_Controls
{
    partial class Throughput_Viewer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuField = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectedColumn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // menuField
            // 
            this.menuField.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedColumn,
            this.toolStripSeparator1});
            this.menuField.Name = "menuField";
            this.menuField.Size = new System.Drawing.Size(181, 32);
            // 
            // selectedColumn
            // 
            this.selectedColumn.Checked = true;
            this.selectedColumn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.selectedColumn.Name = "selectedColumn";
            this.selectedColumn.Size = new System.Drawing.Size(180, 22);
            this.selectedColumn.Text = "toolStripMenuItem1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            this.menuField.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem selectedColumn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ContextMenuStrip menuField;
    }
}
