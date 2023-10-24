using System;
using System.Collections.Generic;
using CursoWindonsFormsBibliotecas;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaSenha : Form
    {
        bool verSenhaTxt = false;
        public Frm_ValidaSenha()
        {
            InitializeComponent();
        }

        private void Frm_ValidaSenha_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Senha.Text = string.Empty;
            Lbl_Resultado.Text = string.Empty;
        }

        private void Txt_Senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            ClsUteis.ChecaForcaSenha verifica = new ClsUteis.ChecaForcaSenha();
            ClsUteis.ChecaForcaSenha.ForcaDaSenha forca;
            forca = verifica.GetForcaDaSenha(Txt_Senha.Text);
            Lbl_Resultado.Text = forca.ToString();

            if (Lbl_Resultado.Text == "Inaceitavel" || Lbl_Resultado.Text == "Fraca")
            {
                Lbl_Resultado.ForeColor = Color.Red;
            }

            if (Lbl_Resultado.Text == "Aceitavel")
            {
                Lbl_Resultado.ForeColor = Color.Blue;
            }

            if (Lbl_Resultado.Text == "Segura" || Lbl_Resultado.Text == "Forte")
            {
                Lbl_Resultado.ForeColor = Color.Green;
            }
        }

        private void Btn_VerSenha_Click(object sender, EventArgs e)
        {
            if (verSenhaTxt == false)
            {
                Txt_Senha.PasswordChar = '\0';
                Btn_VerSenha.Text = "Esconder Senha";
                verSenhaTxt = true;
            }
            else
            {
                Txt_Senha.PasswordChar = '*';
                Btn_VerSenha.Text = "Ver senha";
                verSenhaTxt = false;
            }
            
        }
    }
}
