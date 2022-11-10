namespace UPanelZeitgeber
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CmdStartTimer = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.PnSquare1 = new System.Windows.Forms.Panel();
            this.PnSquare2 = new System.Windows.Forms.Panel();
            this.PnSquare3 = new System.Windows.Forms.Panel();
            this.PnSquare4 = new System.Windows.Forms.Panel();
            this.GrafischeUhr = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CmdStartTimer
            // 
            this.CmdStartTimer.Location = new System.Drawing.Point(12, 12);
            this.CmdStartTimer.Name = "CmdStartTimer";
            this.CmdStartTimer.Size = new System.Drawing.Size(75, 23);
            this.CmdStartTimer.TabIndex = 0;
            this.CmdStartTimer.Text = "Start";
            this.CmdStartTimer.UseVisualStyleBackColor = true;
            this.CmdStartTimer.Click += new System.EventHandler(this.CmdStartTimer_Click);
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(93, 12);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(75, 23);
            this.CmdClose.TabIndex = 1;
            this.CmdClose.Text = "Beenden";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // PnSquare1
            // 
            this.PnSquare1.BackColor = System.Drawing.Color.Yellow;
            this.PnSquare1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnSquare1.Location = new System.Drawing.Point(203, 184);
            this.PnSquare1.Name = "PnSquare1";
            this.PnSquare1.Size = new System.Drawing.Size(20, 20);
            this.PnSquare1.TabIndex = 2;
            // 
            // PnSquare2
            // 
            this.PnSquare2.BackColor = System.Drawing.Color.Gold;
            this.PnSquare2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnSquare2.Location = new System.Drawing.Point(203, 210);
            this.PnSquare2.Name = "PnSquare2";
            this.PnSquare2.Size = new System.Drawing.Size(20, 20);
            this.PnSquare2.TabIndex = 3;
            // 
            // PnSquare3
            // 
            this.PnSquare3.BackColor = System.Drawing.Color.DarkOrange;
            this.PnSquare3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnSquare3.Location = new System.Drawing.Point(177, 184);
            this.PnSquare3.Name = "PnSquare3";
            this.PnSquare3.Size = new System.Drawing.Size(20, 20);
            this.PnSquare3.TabIndex = 4;
            // 
            // PnSquare4
            // 
            this.PnSquare4.BackColor = System.Drawing.Color.OrangeRed;
            this.PnSquare4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnSquare4.Location = new System.Drawing.Point(177, 210);
            this.PnSquare4.Name = "PnSquare4";
            this.PnSquare4.Size = new System.Drawing.Size(20, 20);
            this.PnSquare4.TabIndex = 5;
            // 
            // GrafischeUhr
            // 
            this.GrafischeUhr.Interval = 40;
            this.GrafischeUhr.Tick += new EventHandler(GrafischeUhr_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 411);
            this.Controls.Add(this.PnSquare4);
            this.Controls.Add(this.PnSquare3);
            this.Controls.Add(this.PnSquare2);
            this.Controls.Add(this.PnSquare1);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdStartTimer);
            this.Name = "MainForm";
            this.Text = "UPanelZeitgeber";
            this.ResumeLayout(false);

        }

        #endregion

        private Button CmdStartTimer;
        private Button CmdClose;
        private Panel PnSquare1;
        private Panel PnSquare2;
        private Panel PnSquare3;
        private Panel PnSquare4;
        private System.Windows.Forms.Timer GrafischeUhr;
    }
}