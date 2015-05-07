namespace usbkill
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.radioButton01 = new System.Windows.Forms.RadioButton();
            this.radioButton03 = new System.Windows.Forms.RadioButton();
            this.radioButton04 = new System.Windows.Forms.RadioButton();
            this.radioButton02 = new System.Windows.Forms.RadioButton();
            this.radioButton00 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 142);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(224, 88);
            this.listBox1.TabIndex = 0;
            // 
            // radioButton01
            // 
            this.radioButton01.AutoSize = true;
            this.radioButton01.Location = new System.Drawing.Point(80, 21);
            this.radioButton01.Name = "radioButton01";
            this.radioButton01.Size = new System.Drawing.Size(47, 16);
            this.radioButton01.TabIndex = 1;
            this.radioButton01.Text = "Lock";
            this.radioButton01.UseVisualStyleBackColor = true;
            this.radioButton01.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton03
            // 
            this.radioButton03.AutoSize = true;
            this.radioButton03.Location = new System.Drawing.Point(80, 43);
            this.radioButton03.Name = "radioButton03";
            this.radioButton03.Size = new System.Drawing.Size(62, 16);
            this.radioButton03.TabIndex = 1;
            this.radioButton03.Text = "Sign out";
            this.radioButton03.UseVisualStyleBackColor = true;
            this.radioButton03.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton04
            // 
            this.radioButton04.AutoSize = true;
            this.radioButton04.Location = new System.Drawing.Point(148, 43);
            this.radioButton04.Name = "radioButton04";
            this.radioButton04.Size = new System.Drawing.Size(73, 16);
            this.radioButton04.TabIndex = 1;
            this.radioButton04.Text = "Shut down";
            this.radioButton04.UseVisualStyleBackColor = true;
            this.radioButton04.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton02
            // 
            this.radioButton02.AutoSize = true;
            this.radioButton02.Location = new System.Drawing.Point(6, 43);
            this.radioButton02.Name = "radioButton02";
            this.radioButton02.Size = new System.Drawing.Size(68, 16);
            this.radioButton02.TabIndex = 1;
            this.radioButton02.Text = "Hibernate";
            this.radioButton02.UseVisualStyleBackColor = true;
            this.radioButton02.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton00
            // 
            this.radioButton00.AutoSize = true;
            this.radioButton00.Checked = true;
            this.radioButton00.Location = new System.Drawing.Point(6, 21);
            this.radioButton00.Name = "radioButton00";
            this.radioButton00.Size = new System.Drawing.Size(48, 16);
            this.radioButton00.TabIndex = 1;
            this.radioButton00.TabStop = true;
            this.radioButton00.Text = "None";
            this.radioButton00.UseVisualStyleBackColor = true;
            this.radioButton00.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(80, 21);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(47, 16);
            this.radioButton11.TabIndex = 2;
            this.radioButton11.Text = "Lock";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Checked = true;
            this.radioButton10.Location = new System.Drawing.Point(6, 21);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(48, 16);
            this.radioButton10.TabIndex = 2;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "None";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(80, 43);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(62, 16);
            this.radioButton13.TabIndex = 2;
            this.radioButton13.Text = "Sign out";
            this.radioButton13.UseVisualStyleBackColor = true;
            this.radioButton13.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(6, 43);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(68, 16);
            this.radioButton12.TabIndex = 2;
            this.radioButton12.Text = "Hibernate";
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(148, 43);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(73, 16);
            this.radioButton14.TabIndex = 2;
            this.radioButton14.Text = "Shut down";
            this.radioButton14.UseVisualStyleBackColor = true;
            this.radioButton14.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton00);
            this.groupBox1.Controls.Add(this.radioButton01);
            this.groupBox1.Controls.Add(this.radioButton02);
            this.groupBox1.Controls.Add(this.radioButton03);
            this.groupBox1.Controls.Add(this.radioButton04);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 64);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insert";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton10);
            this.groupBox2.Controls.Add(this.radioButton11);
            this.groupBox2.Controls.Add(this.radioButton12);
            this.groupBox2.Controls.Add(this.radioButton13);
            this.groupBox2.Controls.Add(this.radioButton14);
            this.groupBox2.Location = new System.Drawing.Point(12, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 64);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remove";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 249);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "USB Kill";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton radioButton01;
        private System.Windows.Forms.RadioButton radioButton03;
        private System.Windows.Forms.RadioButton radioButton04;
        private System.Windows.Forms.RadioButton radioButton02;
        private System.Windows.Forms.RadioButton radioButton00;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

