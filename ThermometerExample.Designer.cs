namespace ThermometerExample
{
    partial class ThermometerExample
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBackColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.trackBarCurrentValue = new System.Windows.Forms.TrackBar();
            this.CurrentValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownDevision = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.thermometer3 = new SeeSharpTools.JY.GUI.Thermometer();
            this.thermometer2 = new SeeSharpTools.JY.GUI.Thermometer();
            this.thermometer1 = new SeeSharpTools.JY.GUI.Thermometer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCurrentValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDevision)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "BallColor";
            // 
            // buttonBackColor
            // 
            this.buttonBackColor.Location = new System.Drawing.Point(168, 304);
            this.buttonBackColor.Name = "buttonBackColor";
            this.buttonBackColor.Size = new System.Drawing.Size(22, 22);
            this.buttonBackColor.TabIndex = 4;
            this.buttonBackColor.UseVisualStyleBackColor = true;
            this.buttonBackColor.Click += new System.EventHandler(this.buttonBackColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Min";
            // 
            // numericUpDownMax
            // 
            this.numericUpDownMax.Location = new System.Drawing.Point(143, 341);
            this.numericUpDownMax.Name = "numericUpDownMax";
            this.numericUpDownMax.Size = new System.Drawing.Size(75, 21);
            this.numericUpDownMax.TabIndex = 7;
            this.numericUpDownMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMax.ValueChanged += new System.EventHandler(this.numericUpDownMax_ValueChanged);
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.Location = new System.Drawing.Point(143, 376);
            this.numericUpDownMin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(75, 21);
            this.numericUpDownMin.TabIndex = 8;
            this.numericUpDownMin.ValueChanged += new System.EventHandler(this.numericUpDownMin_ValueChanged);
            // 
            // trackBarCurrentValue
            // 
            this.trackBarCurrentValue.Location = new System.Drawing.Point(380, 304);
            this.trackBarCurrentValue.Maximum = 100;
            this.trackBarCurrentValue.Name = "trackBarCurrentValue";
            this.trackBarCurrentValue.Size = new System.Drawing.Size(195, 45);
            this.trackBarCurrentValue.TabIndex = 9;
            this.trackBarCurrentValue.TickFrequency = 10;
            this.trackBarCurrentValue.Scroll += new System.EventHandler(this.trackBarCurrentValue_Scroll);
            // 
            // CurrentValue
            // 
            this.CurrentValue.AutoSize = true;
            this.CurrentValue.Location = new System.Drawing.Point(300, 311);
            this.CurrentValue.Name = "CurrentValue";
            this.CurrentValue.Size = new System.Drawing.Size(77, 12);
            this.CurrentValue.TabIndex = 11;
            this.CurrentValue.Text = "CurrentValue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "Number Of Devision";
            // 
            // numericUpDownDevision
            // 
            this.numericUpDownDevision.Location = new System.Drawing.Point(143, 407);
            this.numericUpDownDevision.Name = "numericUpDownDevision";
            this.numericUpDownDevision.Size = new System.Drawing.Size(75, 21);
            this.numericUpDownDevision.TabIndex = 14;
            this.numericUpDownDevision.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDevision.ValueChanged += new System.EventHandler(this.numericUpDownDevision_ValueChanged);
            // 
            // thermometer3
            // 
            this.thermometer3.BackColor = System.Drawing.Color.Transparent;
            this.thermometer3.BallSize = 15;
            this.thermometer3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thermometer3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.thermometer3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.thermometer3.LineWidth = 5;
            this.thermometer3.Location = new System.Drawing.Point(499, 57);
            this.thermometer3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.thermometer3.Max = 100D;
            this.thermometer3.Min = 0D;
            this.thermometer3.Name = "thermometer3";
            this.thermometer3.NumberOfDivisions = 10;
            this.thermometer3.Size = new System.Drawing.Size(65, 163);
            this.thermometer3.TabIndex = 15;
            this.thermometer3.TextColor = System.Drawing.Color.Black;
            this.thermometer3.TextDecimals = 3;
            this.thermometer3.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.thermometer3.TickWidth = 4;
            this.thermometer3.Value = 0D;
            // 
            // thermometer2
            // 
            this.thermometer2.BackColor = System.Drawing.Color.Transparent;
            this.thermometer2.BallSize = 15;
            this.thermometer2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thermometer2.ForeColor = System.Drawing.Color.DarkRed;
            this.thermometer2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.thermometer2.LineWidth = 5;
            this.thermometer2.Location = new System.Drawing.Point(305, 57);
            this.thermometer2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.thermometer2.Max = 100D;
            this.thermometer2.Min = 0D;
            this.thermometer2.Name = "thermometer2";
            this.thermometer2.NumberOfDivisions = 10;
            this.thermometer2.Size = new System.Drawing.Size(59, 163);
            this.thermometer2.TabIndex = 16;
            this.thermometer2.TextColor = System.Drawing.Color.Black;
            this.thermometer2.TextDecimals = 3;
            this.thermometer2.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.thermometer2.TickWidth = 4;
            this.thermometer2.Value = 0D;
            // 
            // thermometer1
            // 
            this.thermometer1.BackColor = System.Drawing.Color.Transparent;
            this.thermometer1.BallSize = 15;
            this.thermometer1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thermometer1.ForeColor = System.Drawing.Color.OliveDrab;
            this.thermometer1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(90)))));
            this.thermometer1.LineWidth = 5;
            this.thermometer1.Location = new System.Drawing.Point(82, 57);
            this.thermometer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.thermometer1.Max = 100D;
            this.thermometer1.Min = 0D;
            this.thermometer1.Name = "thermometer1";
            this.thermometer1.NumberOfDivisions = 10;
            this.thermometer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.thermometer1.Size = new System.Drawing.Size(59, 163);
            this.thermometer1.TabIndex = 17;
            this.thermometer1.TextColor = System.Drawing.Color.Black;
            this.thermometer1.TextDecimals = 3;
            this.thermometer1.TextStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.thermometer1.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.thermometer1.TickWidth = 4;
            this.thermometer1.Value = 0D;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "None",
            "TopLeft",
            "BottomRight",
            "Both"});
            this.listBox1.Location = new System.Drawing.Point(389, 372);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 52);
            this.listBox1.TabIndex = 18;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 19;
            this.label4.Text = "TextStyle";
            // 
            // ThermometerExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(611, 448);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.numericUpDownDevision);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CurrentValue);
            this.Controls.Add(this.trackBarCurrentValue);
            this.Controls.Add(this.numericUpDownMin);
            this.Controls.Add(this.numericUpDownMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBackColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thermometer3);
            this.Controls.Add(this.thermometer2);
            this.Controls.Add(this.thermometer1);
            this.Name = "ThermometerExample";
            this.Text = "ThermometerExample";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCurrentValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDevision)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SeeSharpTools.JY.GUI.Thermometer thermometer1;
        private SeeSharpTools.JY.GUI.Thermometer thermometer2;
        private SeeSharpTools.JY.GUI.Thermometer thermometer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBackColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownMax;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.TrackBar trackBarCurrentValue;
        private System.Windows.Forms.Label CurrentValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownDevision;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
    }
}

