using CursoWindonsFormsBibliotecas;
using System;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_ValidaCPF2 : Form
    {
        public Frm_ValidaCPF2()
        {
            InitializeComponent();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_CPF.Text = string.Empty;
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            var vConteudo = Msk_CPF.Text;
            vConteudo = vConteudo.Replace(".", "").Replace("-", "").Trim();

            if (vConteudo == "")
            {
                MessageBox.Show("Você precisa digitar um CPF", "Mensagem De Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (vConteudo.Length != 11)
                {
                    MessageBox.Show("O CPF precisa de 11 digitos", "Mensagem De Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Deseja Validar o CPF", "Pergunta validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool validaCpf = false;
                        validaCpf = ClsUteis.Valida(Msk_CPF.Text);
                        if (validaCpf)
                        {
                            MessageBox.Show("CPF VALIDO", "Mensagem De Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("CPF INVALIDO", "Mensagem De Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }             
            }        
        }

        private void Frm_ValidaCPF2_Load(object sender, EventArgs e)
        {

        }
    }
}
