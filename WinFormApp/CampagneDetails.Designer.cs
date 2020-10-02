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
            this.importBtn = new System.Windows.Forms.Button();
            this.addLabel = new System.Windows.Forms.Label();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.importEmail = new System.Windows.Forms.Button();
            this.contactInfoInput = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.doublonBtn = new System.Windows.Forms.Button();
            this.sendMailBtn = new System.Windows.Forms.Button();


            this.SuspendLayout();
            // 
            // campagneLabel
            // 
            this.campagneLabel.AutoSize = true;
            this.campagneLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.campagneLabel.Location = new System.Drawing.Point(500, 30);
            this.campagneLabel.Name = "campagneLabel";
            this.campagneLabel.Size = new System.Drawing.Size(320, 80);
            this.campagneLabel.TabIndex = 0;
            this.campagneLabel.Text = "Campagne :";
            // 
            // campagneName
            // 
            this.campagneName.AutoSize = true;
            this.campagneName.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.campagneName.Location = new System.Drawing.Point(850, 30);
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
            this.listEmailBox.Click += new System.EventHandler(this.MoreInformations_Click);
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(970, 145);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(100, 40);
            this.importBtn.TabIndex = 5;
            this.importBtn.Text = "Importer";
            this.importBtn.Click += new System.EventHandler(this.OpenDialog_Click);
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addLabel.Location = new System.Drawing.Point(20, 145);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(40, 40);
            this.addLabel.TabIndex = 6;
            this.addLabel.Text = "Nouvel email :";
            // 
            // textBoxEmail
            // 
            this.inputEmail.Location = new System.Drawing.Point(180, 150);
            this.inputEmail.Name = "textBoxEmail";
            this.inputEmail.Size = new System.Drawing.Size(300, 40);
            this.inputEmail.TabIndex = 7;
            // 
            // importEmail
            // 
            this.importEmail.Location = new System.Drawing.Point(500, 145);
            this.importEmail.Name = "importEmail";
            this.importEmail.Size = new System.Drawing.Size(110, 40);
            this.importEmail.TabIndex = 8;
            this.importEmail.Text = "Ajouter";
            this.importEmail.Click += new System.EventHandler(this.AddEmail_Click);
            // 
            // contactInfoInput
            // 
            this.contactInfoInput.AutoSize = true;
            this.contactInfoInput.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contactInfoInput.Location = new System.Drawing.Point(1085, 300);
            this.contactInfoInput.Name = "contactInfoInput";
            this.contactInfoInput.Size = new System.Drawing.Size(400, 80);
            this.contactInfoInput.TabIndex = 9;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(1085, 400);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(100, 40);
            this.updateBtn.TabIndex = 9;
            this.updateBtn.Text = "Modifier";
            this.updateBtn.Click += new System.EventHandler(this.UpdateEmail_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(1370, 400);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(110, 40);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.Text = "Supprimer";
            this.deleteBtn.Click += new System.EventHandler(this.DeleteEmail_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(850, 145);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(110, 40);
            this.exportBtn.TabIndex = 11;
            this.exportBtn.Text = "Exporter";
            this.exportBtn.Click += new System.EventHandler(this.ExportEmails_Click);
            // 
            // doublonBtn
            // 
            this.doublonBtn.Location = new System.Drawing.Point(630, 145);
            this.doublonBtn.Name = "doublonBtn";
            this.doublonBtn.Size = new System.Drawing.Size(200, 40);
            this.doublonBtn.TabIndex = 12;
            this.doublonBtn.Text = "Supprimer Doublons";
            this.doublonBtn.Click += new System.EventHandler(this.DeleteDuplicate_Click);
            // 
            // sendMailBtn
            // 
            this.sendMailBtn.Location = new System.Drawing.Point(1200, 145);
            this.sendMailBtn.Name = "sendMailBtn";
            this.sendMailBtn.Size = new System.Drawing.Size(200, 40);
            this.sendMailBtn.TabIndex = 12;
            this.sendMailBtn.Text = "Envoyer Email";
            this.sendMailBtn.Click += new System.EventHandler(this.SendMail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 600);
            this.Controls.Add(this.campagneLabel);
            this.Controls.Add(this.campagneName);
            this.Controls.Add(this.listEmailBox);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.addLabel);
            this.Controls.Add(this.inputEmail);
            this.Controls.Add(this.importEmail);
            this.Controls.Add(this.contactInfoInput);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.doublonBtn);
            this.Controls.Add(this.sendMailBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label campagneLabel;
        private System.Windows.Forms.Label campagneName;
        private System.Windows.Forms.ListBox listEmailBox;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.Button importEmail;
        private System.Windows.Forms.TextBox contactInfoInput;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Button doublonBtn;
        private System.Windows.Forms.Button sendMailBtn;

    }
}

