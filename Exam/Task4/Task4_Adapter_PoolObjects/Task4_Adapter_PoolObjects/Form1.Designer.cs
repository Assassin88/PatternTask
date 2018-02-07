namespace Task4_Adapter_PoolObjects
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
            this.MainPB = new System.Windows.Forms.PictureBox();
            this.NegativePB = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnSaveNegative = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.SaveOriginal = new System.Windows.Forms.Button();
            this.trackBarMain = new System.Windows.Forms.TrackBar();
            this.btnTurnLeft = new System.Windows.Forms.Button();
            this.btnTurnRight = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MainPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NegativePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMain)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPB
            // 
            this.MainPB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MainPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPB.Location = new System.Drawing.Point(12, 12);
            this.MainPB.Name = "MainPB";
            this.MainPB.Size = new System.Drawing.Size(382, 337);
            this.MainPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainPB.TabIndex = 0;
            this.MainPB.TabStop = false;
            // 
            // NegativePB
            // 
            this.NegativePB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NegativePB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NegativePB.Location = new System.Drawing.Point(413, 12);
            this.NegativePB.Name = "NegativePB";
            this.NegativePB.Size = new System.Drawing.Size(374, 337);
            this.NegativePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NegativePB.TabIndex = 1;
            this.NegativePB.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnOpen.Location = new System.Drawing.Point(12, 371);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(108, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnNegative
            // 
            this.btnNegative.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnNegative.Location = new System.Drawing.Point(288, 371);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(106, 23);
            this.btnNegative.TabIndex = 3;
            this.btnNegative.Text = "Negative";
            this.btnNegative.UseVisualStyleBackColor = false;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnSaveNegative
            // 
            this.btnSaveNegative.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSaveNegative.Location = new System.Drawing.Point(676, 371);
            this.btnSaveNegative.Name = "btnSaveNegative";
            this.btnSaveNegative.Size = new System.Drawing.Size(111, 23);
            this.btnSaveNegative.TabIndex = 4;
            this.btnSaveNegative.Text = "SaveNegative";
            this.btnSaveNegative.UseVisualStyleBackColor = false;
            this.btnSaveNegative.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbName.Location = new System.Drawing.Point(12, 511);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(775, 20);
            this.tbName.TabIndex = 5;
            // 
            // SaveOriginal
            // 
            this.SaveOriginal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SaveOriginal.Location = new System.Drawing.Point(156, 371);
            this.SaveOriginal.Name = "SaveOriginal";
            this.SaveOriginal.Size = new System.Drawing.Size(103, 23);
            this.SaveOriginal.TabIndex = 6;
            this.SaveOriginal.Text = "SaveOriginal";
            this.SaveOriginal.UseVisualStyleBackColor = false;
            this.SaveOriginal.Click += new System.EventHandler(this.SaveOriginal_Click);
            // 
            // trackBarMain
            // 
            this.trackBarMain.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.trackBarMain.Location = new System.Drawing.Point(12, 435);
            this.trackBarMain.Maximum = 360;
            this.trackBarMain.Name = "trackBarMain";
            this.trackBarMain.Size = new System.Drawing.Size(775, 45);
            this.trackBarMain.TabIndex = 7;
            this.trackBarMain.TickFrequency = 10;
            this.trackBarMain.Scroll += new System.EventHandler(this.trackBarMain_Scroll);
            // 
            // btnTurnLeft
            // 
            this.btnTurnLeft.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTurnLeft.Location = new System.Drawing.Point(413, 371);
            this.btnTurnLeft.Name = "btnTurnLeft";
            this.btnTurnLeft.Size = new System.Drawing.Size(105, 23);
            this.btnTurnLeft.TabIndex = 8;
            this.btnTurnLeft.Text = "TurnLeft";
            this.btnTurnLeft.UseVisualStyleBackColor = false;
            this.btnTurnLeft.Click += new System.EventHandler(this.btnTurnLeft_Click);
            // 
            // btnTurnRight
            // 
            this.btnTurnRight.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTurnRight.Location = new System.Drawing.Point(538, 371);
            this.btnTurnRight.Name = "btnTurnRight";
            this.btnTurnRight.Size = new System.Drawing.Size(112, 23);
            this.btnTurnRight.TabIndex = 9;
            this.btnTurnRight.Text = "TurnRight";
            this.btnTurnRight.UseVisualStyleBackColor = false;
            this.btnTurnRight.Click += new System.EventHandler(this.btnTurnRight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Task4_Adapter_PoolObjects.Properties.Resources.st;
            this.ClientSize = new System.Drawing.Size(799, 543);
            this.Controls.Add(this.btnTurnRight);
            this.Controls.Add(this.btnTurnLeft);
            this.Controls.Add(this.trackBarMain);
            this.Controls.Add(this.SaveOriginal);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnSaveNegative);
            this.Controls.Add(this.btnNegative);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.NegativePB);
            this.Controls.Add(this.MainPB);
            this.Name = "Form1";
            this.Text = "Task4_Adapter";
            ((System.ComponentModel.ISupportInitialize)(this.MainPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NegativePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MainPB;
        private System.Windows.Forms.PictureBox NegativePB;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnSaveNegative;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button SaveOriginal;
        private System.Windows.Forms.TrackBar trackBarMain;
        private System.Windows.Forms.Button btnTurnLeft;
        private System.Windows.Forms.Button btnTurnRight;
    }
}

