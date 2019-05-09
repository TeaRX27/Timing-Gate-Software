namespace WindowsFormsApplication9
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ArduPort = new System.IO.Ports.SerialPort(this.components);
            this.Time = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SerialSettings = new System.Windows.Forms.GroupBox();
            this.PortBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PortDisplay = new System.Windows.Forms.Label();
            this.SelectButton = new System.Windows.Forms.Button();
            this.ShowSettings = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.DataTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.OpenSerial = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SerialSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold);
            this.Time.Location = new System.Drawing.Point(62, 9);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(293, 86);
            this.Time.TabIndex = 0;
            this.Time.Text = "00:00.00";
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(255, 98);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(117, 47);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SerialSettings
            // 
            this.SerialSettings.Controls.Add(this.button2);
            this.SerialSettings.Controls.Add(this.OpenSerial);
            this.SerialSettings.Controls.Add(this.SelectButton);
            this.SerialSettings.Controls.Add(this.PortDisplay);
            this.SerialSettings.Controls.Add(this.label1);
            this.SerialSettings.Controls.Add(this.PortBox);
            this.SerialSettings.Location = new System.Drawing.Point(121, 206);
            this.SerialSettings.Name = "SerialSettings";
            this.SerialSettings.Size = new System.Drawing.Size(251, 143);
            this.SerialSettings.TabIndex = 2;
            this.SerialSettings.TabStop = false;
            this.SerialSettings.Text = "Serial Port Settings";
            this.SerialSettings.Visible = false;
            // 
            // PortBox
            // 
            this.PortBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortBox.FormattingEnabled = true;
            this.PortBox.Location = new System.Drawing.Point(6, 56);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(141, 33);
            this.PortBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Serial Port Selected :";
            // 
            // PortDisplay
            // 
            this.PortDisplay.AutoSize = true;
            this.PortDisplay.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortDisplay.Location = new System.Drawing.Point(184, 28);
            this.PortDisplay.Name = "PortDisplay";
            this.PortDisplay.Size = new System.Drawing.Size(67, 25);
            this.PortDisplay.TabIndex = 3;
            this.PortDisplay.Text = "COM1";
            this.PortDisplay.Click += new System.EventHandler(this.PortDisplay_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectButton.Location = new System.Drawing.Point(6, 95);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(141, 36);
            this.SelectButton.TabIndex = 5;
            this.SelectButton.Text = "Select Serial Port";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // ShowSettings
            // 
            this.ShowSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowSettings.Location = new System.Drawing.Point(12, 206);
            this.ShowSettings.Name = "ShowSettings";
            this.ShowSettings.Size = new System.Drawing.Size(97, 131);
            this.ShowSettings.TabIndex = 3;
            this.ShowSettings.Text = "Show Serial Port Settings";
            this.ShowSettings.UseVisualStyleBackColor = true;
            this.ShowSettings.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(127, 98);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(111, 47);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(4, 98);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(111, 47);
            this.StartButton.TabIndex = 6;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // DataTimer
            // 
            this.DataTimer.Tick += new System.EventHandler(this.DataTimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // OpenSerial
            // 
            this.OpenSerial.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenSerial.Location = new System.Drawing.Point(153, 56);
            this.OpenSerial.Name = "OpenSerial";
            this.OpenSerial.Size = new System.Drawing.Size(92, 36);
            this.OpenSerial.TabIndex = 8;
            this.OpenSerial.Text = "Open Port";
            this.OpenSerial.UseVisualStyleBackColor = true;
            this.OpenSerial.Click += new System.EventHandler(this.OpenSerial_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(153, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "Close Port";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Stopwatch:";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.SerialSettings);
            this.Controls.Add(this.ShowSettings);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.Time);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SerialSettings.ResumeLayout(false);
            this.SerialSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort ArduPort;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.GroupBox SerialSettings;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Label PortDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PortBox;
        private System.Windows.Forms.Button ShowSettings;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Timer DataTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button OpenSerial;
        private System.Windows.Forms.Label label3;
    }
}

