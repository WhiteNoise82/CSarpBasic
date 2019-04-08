namespace DelegateAndEvent
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDow = new System.Windows.Forms.GroupBox();
            this.gbEdge = new System.Windows.Forms.GroupBox();
            this.gbTopping = new System.Windows.Forms.GroupBox();
            this.rbOrigin = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.rbRich = new System.Windows.Forms.RadioButton();
            this.rbCrust = new System.Windows.Forms.RadioButton();
            this.cbSoce = new System.Windows.Forms.CheckBox();
            this.cbPote = new System.Windows.Forms.CheckBox();
            this.cbChee = new System.Windows.Forms.CheckBox();
            this.nudEa = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.gbDow.SuspendLayout();
            this.gbEdge.SuspendLayout();
            this.gbTopping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEa)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDow
            // 
            this.gbDow.Controls.Add(this.rbThin);
            this.gbDow.Controls.Add(this.rbOrigin);
            this.gbDow.Location = new System.Drawing.Point(12, 12);
            this.gbDow.Name = "gbDow";
            this.gbDow.Size = new System.Drawing.Size(276, 44);
            this.gbDow.TabIndex = 0;
            this.gbDow.TabStop = false;
            this.gbDow.Text = "도우";
            // 
            // gbEdge
            // 
            this.gbEdge.Controls.Add(this.rbCrust);
            this.gbEdge.Controls.Add(this.rbRich);
            this.gbEdge.Location = new System.Drawing.Point(12, 62);
            this.gbEdge.Name = "gbEdge";
            this.gbEdge.Size = new System.Drawing.Size(276, 41);
            this.gbEdge.TabIndex = 0;
            this.gbEdge.TabStop = false;
            this.gbEdge.Text = "엣지";
            // 
            // gbTopping
            // 
            this.gbTopping.Controls.Add(this.label1);
            this.gbTopping.Controls.Add(this.nudEa);
            this.gbTopping.Controls.Add(this.cbChee);
            this.gbTopping.Controls.Add(this.cbPote);
            this.gbTopping.Controls.Add(this.cbSoce);
            this.gbTopping.Location = new System.Drawing.Point(12, 109);
            this.gbTopping.Name = "gbTopping";
            this.gbTopping.Size = new System.Drawing.Size(276, 90);
            this.gbTopping.TabIndex = 0;
            this.gbTopping.TabStop = false;
            this.gbTopping.Text = "토핑";
            // 
            // rbOrigin
            // 
            this.rbOrigin.AutoSize = true;
            this.rbOrigin.Location = new System.Drawing.Point(6, 20);
            this.rbOrigin.Name = "rbOrigin";
            this.rbOrigin.Size = new System.Drawing.Size(127, 16);
            this.rbOrigin.TabIndex = 1;
            this.rbOrigin.TabStop = true;
            this.rbOrigin.Text = "오리지널 (10000원)";
            this.rbOrigin.UseVisualStyleBackColor = true;
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Location = new System.Drawing.Point(139, 20);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(91, 16);
            this.rbThin.TabIndex = 2;
            this.rbThin.TabStop = true;
            this.rbThin.Text = "씬 (11000원)";
            this.rbThin.UseVisualStyleBackColor = true;
            // 
            // rbRich
            // 
            this.rbRich.AutoSize = true;
            this.rbRich.Location = new System.Drawing.Point(3, 17);
            this.rbRich.Name = "rbRich";
            this.rbRich.Size = new System.Drawing.Size(121, 16);
            this.rbRich.TabIndex = 0;
            this.rbRich.TabStop = true;
            this.rbRich.Text = "리치골드 (1000원)";
            this.rbRich.UseVisualStyleBackColor = true;
            // 
            // rbCrust
            // 
            this.rbCrust.AutoSize = true;
            this.rbCrust.Location = new System.Drawing.Point(130, 17);
            this.rbCrust.Name = "rbCrust";
            this.rbCrust.Size = new System.Drawing.Size(145, 16);
            this.rbCrust.TabIndex = 1;
            this.rbCrust.TabStop = true;
            this.rbCrust.Text = "치즈크러스터 (2000원)";
            this.rbCrust.UseVisualStyleBackColor = true;
            // 
            // cbSoce
            // 
            this.cbSoce.AutoSize = true;
            this.cbSoce.Location = new System.Drawing.Point(6, 17);
            this.cbSoce.Name = "cbSoce";
            this.cbSoce.Size = new System.Drawing.Size(128, 16);
            this.cbSoce.TabIndex = 0;
            this.cbSoce.Text = "소세지 (1ea 500원)";
            this.cbSoce.UseVisualStyleBackColor = true;
            // 
            // cbPote
            // 
            this.cbPote.AutoSize = true;
            this.cbPote.Location = new System.Drawing.Point(6, 39);
            this.cbPote.Name = "cbPote";
            this.cbPote.Size = new System.Drawing.Size(116, 16);
            this.cbPote.TabIndex = 1;
            this.cbPote.Text = "감자 (1ea 200원)";
            this.cbPote.UseVisualStyleBackColor = true;
            // 
            // cbChee
            // 
            this.cbChee.AutoSize = true;
            this.cbChee.Location = new System.Drawing.Point(6, 61);
            this.cbChee.Name = "cbChee";
            this.cbChee.Size = new System.Drawing.Size(116, 16);
            this.cbChee.TabIndex = 2;
            this.cbChee.Text = "치즈 (1ea 300원)";
            this.cbChee.UseVisualStyleBackColor = true;
            // 
            // nudEa
            // 
            this.nudEa.Location = new System.Drawing.Point(190, 61);
            this.nudEa.Name = "nudEa";
            this.nudEa.Size = new System.Drawing.Size(40, 21);
            this.nudEa.TabIndex = 3;
            this.nudEa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "(ea)";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(213, 205);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "주문하기";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.ItemHeight = 12;
            this.lbResult.Location = new System.Drawing.Point(12, 234);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(275, 136);
            this.lbResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 385);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.gbTopping);
            this.Controls.Add(this.gbDow);
            this.Controls.Add(this.gbEdge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbDow.ResumeLayout(false);
            this.gbDow.PerformLayout();
            this.gbEdge.ResumeLayout(false);
            this.gbEdge.PerformLayout();
            this.gbTopping.ResumeLayout(false);
            this.gbTopping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDow;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.RadioButton rbOrigin;
        private System.Windows.Forms.GroupBox gbEdge;
        private System.Windows.Forms.GroupBox gbTopping;
        private System.Windows.Forms.RadioButton rbCrust;
        private System.Windows.Forms.RadioButton rbRich;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudEa;
        private System.Windows.Forms.CheckBox cbChee;
        private System.Windows.Forms.CheckBox cbPote;
        private System.Windows.Forms.CheckBox cbSoce;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ListBox lbResult;
    }
}

