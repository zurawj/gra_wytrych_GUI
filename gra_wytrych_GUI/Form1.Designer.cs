﻿
namespace gra_wytrych_GUI
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
            this.BtnNowaGra = new System.Windows.Forms.Button();
            this.BtnLewo = new System.Windows.Forms.Button();
            this.BtnPrawo = new System.Windows.Forms.Button();
            this.LblLiczbaSkrzyniInfo = new System.Windows.Forms.Label();
            this.LblLiczbaSkrzyni = new System.Windows.Forms.Label();
            this.LblPunktyInfo = new System.Windows.Forms.Label();
            this.LblPunkty = new System.Windows.Forms.Label();
            this.LblLiczbaWytrychowInfo = new System.Windows.Forms.Label();
            this.LblLiczbaWytrychow = new System.Windows.Forms.Label();
            this.LblOutput = new System.Windows.Forms.Label();
            this.BtnOpcje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnNowaGra
            // 
            this.BtnNowaGra.Location = new System.Drawing.Point(102, 289);
            this.BtnNowaGra.Name = "BtnNowaGra";
            this.BtnNowaGra.Size = new System.Drawing.Size(75, 23);
            this.BtnNowaGra.TabIndex = 0;
            this.BtnNowaGra.Text = "Nowa Gra";
            this.BtnNowaGra.UseVisualStyleBackColor = true;
            this.BtnNowaGra.Click += new System.EventHandler(this.BtnNowaGra_Click);
            // 
            // BtnLewo
            // 
            this.BtnLewo.Location = new System.Drawing.Point(30, 212);
            this.BtnLewo.Name = "BtnLewo";
            this.BtnLewo.Size = new System.Drawing.Size(110, 51);
            this.BtnLewo.TabIndex = 1;
            this.BtnLewo.Text = "Lewo";
            this.BtnLewo.UseVisualStyleBackColor = true;
            this.BtnLewo.Visible = false;
            this.BtnLewo.Click += new System.EventHandler(this.BtnLewo_Click);
            // 
            // BtnPrawo
            // 
            this.BtnPrawo.Location = new System.Drawing.Point(146, 212);
            this.BtnPrawo.Name = "BtnPrawo";
            this.BtnPrawo.Size = new System.Drawing.Size(108, 51);
            this.BtnPrawo.TabIndex = 2;
            this.BtnPrawo.Text = "Prawo";
            this.BtnPrawo.UseVisualStyleBackColor = true;
            this.BtnPrawo.Visible = false;
            this.BtnPrawo.Click += new System.EventHandler(this.BtnPrawo_Click);
            // 
            // LblLiczbaSkrzyniInfo
            // 
            this.LblLiczbaSkrzyniInfo.AutoSize = true;
            this.LblLiczbaSkrzyniInfo.Location = new System.Drawing.Point(27, 31);
            this.LblLiczbaSkrzyniInfo.Name = "LblLiczbaSkrzyniInfo";
            this.LblLiczbaSkrzyniInfo.Size = new System.Drawing.Size(125, 13);
            this.LblLiczbaSkrzyniInfo.TabIndex = 3;
            this.LblLiczbaSkrzyniInfo.Text = "Liczba otwartych skrzyni:";
            // 
            // LblLiczbaSkrzyni
            // 
            this.LblLiczbaSkrzyni.AutoSize = true;
            this.LblLiczbaSkrzyni.Location = new System.Drawing.Point(156, 31);
            this.LblLiczbaSkrzyni.Name = "LblLiczbaSkrzyni";
            this.LblLiczbaSkrzyni.Size = new System.Drawing.Size(0, 13);
            this.LblLiczbaSkrzyni.TabIndex = 4;
            // 
            // LblPunktyInfo
            // 
            this.LblPunktyInfo.AutoSize = true;
            this.LblPunktyInfo.Location = new System.Drawing.Point(27, 67);
            this.LblPunktyInfo.Name = "LblPunktyInfo";
            this.LblPunktyInfo.Size = new System.Drawing.Size(45, 17);
            this.LblPunktyInfo.TabIndex = 5;
            this.LblPunktyInfo.Text = "Punkty: ";
            this.LblPunktyInfo.UseCompatibleTextRendering = true;
            // 
            // LblPunkty
            // 
            this.LblPunkty.AutoSize = true;
            this.LblPunkty.Location = new System.Drawing.Point(79, 67);
            this.LblPunkty.Name = "LblPunkty";
            this.LblPunkty.Size = new System.Drawing.Size(13, 13);
            this.LblPunkty.TabIndex = 6;
            this.LblPunkty.Text = "0";
            this.LblPunkty.Visible = false;
            // 
            // LblLiczbaWytrychowInfo
            // 
            this.LblLiczbaWytrychowInfo.AutoSize = true;
            this.LblLiczbaWytrychowInfo.Location = new System.Drawing.Point(27, 98);
            this.LblLiczbaWytrychowInfo.Name = "LblLiczbaWytrychowInfo";
            this.LblLiczbaWytrychowInfo.Size = new System.Drawing.Size(94, 13);
            this.LblLiczbaWytrychowInfo.TabIndex = 7;
            this.LblLiczbaWytrychowInfo.Text = "Liczba wytrychów:";
            // 
            // LblLiczbaWytrychow
            // 
            this.LblLiczbaWytrychow.AutoSize = true;
            this.LblLiczbaWytrychow.Location = new System.Drawing.Point(128, 98);
            this.LblLiczbaWytrychow.Name = "LblLiczbaWytrychow";
            this.LblLiczbaWytrychow.Size = new System.Drawing.Size(0, 13);
            this.LblLiczbaWytrychow.TabIndex = 8;
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Location = new System.Drawing.Point(27, 152);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(39, 13);
            this.LblOutput.TabIndex = 9;
            this.LblOutput.Text = "Output";
            this.LblOutput.Visible = false;
            // 
            // BtnOpcje
            // 
            this.BtnOpcje.Location = new System.Drawing.Point(102, 318);
            this.BtnOpcje.Name = "BtnOpcje";
            this.BtnOpcje.Size = new System.Drawing.Size(75, 23);
            this.BtnOpcje.TabIndex = 10;
            this.BtnOpcje.Text = "Opcje";
            this.BtnOpcje.UseVisualStyleBackColor = true;
            this.BtnOpcje.Click += new System.EventHandler(this.BtnOpcje_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(291, 365);
            this.Controls.Add(this.BtnOpcje);
            this.Controls.Add(this.LblOutput);
            this.Controls.Add(this.LblLiczbaWytrychow);
            this.Controls.Add(this.LblLiczbaWytrychowInfo);
            this.Controls.Add(this.LblPunkty);
            this.Controls.Add(this.LblPunktyInfo);
            this.Controls.Add(this.LblLiczbaSkrzyni);
            this.Controls.Add(this.LblLiczbaSkrzyniInfo);
            this.Controls.Add(this.BtnPrawo);
            this.Controls.Add(this.BtnLewo);
            this.Controls.Add(this.BtnNowaGra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gra - Otwórz Skrzynię";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnNowaGra;
        private System.Windows.Forms.Button BtnLewo;
        private System.Windows.Forms.Button BtnPrawo;
        private System.Windows.Forms.Label LblLiczbaSkrzyniInfo;
        private System.Windows.Forms.Label LblLiczbaSkrzyni;
        private System.Windows.Forms.Label LblPunktyInfo;
        private System.Windows.Forms.Label LblPunkty;
        private System.Windows.Forms.Label LblLiczbaWytrychowInfo;
        private System.Windows.Forms.Label LblLiczbaWytrychow;
        private System.Windows.Forms.Label LblOutput;
        private System.Windows.Forms.Button BtnOpcje;
    }
}

