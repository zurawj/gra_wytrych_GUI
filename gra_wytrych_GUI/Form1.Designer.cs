
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
            this.SuspendLayout();
            // 
            // BtnNowaGra
            // 
            this.BtnNowaGra.Location = new System.Drawing.Point(100, 361);
            this.BtnNowaGra.Name = "BtnNowaGra";
            this.BtnNowaGra.Size = new System.Drawing.Size(75, 23);
            this.BtnNowaGra.TabIndex = 0;
            this.BtnNowaGra.Text = "Nowa Gra";
            this.BtnNowaGra.UseVisualStyleBackColor = true;
            this.BtnNowaGra.Click += new System.EventHandler(this.BtnNowaGra_Click);
            // 
            // BtnLewo
            // 
            this.BtnLewo.Location = new System.Drawing.Point(27, 276);
            this.BtnLewo.Name = "BtnLewo";
            this.BtnLewo.Size = new System.Drawing.Size(95, 39);
            this.BtnLewo.TabIndex = 1;
            this.BtnLewo.Text = "Lewo";
            this.BtnLewo.UseVisualStyleBackColor = true;
            this.BtnLewo.Click += new System.EventHandler(this.BtnLewo_Click);
            // 
            // BtnPrawo
            // 
            this.BtnPrawo.Location = new System.Drawing.Point(158, 276);
            this.BtnPrawo.Name = "BtnPrawo";
            this.BtnPrawo.Size = new System.Drawing.Size(99, 39);
            this.BtnPrawo.TabIndex = 2;
            this.BtnPrawo.Text = "Prawo";
            this.BtnPrawo.UseVisualStyleBackColor = true;
            this.BtnPrawo.Click += new System.EventHandler(this.BtnPrawo_Click);
            // 
            // LblLiczbaSkrzyniInfo
            // 
            this.LblLiczbaSkrzyniInfo.AutoSize = true;
            this.LblLiczbaSkrzyniInfo.Location = new System.Drawing.Point(24, 31);
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
            this.LblOutput.Location = new System.Drawing.Point(27, 174);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(39, 13);
            this.LblOutput.TabIndex = 9;
            this.LblOutput.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form1";
            this.Text = " ";
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
    }
}

