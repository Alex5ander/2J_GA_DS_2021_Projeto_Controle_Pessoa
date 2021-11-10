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

        IPessoa pessoa;
        BindingList<IPessoa> pessoas = new BindingList<IPessoa>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (pessoa.Validar())
            {
                lbStatus.Text = pessoa.documento() + " válido";
                lbStatus.ForeColor = Color.Green;
            }
            else
            {
                lbStatus.Text = pessoa.documento() + " inválido";
                lbStatus.ForeColor = Color.Red;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (rbPF.Checked)
            {
                pessoa = new PessoaFisica(txtNome.Text, txtEndereco.Text, txtDocumento.Text);
            }
            else if (rbPJ.Checked)
            {
                pessoa = new PessoaJuridica(txtNome.Text, txtEndereco.Text, txtDocumento.Text);
            }
            pessoas.Add(pessoa);
            lbLista.DataSource = pessoas;
        }

    }
}
