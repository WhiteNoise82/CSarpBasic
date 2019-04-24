namespace UserControl1
{
    partial class UCInfo
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNo = new System.Windows.Forms.Label();
            this.pboxFace = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnIdle = new System.Windows.Forms.Button();
            this.btnCatch = new System.Windows.Forms.Button();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFace)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Location = new System.Drawing.Point(15, 15);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(11, 12);
            this.lblNo.TabIndex = 0;
            this.lblNo.Text = "1";
            // 
            // pboxFace
            // 
            this.pboxFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxFace.Location = new System.Drawing.Point(116, 48);
            this.pboxFace.Name = "pboxFace";
            this.pboxFace.Size = new System.Drawing.Size(100, 117);
            this.pboxFace.TabIndex = 1;
            this.pboxFace.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(99, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "이름 :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(99, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "금액 :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(37, 274);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
            this.btnReg.TabIndex = 4;
            this.btnReg.Text = "수베";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnIdle
            // 
            this.btnIdle.Location = new System.Drawing.Point(128, 274);
            this.btnIdle.Name = "btnIdle";
            this.btnIdle.Size = new System.Drawing.Size(75, 23);
            this.btnIdle.TabIndex = 5;
            this.btnIdle.Text = "해제";
            this.btnIdle.UseVisualStyleBackColor = true;
            this.btnIdle.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnCatch
            // 
            this.btnCatch.Location = new System.Drawing.Point(219, 274);
            this.btnCatch.Name = "btnCatch";
            this.btnCatch.Size = new System.Drawing.Size(75, 23);
            this.btnCatch.TabIndex = 6;
            this.btnCatch.Text = "검거";
            this.btnCatch.UseVisualStyleBackColor = true;
            this.btnCatch.Click += new System.EventHandler(this.Btn_Click);
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGold.Location = new System.Drawing.Point(168, 224);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(80, 19);
            this.lblGold.TabIndex = 8;
            this.lblGold.Text = "2천만원";
            this.lblGold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.Location = new System.Drawing.Point(174, 194);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 19);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "홍길동";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnCatch);
            this.Controls.Add(this.btnIdle);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pboxFace);
            this.Controls.Add(this.lblNo);
            this.Name = "UCInfo";
            this.Size = new System.Drawing.Size(328, 319);
            ((System.ComponentModel.ISupportInitialize)(this.pboxFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.PictureBox pboxFace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnIdle;
        private System.Windows.Forms.Button btnCatch;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblName;
    }
}
