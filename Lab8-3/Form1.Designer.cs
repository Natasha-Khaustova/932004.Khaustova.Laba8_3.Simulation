
namespace Lab8_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.Val1Ed1 = new System.Windows.Forms.NumericUpDown();
            this.Val1Ed2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Val1Ed3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Val1Ed4 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Val1Ed5 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.numEd = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEd)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.Maximum = 7D;
            chartArea1.AxisX.Minimum = -1D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(307, 39);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Prob1";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "Prob2";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Prob3";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Prob4";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Prob5";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(706, 521);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Probability 1";
            // 
            // Val1Ed1
            // 
            this.Val1Ed1.DecimalPlaces = 3;
            this.Val1Ed1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.Val1Ed1.Location = new System.Drawing.Point(152, 58);
            this.Val1Ed1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Val1Ed1.Name = "Val1Ed1";
            this.Val1Ed1.Size = new System.Drawing.Size(120, 22);
            this.Val1Ed1.TabIndex = 2;
            this.Val1Ed1.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // Val1Ed2
            // 
            this.Val1Ed2.DecimalPlaces = 3;
            this.Val1Ed2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.Val1Ed2.Location = new System.Drawing.Point(152, 102);
            this.Val1Ed2.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Val1Ed2.Name = "Val1Ed2";
            this.Val1Ed2.Size = new System.Drawing.Size(120, 22);
            this.Val1Ed2.TabIndex = 4;
            this.Val1Ed2.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Probability 2";
            // 
            // Val1Ed3
            // 
            this.Val1Ed3.DecimalPlaces = 3;
            this.Val1Ed3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.Val1Ed3.Location = new System.Drawing.Point(152, 156);
            this.Val1Ed3.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Val1Ed3.Name = "Val1Ed3";
            this.Val1Ed3.Size = new System.Drawing.Size(120, 22);
            this.Val1Ed3.TabIndex = 6;
            this.Val1Ed3.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Probability 3";
            // 
            // Val1Ed4
            // 
            this.Val1Ed4.DecimalPlaces = 3;
            this.Val1Ed4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.Val1Ed4.Location = new System.Drawing.Point(152, 210);
            this.Val1Ed4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Val1Ed4.Name = "Val1Ed4";
            this.Val1Ed4.Size = new System.Drawing.Size(120, 22);
            this.Val1Ed4.TabIndex = 8;
            this.Val1Ed4.Value = new decimal(new int[] {
            8,
            0,
            0,
            131072});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Probability 4";
            // 
            // Val1Ed5
            // 
            this.Val1Ed5.DecimalPlaces = 3;
            this.Val1Ed5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.Val1Ed5.Location = new System.Drawing.Point(152, 272);
            this.Val1Ed5.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Val1Ed5.Name = "Val1Ed5";
            this.Val1Ed5.Size = new System.Drawing.Size(120, 22);
            this.Val1Ed5.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Probability 5";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(42, 425);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(166, 55);
            this.StartBtn.TabIndex = 11;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // numEd
            // 
            this.numEd.Location = new System.Drawing.Point(152, 365);
            this.numEd.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numEd.Name = "numEd";
            this.numEd.Size = new System.Drawing.Size(120, 22);
            this.numEd.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Number of trials:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 600);
            this.Controls.Add(this.numEd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.Val1Ed5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Val1Ed4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Val1Ed3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Val1Ed2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Val1Ed1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Val1Ed5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Val1Ed1;
        private System.Windows.Forms.NumericUpDown Val1Ed2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Val1Ed3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Val1Ed4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Val1Ed5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.NumericUpDown numEd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
    }
}

