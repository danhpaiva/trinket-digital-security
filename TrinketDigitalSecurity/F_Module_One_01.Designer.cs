﻿
namespace TrinketDigitalSecurity
{
    partial class F_Module_One_01
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
            this.btn_answer = new System.Windows.Forms.Button();
            this.lbl_answer_appears = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(500, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "What is Information Security";
            // 
            // btn_answer
            // 
            this.btn_answer.Location = new System.Drawing.Point(539, 98);
            this.btn_answer.Name = "btn_answer";
            this.btn_answer.Size = new System.Drawing.Size(75, 23);
            this.btn_answer.TabIndex = 1;
            this.btn_answer.Text = "?";
            this.btn_answer.UseVisualStyleBackColor = true;
            this.btn_answer.Click += new System.EventHandler(this.btn_answer_Click);
            // 
            // lbl_answer_appears
            // 
            this.lbl_answer_appears.AutoSize = true;
            this.lbl_answer_appears.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_answer_appears.Location = new System.Drawing.Point(68, 213);
            this.lbl_answer_appears.Name = "lbl_answer_appears";
            this.lbl_answer_appears.Size = new System.Drawing.Size(0, 32);
            this.lbl_answer_appears.TabIndex = 2;
            // 
            // btn_next
            // 
            this.btn_next.Enabled = false;
            this.btn_next.Location = new System.Drawing.Point(500, 593);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(157, 23);
            this.btn_next.TabIndex = 3;
            this.btn_next.Text = "NEXT";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // F_Module_One_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lbl_answer_appears);
            this.Controls.Add(this.btn_answer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Module_One_01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Module_One_01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_answer;
        private System.Windows.Forms.Label lbl_answer_appears;
        private System.Windows.Forms.Button btn_next;
    }
}