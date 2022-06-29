
namespace gra_wytrych_GUI
{
    partial class Opcje
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
            this.RbtnLatwy = new System.Windows.Forms.RadioButton();
            this.RbtnSredni = new System.Windows.Forms.RadioButton();
            this.RbtnTrudny = new System.Windows.Forms.RadioButton();
            this.LblLevelInfo = new System.Windows.Forms.Label();
            this.BtnZapisz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RbtnLatwy
            // 
            this.RbtnLatwy.AutoSize = true;
            this.RbtnLatwy.Location = new System.Drawing.Point(82, 117);
            this.RbtnLatwy.Name = "RbtnLatwy";
            this.RbtnLatwy.Size = new System.Drawing.Size(54, 17);
            this.RbtnLatwy.TabIndex = 0;
            this.RbtnLatwy.TabStop = true;
            this.RbtnLatwy.Text = "Łatwy";
            this.RbtnLatwy.UseVisualStyleBackColor = true;
            this.RbtnLatwy.CheckedChanged += new System.EventHandler(this.RbtnLatwy_CheckedChanged);
            // 
            // RbtnSredni
            // 
            this.RbtnSredni.AutoSize = true;
            this.RbtnSredni.Location = new System.Drawing.Point(82, 141);
            this.RbtnSredni.Name = "RbtnSredni";
            this.RbtnSredni.Size = new System.Drawing.Size(55, 17);
            this.RbtnSredni.TabIndex = 1;
            this.RbtnSredni.TabStop = true;
            this.RbtnSredni.Text = "Średni";
            this.RbtnSredni.UseVisualStyleBackColor = true;
            this.RbtnSredni.CheckedChanged += new System.EventHandler(this.RbtnSredni_CheckedChanged);
            // 
            // RbtnTrudny
            // 
            this.RbtnTrudny.AutoSize = true;
            this.RbtnTrudny.Location = new System.Drawing.Point(82, 165);
            this.RbtnTrudny.Name = "RbtnTrudny";
            this.RbtnTrudny.Size = new System.Drawing.Size(58, 17);
            this.RbtnTrudny.TabIndex = 2;
            this.RbtnTrudny.TabStop = true;
            this.RbtnTrudny.Text = "Trudny";
            this.RbtnTrudny.UseVisualStyleBackColor = true;
            this.RbtnTrudny.CheckedChanged += new System.EventHandler(this.RbtnTrudny_CheckedChanged);
            // 
            // LblLevelInfo
            // 
            this.LblLevelInfo.AutoSize = true;
            this.LblLevelInfo.Location = new System.Drawing.Point(79, 91);
            this.LblLevelInfo.Name = "LblLevelInfo";
            this.LblLevelInfo.Size = new System.Drawing.Size(130, 13);
            this.LblLevelInfo.TabIndex = 3;
            this.LblLevelInfo.Text = "Wybierz poziom trudności:";
            // 
            // BtnZapisz
            // 
            this.BtnZapisz.Location = new System.Drawing.Point(101, 311);
            this.BtnZapisz.Name = "BtnZapisz";
            this.BtnZapisz.Size = new System.Drawing.Size(75, 23);
            this.BtnZapisz.TabIndex = 4;
            this.BtnZapisz.Text = "Zapisz";
            this.BtnZapisz.UseVisualStyleBackColor = true;
            this.BtnZapisz.Click += new System.EventHandler(this.BtnZapisz_Click);
            // 
            // Opcje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 365);
            this.Controls.Add(this.BtnZapisz);
            this.Controls.Add(this.LblLevelInfo);
            this.Controls.Add(this.RbtnTrudny);
            this.Controls.Add(this.RbtnSredni);
            this.Controls.Add(this.RbtnLatwy);
            this.MaximizeBox = false;
            this.Name = "Opcje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opcje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RbtnLatwy;
        private System.Windows.Forms.RadioButton RbtnSredni;
        private System.Windows.Forms.RadioButton RbtnTrudny;
        private System.Windows.Forms.Label LblLevelInfo;
        private System.Windows.Forms.Button BtnZapisz;
    }
}