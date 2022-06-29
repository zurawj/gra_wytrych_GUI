
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
            this.TbtnTrudny = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // RbtnLatwy
            // 
            this.RbtnLatwy.AutoSize = true;
            this.RbtnLatwy.Location = new System.Drawing.Point(28, 64);
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
            this.RbtnSredni.Location = new System.Drawing.Point(28, 88);
            this.RbtnSredni.Name = "RbtnSredni";
            this.RbtnSredni.Size = new System.Drawing.Size(55, 17);
            this.RbtnSredni.TabIndex = 1;
            this.RbtnSredni.TabStop = true;
            this.RbtnSredni.Text = "Średni";
            this.RbtnSredni.UseVisualStyleBackColor = true;
            this.RbtnSredni.CheckedChanged += new System.EventHandler(this.RbtnSredni_CheckedChanged);
            // 
            // TbtnTrudny
            // 
            this.TbtnTrudny.AutoSize = true;
            this.TbtnTrudny.Location = new System.Drawing.Point(28, 112);
            this.TbtnTrudny.Name = "TbtnTrudny";
            this.TbtnTrudny.Size = new System.Drawing.Size(58, 17);
            this.TbtnTrudny.TabIndex = 2;
            this.TbtnTrudny.TabStop = true;
            this.TbtnTrudny.Text = "Trudny";
            this.TbtnTrudny.UseVisualStyleBackColor = true;
            this.TbtnTrudny.CheckedChanged += new System.EventHandler(this.TbtnTrudny_CheckedChanged);
            // 
            // Opcje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TbtnTrudny);
            this.Controls.Add(this.RbtnSredni);
            this.Controls.Add(this.RbtnLatwy);
            this.Name = "Opcje";
            this.Text = "Opcje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RbtnLatwy;
        private System.Windows.Forms.RadioButton RbtnSredni;
        private System.Windows.Forms.RadioButton TbtnTrudny;
    }
}