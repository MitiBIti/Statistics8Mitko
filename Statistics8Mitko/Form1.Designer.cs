namespace Statistics8Mitko
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnAvr = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblAvr = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAvr
            // 
            this.btnAvr.BackColor = System.Drawing.Color.Orange;
            this.btnAvr.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAvr.Location = new System.Drawing.Point(322, 313);
            this.btnAvr.Name = "btnAvr";
            this.btnAvr.Size = new System.Drawing.Size(150, 59);
            this.btnAvr.TabIndex = 0;
            this.btnAvr.Text = "Average";
            this.btnAvr.UseVisualStyleBackColor = false;
            this.btnAvr.Click += new System.EventHandler(this.btnAvr_Click);
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.Color.White;
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtNum.Location = new System.Drawing.Point(204, 12);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(562, 38);
            this.txtNum.TabIndex = 1;
            // 
            // lblAvr
            // 
            this.lblAvr.AutoSize = true;
            this.lblAvr.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAvr.Location = new System.Drawing.Point(349, 391);
            this.lblAvr.Name = "lblAvr";
            this.lblAvr.Size = new System.Drawing.Size(0, 38);
            this.lblAvr.TabIndex = 2;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Orange;
            this.lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl.Location = new System.Drawing.Point(36, 12);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(139, 38);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "Numbers:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblAvr);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnAvr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAvr;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblAvr;
        private System.Windows.Forms.Label lbl;
    }
}

