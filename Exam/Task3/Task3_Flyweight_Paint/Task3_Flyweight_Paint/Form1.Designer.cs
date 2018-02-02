namespace Task3_Flyweight_Paint
{
    partial class MainForm
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
            this.btnColor = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.btnColorControl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(12, 55);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(105, 23);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "ColorDictionary";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(13, 203);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(139, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 315);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(12, 101);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(105, 20);
            this.tbColor.TabIndex = 3;
            // 
            // btnColorControl
            // 
            this.btnColorControl.Location = new System.Drawing.Point(13, 150);
            this.btnColorControl.Name = "btnColorControl";
            this.btnColorControl.Size = new System.Drawing.Size(105, 23);
            this.btnColorControl.TabIndex = 4;
            this.btnColorControl.Text = "ColorControl";
            this.btnColorControl.UseVisualStyleBackColor = true;
            this.btnColorControl.Click += new System.EventHandler(this.btnColorControl_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnClear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 403);
            this.Controls.Add(this.btnColorControl);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnColor);
            this.Name = "MainForm";
            this.Text = "Paint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.Button btnColorControl;
    }
}

