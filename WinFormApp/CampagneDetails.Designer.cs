using Provider.EntityFramework;
using System;

namespace WinFormApp
{
    partial class CampagneDetails
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
            this.campagneLabel = new System.Windows.Forms.Label();
            this.campagneName = new System.Windows.Forms.Label();
            this.listEmailBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // campagneLabel
            // 
            this.campagneLabel.AutoSize = true;
            this.campagneLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.campagneLabel.Location = new System.Drawing.Point(200, 30);
            this.campagneLabel.Name = "campagneLabel";
            this.campagneLabel.Size = new System.Drawing.Size(320, 80);
            this.campagneLabel.TabIndex = 0;
            this.campagneLabel.Text = "Campagne :";
            // 
            // campagneName
            // 
            this.campagneName.AutoSize = true;
            this.campagneName.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.campagneName.Location = new System.Drawing.Point(530, 30);
            this.campagneName.Name = "campagneName";
            this.campagneName.Size = new System.Drawing.Size(320, 80);
            this.campagneName.TabIndex = 0;
            // 
            // listBoxEmailCampagne
            // 
            this.listEmailBox.FormattingEnabled = true;
            this.listEmailBox.ItemHeight = 25;
            this.listEmailBox.Location = new System.Drawing.Point(20, 200);
            this.listEmailBox.Name = "listBoxEmailCampagne";
            this.listEmailBox.Size = new System.Drawing.Size(1050, 400);
            this.listEmailBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 601);
            this.Controls.Add(this.campagneLabel);
            this.Controls.Add(this.campagneName);
            this.Controls.Add(this.listEmailBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label campagneLabel;
        private System.Windows.Forms.Label campagneName;
        private System.Windows.Forms.ListBox listEmailBox;
    }
}

