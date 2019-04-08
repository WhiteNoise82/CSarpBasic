namespace DelegateAndEvent
{
    partial class frmPizza
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
            this.lbMake = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMake
            // 
            this.lbMake.FormattingEnabled = true;
            this.lbMake.ItemHeight = 12;
            this.lbMake.Location = new System.Drawing.Point(12, 12);
            this.lbMake.Name = "lbMake";
            this.lbMake.Size = new System.Drawing.Size(316, 160);
            this.lbMake.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(253, 178);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "창닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 211);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbMake);
            this.Name = "frmPizza";
            this.Text = "frmPizza";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbMake;
        private System.Windows.Forms.Button btnClose;
    }
}