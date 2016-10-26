namespace ESPL_POS
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
            this.rightPane = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.leftpane.SuspendLayout();
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
            // rightPane
            // 
            this.rightPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPane.Location = new System.Drawing.Point(387, 0);
            this.rightPane.Name = "rightPane";
            this.rightPane.Size = new System.Drawing.Size(324, 341);
            this.rightPane.TabIndex = 1;
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
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(104, 15);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(164, 20);
            this.txtProductID.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(274, 13);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftpane;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel rightPane;
    }
}

