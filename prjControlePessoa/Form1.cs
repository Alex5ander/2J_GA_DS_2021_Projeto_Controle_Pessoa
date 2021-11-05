using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjControlePessoa
{
    public partial class Form1 : Form
    {

        PessoaFisica PF;
        PessoaJuridica PJ;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (rbPF.Checked)
            {
                PF = new PessoaFisica(txtNome.Text, txtEndereco.Text, txtDocumento.Text);
                if (PF.Validar())
                {
                    lbStatus.Text = "CPF válido";
                }
                else
                {
                    lbStatus.Text = "CPF inválido";
                }
            }
            else if (rbPJ.Checked)
            {
                PJ = new PessoaJuridica(txtNome.Text, txtEndereco.Text, txtDocumento.Text);
                if (PJ.Validar())
                {

                }
            }
        }
    }
}
