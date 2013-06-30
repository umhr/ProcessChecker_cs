namespace ProcessChecker
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.processNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.logTB = new System.Windows.Forms.TextBox();
            this.resetHour = new System.Windows.Forms.NumericUpDown();
            this.resetMinute = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pathTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // processNameTB
            // 
            this.processNameTB.Location = new System.Drawing.Point(129, 13);
            this.processNameTB.Name = "processNameTB";
            this.processNameTB.Size = new System.Drawing.Size(143, 19);
            this.processNameTB.TabIndex = 0;
            this.processNameTB.Text = "notepad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Process Name";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Check Interval (sec)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(129, 61);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 19);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(205, 108);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 16);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Activate";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // logTB
            // 
            this.logTB.Location = new System.Drawing.Point(16, 135);
            this.logTB.Multiline = true;
            this.logTB.Name = "logTB";
            this.logTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTB.Size = new System.Drawing.Size(256, 115);
            this.logTB.TabIndex = 6;
            // 
            // resetHour
            // 
            this.resetHour.Location = new System.Drawing.Point(129, 85);
            this.resetHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.resetHour.Name = "resetHour";
            this.resetHour.Size = new System.Drawing.Size(35, 19);
            this.resetHour.TabIndex = 7;
            // 
            // resetMinute
            // 
            this.resetMinute.Location = new System.Drawing.Point(183, 85);
            this.resetMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.resetMinute.Name = "resetMinute";
            this.resetMinute.Size = new System.Drawing.Size(35, 19);
            this.resetMinute.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "Reset(H:M)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(7, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "Path";
            // 
            // pathTB
            // 
            this.pathTB.Location = new System.Drawing.Point(48, 36);
            this.pathTB.Name = "pathTB";
            this.pathTB.Size = new System.Drawing.Size(224, 19);
            this.pathTB.TabIndex = 12;
            this.pathTB.Text = "C:\\Windows\\System32\\notepad.exe";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save SettingXML";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pathTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resetMinute);
            this.Controls.Add(this.resetHour);
            this.Controls.Add(this.logTB);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.processNameTB);
            this.Name = "Form1";
            this.Text = "ProcessChecker";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resetMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox processNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox logTB;
        private System.Windows.Forms.NumericUpDown resetHour;
        private System.Windows.Forms.NumericUpDown resetMinute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pathTB;
        private System.Windows.Forms.Button button1;

    }
}

