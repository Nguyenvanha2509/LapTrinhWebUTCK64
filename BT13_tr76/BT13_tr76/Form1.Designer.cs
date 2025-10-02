namespace BT13_tr76
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hscRed = new System.Windows.Forms.HScrollBar();
            this.hscGreen = new System.Windows.Forms.HScrollBar();
            this.hscBlue = new System.Windows.Forms.HScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lable3 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.lblRedValue = new System.Windows.Forms.Label();
            this.lblGreenValue = new System.Windows.Forms.Label();
            this.lblBlueValue = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.lblBlueValue);
            this.groupBox1.Controls.Add(this.lblGreenValue);
            this.groupBox1.Controls.Add(this.lblRedValue);
            this.groupBox1.Controls.Add(this.lable3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.hscBlue);
            this.groupBox1.Controls.Add(this.hscGreen);
            this.groupBox1.Controls.Add(this.hscRed);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(56, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 220);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn màu nền cho TextBox";
            // 
            // hscRed
            // 
            this.hscRed.LargeChange = 1;
            this.hscRed.Location = new System.Drawing.Point(126, 42);
            this.hscRed.Maximum = 255;
            this.hscRed.Name = "hscRed";
            this.hscRed.Size = new System.Drawing.Size(264, 34);
            this.hscRed.TabIndex = 0;
            this.hscRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hscRed_Scroll);
            // 
            // hscGreen
            // 
            this.hscGreen.LargeChange = 1;
            this.hscGreen.Location = new System.Drawing.Point(126, 105);
            this.hscGreen.Maximum = 255;
            this.hscGreen.Name = "hscGreen";
            this.hscGreen.Size = new System.Drawing.Size(264, 34);
            this.hscGreen.TabIndex = 1;
            this.hscGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hscGreen_Scroll);
            // 
            // hscBlue
            // 
            this.hscBlue.Location = new System.Drawing.Point(126, 166);
            this.hscBlue.Maximum = 255;
            this.hscBlue.Name = "hscBlue";
            this.hscBlue.Size = new System.Drawing.Size(264, 34);
            this.hscBlue.TabIndex = 2;
            this.hscBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hscBlue_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(39, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(39, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Green";
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.ForeColor = System.Drawing.Color.Blue;
            this.lable3.Location = new System.Drawing.Point(39, 181);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(44, 19);
            this.lable3.TabIndex = 5;
            this.lable3.Text = "Blue";
            // 
            // txtColor
            // 
            this.txtColor.Enabled = false;
            this.txtColor.Location = new System.Drawing.Point(56, 42);
            this.txtColor.Multiline = true;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(516, 127);
            this.txtColor.TabIndex = 2;
            // 
            // lblRedValue
            // 
            this.lblRedValue.AutoSize = true;
            this.lblRedValue.ForeColor = System.Drawing.Color.Red;
            this.lblRedValue.Location = new System.Drawing.Point(443, 57);
            this.lblRedValue.Name = "lblRedValue";
            this.lblRedValue.Size = new System.Drawing.Size(0, 19);
            this.lblRedValue.TabIndex = 6;
            this.lblRedValue.Text = "Red";

            // 
            // lblGreenValue
            // 
            this.lblGreenValue.AutoSize = true;
            this.lblGreenValue.ForeColor = System.Drawing.Color.Lime;
            this.lblGreenValue.Location = new System.Drawing.Point(443, 120);
            this.lblGreenValue.Name = "lblGreenValue";
            this.lblGreenValue.Size = new System.Drawing.Size(57, 19);
            this.lblGreenValue.TabIndex = 7;
            this.lblGreenValue.Text = "Green";
            // 
            // lblBlueValue
            // 
            this.lblBlueValue.AutoSize = true;
            this.lblBlueValue.ForeColor = System.Drawing.Color.Blue;
            this.lblBlueValue.Location = new System.Drawing.Point(443, 181);
            this.lblBlueValue.Name = "lblBlueValue";
            this.lblBlueValue.Size = new System.Drawing.Size(44, 19);
            this.lblBlueValue.TabIndex = 8;
            this.lblBlueValue.Text = "Blue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 477);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Đổi màu nền cho TextBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.HScrollBar hscRed;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar hscBlue;
        private System.Windows.Forms.HScrollBar hscGreen;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label lblBlueValue;
        private System.Windows.Forms.Label lblGreenValue;
        private System.Windows.Forms.Label lblRedValue;
    }
}

