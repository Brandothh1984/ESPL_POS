﻿namespace ESPL_POS
{
    partial class MainForm
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
            this.leftpane = new System.Windows.Forms.Panel();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rightPane = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.gridviewData = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.leftpane.SuspendLayout();
            this.rightPane.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewData)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpane
            // 
            this.leftpane.Controls.Add(this.btnFind);
            this.leftpane.Controls.Add(this.txtProductID);
            this.leftpane.Controls.Add(this.label1);
            this.leftpane.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftpane.Location = new System.Drawing.Point(0, 0);
            this.leftpane.Name = "leftpane";
            this.leftpane.Size = new System.Drawing.Size(387, 341);
            this.leftpane.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(274, 13);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Add";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(104, 15);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(164, 20);
            this.txtProductID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Product ID";
            // 
            // rightPane
            // 
            this.rightPane.Controls.Add(this.panel2);
            this.rightPane.Controls.Add(this.panel1);
            this.rightPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPane.Location = new System.Drawing.Point(387, 0);
            this.rightPane.Name = "rightPane";
            this.rightPane.Size = new System.Drawing.Size(324, 341);
            this.rightPane.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 36);
            this.panel1.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(237, 8);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // gridviewData
            // 
            this.gridviewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridviewData.Location = new System.Drawing.Point(0, 0);
            this.gridviewData.Name = "gridviewData";
            this.gridviewData.Size = new System.Drawing.Size(324, 305);
            this.gridviewData.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridviewData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 305);
            this.panel2.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 341);
            this.Controls.Add(this.rightPane);
            this.Controls.Add(this.leftpane);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.leftpane.ResumeLayout(false);
            this.leftpane.PerformLayout();
            this.rightPane.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftpane;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel rightPane;
        private System.Windows.Forms.DataGridView gridviewData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel2;
    }
}

