﻿namespace WindowsAPI.EditingMode
{
    partial class EditingModeAuto_clienta
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
            this.BtnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.Exite = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnInsert
            // 
            this.BtnInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnInsert.Location = new System.Drawing.Point(574, 12);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(214, 30);
            this.BtnInsert.TabIndex = 14;
            this.BtnInsert.Text = "Добавить";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(574, 81);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(214, 30);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Изменить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // Exite
            // 
            this.Exite.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Exite.Location = new System.Drawing.Point(574, 408);
            this.Exite.Name = "Exite";
            this.Exite.Size = new System.Drawing.Size(214, 30);
            this.Exite.TabIndex = 12;
            this.Exite.Text = "Выйти из режима редактирования";
            this.Exite.UseVisualStyleBackColor = true;
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete.Location = new System.Drawing.Point(574, 148);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(214, 30);
            this.Delete.TabIndex = 11;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(556, 426);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(713, 225);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Главная";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // EditingModeAuto_clienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.Exite);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EditingModeAuto_clienta";
            this.Text = "\'\\\\\\";
            this.Load += new System.EventHandler(this.EditingModeAuto_clienta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnInsert;
        private Button btnUpdate;
        private Button Exite;
        private Button Delete;
        private DataGridView dataGridView1;
        private Button button5;
    }
}