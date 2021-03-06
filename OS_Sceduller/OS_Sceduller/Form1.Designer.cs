﻿namespace OS_Sceduller
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SJF = new System.Windows.Forms.Button();
            this.RR = new System.Windows.Forms.Button();
            this.Prio = new System.Windows.Forms.Button();
            this.CLR = new System.Windows.Forms.Button();
            this.Process = new System.Windows.Forms.Label();
            this.arrv = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.proc = new System.Windows.Forms.TextBox();
            this.burst = new System.Windows.Forms.TextBox();
            this.arriv = new System.Windows.Forms.TextBox();
            this.add_process = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.priority = new System.Windows.Forms.TextBox();
            this.FCFS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.wait = new System.Windows.Forms.TextBox();
            this.turn = new System.Windows.Forms.TextBox();
            this.quam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // SJF
            // 
            this.SJF.Location = new System.Drawing.Point(165, 216);
            this.SJF.Name = "SJF";
            this.SJF.Size = new System.Drawing.Size(75, 23);
            this.SJF.TabIndex = 1;
            this.SJF.Text = "SJF";
            this.SJF.UseVisualStyleBackColor = true;
            this.SJF.Click += new System.EventHandler(this.SJF_Click);
            // 
            // RR
            // 
            this.RR.Location = new System.Drawing.Point(304, 216);
            this.RR.Name = "RR";
            this.RR.Size = new System.Drawing.Size(101, 23);
            this.RR.TabIndex = 2;
            this.RR.Text = "Round Robin";
            this.RR.UseVisualStyleBackColor = true;
            this.RR.Click += new System.EventHandler(this.RR_Click);
            // 
            // Prio
            // 
            this.Prio.Location = new System.Drawing.Point(448, 216);
            this.Prio.Name = "Prio";
            this.Prio.Size = new System.Drawing.Size(88, 23);
            this.Prio.TabIndex = 3;
            this.Prio.Text = "Priority";
            this.Prio.UseVisualStyleBackColor = true;
            this.Prio.Click += new System.EventHandler(this.Prio_Click);
            // 
            // CLR
            // 
            this.CLR.Location = new System.Drawing.Point(414, 277);
            this.CLR.Name = "CLR";
            this.CLR.Size = new System.Drawing.Size(91, 35);
            this.CLR.TabIndex = 5;
            this.CLR.Text = "Clear";
            this.CLR.UseVisualStyleBackColor = true;
            this.CLR.Click += new System.EventHandler(this.CLR_Click);
            // 
            // Process
            // 
            this.Process.AutoSize = true;
            this.Process.Location = new System.Drawing.Point(12, 24);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(59, 13);
            this.Process.TabIndex = 6;
            this.Process.Text = "Process ID";
            this.Process.Click += new System.EventHandler(this.label1_Click);
            // 
            // arrv
            // 
            this.arrv.AutoSize = true;
            this.arrv.Location = new System.Drawing.Point(137, 24);
            this.arrv.Name = "arrv";
            this.arrv.Size = new System.Drawing.Size(62, 13);
            this.arrv.TabIndex = 7;
            this.arrv.Text = "Arrival Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Burst Time";
            // 
            // proc
            // 
            this.proc.Enabled = false;
            this.proc.Location = new System.Drawing.Point(12, 52);
            this.proc.Name = "proc";
            this.proc.Size = new System.Drawing.Size(100, 20);
            this.proc.TabIndex = 9;
            this.proc.Text = "0";
            // 
            // burst
            // 
            this.burst.Location = new System.Drawing.Point(281, 52);
            this.burst.Name = "burst";
            this.burst.Size = new System.Drawing.Size(100, 20);
            this.burst.TabIndex = 10;
            // 
            // arriv
            // 
            this.arriv.Location = new System.Drawing.Point(140, 52);
            this.arriv.Name = "arriv";
            this.arriv.Size = new System.Drawing.Size(100, 20);
            this.arriv.TabIndex = 11;
            // 
            // add_process
            // 
            this.add_process.Location = new System.Drawing.Point(193, 148);
            this.add_process.Name = "add_process";
            this.add_process.Size = new System.Drawing.Size(153, 38);
            this.add_process.TabIndex = 12;
            this.add_process.Text = "Add Process";
            this.add_process.UseVisualStyleBackColor = true;
            this.add_process.Click += new System.EventHandler(this.add_process_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(553, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(500, 326);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Priority";
            // 
            // priority
            // 
            this.priority.Location = new System.Drawing.Point(405, 52);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(100, 20);
            this.priority.TabIndex = 15;
            this.priority.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // FCFS
            // 
            this.FCFS.Location = new System.Drawing.Point(12, 216);
            this.FCFS.Name = "FCFS";
            this.FCFS.Size = new System.Drawing.Size(75, 23);
            this.FCFS.TabIndex = 16;
            this.FCFS.Text = "FCFS";
            this.FCFS.UseVisualStyleBackColor = true;
            this.FCFS.Click += new System.EventHandler(this.FCFS_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Avg Waiting Time";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Avg Turnaround Time";
            // 
            // wait
            // 
            this.wait.Enabled = false;
            this.wait.Location = new System.Drawing.Point(52, 292);
            this.wait.Name = "wait";
            this.wait.Size = new System.Drawing.Size(100, 20);
            this.wait.TabIndex = 21;
            this.wait.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // turn
            // 
            this.turn.Enabled = false;
            this.turn.Location = new System.Drawing.Point(193, 292);
            this.turn.Name = "turn";
            this.turn.Size = new System.Drawing.Size(100, 20);
            this.turn.TabIndex = 22;
            // 
            // quam
            // 
            this.quam.Location = new System.Drawing.Point(12, 112);
            this.quam.Name = "quam";
            this.quam.Size = new System.Drawing.Size(100, 20);
            this.quam.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Quantum";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Preemptive SJF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(369, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Premptive Priority";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1065, 352);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quam);
            this.Controls.Add(this.turn);
            this.Controls.Add(this.wait);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FCFS);
            this.Controls.Add(this.priority);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.add_process);
            this.Controls.Add(this.arriv);
            this.Controls.Add(this.burst);
            this.Controls.Add(this.proc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.arrv);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.CLR);
            this.Controls.Add(this.Prio);
            this.Controls.Add(this.RR);
            this.Controls.Add(this.SJF);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Process Scheduler";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SJF;
        private System.Windows.Forms.Button RR;
        private System.Windows.Forms.Button Prio;
        private System.Windows.Forms.Button CLR;
        private System.Windows.Forms.Label Process;
        private System.Windows.Forms.Label arrv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox proc;
        private System.Windows.Forms.TextBox burst;
        private System.Windows.Forms.TextBox arriv;
        private System.Windows.Forms.Button add_process;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priority;
        private System.Windows.Forms.Button FCFS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox wait;
        private System.Windows.Forms.TextBox turn;
        private System.Windows.Forms.TextBox quam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

