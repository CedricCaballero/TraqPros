
namespace PrincipalBueno
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnLogo = new System.Windows.Forms.Panel();
            this.ptBLogo = new System.Windows.Forms.PictureBox();
            this.pnLateral = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.pnConnect = new System.Windows.Forms.Panel();
            this.lbUSB = new System.Windows.Forms.ListBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.ptBClose = new System.Windows.Forms.PictureBox();
            this.pnStatus = new System.Windows.Forms.Panel();
            this.lbStatus = new System.Windows.Forms.Label();
            this.pnClose = new System.Windows.Forms.Panel();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptBLogo)).BeginInit();
            this.pnLateral.SuspendLayout();
            this.pnConnect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptBClose)).BeginInit();
            this.pnStatus.SuspendLayout();
            this.pnClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnLogo
            // 
            this.pnLogo.Controls.Add(this.ptBLogo);
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(250, 180);
            this.pnLogo.TabIndex = 0;
            this.pnLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // ptBLogo
            // 
            this.ptBLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptBLogo.Image")));
            this.ptBLogo.Location = new System.Drawing.Point(0, 40);
            this.ptBLogo.Name = "ptBLogo";
            this.ptBLogo.Size = new System.Drawing.Size(250, 100);
            this.ptBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptBLogo.TabIndex = 0;
            this.ptBLogo.TabStop = false;
            // 
            // pnLateral
            // 
            this.pnLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(207)))), ((int)(((byte)(144)))));
            this.pnLateral.Controls.Add(this.btnHelp);
            this.pnLateral.Controls.Add(this.btnContact);
            this.pnLateral.Controls.Add(this.btnTest);
            this.pnLateral.Controls.Add(this.pnConnect);
            this.pnLateral.Controls.Add(this.btnConnect);
            this.pnLateral.Controls.Add(this.pnLogo);
            this.pnLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLateral.Location = new System.Drawing.Point(0, 0);
            this.pnLateral.Name = "pnLateral";
            this.pnLateral.Size = new System.Drawing.Size(250, 650);
            this.pnLateral.TabIndex = 0;
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Arial", 14F);
            this.btnHelp.Location = new System.Drawing.Point(0, 343);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(250, 45);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnContact
            // 
            this.btnContact.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContact.FlatAppearance.BorderSize = 0;
            this.btnContact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnContact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContact.Font = new System.Drawing.Font("Arial", 14F);
            this.btnContact.Location = new System.Drawing.Point(0, 298);
            this.btnContact.Name = "btnContact";
            this.btnContact.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnContact.Size = new System.Drawing.Size(250, 45);
            this.btnContact.TabIndex = 4;
            this.btnContact.Text = "Contact";
            this.btnContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContact.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTest.Enabled = false;
            this.btnTest.FlatAppearance.BorderSize = 0;
            this.btnTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Arial", 14F);
            this.btnTest.Location = new System.Drawing.Point(0, 253);
            this.btnTest.Name = "btnTest";
            this.btnTest.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnTest.Size = new System.Drawing.Size(250, 45);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "Test";
            this.btnTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            // 
            // pnConnect
            // 
            this.pnConnect.Controls.Add(this.lbUSB);
            this.pnConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnConnect.Location = new System.Drawing.Point(0, 225);
            this.pnConnect.Name = "pnConnect";
            this.pnConnect.Size = new System.Drawing.Size(250, 28);
            this.pnConnect.TabIndex = 2;
            // 
            // lbUSB
            // 
            this.lbUSB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.lbUSB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbUSB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbUSB.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbUSB.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUSB.ForeColor = System.Drawing.Color.Black;
            this.lbUSB.FormattingEnabled = true;
            this.lbUSB.ItemHeight = 23;
            this.lbUSB.Location = new System.Drawing.Point(0, 0);
            this.lbUSB.Name = "lbUSB";
            this.lbUSB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbUSB.Size = new System.Drawing.Size(250, 23);
            this.lbUSB.TabIndex = 0;
            this.lbUSB.SelectedIndexChanged += new System.EventHandler(this.lbUSB_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Arial", 14F);
            this.btnConnect.Location = new System.Drawing.Point(0, 180);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnConnect.Size = new System.Drawing.Size(250, 45);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // ptBClose
            // 
            this.ptBClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptBClose.Image = ((System.Drawing.Image)(resources.GetObject("ptBClose.Image")));
            this.ptBClose.Location = new System.Drawing.Point(667, 0);
            this.ptBClose.Name = "ptBClose";
            this.ptBClose.Size = new System.Drawing.Size(33, 34);
            this.ptBClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptBClose.TabIndex = 1;
            this.ptBClose.TabStop = false;
            this.ptBClose.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pnStatus
            // 
            this.pnStatus.BackColor = System.Drawing.Color.Silver;
            this.pnStatus.Controls.Add(this.lbStatus);
            this.pnStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnStatus.Location = new System.Drawing.Point(250, 556);
            this.pnStatus.Name = "pnStatus";
            this.pnStatus.Size = new System.Drawing.Size(700, 94);
            this.pnStatus.TabIndex = 2;
            // 
            // lbStatus
            // 
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(0, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(700, 94);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "Disconnected";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnClose
            // 
            this.pnClose.Controls.Add(this.ptBClose);
            this.pnClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnClose.Location = new System.Drawing.Point(250, 0);
            this.pnClose.Name = "pnClose";
            this.pnClose.Size = new System.Drawing.Size(700, 34);
            this.pnClose.TabIndex = 5;
            this.pnClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(250, 34);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(700, 522);
            this.pnMain.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnClose);
            this.Controls.Add(this.pnStatus);
            this.Controls.Add(this.pnLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.pnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptBLogo)).EndInit();
            this.pnLateral.ResumeLayout(false);
            this.pnConnect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptBClose)).EndInit();
            this.pnStatus.ResumeLayout(false);
            this.pnClose.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.PictureBox ptBLogo;
        private System.Windows.Forms.Panel pnLateral;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel pnConnect;
        private System.Windows.Forms.ListBox lbUSB;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.PictureBox ptBClose;
        private System.Windows.Forms.Panel pnStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Panel pnClose;
        private System.Windows.Forms.Panel pnMain;
    }
}

