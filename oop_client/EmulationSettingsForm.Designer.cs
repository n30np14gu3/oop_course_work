namespace oop_client
{
    partial class EmulationSettingsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NLineCapacity = new System.Windows.Forms.NumericUpDown();
            this.NLinesCount = new System.Windows.Forms.NumericUpDown();
            this.NEntityCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.NMathWait = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.NFailsCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NHourTime = new System.Windows.Forms.NumericUpDown();
            this.BSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NLineCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NLinesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NEntityCount)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NMathWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NFailsCount)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NHourTime)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NLineCapacity);
            this.groupBox1.Controls.Add(this.NLinesCount);
            this.groupBox1.Controls.Add(this.NEntityCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки предприятия";
            // 
            // NLineCapacity
            // 
            this.NLineCapacity.Location = new System.Drawing.Point(225, 78);
            this.NLineCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NLineCapacity.Name = "NLineCapacity";
            this.NLineCapacity.Size = new System.Drawing.Size(174, 20);
            this.NLineCapacity.TabIndex = 5;
            this.NLineCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NLinesCount
            // 
            this.NLinesCount.Location = new System.Drawing.Point(225, 52);
            this.NLinesCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NLinesCount.Name = "NLinesCount";
            this.NLinesCount.Size = new System.Drawing.Size(174, 20);
            this.NLinesCount.TabIndex = 4;
            this.NLinesCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NEntityCount
            // 
            this.NEntityCount.Location = new System.Drawing.Point(225, 26);
            this.NEntityCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NEntityCount.Name = "NEntityCount";
            this.NEntityCount.Size = new System.Drawing.Size(174, 20);
            this.NEntityCount.TabIndex = 3;
            this.NEntityCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Максимальное кол-во ТУ на линии (L):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кол-во технологических линий (M):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кол-во ТУ (N):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.NMathWait);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.NFailsCount);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 87);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройки ТУ";
            // 
            // NMathWait
            // 
            this.NMathWait.Location = new System.Drawing.Point(220, 50);
            this.NMathWait.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NMathWait.Name = "NMathWait";
            this.NMathWait.Size = new System.Drawing.Size(179, 20);
            this.NMathWait.TabIndex = 8;
            this.NMathWait.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Мат ожидание восстановления (R):";
            // 
            // NFailsCount
            // 
            this.NFailsCount.Location = new System.Drawing.Point(220, 22);
            this.NFailsCount.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.NFailsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NFailsCount.Name = "NFailsCount";
            this.NFailsCount.Size = new System.Drawing.Size(179, 20);
            this.NFailsCount.TabIndex = 6;
            this.NFailsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Кол-во отказов в сутки (Z):";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.NHourTime);
            this.groupBox3.Location = new System.Drawing.Point(12, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(408, 58);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Настройки времени";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Время одного часа (ms):";
            // 
            // NHourTime
            // 
            this.NHourTime.Location = new System.Drawing.Point(220, 19);
            this.NHourTime.Maximum = new decimal(new int[] {
            86400000,
            0,
            0,
            0});
            this.NHourTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NHourTime.Name = "NHourTime";
            this.NHourTime.Size = new System.Drawing.Size(179, 20);
            this.NHourTime.TabIndex = 9;
            this.NHourTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BSave
            // 
            this.BSave.Location = new System.Drawing.Point(12, 308);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(408, 40);
            this.BSave.TabIndex = 3;
            this.BSave.Text = "Сохранить";
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // EmulationSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 357);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmulationSettingsForm";
            this.Text = "Настройки симуляции";
            this.Load += new System.EventHandler(this.EmulationSettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NLineCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NLinesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NEntityCount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NMathWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NFailsCount)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NHourTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown NLineCapacity;
        private System.Windows.Forms.NumericUpDown NLinesCount;
        private System.Windows.Forms.NumericUpDown NEntityCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NFailsCount;
        private System.Windows.Forms.NumericUpDown NMathWait;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NHourTime;
        private System.Windows.Forms.Button BSave;
    }
}