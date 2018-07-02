namespace InternationalTimes
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
            this.lbLocal = new System.Windows.Forms.Label();
            this.lbIST = new System.Windows.Forms.Label();
            this.lbPST = new System.Windows.Forms.Label();
            this.lbCST = new System.Windows.Forms.Label();
            this.lbEST = new System.Windows.Forms.Label();
            this.lbUTC = new System.Windows.Forms.Label();
            this.lbLocalTime = new System.Windows.Forms.Label();
            this.lbISTtime = new System.Windows.Forms.Label();
            this.lbPSTtime = new System.Windows.Forms.Label();
            this.lbCSTtime = new System.Windows.Forms.Label();
            this.lbESTtime = new System.Windows.Forms.Label();
            this.lbUTCtime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.boxFreq = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLocal
            // 
            this.lbLocal.AutoSize = true;
            this.lbLocal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocal.Location = new System.Drawing.Point(16, 13);
            this.lbLocal.Name = "lbLocal";
            this.lbLocal.Size = new System.Drawing.Size(108, 15);
            this.lbLocal.TabIndex = 0;
            this.lbLocal.Text = "Local Time (China)";
            // 
            // lbIST
            // 
            this.lbIST.AutoSize = true;
            this.lbIST.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIST.Location = new System.Drawing.Point(16, 43);
            this.lbIST.Name = "lbIST";
            this.lbIST.Size = new System.Drawing.Size(118, 15);
            this.lbIST.TabIndex = 1;
            this.lbIST.Text = "India Standard Time";
            // 
            // lbPST
            // 
            this.lbPST.AutoSize = true;
            this.lbPST.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPST.Location = new System.Drawing.Point(16, 73);
            this.lbPST.Name = "lbPST";
            this.lbPST.Size = new System.Drawing.Size(115, 15);
            this.lbPST.TabIndex = 2;
            this.lbPST.Text = "Pacific Time (Vegas)";
            // 
            // lbCST
            // 
            this.lbCST.AutoSize = true;
            this.lbCST.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCST.Location = new System.Drawing.Point(16, 103);
            this.lbCST.Name = "lbCST";
            this.lbCST.Size = new System.Drawing.Size(129, 15);
            this.lbCST.TabIndex = 3;
            this.lbCST.Text = "Central Standard Time";
            // 
            // lbEST
            // 
            this.lbEST.AutoSize = true;
            this.lbEST.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEST.Location = new System.Drawing.Point(16, 133);
            this.lbEST.Name = "lbEST";
            this.lbEST.Size = new System.Drawing.Size(155, 15);
            this.lbEST.TabIndex = 4;
            this.lbEST.Text = "Eastern Standard Time (NY)";
            // 
            // lbUTC
            // 
            this.lbUTC.AutoSize = true;
            this.lbUTC.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUTC.Location = new System.Drawing.Point(16, 163);
            this.lbUTC.Name = "lbUTC";
            this.lbUTC.Size = new System.Drawing.Size(79, 15);
            this.lbUTC.TabIndex = 5;
            this.lbUTC.Text = "UTC (London)";
            // 
            // lbLocalTime
            // 
            this.lbLocalTime.AutoSize = true;
            this.lbLocalTime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalTime.Location = new System.Drawing.Point(205, 13);
            this.lbLocalTime.Name = "lbLocalTime";
            this.lbLocalTime.Size = new System.Drawing.Size(68, 15);
            this.lbLocalTime.TabIndex = 6;
            this.lbLocalTime.Text = "Not Started";
            // 
            // lbISTtime
            // 
            this.lbISTtime.AutoSize = true;
            this.lbISTtime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbISTtime.Location = new System.Drawing.Point(205, 43);
            this.lbISTtime.Name = "lbISTtime";
            this.lbISTtime.Size = new System.Drawing.Size(68, 15);
            this.lbISTtime.TabIndex = 7;
            this.lbISTtime.Text = "Not Started";
            // 
            // lbPSTtime
            // 
            this.lbPSTtime.AutoSize = true;
            this.lbPSTtime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPSTtime.Location = new System.Drawing.Point(205, 73);
            this.lbPSTtime.Name = "lbPSTtime";
            this.lbPSTtime.Size = new System.Drawing.Size(68, 15);
            this.lbPSTtime.TabIndex = 8;
            this.lbPSTtime.Text = "Not Started";
            // 
            // lbCSTtime
            // 
            this.lbCSTtime.AutoSize = true;
            this.lbCSTtime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCSTtime.Location = new System.Drawing.Point(205, 103);
            this.lbCSTtime.Name = "lbCSTtime";
            this.lbCSTtime.Size = new System.Drawing.Size(68, 15);
            this.lbCSTtime.TabIndex = 9;
            this.lbCSTtime.Text = "Not Started";
            // 
            // lbESTtime
            // 
            this.lbESTtime.AutoSize = true;
            this.lbESTtime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbESTtime.Location = new System.Drawing.Point(205, 133);
            this.lbESTtime.Name = "lbESTtime";
            this.lbESTtime.Size = new System.Drawing.Size(68, 15);
            this.lbESTtime.TabIndex = 10;
            this.lbESTtime.Text = "Not Started";
            // 
            // lbUTCtime
            // 
            this.lbUTCtime.AutoSize = true;
            this.lbUTCtime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUTCtime.Location = new System.Drawing.Point(205, 163);
            this.lbUTCtime.Name = "lbUTCtime";
            this.lbUTCtime.Size = new System.Drawing.Size(68, 15);
            this.lbUTCtime.TabIndex = 11;
            this.lbUTCtime.Text = "Not Started";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(19, 231);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(115, 231);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 266);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(400, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbStatus
            // 
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(39, 17);
            this.lbStatus.Text = "Ready";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Update Frequency (Seconds)";
            // 
            // boxFreq
            // 
            this.boxFreq.Location = new System.Drawing.Point(173, 200);
            this.boxFreq.Name = "boxFreq";
            this.boxFreq.Size = new System.Drawing.Size(40, 20);
            this.boxFreq.TabIndex = 16;
            this.boxFreq.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 288);
            this.Controls.Add(this.boxFreq);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbUTCtime);
            this.Controls.Add(this.lbESTtime);
            this.Controls.Add(this.lbCSTtime);
            this.Controls.Add(this.lbPSTtime);
            this.Controls.Add(this.lbISTtime);
            this.Controls.Add(this.lbLocalTime);
            this.Controls.Add(this.lbUTC);
            this.Controls.Add(this.lbEST);
            this.Controls.Add(this.lbCST);
            this.Controls.Add(this.lbPST);
            this.Controls.Add(this.lbIST);
            this.Controls.Add(this.lbLocal);
            this.Name = "Form1";
            this.Text = "International Times";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLocal;
        private System.Windows.Forms.Label lbIST;
        private System.Windows.Forms.Label lbPST;
        private System.Windows.Forms.Label lbCST;
        private System.Windows.Forms.Label lbEST;
        private System.Windows.Forms.Label lbUTC;
        private System.Windows.Forms.Label lbLocalTime;
        private System.Windows.Forms.Label lbISTtime;
        private System.Windows.Forms.Label lbPSTtime;
        private System.Windows.Forms.Label lbCSTtime;
        private System.Windows.Forms.Label lbESTtime;
        private System.Windows.Forms.Label lbUTCtime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxFreq;
    }
}

