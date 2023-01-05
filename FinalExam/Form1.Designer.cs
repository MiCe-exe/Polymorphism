namespace FinalExam
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
            this.btnCallCricket = new System.Windows.Forms.Button();
            this.btnOutputBee = new System.Windows.Forms.Button();
            this.btnMakeCricket = new System.Windows.Forms.Button();
            this.btnMakeBee = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtInsectColor = new System.Windows.Forms.TextBox();
            this.txtInsectType = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCallCricket
            // 
            this.btnCallCricket.Enabled = false;
            this.btnCallCricket.Location = new System.Drawing.Point(366, 168);
            this.btnCallCricket.Name = "btnCallCricket";
            this.btnCallCricket.Size = new System.Drawing.Size(105, 38);
            this.btnCallCricket.TabIndex = 17;
            this.btnCallCricket.Text = "Polymorphically Call Cricket Object";
            this.btnCallCricket.UseVisualStyleBackColor = true;
            this.btnCallCricket.Click += new System.EventHandler(this.btnCallCricket_Click);
            // 
            // btnOutputBee
            // 
            this.btnOutputBee.Enabled = false;
            this.btnOutputBee.Location = new System.Drawing.Point(231, 168);
            this.btnOutputBee.Name = "btnOutputBee";
            this.btnOutputBee.Size = new System.Drawing.Size(105, 38);
            this.btnOutputBee.TabIndex = 16;
            this.btnOutputBee.Text = "Polymorphically Call Bee Object";
            this.btnOutputBee.UseVisualStyleBackColor = true;
            this.btnOutputBee.Click += new System.EventHandler(this.btnOutputBee_Click);
            // 
            // btnMakeCricket
            // 
            this.btnMakeCricket.Location = new System.Drawing.Point(79, 90);
            this.btnMakeCricket.Name = "btnMakeCricket";
            this.btnMakeCricket.Size = new System.Drawing.Size(84, 23);
            this.btnMakeCricket.TabIndex = 15;
            this.btnMakeCricket.Text = "Make Cricket";
            this.btnMakeCricket.UseVisualStyleBackColor = true;
            this.btnMakeCricket.Click += new System.EventHandler(this.btnMakeCricket_Click);
            // 
            // btnMakeBee
            // 
            this.btnMakeBee.Location = new System.Drawing.Point(79, 61);
            this.btnMakeBee.Name = "btnMakeBee";
            this.btnMakeBee.Size = new System.Drawing.Size(84, 23);
            this.btnMakeBee.TabIndex = 14;
            this.btnMakeBee.Text = "Make Bee";
            this.btnMakeBee.UseVisualStyleBackColor = true;
            this.btnMakeBee.Click += new System.EventHandler(this.btnMakeBee_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Location = new System.Drawing.Point(231, 9);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(326, 146);
            this.lblOutput.TabIndex = 13;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInsectColor
            // 
            this.txtInsectColor.Location = new System.Drawing.Point(125, 35);
            this.txtInsectColor.Name = "txtInsectColor";
            this.txtInsectColor.Size = new System.Drawing.Size(100, 20);
            this.txtInsectColor.TabIndex = 12;
            this.txtInsectColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInsectType
            // 
            this.txtInsectType.Location = new System.Drawing.Point(6, 35);
            this.txtInsectType.Name = "txtInsectType";
            this.txtInsectType.Size = new System.Drawing.Size(100, 20);
            this.txtInsectType.TabIndex = 11;
            this.txtInsectType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(125, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Insect Color";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Insect Type";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 256);
            this.Controls.Add(this.btnCallCricket);
            this.Controls.Add(this.btnOutputBee);
            this.Controls.Add(this.btnMakeCricket);
            this.Controls.Add(this.btnMakeBee);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtInsectColor);
            this.Controls.Add(this.txtInsectType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CIS221 C# Final Exam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCallCricket;
        private System.Windows.Forms.Button btnOutputBee;
        private System.Windows.Forms.Button btnMakeCricket;
        private System.Windows.Forms.Button btnMakeBee;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtInsectColor;
        private System.Windows.Forms.TextBox txtInsectType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

