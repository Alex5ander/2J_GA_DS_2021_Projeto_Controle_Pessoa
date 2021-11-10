namespace prjControlePessoa
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.rbPF = new System.Windows.Forms.RadioButton();
            this.rbPJ = new System.Windows.Forms.RadioButton();
            this.lbStatus = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbLista = new System.Windows.Forms.ListBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNome.Location = new System.Drawing.Point(8, 33);
            this.txtNome.Margin = new System.Windows.Forms.Padding(0);
            this.txtNome.MaxLength = 45;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(458, 32);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEndereco.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEndereco.Location = new System.Drawing.Point(8, 90);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(458, 32);
            this.txtEndereco.TabIndex = 2;
            // 
            // rbPF
            // 
            this.rbPF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPF.Location = new System.Drawing.Point(4, 5);
            this.rbPF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbPF.Name = "rbPF";
            this.rbPF.Size = new System.Drawing.Size(231, 29);
            this.rbPF.TabIndex = 3;
            this.rbPF.TabStop = true;
            this.rbPF.Text = "Pessoa física";
            this.rbPF.UseVisualStyleBackColor = true;
            // 
            // rbPJ
            // 
            this.rbPJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbPJ.Location = new System.Drawing.Point(243, 5);
            this.rbPJ.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbPJ.Name = "rbPJ";
            this.rbPJ.Size = new System.Drawing.Size(211, 29);
            this.rbPJ.TabIndex = 4;
            this.rbPJ.TabStop = true;
            this.rbPJ.Text = "Pessoa jurídica";
            this.rbPJ.UseVisualStyleBackColor = true;
            // 
            // lbStatus
            // 
            this.lbStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbStatus.Location = new System.Drawing.Point(8, 469);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(458, 25);
            this.lbStatus.TabIndex = 5;
            this.lbStatus.Text = "Situação não validado";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnValidar
            // 
            this.btnValidar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValidar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.Location = new System.Drawing.Point(8, 424);
            this.btnValidar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(458, 45);
            this.btnValidar.TabIndex = 5;
            this.btnValidar.Text = "Validar documentos";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(8, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Número do documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocumento.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDocumento.Location = new System.Drawing.Point(8, 147);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(8);
            this.txtDocumento.MaxLength = 15;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(458, 32);
            this.txtDocumento.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rbPF);
            this.flowLayoutPanel1.Controls.Add(this.rbPJ);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 179);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(458, 42);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // lbLista
            // 
            this.lbLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLista.FormattingEnabled = true;
            this.lbLista.ItemHeight = 25;
            this.lbLista.Location = new System.Drawing.Point(8, 221);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(458, 152);
            this.lbLista.TabIndex = 9;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Location = new System.Drawing.Point(8, 379);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(458, 45);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 502);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.ShowIcon = false;
            this.Text = "Validador de documentos";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.RadioButton rbPF;
        private System.Windows.Forms.RadioButton rbPJ;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox lbLista;
        private System.Windows.Forms.Button btnAdicionar;
    }
}

