
namespace BeehiveSimulator
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.StartButton = new System.Windows.Forms.ToolStripButton();
            this.ResetButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblNumberOfBees = new System.Windows.Forms.Label();
            this.LblNumberOfFlowers = new System.Windows.Forms.Label();
            this.LblTotalHiveHoney = new System.Windows.Forms.Label();
            this.LblTotalFieldNectar = new System.Windows.Forms.Label();
            this.LblFramesRun = new System.Windows.Forms.Label();
            this.LblFrameRate = new System.Windows.Forms.Label();
            this.LblBees = new System.Windows.Forms.Label();
            this.LblFlowers = new System.Windows.Forms.Label();
            this.LblHoneyInHive = new System.Windows.Forms.Label();
            this.LblNectarInFlowers = new System.Windows.Forms.Label();
            this.LblFramesRun2 = new System.Windows.Forms.Label();
            this.LblFrameRate2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartButton,
            this.ResetButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(374, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // StartButton
            // 
            this.StartButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StartButton.Image = ((System.Drawing.Image)(resources.GetObject("StartButton.Image")));
            this.StartButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(95, 22);
            this.StartButton.Text = "Start Simulation";
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ResetButton.Image = ((System.Drawing.Image)(resources.GetObject("ResetButton.Image")));
            this.ResetButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(39, 22);
            this.ResetButton.Text = "Reset";
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 182);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(374, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(91, 17);
            this.StatusLabel.Text = "Start Simulation";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LblNumberOfBees, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblNumberOfFlowers, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblTotalHiveHoney, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblTotalFieldNectar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LblFramesRun, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.LblFrameRate, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.LblBees, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LblFlowers, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LblHoneyInHive, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LblNectarInFlowers, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.LblFramesRun2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.LblFrameRate2, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 156);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // LblNumberOfBees
            // 
            this.LblNumberOfBees.AutoSize = true;
            this.LblNumberOfBees.Location = new System.Drawing.Point(3, 0);
            this.LblNumberOfBees.Name = "LblNumberOfBees";
            this.LblNumberOfBees.Size = new System.Drawing.Size(41, 13);
            this.LblNumberOfBees.TabIndex = 0;
            this.LblNumberOfBees.Text = "# Bees";
            // 
            // LblNumberOfFlowers
            // 
            this.LblNumberOfFlowers.AutoSize = true;
            this.LblNumberOfFlowers.Location = new System.Drawing.Point(3, 20);
            this.LblNumberOfFlowers.Name = "LblNumberOfFlowers";
            this.LblNumberOfFlowers.Size = new System.Drawing.Size(53, 13);
            this.LblNumberOfFlowers.TabIndex = 1;
            this.LblNumberOfFlowers.Text = "# Flowers";
            // 
            // LblTotalHiveHoney
            // 
            this.LblTotalHiveHoney.AutoSize = true;
            this.LblTotalHiveHoney.Location = new System.Drawing.Point(3, 40);
            this.LblTotalHiveHoney.Name = "LblTotalHiveHoney";
            this.LblTotalHiveHoney.Size = new System.Drawing.Size(101, 13);
            this.LblTotalHiveHoney.TabIndex = 2;
            this.LblTotalHiveHoney.Text = "Total Honey in Hive";
            // 
            // LblTotalFieldNectar
            // 
            this.LblTotalFieldNectar.AutoSize = true;
            this.LblTotalFieldNectar.Location = new System.Drawing.Point(3, 60);
            this.LblTotalFieldNectar.Name = "LblTotalFieldNectar";
            this.LblTotalFieldNectar.Size = new System.Drawing.Size(105, 13);
            this.LblTotalFieldNectar.TabIndex = 3;
            this.LblTotalFieldNectar.Text = "Total Nectar  in Field";
            // 
            // LblFramesRun
            // 
            this.LblFramesRun.AutoSize = true;
            this.LblFramesRun.Location = new System.Drawing.Point(3, 80);
            this.LblFramesRun.Name = "LblFramesRun";
            this.LblFramesRun.Size = new System.Drawing.Size(59, 13);
            this.LblFramesRun.TabIndex = 4;
            this.LblFramesRun.Text = "Frames run";
            // 
            // LblFrameRate
            // 
            this.LblFrameRate.AutoSize = true;
            this.LblFrameRate.Location = new System.Drawing.Point(3, 100);
            this.LblFrameRate.Name = "LblFrameRate";
            this.LblFrameRate.Size = new System.Drawing.Size(57, 13);
            this.LblFrameRate.TabIndex = 5;
            this.LblFrameRate.Text = "Frame rate";
            // 
            // LblBees
            // 
            this.LblBees.AutoSize = true;
            this.LblBees.Location = new System.Drawing.Point(189, 0);
            this.LblBees.Name = "LblBees";
            this.LblBees.Size = new System.Drawing.Size(31, 13);
            this.LblBees.TabIndex = 6;
            this.LblBees.Text = "Bees";
            // 
            // LblFlowers
            // 
            this.LblFlowers.AutoSize = true;
            this.LblFlowers.Location = new System.Drawing.Point(189, 20);
            this.LblFlowers.Name = "LblFlowers";
            this.LblFlowers.Size = new System.Drawing.Size(43, 13);
            this.LblFlowers.TabIndex = 7;
            this.LblFlowers.Text = "Flowers";
            // 
            // LblHoneyInHive
            // 
            this.LblHoneyInHive.AutoSize = true;
            this.LblHoneyInHive.Location = new System.Drawing.Point(189, 40);
            this.LblHoneyInHive.Name = "LblHoneyInHive";
            this.LblHoneyInHive.Size = new System.Drawing.Size(74, 13);
            this.LblHoneyInHive.TabIndex = 8;
            this.LblHoneyInHive.Text = "Honey in Hive";
            // 
            // LblNectarInFlowers
            // 
            this.LblNectarInFlowers.AutoSize = true;
            this.LblNectarInFlowers.Location = new System.Drawing.Point(189, 60);
            this.LblNectarInFlowers.Name = "LblNectarInFlowers";
            this.LblNectarInFlowers.Size = new System.Drawing.Size(89, 13);
            this.LblNectarInFlowers.TabIndex = 9;
            this.LblNectarInFlowers.Text = "Nectar in Flowers";
            // 
            // LblFramesRun2
            // 
            this.LblFramesRun2.AutoSize = true;
            this.LblFramesRun2.Location = new System.Drawing.Point(189, 80);
            this.LblFramesRun2.Name = "LblFramesRun2";
            this.LblFramesRun2.Size = new System.Drawing.Size(64, 13);
            this.LblFramesRun2.TabIndex = 10;
            this.LblFramesRun2.Text = "Frames Run";
            // 
            // LblFrameRate2
            // 
            this.LblFrameRate2.AutoSize = true;
            this.LblFrameRate2.Location = new System.Drawing.Point(189, 100);
            this.LblFrameRate2.Name = "LblFrameRate2";
            this.LblFrameRate2.Size = new System.Drawing.Size(62, 13);
            this.LblFrameRate2.TabIndex = 11;
            this.LblFrameRate2.Text = "Frame Rate";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 204);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.MaximumSize = new System.Drawing.Size(390, 243);
            this.MinimumSize = new System.Drawing.Size(390, 243);
            this.Name = "Dashboard";
            this.Text = "Beehive Simulator";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton StartButton;
        private System.Windows.Forms.ToolStripButton ResetButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblNumberOfBees;
        private System.Windows.Forms.Label LblNumberOfFlowers;
        private System.Windows.Forms.Label LblTotalHiveHoney;
        private System.Windows.Forms.Label LblTotalFieldNectar;
        private System.Windows.Forms.Label LblFramesRun;
        private System.Windows.Forms.Label LblFrameRate;
        private System.Windows.Forms.Label LblBees;
        private System.Windows.Forms.Label LblFlowers;
        private System.Windows.Forms.Label LblHoneyInHive;
        private System.Windows.Forms.Label LblNectarInFlowers;
        private System.Windows.Forms.Label LblFramesRun2;
        private System.Windows.Forms.Label LblFrameRate2;
        private System.Windows.Forms.Timer timer1;
    }
}

