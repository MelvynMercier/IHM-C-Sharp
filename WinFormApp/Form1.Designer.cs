using Provider.EntityFramework;
using System;

namespace WinFormApp
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
            this.campagneLabel = new System.Windows.Forms.Label();
            this.textBoxNomCampagne = new System.Windows.Forms.TextBox();
            this.nomCampagneLabel = new System.Windows.Forms.Label();
            this.btnAjouterCampagne = new System.Windows.Forms.Button();
            this.listBoxEmailCampagne = new System.Windows.Forms.ListBox();
            this.listEmailCampagne = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // campagneLabel
            // 
            this.campagneLabel.AutoSize = true;
            this.campagneLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.campagneLabel.Location = new System.Drawing.Point(337, 24);
            this.campagneLabel.Name = "campagneLabel";
            this.campagneLabel.Size = new System.Drawing.Size(321, 81);
            this.campagneLabel.TabIndex = 0;
            this.campagneLabel.Text = "Campagne";
            // 
            // textBoxNomCampagne
            // 
            this.textBoxNomCampagne.Location = new System.Drawing.Point(277, 223);
            this.textBoxNomCampagne.Name = "textBoxNomCampagne";
            this.textBoxNomCampagne.Size = new System.Drawing.Size(286, 31);
            this.textBoxNomCampagne.TabIndex = 1;
            // 
            // nomCampagneLabel
            // 
            this.nomCampagneLabel.AutoSize = true;
            this.nomCampagneLabel.Location = new System.Drawing.Point(43, 229);
            this.nomCampagneLabel.Name = "nomCampagneLabel";
            this.nomCampagneLabel.Size = new System.Drawing.Size(183, 25);
            this.nomCampagneLabel.TabIndex = 2;
            this.nomCampagneLabel.Text = "Nom de la campagne";
            // 
            // btnAjouterCampagne
            // 
            this.btnAjouterCampagne.Location = new System.Drawing.Point(620, 223);
            this.btnAjouterCampagne.Name = "btnAjouterCampagne";
            this.btnAjouterCampagne.Size = new System.Drawing.Size(232, 34);
            this.btnAjouterCampagne.TabIndex = 3;
            this.btnAjouterCampagne.Text = "Ajouter la campagne";
            this.btnAjouterCampagne.UseVisualStyleBackColor = true;
            this.btnAjouterCampagne.Click += new System.EventHandler(this.btnAjouterCampagne_Click);
            // 
            // listBoxEmailCampagne
            // 
            this.listBoxEmailCampagne.FormattingEnabled = true;
            this.listBoxEmailCampagne.ItemHeight = 25;
            this.listBoxEmailCampagne.Location = new System.Drawing.Point(43, 310);
            this.listBoxEmailCampagne.Name = "listBoxEmailCampagne";
            this.listBoxEmailCampagne.Size = new System.Drawing.Size(300, 254);
            this.listBoxEmailCampagne.TabIndex = 4;
            this.listBoxEmailCampagne.Click += new System.EventHandler(this.listBoxEmailCampagne_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 601);
            this.Controls.Add(this.listBoxEmailCampagne);
            this.Controls.Add(this.listEmailCampagne);
            this.Controls.Add(this.btnAjouterCampagne);
            this.Controls.Add(this.nomCampagneLabel);
            this.Controls.Add(this.textBoxNomCampagne);
            this.Controls.Add(this.campagneLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label campagneLabel;
        private System.Windows.Forms.TextBox textBoxNomCampagne;
        private System.Windows.Forms.Label nomCampagneLabel;
        private System.Windows.Forms.Button btnAjouterCampagne;
        private System.Windows.Forms.ListBox listBoxEmailCampagne;
        private System.Windows.Forms.ListBox listEmailCampagne;
    }
}

