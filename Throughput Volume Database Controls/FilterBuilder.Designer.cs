namespace Throughput_Volume_Database_Controls
{
    partial class FilterBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterBuilder));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeFilter = new System.Windows.Forms.TreeView();
            this.textParameter = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonNegate = new System.Windows.Forms.Button();
            this.buttonOr = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAnd = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeFilter);
            this.groupBox1.Controls.Add(this.textParameter);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter Criteria";
            // 
            // treeFilter
            // 
            this.treeFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeFilter.HideSelection = false;
            this.treeFilter.Location = new System.Drawing.Point(6, 49);
            this.treeFilter.Name = "treeFilter";
            this.treeFilter.Size = new System.Drawing.Size(574, 143);
            this.treeFilter.TabIndex = 5;
            // 
            // textParameter
            // 
            this.textParameter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textParameter.Location = new System.Drawing.Point(476, 22);
            this.textParameter.Name = "textParameter";
            this.textParameter.Size = new System.Drawing.Size(211, 20);
            this.textParameter.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(348, 22);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(122, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(336, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonApply);
            this.panel1.Controls.Add(this.buttonNegate);
            this.panel1.Controls.Add(this.buttonOr);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonAnd);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Location = new System.Drawing.Point(586, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 143);
            this.panel1.TabIndex = 1;
            // 
            // buttonApply
            // 
            this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonApply.Image = ((System.Drawing.Image)(resources.GetObject("buttonApply.Image")));
            this.buttonApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonApply.Location = new System.Drawing.Point(3, 106);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(239, 21);
            this.buttonApply.TabIndex = 6;
            this.buttonApply.Text = "Apply Filter";
            this.buttonApply.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonApply.UseVisualStyleBackColor = true;
            // 
            // buttonNegate
            // 
            this.buttonNegate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNegate.Image = ((System.Drawing.Image)(resources.GetObject("buttonNegate.Image")));
            this.buttonNegate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNegate.Location = new System.Drawing.Point(125, 77);
            this.buttonNegate.Name = "buttonNegate";
            this.buttonNegate.Size = new System.Drawing.Size(117, 21);
            this.buttonNegate.TabIndex = 5;
            this.buttonNegate.Text = "Negate";
            this.buttonNegate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNegate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNegate.UseVisualStyleBackColor = true;
            // 
            // buttonOr
            // 
            this.buttonOr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOr.Image = ((System.Drawing.Image)(resources.GetObject("buttonOr.Image")));
            this.buttonOr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOr.Location = new System.Drawing.Point(125, 48);
            this.buttonOr.Name = "buttonOr";
            this.buttonOr.Size = new System.Drawing.Size(117, 21);
            this.buttonOr.TabIndex = 3;
            this.buttonOr.Text = "Add \"OR\" Group";
            this.buttonOr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOr.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(3, 48);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(117, 21);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonAnd
            // 
            this.buttonAnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAnd.Image")));
            this.buttonAnd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnd.Location = new System.Drawing.Point(125, 19);
            this.buttonAnd.Name = "buttonAnd";
            this.buttonAnd.Size = new System.Drawing.Size(117, 21);
            this.buttonAnd.TabIndex = 1;
            this.buttonAnd.Text = "Add \"AND\" Group";
            this.buttonAnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAnd.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(3, 19);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(117, 21);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add Criterion";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // FilterBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(0, 196);
            this.MinimumSize = new System.Drawing.Size(839, 0);
            this.Name = "FilterBuilder";
            this.Size = new System.Drawing.Size(839, 196);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView treeFilter;
        private System.Windows.Forms.TextBox textParameter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonNegate;
        private System.Windows.Forms.Button buttonOr;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAnd;
        private System.Windows.Forms.Button buttonAdd;
    }
}
