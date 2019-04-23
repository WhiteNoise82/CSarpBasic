namespace Thread1
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
            this.components = new System.ComponentModel.Container();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.numPlayerCount = new System.Windows.Forms.NumericUpDown();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lboxResult = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayerCount)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.numPlayerCount);
            this.gbMenu.Controls.Add(this.lblPlayer);
            this.gbMenu.Location = new System.Drawing.Point(12, 12);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(393, 68);
            this.gbMenu.TabIndex = 0;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "Menu";
            // 
            // numPlayerCount
            // 
            this.numPlayerCount.Location = new System.Drawing.Point(99, 25);
            this.numPlayerCount.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numPlayerCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPlayerCount.Name = "numPlayerCount";
            this.numPlayerCount.Size = new System.Drawing.Size(37, 21);
            this.numPlayerCount.TabIndex = 1;
            this.numPlayerCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numPlayerCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(16, 29);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(77, 12);
            this.lblPlayer.TabIndex = 0;
            this.lblPlayer.Text = "플레이어 수 :";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(330, 86);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "시작";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // lboxResult
            // 
            this.lboxResult.FormattingEnabled = true;
            this.lboxResult.ItemHeight = 12;
            this.lboxResult.Location = new System.Drawing.Point(12, 126);
            this.lboxResult.Name = "lboxResult";
            this.lboxResult.Size = new System.Drawing.Size(393, 112);
            this.lboxResult.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 252);
            this.Controls.Add(this.lboxResult);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gbMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gbMenu.ResumeLayout(false);
            this.gbMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPlayerCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.NumericUpDown numPlayerCount;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox lboxResult;
        private System.Windows.Forms.Timer timer1;
    }
}

