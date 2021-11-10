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

        IPessoa p;
        BindingList<IPessoa> pessoas = new BindingList<IPessoa>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            p = (IPessoa) lbLista.SelectedItem;
            if (p == null) return;
            if (p.Validar())
            {
                lbStatus.Text = p.documento + " válido";
                lbStatus.ForeColor = Color.Green;
            }
            else
            {
                lbStatus.Text = p.documento + " inválido";
                lbStatus.ForeColor = Color.Red;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (rbPF.Checked)
            {
                p = new PessoaFisica(txtNome.Text, txtEndereco.Text, txtDocumento.Text);
            }
            else if (rbPJ.Checked)
            {
                p = new PessoaJuridica(txtNome.Text, txtEndereco.Text, txtDocumento.Text);
            }
            pessoas.Add(p);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbLista.DataSource = pessoas;
            lbLista.DisplayMember = "Documento";
        }

    }
}
