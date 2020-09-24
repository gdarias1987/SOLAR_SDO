namespace SOLAR_SDO
{
    partial class frmMainSecond
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.download = new System.Windows.Forms.Timer(this.components);
            this.cmbTemp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.chkRandom = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CloseWindow = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picExample = new System.Windows.Forms.PictureBox();
            this.lblTimer = new System.Windows.Forms.Label();
            this.NASA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CloseWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NASA)).BeginInit();
            this.SuspendLayout();
            // 
            // download
            // 
            this.download.Enabled = true;
            this.download.Interval = 10000;
            this.download.Tick += new System.EventHandler(this.download_Tick);
            // 
            // cmbTemp
            // 
            this.cmbTemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTemp.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTemp.FormattingEnabled = true;
            this.cmbTemp.Location = new System.Drawing.Point(177, 157);
            this.cmbTemp.Name = "cmbTemp";
            this.cmbTemp.Size = new System.Drawing.Size(320, 37);
            this.cmbTemp.TabIndex = 0;
            this.cmbTemp.SelectedIndexChanged += new System.EventHandler(this.cmbTemp_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(106, 301);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 29);
            this.lblTime.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // chkRandom
            // 
            this.chkRandom.AutoSize = true;
            this.chkRandom.BackColor = System.Drawing.Color.Transparent;
            this.chkRandom.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRandom.Location = new System.Drawing.Point(503, 161);
            this.chkRandom.Name = "chkRandom";
            this.chkRandom.Size = new System.Drawing.Size(129, 33);
            this.chkRandom.TabIndex = 3;
            this.chkRandom.Text = "RANDOM";
            this.chkRandom.UseVisualStyleBackColor = false;
            this.chkRandom.CheckedChanged += new System.EventHandler(this.chkRandom_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 59);
            this.label2.TabIndex = 4;
            this.label2.Text = "FILTROS";
            // 
            // CloseWindow
            // 
            this.CloseWindow.BackColor = System.Drawing.Color.Transparent;
            this.CloseWindow.Image = ((System.Drawing.Image)(resources.GetObject("CloseWindow.Image")));
            this.CloseWindow.Location = new System.Drawing.Point(629, 335);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(59, 53);
            this.CloseWindow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseWindow.TabIndex = 5;
            this.CloseWindow.TabStop = false;
            this.CloseWindow.Click += new System.EventHandler(this.CloseWindowClick);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(656, 12);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(32, 28);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimize.TabIndex = 6;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.MinimizeClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 73);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // picExample
            // 
            this.picExample.Location = new System.Drawing.Point(16, 95);
            this.picExample.Name = "picExample";
            this.picExample.Size = new System.Drawing.Size(150, 150);
            this.picExample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExample.TabIndex = 8;
            this.picExample.TabStop = false;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(24, 301);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(82, 29);
            this.lblTimer.TabIndex = 9;
            this.lblTimer.Text = "Timer";
            this.lblTimer.Visible = false;
            // 
            // NASA
            // 
            this.NASA.BackColor = System.Drawing.Color.Transparent;
            this.NASA.Image = ((System.Drawing.Image)(resources.GetObject("NASA.Image")));
            this.NASA.Location = new System.Drawing.Point(503, 308);
            this.NASA.Name = "NASA";
            this.NASA.Size = new System.Drawing.Size(80, 80);
            this.NASA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NASA.TabIndex = 10;
            this.NASA.TabStop = false;
            this.NASA.Click += new System.EventHandler(this.NASA_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.NASA);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.picExample);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.CloseWindow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkRandom);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTemp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "SDO SOLAR WALLPAPER";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.CloseWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NASA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer download;
        private System.Windows.Forms.ComboBox cmbTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox chkRandom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox CloseWindow;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picExample;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.PictureBox NASA;
    }
}

