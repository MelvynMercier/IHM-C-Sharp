using Provider.EntityFramework;
using System;

namespace WinFormApp
{
    partial class Campagne
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
            this.inputName = new System.Windows.Forms.TextBox();
            this.campagneLabelName = new System.Windows.Forms.Label();
            this.addCampagneBtn = new System.Windows.Forms.Button();
            this.listBoxEmailCampagne = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // campagneLabel
            // 
            this.campagneLabel.AutoSize = true;
            this.campagneLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.campagneLabel.Location = new System.Drawing.Point(400, 30);
            this.campagneLabel.Name = "campagneLabel";
            this.campagneLabel.Size = new System.Drawing.Size(321, 81);
            this.campagneLabel.TabIndex = 0;
            this.campagneLabel.Text = "Campagnes";
            // 
            // nomCampagneLabel
            // 
            this.campagneLabelName.AutoSize = true;
            this.campagneLabelName.Location = new System.Drawing.Point(20, 150);
            this.campagneLabelName.Name = "nomCampagneLabel";
            this.campagneLabelName.Size = new System.Drawing.Size(180, 25);
            this.campagneLabelName.TabIndex = 2;
            this.campagneLabelName.Text = "Nom de la nouvelle campagne :";
            // 
            // textBoxNomCampagne
            // 
            this.inputName.Location = new System.Drawing.Point(300, 145);
            this.inputName.Name = "textBoxNomCampagne";
            this.inputName.Size = new System.Drawing.Size(200, 30);
            this.inputName.TabIndex = 1;

            // 
            // btnAjouterCampagne
            // 
            this.addCampagneBtn.Location = new System.Drawing.Point(520, 140);
            this.addCampagneBtn.Name = "btnAjouterCampagne";
            this.addCampagneBtn.Size = new System.Drawing.Size(200, 40);
            this.addCampagneBtn.TabIndex = 3;
            this.addCampagneBtn.Text = "Ajouter la campagne";
            this.addCampagneBtn.UseVisualStyleBackColor = true;
            this.addCampagneBtn.Click += new System.EventHandler(this.AddCampagne_Click);
            // 
            // listBoxEmailCampagne
            // 
            this.listBoxEmailCampagne.FormattingEnabled = true;
            this.listBoxEmailCampagne.ItemHeight = 25;
            this.listBoxEmailCampagne.Location = new System.Drawing.Point(20, 200);
            this.listBoxEmailCampagne.Name = "listBoxEmailCampagne";
            this.listBoxEmailCampagne.Size = new System.Drawing.Size(1050, 400);
            this.listBoxEmailCampagne.TabIndex = 4;
            this.listBoxEmailCampagne.Click += new System.EventHandler(this.OpenIHMCampagne_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 601);
            this.Controls.Add(this.listBoxEmailCampagne);
            this.Controls.Add(this.addCampagneBtn);
            this.Controls.Add(this.campagneLabelName);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.campagneLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label campagneLabel;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label campagneLabelName;
        private System.Windows.Forms.Button addCampagneBtn;
        private System.Windows.Forms.ListBox listBoxEmailCampagne;
    }
}

