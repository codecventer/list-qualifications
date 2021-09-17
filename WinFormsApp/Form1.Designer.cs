
namespace WinFormsApp
{
    partial class Form1
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
            this.lblQuals = new System.Windows.Forms.Label();
            this.lstQuals = new System.Windows.Forms.ListBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuals
            // 
            this.lblQuals.AutoSize = true;
            this.lblQuals.Location = new System.Drawing.Point(54, 65);
            this.lblQuals.Name = "lblQuals";
            this.lblQuals.Size = new System.Drawing.Size(104, 15);
            this.lblQuals.TabIndex = 0;
            this.lblQuals.Text = "Qualifications List:";
            // 
            // lstQuals
            // 
            this.lstQuals.FormattingEnabled = true;
            this.lstQuals.ItemHeight = 15;
            this.lstQuals.Location = new System.Drawing.Point(54, 83);
            this.lstQuals.Name = "lstQuals";
            this.lstQuals.Size = new System.Drawing.Size(202, 259);
            this.lstQuals.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(295, 83);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name:";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(295, 197);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(73, 15);
            this.lblDept.TabIndex = 3;
            this.lblDept.Text = "Department:";
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(295, 322);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(37, 15);
            this.lblYears.TabIndex = 4;
            this.lblYears.Text = "Years:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(399, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 23);
            this.txtName.TabIndex = 5;
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(399, 194);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(207, 23);
            this.txtDept.TabIndex = 6;
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(399, 319);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(207, 23);
            this.txtYears.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(119, 452);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 39);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Qualification";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(399, 452);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(137, 39);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 503);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lstQuals);
            this.Controls.Add(this.lblQuals);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuals;
        private System.Windows.Forms.ListBox lstQuals;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
    }
}

