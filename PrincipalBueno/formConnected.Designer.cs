
namespace PrincipalBueno
{
    partial class formConnected
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formConnected));
            this.btnStartTest = new System.Windows.Forms.Button();
            this.pnStartTest = new System.Windows.Forms.Panel();
            this.pnLStartTest = new System.Windows.Forms.Panel();
            this.cpbBattery = new CircularProgressBar.CircularProgressBar();
            this.cpbDataTransmission = new CircularProgressBar.CircularProgressBar();
            this.cpbGPS = new CircularProgressBar.CircularProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbStarteGPS = new System.Windows.Forms.Label();
            this.lbstartedDataTransmission = new System.Windows.Forms.Label();
            this.lbStartedBattery = new System.Windows.Forms.Label();
            this.pnStartTest.SuspendLayout();
            this.pnLStartTest.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartTest
            // 
            this.btnStartTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStartTest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStartTest.BackgroundImage")));
            this.btnStartTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStartTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartTest.FlatAppearance.BorderSize = 0;
            this.btnStartTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTest.ForeColor = System.Drawing.Color.Black;
            this.btnStartTest.Location = new System.Drawing.Point(276, 3);
            this.btnStartTest.Name = "btnStartTest";
            this.btnStartTest.Padding = new System.Windows.Forms.Padding(0, 0, 50, 0);
            this.btnStartTest.Size = new System.Drawing.Size(119, 94);
            this.btnStartTest.TabIndex = 0;
            this.btnStartTest.UseVisualStyleBackColor = true;
            this.btnStartTest.Click += new System.EventHandler(this.btnStartTest_Click);
            // 
            // pnStartTest
            // 
            this.pnStartTest.Controls.Add(this.btnStartTest);
            this.pnStartTest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnStartTest.Location = new System.Drawing.Point(0, 422);
            this.pnStartTest.Name = "pnStartTest";
            this.pnStartTest.Size = new System.Drawing.Size(700, 100);
            this.pnStartTest.TabIndex = 2;
            // 
            // pnLStartTest
            // 
            this.pnLStartTest.Controls.Add(this.tableLayoutPanel1);
            this.pnLStartTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLStartTest.Location = new System.Drawing.Point(0, 0);
            this.pnLStartTest.Name = "pnLStartTest";
            this.pnLStartTest.Size = new System.Drawing.Size(700, 422);
            this.pnLStartTest.TabIndex = 3;
            // 
            // cpbBattery
            // 
            this.cpbBattery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cpbBattery.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbBattery.AnimationSpeed = 500;
            this.cpbBattery.BackColor = System.Drawing.Color.Transparent;
            this.cpbBattery.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpbBattery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpbBattery.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpbBattery.InnerMargin = 2;
            this.cpbBattery.InnerWidth = -1;
            this.cpbBattery.Location = new System.Drawing.Point(488, 67);
            this.cpbBattery.MarqueeAnimationSpeed = 1000;
            this.cpbBattery.Name = "cpbBattery";
            this.cpbBattery.OuterColor = System.Drawing.Color.Gray;
            this.cpbBattery.OuterMargin = -25;
            this.cpbBattery.OuterWidth = 26;
            this.cpbBattery.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(60)))), ((int)(((byte)(10)))));
            this.cpbBattery.ProgressWidth = 25;
            this.cpbBattery.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.cpbBattery.Size = new System.Drawing.Size(189, 186);
            this.cpbBattery.StartAngle = 270;
            this.cpbBattery.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbBattery.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbBattery.SubscriptText = "10";
            this.cpbBattery.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbBattery.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbBattery.SuperscriptText = "%";
            this.cpbBattery.TabIndex = 2;
            this.cpbBattery.Text = "Battery";
            this.cpbBattery.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpbBattery.Value = 10;
            // 
            // cpbDataTransmission
            // 
            this.cpbDataTransmission.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cpbDataTransmission.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbDataTransmission.AnimationSpeed = 500;
            this.cpbDataTransmission.BackColor = System.Drawing.Color.Transparent;
            this.cpbDataTransmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpbDataTransmission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpbDataTransmission.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpbDataTransmission.InnerMargin = 2;
            this.cpbDataTransmission.InnerWidth = -1;
            this.cpbDataTransmission.Location = new System.Drawing.Point(255, 67);
            this.cpbDataTransmission.MarqueeAnimationSpeed = 1000;
            this.cpbDataTransmission.Name = "cpbDataTransmission";
            this.cpbDataTransmission.OuterColor = System.Drawing.Color.Gray;
            this.cpbDataTransmission.OuterMargin = -25;
            this.cpbDataTransmission.OuterWidth = 26;
            this.cpbDataTransmission.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(207)))), ((int)(((byte)(144)))));
            this.cpbDataTransmission.ProgressWidth = 25;
            this.cpbDataTransmission.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cpbDataTransmission.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.cpbDataTransmission.Size = new System.Drawing.Size(189, 186);
            this.cpbDataTransmission.StartAngle = 270;
            this.cpbDataTransmission.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.cpbDataTransmission.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbDataTransmission.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbDataTransmission.SubscriptText = "30";
            this.cpbDataTransmission.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbDataTransmission.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbDataTransmission.SuperscriptText = "%";
            this.cpbDataTransmission.TabIndex = 1;
            this.cpbDataTransmission.Text = "Data\r\nTransmission";
            this.cpbDataTransmission.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpbDataTransmission.Value = 30;
            // 
            // cpbGPS
            // 
            this.cpbGPS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cpbGPS.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbGPS.AnimationSpeed = 500;
            this.cpbGPS.BackColor = System.Drawing.Color.Transparent;
            this.cpbGPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpbGPS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cpbGPS.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cpbGPS.InnerMargin = 2;
            this.cpbGPS.InnerWidth = -1;
            this.cpbGPS.Location = new System.Drawing.Point(16, 61);
            this.cpbGPS.MarqueeAnimationSpeed = 1000;
            this.cpbGPS.Name = "cpbGPS";
            this.cpbGPS.OuterColor = System.Drawing.Color.Gray;
            this.cpbGPS.OuterMargin = -25;
            this.cpbGPS.OuterWidth = 26;
            this.cpbGPS.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(207)))), ((int)(((byte)(144)))));
            this.cpbGPS.ProgressWidth = 25;
            this.cpbGPS.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.cpbGPS.Size = new System.Drawing.Size(201, 198);
            this.cpbGPS.StartAngle = 270;
            this.cpbGPS.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.cpbGPS.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbGPS.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbGPS.SubscriptText = "75";
            this.cpbGPS.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbGPS.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbGPS.SuperscriptText = "%";
            this.cpbGPS.TabIndex = 0;
            this.cpbGPS.Text = "GPS";
            this.cpbGPS.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpbGPS.Value = 75;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.lbStartedBattery, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbstartedDataTransmission, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cpbDataTransmission, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cpbBattery, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cpbGPS, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbStarteGPS, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.30331F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.69668F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 422);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // lbStarteGPS
            // 
            this.lbStarteGPS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbStarteGPS.AutoSize = true;
            this.lbStarteGPS.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStarteGPS.Location = new System.Drawing.Point(36, 321);
            this.lbStarteGPS.Name = "lbStarteGPS";
            this.lbStarteGPS.Size = new System.Drawing.Size(161, 32);
            this.lbStarteGPS.TabIndex = 3;
            this.lbStarteGPS.Text = "Not Started ";
            // 
            // lbstartedDataTransmission
            // 
            this.lbstartedDataTransmission.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbstartedDataTransmission.AutoSize = true;
            this.lbstartedDataTransmission.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbstartedDataTransmission.Location = new System.Drawing.Point(269, 321);
            this.lbstartedDataTransmission.Name = "lbstartedDataTransmission";
            this.lbstartedDataTransmission.Size = new System.Drawing.Size(161, 32);
            this.lbstartedDataTransmission.TabIndex = 4;
            this.lbstartedDataTransmission.Text = "Not Started ";
            // 
            // lbStartedBattery
            // 
            this.lbStartedBattery.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbStartedBattery.AutoSize = true;
            this.lbStartedBattery.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartedBattery.Location = new System.Drawing.Point(490, 321);
            this.lbStartedBattery.Name = "lbStartedBattery";
            this.lbStartedBattery.Size = new System.Drawing.Size(186, 32);
            this.lbStartedBattery.TabIndex = 5;
            this.lbStartedBattery.Text = "Not Measured";
            // 
            // formConnected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 522);
            this.Controls.Add(this.pnLStartTest);
            this.Controls.Add(this.pnStartTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formConnected";
            this.Opacity = 0.9D;
            this.Text = "formConnected";
            this.Shown += new System.EventHandler(this.formConnected_Shown);
            this.pnStartTest.ResumeLayout(false);
            this.pnLStartTest.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.Panel pnStartTest;
        private System.Windows.Forms.Panel pnLStartTest;
        private CircularProgressBar.CircularProgressBar cpbGPS;
        private CircularProgressBar.CircularProgressBar cpbBattery;
        private CircularProgressBar.CircularProgressBar cpbDataTransmission;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbStartedBattery;
        private System.Windows.Forms.Label lbstartedDataTransmission;
        private System.Windows.Forms.Label lbStarteGPS;
    }
}