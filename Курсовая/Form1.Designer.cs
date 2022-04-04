using System.Drawing;

namespace Курсовая
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea16 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend16 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea17 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend17 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea19 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend19 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea20 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend20 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.func = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.left = new System.Windows.Forms.TextBox();
            this.right = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.func)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.SuspendLayout();
            // 
            // func
            // 
            chartArea16.Name = "ChartArea1";
            this.func.ChartAreas.Add(chartArea16);
            legend16.Name = "Legend1";
            this.func.Legends.Add(legend16);
            this.func.Location = new System.Drawing.Point(36, 407);
            this.func.Name = "func";
            series16.ChartArea = "ChartArea1";
            series16.Legend = "Legend1";
            series16.Name = "f(x)";
            this.func.Series.Add(series16);
            this.func.Size = new System.Drawing.Size(408, 343);
            this.func.TabIndex = 1;
            this.func.Text = "chart1";
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(186, 140);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(100, 22);
            this.left.TabIndex = 3;
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(186, 184);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(100, 22);
            this.right.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(162, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(162, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "b";
            // 
            // chart2
            // 
            chartArea17.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea17);
            legend17.Name = "Legend1";
            this.chart2.Legends.Add(legend17);
            this.chart2.Location = new System.Drawing.Point(491, 407);
            this.chart2.Name = "chart2";
            series17.ChartArea = "ChartArea1";
            series17.Legend = "Legend1";
            series17.Name = "E2(h)";
            this.chart2.Series.Add(series17);
            this.chart2.Size = new System.Drawing.Size(408, 343);
            this.chart2.TabIndex = 8;
            this.chart2.Text = "chart1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "Погрешность";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chart4
            // 
            chartArea18.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea18);
            legend18.Name = "Legend1";
            this.chart4.Legends.Add(legend18);
            this.chart4.Location = new System.Drawing.Point(941, 407);
            this.chart4.Name = "chart4";
            series18.ChartArea = "ChartArea1";
            series18.Legend = "Legend1";
            series18.Name = "E4(h)";
            this.chart4.Series.Add(series18);
            this.chart4.Size = new System.Drawing.Size(408, 343);
            this.chart4.TabIndex = 10;
            this.chart4.Text = "chart2";
            // 
            // chart1
            // 
            chartArea19.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea19);
            legend19.Name = "Legend1";
            this.chart1.Legends.Add(legend19);
            this.chart1.Location = new System.Drawing.Point(491, 24);
            this.chart1.Name = "chart1";
            series19.ChartArea = "ChartArea1";
            series19.Legend = "Legend1";
            series19.Name = "E1(h)";
            this.chart1.Series.Add(series19);
            this.chart1.Size = new System.Drawing.Size(408, 343);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart3";
            // 
            // chart3
            // 
            chartArea20.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea20);
            legend20.Name = "Legend1";
            this.chart3.Legends.Add(legend20);
            this.chart3.Location = new System.Drawing.Point(941, 24);
            this.chart3.Name = "chart3";
            series20.ChartArea = "ChartArea1";
            series20.Legend = "Legend1";
            series20.Name = "E3(h)";
            this.chart3.Series.Add(series20);
            this.chart3.Size = new System.Drawing.Size(408, 343);
            this.chart3.TabIndex = 14;
            this.chart3.Text = "chart4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "f(x) = 2 * x^2 + 10 * x * sin(x)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 768);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.func);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.func)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart func;
        private System.Windows.Forms.TextBox left;
        private System.Windows.Forms.TextBox right;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Label label3;
    }
}

