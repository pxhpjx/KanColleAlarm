namespace KanColleAlarm
{
    partial class Alarm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alarm));
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.cb3 = new System.Windows.Forms.ComboBox();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblName3 = new System.Windows.Forms.Label();
            this.txtTimeCost1 = new System.Windows.Forms.TextBox();
            this.txtTimeCost2 = new System.Windows.Forms.TextBox();
            this.txtTimeCost3 = new System.Windows.Forms.TextBox();
            this.btnGo1 = new System.Windows.Forms.Button();
            this.btnGo2 = new System.Windows.Forms.Button();
            this.btnGo3 = new System.Windows.Forms.Button();
            this.lblWait1 = new System.Windows.Forms.Label();
            this.lblWait2 = new System.Windows.Forms.Label();
            this.lblWait3 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(12, 12);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(64, 20);
            this.cb1.TabIndex = 0;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
            // 
            // cb2
            // 
            this.cb2.FormattingEnabled = true;
            this.cb2.Location = new System.Drawing.Point(12, 62);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(64, 20);
            this.cb2.TabIndex = 1;
            this.cb2.SelectedIndexChanged += new System.EventHandler(this.cb2_SelectedIndexChanged);
            // 
            // cb3
            // 
            this.cb3.FormattingEnabled = true;
            this.cb3.Location = new System.Drawing.Point(12, 112);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(64, 20);
            this.cb3.TabIndex = 2;
            this.cb3.SelectedIndexChanged += new System.EventHandler(this.cb3_SelectedIndexChanged);
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Location = new System.Drawing.Point(82, 15);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(53, 12);
            this.lblName1.TabIndex = 3;
            this.lblName1.Text = "手动设定";
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Location = new System.Drawing.Point(82, 67);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(53, 12);
            this.lblName2.TabIndex = 4;
            this.lblName2.Text = "手动设定";
            // 
            // lblName3
            // 
            this.lblName3.AutoSize = true;
            this.lblName3.Location = new System.Drawing.Point(82, 115);
            this.lblName3.Name = "lblName3";
            this.lblName3.Size = new System.Drawing.Size(53, 12);
            this.lblName3.TabIndex = 5;
            this.lblName3.Text = "手动设定";
            // 
            // txtTimeCost1
            // 
            this.txtTimeCost1.Location = new System.Drawing.Point(222, 12);
            this.txtTimeCost1.Name = "txtTimeCost1";
            this.txtTimeCost1.Size = new System.Drawing.Size(64, 21);
            this.txtTimeCost1.TabIndex = 6;
            // 
            // txtTimeCost2
            // 
            this.txtTimeCost2.Location = new System.Drawing.Point(222, 62);
            this.txtTimeCost2.Name = "txtTimeCost2";
            this.txtTimeCost2.Size = new System.Drawing.Size(64, 21);
            this.txtTimeCost2.TabIndex = 7;
            // 
            // txtTimeCost3
            // 
            this.txtTimeCost3.Location = new System.Drawing.Point(222, 112);
            this.txtTimeCost3.Name = "txtTimeCost3";
            this.txtTimeCost3.Size = new System.Drawing.Size(64, 21);
            this.txtTimeCost3.TabIndex = 8;
            // 
            // btnGo1
            // 
            this.btnGo1.Location = new System.Drawing.Point(292, 10);
            this.btnGo1.Name = "btnGo1";
            this.btnGo1.Size = new System.Drawing.Size(58, 23);
            this.btnGo1.TabIndex = 9;
            this.btnGo1.Text = "Go!";
            this.btnGo1.UseVisualStyleBackColor = true;
            this.btnGo1.Click += new System.EventHandler(this.btnGo1_Click);
            // 
            // btnGo2
            // 
            this.btnGo2.Location = new System.Drawing.Point(292, 60);
            this.btnGo2.Name = "btnGo2";
            this.btnGo2.Size = new System.Drawing.Size(58, 23);
            this.btnGo2.TabIndex = 10;
            this.btnGo2.Text = "Go!";
            this.btnGo2.UseVisualStyleBackColor = true;
            this.btnGo2.Click += new System.EventHandler(this.btnGo2_Click);
            // 
            // btnGo3
            // 
            this.btnGo3.Location = new System.Drawing.Point(292, 110);
            this.btnGo3.Name = "btnGo3";
            this.btnGo3.Size = new System.Drawing.Size(58, 23);
            this.btnGo3.TabIndex = 11;
            this.btnGo3.Text = "Go!";
            this.btnGo3.UseVisualStyleBackColor = true;
            this.btnGo3.Click += new System.EventHandler(this.btnGo3_Click);
            // 
            // lblWait1
            // 
            this.lblWait1.AutoSize = true;
            this.lblWait1.Location = new System.Drawing.Point(356, 15);
            this.lblWait1.Name = "lblWait1";
            this.lblWait1.Size = new System.Drawing.Size(53, 12);
            this.lblWait1.TabIndex = 12;
            this.lblWait1.Text = "--:--:--";
            // 
            // lblWait2
            // 
            this.lblWait2.AutoSize = true;
            this.lblWait2.Location = new System.Drawing.Point(356, 67);
            this.lblWait2.Name = "lblWait2";
            this.lblWait2.Size = new System.Drawing.Size(53, 12);
            this.lblWait2.TabIndex = 13;
            this.lblWait2.Text = "--:--:--";
            // 
            // lblWait3
            // 
            this.lblWait3.AutoSize = true;
            this.lblWait3.Location = new System.Drawing.Point(356, 115);
            this.lblWait3.Name = "lblWait3";
            this.lblWait3.Size = new System.Drawing.Size(53, 12);
            this.lblWait3.TabIndex = 14;
            this.lblWait3.Text = "--:--:--";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "KanColleAlarm";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 144);
            this.Controls.Add(this.lblWait3);
            this.Controls.Add(this.lblWait2);
            this.Controls.Add(this.lblWait1);
            this.Controls.Add(this.btnGo3);
            this.Controls.Add(this.btnGo2);
            this.Controls.Add(this.btnGo1);
            this.Controls.Add(this.txtTimeCost3);
            this.Controls.Add(this.txtTimeCost2);
            this.Controls.Add(this.txtTimeCost1);
            this.Controls.Add(this.lblName3);
            this.Controls.Add(this.lblName2);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.cb3);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.cb2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Alarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PP\'s KanColleAlarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.ComboBox cb3;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblName3;
        private System.Windows.Forms.TextBox txtTimeCost1;
        private System.Windows.Forms.TextBox txtTimeCost2;
        private System.Windows.Forms.TextBox txtTimeCost3;
        private System.Windows.Forms.Button btnGo1;
        private System.Windows.Forms.Button btnGo2;
        private System.Windows.Forms.Button btnGo3;
        private System.Windows.Forms.Label lblWait1;
        private System.Windows.Forms.Label lblWait2;
        private System.Windows.Forms.Label lblWait3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

