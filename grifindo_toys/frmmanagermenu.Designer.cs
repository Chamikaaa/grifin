namespace grifindo_toys
{
    partial class frmmanagermenu
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
            this.btnlogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(328, 21);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(266, 42);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Manager Menu";
            // 
            // btnemployee
            // 
            this.btnemployee.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnemployee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnemployee.ForeColor = System.Drawing.Color.Ivory;
            this.btnemployee.Location = new System.Drawing.Point(335, 247);
            this.btnemployee.Name = "btnemployee";
            this.btnemployee.Size = new System.Drawing.Size(245, 82);
            this.btnemployee.TabIndex = 2;
            this.btnemployee.Text = "Employee Details";
            this.btnemployee.UseVisualStyleBackColor = false;
            this.btnemployee.Click += new System.EventHandler(this.btnemployee_Click);
            // 
            // btnsalary
            // 
            this.btnsalary.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnsalary.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalary.ForeColor = System.Drawing.Color.Ivory;
            this.btnsalary.Location = new System.Drawing.Point(335, 126);
            this.btnsalary.Name = "btnsalary";
            this.btnsalary.Size = new System.Drawing.Size(245, 84);
            this.btnsalary.TabIndex = 3;
            this.btnsalary.Text = "Salary Details";
            this.btnsalary.UseVisualStyleBackColor = false;
            this.btnsalary.Click += new System.EventHandler(this.btnsalary_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(870, 451);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(90, 36);
            this.btnlogout.TabIndex = 7;
            this.btnlogout.Text = "log out";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // frmmanagermenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(972, 499);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.btnsalary);
            this.Controls.Add(this.btnemployee);
            this.Controls.Add(this.lbl1);
            this.Name = "frmmanagermenu";
            this.Text = "Manager Menu";
            this.Load += new System.EventHandler(this.frmmanagermenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnemployee;
        private System.Windows.Forms.Button btnsalary;
        private System.Windows.Forms.Button btnlogout;
    }
}