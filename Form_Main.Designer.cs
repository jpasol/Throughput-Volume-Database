namespace ThroughputVolumeDatabase
{
    partial class Form_Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.throughput_Viewer1 = new Throughput_Volume_Database_Controls.Throughput_Viewer();
            this.filterBuilder1 = new Throughput_Volume_Database_Controls.FilterBuilder();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.throughput_Viewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(971, 681);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.filterBuilder1);
            this.tabPage1.Controls.Add(this.throughput_Viewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(963, 655);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // throughput_Viewer1
            // 
            this.throughput_Viewer1.AllowUserToAddRows = false;
            this.throughput_Viewer1.AllowUserToDeleteRows = false;
            this.throughput_Viewer1.AllowUserToOrderColumns = true;
            this.throughput_Viewer1.AllowUserToResizeRows = false;
            this.throughput_Viewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.throughput_Viewer1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.throughput_Viewer1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.throughput_Viewer1.Location = new System.Drawing.Point(3, 208);
            this.throughput_Viewer1.Name = "throughput_Viewer1";
            this.throughput_Viewer1.RowHeadersVisible = false;
            this.throughput_Viewer1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.throughput_Viewer1.Size = new System.Drawing.Size(957, 444);
            this.throughput_Viewer1.TabIndex = 1;
            // 
            // filterBuilder1
            // 
            this.filterBuilder1.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterBuilder1.Location = new System.Drawing.Point(3, 3);
            this.filterBuilder1.MaximumSize = new System.Drawing.Size(0, 196);
            this.filterBuilder1.MinimumSize = new System.Drawing.Size(839, 0);
            this.filterBuilder1.Name = "filterBuilder1";
            this.filterBuilder1.Size = new System.Drawing.Size(957, 196);
            this.filterBuilder1.TabIndex = 2;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(971, 681);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(987, 720);
            this.Name = "Form_Main";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.throughput_Viewer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Throughput_Volume_Database_Controls.Throughput_Viewer throughput_Viewer1;
        private Throughput_Volume_Database_Controls.FilterBuilder filterBuilder1;
    }
}

