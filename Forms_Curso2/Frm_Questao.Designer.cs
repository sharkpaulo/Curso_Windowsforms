﻿namespace CursoWindowsForms
{
    partial class Frm_Questao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Questao));
            this.Lbl_Questao = new System.Windows.Forms.Label();
            this.Btn_OK = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Questao
            // 
            this.Lbl_Questao.AutoSize = true;
            this.Lbl_Questao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Questao.Location = new System.Drawing.Point(18, 9);
            this.Lbl_Questao.Name = "Lbl_Questao";
            this.Lbl_Questao.Size = new System.Drawing.Size(281, 25);
            this.Lbl_Questao.TabIndex = 0;
            this.Lbl_Questao.Text = "Você deseja validar o CPF?";
            // 
            // Btn_OK
            // 
            this.Btn_OK.Location = new System.Drawing.Point(147, 60);
            this.Btn_OK.Name = "Btn_OK";
            this.Btn_OK.Size = new System.Drawing.Size(115, 23);
            this.Btn_OK.TabIndex = 1;
            this.Btn_OK.Text = "Sim.Continue";
            this.Btn_OK.UseVisualStyleBackColor = true;
            this.Btn_OK.Click += new System.EventHandler(this.Btn_OK_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(147, 89);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(115, 23);
            this.Btn_Cancelar.TabIndex = 2;
            this.Btn_Cancelar.Text = "Não.Pare";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::CursoWindowsForms.Properties.Resources.ponto_de_interrogacao;
            this.PictureBox1.Location = new System.Drawing.Point(12, 45);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(100, 86);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 3;
            this.PictureBox1.TabStop = false;
            // 
            // Frm_Questao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 143);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_OK);
            this.Controls.Add(this.Lbl_Questao);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Questao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questão";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Questao;
        private System.Windows.Forms.Button Btn_OK;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.PictureBox PictureBox1;
    }
}