namespace grifindo_toys
{
    partial class frmadminmenu
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnemployee = new System.Windows.Forms.Button();
            this.btnsalary = new System.Windows.Forms.Button();
            this.btnsettings = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.btnreport = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(322, 31);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(229, 42);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Admin Menu";
            // 
            // btnemployee
            // 
            this.btnemployee.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnemployee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemployee.ForeColor = System.Drawing.Color.Ivory;
            this.btnemployee.Location = new System.Drawing.Point(228, 118);
            this.btnemployee.Name = "btnemployee";
            this.btnemployee.Size = new System.Drawing.Size(179, 66);
            this.btnemployee.TabIndex = 1;
            this.btnemployee.Text = "Employee";
            this.btnemployee.UseVisualStyleBackColor = false;
            this.btnemployee.Click += new System.EventHandler(this.btnemployee_Click);
            // 
            // btnsalary
            // 
            this.btnsalary.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnsalary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalary.ForeColor = System.Drawing.Color.Ivory;
            this.btnsalary.Location = new System.Drawing.Point(480, 118);
            this.btnsalary.Name = "btnsalary";
            this.btnsalary.Size = new System.Drawing.Size(179, 66);
            this.btnsalary.TabIndex = 2;
            this.btnsalary.Text = "Salary";
            this.btnsalary.UseVisualStyleBackColor = false;
            this.btnsalary.Click += new System.EventHandler(this.btnsalary_Click);
            // 
            // btnsettings
            // 
            this.btnsettings.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnsettings.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsettings.ForeColor = System.Drawing.Color.Ivory;
            this.btnsettings.Location = new System.Drawing.Point(115, 234);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(179, 66);
            this.btnsettings.TabIndex = 3;
            this.btnsettings.Text = "Settings";
            this.btnsettings.UseVisualStyleBackColor = false;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnview.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.Ivory;
            this.btnview.Location = new System.Drawing.Point(377, 234);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(179, 66);
            this.btnview.TabIndex = 4;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnreport
            // 
            this.btnreport.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnreport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreport.ForeColor = System.Drawing.Color.Ivory;
            this.btnreport.Location = new System.Drawing.Point(628, 234);
            this.btnreport.Name = "btnreport";
            this.btnreport.Size = new System.Drawing.Size(179, 66);
            this.btnreport.TabIndex = 5;
            this.btnreport.Text = "Report";
            this.btnreport.UseVisualStyleBackColor = false;
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(870, 451);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(90, 36);
            this.btnlogout.TabIndex = 6;
            this.btnlogout.Text = "log out";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // frmadminmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(972, 499);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnreport);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.btnsettings);
            this.Controls.Add(this.btnsalary);
            this.Controls.Add(this.btnemployee);
            this.Controls.Add(this.lbl1);
            this.Name = "frmadminmenu";
            this.Text = "Admin Menu";
            this.Load += new System.EventHandler(this.frmadminmenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnemployee;
        private System.Windows.Forms.Button btnsalary;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btnreport;
        private System.Windows.Forms.Button btnlogout;
    }
}