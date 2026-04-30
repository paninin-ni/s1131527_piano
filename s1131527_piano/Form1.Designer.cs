namespace s1131527_piano
{
    partial class frmBeepPlayer
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
            this.palMain = new System.Windows.Forms.Panel();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.palMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // palMain
            // 
            this.palMain.Controls.Add(this.btn8);
            this.palMain.Controls.Add(this.btn7);
            this.palMain.Controls.Add(this.btn6);
            this.palMain.Controls.Add(this.btn5);
            this.palMain.Controls.Add(this.btn4);
            this.palMain.Controls.Add(this.btn3);
            this.palMain.Controls.Add(this.btn2);
            this.palMain.Controls.Add(this.btn1);
            this.palMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.palMain.Location = new System.Drawing.Point(0, 0);
            this.palMain.Name = "palMain";
            this.palMain.Size = new System.Drawing.Size(1024, 265);
            this.palMain.TabIndex = 0;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(24, 39);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(115, 173);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Do";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(145, 39);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(115, 173);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Re";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(266, 39);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(115, 173);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Mi";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(629, 39);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(115, 173);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "La";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(509, 39);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(115, 173);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "So";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(387, 39);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(115, 173);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "Fa";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(750, 39);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(115, 173);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "Si";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.ForeColor = System.Drawing.Color.IndianRed;
            this.btn8.Location = new System.Drawing.Point(871, 39);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(115, 173);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "Do";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // frmBeepPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 265);
            this.Controls.Add(this.palMain);
            this.Name = "frmBeepPlayer";
            this.Text = "簡易電子琴";
            this.Load += new System.EventHandler(this.frmBeepPlayer_Load);
            this.SizeChanged += new System.EventHandler(this.frmBeepPlayer_SizeChanged);
            this.palMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palMain;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
    }
}

