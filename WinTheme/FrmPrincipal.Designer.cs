namespace WinTheme
{
    partial class FrmPrincipal
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
            this.btnlightColor = new System.Windows.Forms.Button();
            this.btndarkColor = new System.Windows.Forms.Button();
            this.btnthemeColor = new System.Windows.Forms.Button();
            this.pnllightColor = new System.Windows.Forms.Panel();
            this.pnldarkColor = new System.Windows.Forms.Panel();
            this.pnlthemeColor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnlightColor
            // 
            this.btnlightColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlightColor.Location = new System.Drawing.Point(103, 178);
            this.btnlightColor.Name = "btnlightColor";
            this.btnlightColor.Size = new System.Drawing.Size(110, 95);
            this.btnlightColor.TabIndex = 0;
            this.btnlightColor.Text = "lightColor";
            this.btnlightColor.UseVisualStyleBackColor = true;
            // 
            // btndarkColor
            // 
            this.btndarkColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndarkColor.Location = new System.Drawing.Point(345, 178);
            this.btndarkColor.Name = "btndarkColor";
            this.btndarkColor.Size = new System.Drawing.Size(110, 95);
            this.btndarkColor.TabIndex = 1;
            this.btndarkColor.Text = "darkColor";
            this.btndarkColor.UseVisualStyleBackColor = true;
            // 
            // btnthemeColor
            // 
            this.btnthemeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthemeColor.Location = new System.Drawing.Point(567, 178);
            this.btnthemeColor.Name = "btnthemeColor";
            this.btnthemeColor.Size = new System.Drawing.Size(110, 95);
            this.btnthemeColor.TabIndex = 2;
            this.btnthemeColor.Tag = "winTheme";
            this.btnthemeColor.Text = "themeColor";
            this.btnthemeColor.UseVisualStyleBackColor = true;
            // 
            // pnllightColor
            // 
            this.pnllightColor.Location = new System.Drawing.Point(71, 46);
            this.pnllightColor.Name = "pnllightColor";
            this.pnllightColor.Size = new System.Drawing.Size(162, 99);
            this.pnllightColor.TabIndex = 3;
            // 
            // pnldarkColor
            // 
            this.pnldarkColor.Location = new System.Drawing.Point(321, 46);
            this.pnldarkColor.Name = "pnldarkColor";
            this.pnldarkColor.Size = new System.Drawing.Size(162, 99);
            this.pnldarkColor.TabIndex = 4;
            // 
            // pnlthemeColor
            // 
            this.pnlthemeColor.Location = new System.Drawing.Point(541, 46);
            this.pnlthemeColor.Name = "pnlthemeColor";
            this.pnlthemeColor.Size = new System.Drawing.Size(162, 99);
            this.pnlthemeColor.TabIndex = 4;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlthemeColor);
            this.Controls.Add(this.pnldarkColor);
            this.Controls.Add(this.pnllightColor);
            this.Controls.Add(this.btnthemeColor);
            this.Controls.Add(this.btndarkColor);
            this.Controls.Add(this.btnlightColor);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnlightColor;
        private System.Windows.Forms.Button btndarkColor;
        private System.Windows.Forms.Button btnthemeColor;
        private System.Windows.Forms.Panel pnllightColor;
        private System.Windows.Forms.Panel pnldarkColor;
        private System.Windows.Forms.Panel pnlthemeColor;
    }
}
