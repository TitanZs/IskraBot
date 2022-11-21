namespace BotIskra
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
            this.label1 = new System.Windows.Forms.Label();
            this.bal_btc = new System.Windows.Forms.TextBox();
            this.bal_ccoh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.ccohMax = new System.Windows.Forms.TextBox();
            this.ccohMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TradeMin = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.connectionStat = new System.Windows.Forms.ToolStripStatusLabel();
            this.workStat = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerStat = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TradeMax = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balance BTC:";
            // 
            // bal_btc
            // 
            this.bal_btc.Location = new System.Drawing.Point(110, 12);
            this.bal_btc.Name = "bal_btc";
            this.bal_btc.Size = new System.Drawing.Size(58, 20);
            this.bal_btc.TabIndex = 1;
            // 
            // bal_ccoh
            // 
            this.bal_ccoh.Location = new System.Drawing.Point(110, 38);
            this.bal_ccoh.Name = "bal_ccoh";
            this.bal_ccoh.Size = new System.Drawing.Size(58, 20);
            this.bal_ccoh.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Balance CCOH:";
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 10);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(503, 276);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Start
            // 
            this.Start.Dock = System.Windows.Forms.DockStyle.Left;
            this.Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start.Location = new System.Drawing.Point(10, 10);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(168, 38);
            this.Start.TabIndex = 5;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // Stop
            // 
            this.Stop.Dock = System.Windows.Forms.DockStyle.Right;
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stop.Location = new System.Drawing.Point(330, 10);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(183, 38);
            this.Stop.TabIndex = 6;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.button2_Click);
            // 
            // ccohMax
            // 
            this.ccohMax.Location = new System.Drawing.Point(240, 38);
            this.ccohMax.Name = "ccohMax";
            this.ccohMax.Size = new System.Drawing.Size(88, 20);
            this.ccohMax.TabIndex = 9;
            // 
            // ccohMin
            // 
            this.ccohMin.BackColor = System.Drawing.Color.White;
            this.ccohMin.Location = new System.Drawing.Point(240, 12);
            this.ccohMin.Name = "ccohMin";
            this.ccohMin.Size = new System.Drawing.Size(88, 20);
            this.ccohMin.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "CCOH Buy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "CCOH Sell:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Min:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Max:";
            // 
            // TradeMin
            // 
            this.TradeMin.Location = new System.Drawing.Point(367, 12);
            this.TradeMin.Name = "TradeMin";
            this.TradeMin.Size = new System.Drawing.Size(111, 20);
            this.TradeMin.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Stop);
            this.panel1.Controls.Add(this.Start);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 370);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(523, 58);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bal_btc);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.bal_ccoh);
            this.panel2.Controls.Add(this.TradeMax);
            this.panel2.Controls.Add(this.TradeMin);
            this.panel2.Controls.Add(this.ccohMin);
            this.panel2.Controls.Add(this.ccohMax);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(523, 74);
            this.panel2.TabIndex = 17;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStat,
            this.toolStripStatusLabel1,
            this.workStat,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.timerStat});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(523, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // connectionStat
            // 
            this.connectionStat.AutoSize = false;
            this.connectionStat.Name = "connectionStat";
            this.connectionStat.Size = new System.Drawing.Size(100, 17);
            this.connectionStat.Text = "Connecting:";
            this.connectionStat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // workStat
            // 
            this.workStat.AutoSize = false;
            this.workStat.Name = "workStat";
            this.workStat.Size = new System.Drawing.Size(100, 17);
            this.workStat.Text = "Work:";
            this.workStat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerStat
            // 
            this.timerStat.MarqueeAnimationSpeed = 0;
            this.timerStat.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.timerStat.Name = "timerStat";
            this.timerStat.Size = new System.Drawing.Size(200, 16);
            this.timerStat.Step = 1;
            this.timerStat.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel3.Text = "Next trade:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 74);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(523, 296);
            this.panel3.TabIndex = 19;
            // 
            // TradeMax
            // 
            this.TradeMax.Location = new System.Drawing.Point(367, 38);
            this.TradeMax.Name = "TradeMax";
            this.TradeMax.Size = new System.Drawing.Size(111, 20);
            this.TradeMax.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "BotIskra";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bal_btc;
        private System.Windows.Forms.TextBox bal_ccoh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.TextBox ccohMax;
        private System.Windows.Forms.TextBox ccohMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TradeMin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel connectionStat;
        private System.Windows.Forms.ToolStripStatusLabel workStat;
        private System.Windows.Forms.ToolStripProgressBar timerStat;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TradeMax;
    }
}