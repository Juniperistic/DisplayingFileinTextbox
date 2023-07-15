
namespace ch17ex3
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
            this.txtGrades = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtGrades
            // 
            this.txtGrades.BackColor = System.Drawing.SystemColors.Control;
            this.txtGrades.Location = new System.Drawing.Point(12, 12);
            this.txtGrades.Multiline = true;
            this.txtGrades.Name = "txtGrades";
            this.txtGrades.ReadOnly = true;
            this.txtGrades.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGrades.Size = new System.Drawing.Size(364, 207);
            this.txtGrades.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 231);
            this.Controls.Add(this.txtGrades);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGrades;
    }
}

