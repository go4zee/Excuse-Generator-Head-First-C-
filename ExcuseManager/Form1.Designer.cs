﻿namespace ExcuseManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.resultsTextBox = new System.Windows.Forms.TextBox();
            this.lastUsed = new System.Windows.Forms.DateTimePicker();
            this.filedateLabel = new System.Windows.Forms.Label();
            this.folder = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.randomExcuse = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excuse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Results";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Used";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "File Date";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(101, 20);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(209, 20);
            this.description.TabIndex = 4;
            this.description.TextChanged += new System.EventHandler(this.description_TextChanged);
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point(101, 49);
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.Size = new System.Drawing.Size(209, 20);
            this.resultsTextBox.TabIndex = 5;
            this.resultsTextBox.TextChanged += new System.EventHandler(this.resultsTextBox_TextChanged);
            // 
            // lastUsed
            // 
            this.lastUsed.Location = new System.Drawing.Point(101, 85);
            this.lastUsed.Name = "lastUsed";
            this.lastUsed.Size = new System.Drawing.Size(209, 20);
            this.lastUsed.TabIndex = 6;
            this.lastUsed.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // filedateLabel
            // 
            this.filedateLabel.Location = new System.Drawing.Point(98, 121);
            this.filedateLabel.Name = "filedateLabel";
            this.filedateLabel.Size = new System.Drawing.Size(212, 23);
            this.filedateLabel.TabIndex = 3;
            this.filedateLabel.Text = "File Date";
            // 
            // folder
            // 
            this.folder.Location = new System.Drawing.Point(26, 161);
            this.folder.Name = "folder";
            this.folder.Size = new System.Drawing.Size(64, 23);
            this.folder.TabIndex = 7;
            this.folder.Text = "Folder";
            this.folder.UseVisualStyleBackColor = true;
            this.folder.Click += new System.EventHandler(this.folder_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(96, 161);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(63, 23);
            this.save.TabIndex = 8;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(165, 161);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(63, 23);
            this.open.TabIndex = 9;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // randomExcuse
            // 
            this.randomExcuse.Location = new System.Drawing.Point(235, 161);
            this.randomExcuse.Name = "randomExcuse";
            this.randomExcuse.Size = new System.Drawing.Size(75, 23);
            this.randomExcuse.TabIndex = 10;
            this.randomExcuse.Text = "Random";
            this.randomExcuse.UseVisualStyleBackColor = true;
            this.randomExcuse.Click += new System.EventHandler(this.randomExcuse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 195);
            this.Controls.Add(this.randomExcuse);
            this.Controls.Add(this.open);
            this.Controls.Add(this.save);
            this.Controls.Add(this.folder);
            this.Controls.Add(this.lastUsed);
            this.Controls.Add(this.resultsTextBox);
            this.Controls.Add(this.description);
            this.Controls.Add(this.filedateLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Excuse Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.DateTimePicker lastUsed;
        private System.Windows.Forms.Label filedateLabel;
        private System.Windows.Forms.Button folder;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button randomExcuse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

