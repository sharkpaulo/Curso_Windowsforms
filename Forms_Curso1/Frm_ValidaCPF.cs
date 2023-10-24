using CursoWindonsFormsBibliotecas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaCPF : Form
    {
        public Frm_ValidaCPF()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = string.Empty;
            Lbl_Resultado.Text = string.Empty;
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            bool validaCpf = false;
            validaCpf =  ClsUteis.Valida(Msk_CPF.Text);
            if (validaCpf)
            {
                Lbl_Resultado.Text = "CPF VALIDO";
                Lbl_Resultado.ForeColor = Color.Green;
            }
            else 
            {
                Lbl_Resultado.Text = "CPF INVALIDO";
                Lbl_Resultado.ForeColor= Color.Red;
            }
        }
    }
}
