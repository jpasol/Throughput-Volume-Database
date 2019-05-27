namespace ThroughputVolumeDatabase
{
    partial class Form_CummulativeReport
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
            this.cummulativeReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // cummulativeReportViewer
            // 
            this.cummulativeReportViewer.ActiveViewIndex = -1;
            this.cummulativeReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cummulativeReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.cummulativeReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cummulativeReportViewer.Location = new System.Drawing.Point(0, 0);
            this.cummulativeReportViewer.Name = "cummulativeReportViewer";
            this.cummulativeReportViewer.Size = new System.Drawing.Size(800, 450);
            this.cummulativeReportViewer.TabIndex = 0;
            // 
            // Form_CummulativeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cummulativeReportViewer);
            this.Name = "Form_CummulativeReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_CummulativeReport";
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer cummulativeReportViewer;
    }
}