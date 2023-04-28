namespace Views
{
    public class AlterarProduto : Form
    {
        private Label lblTexto;
        private Label lblNome;
        private Label lblPreco;
        private TextBox txtNome;
        private TextBox txtPreco;
        private Button botaoConfirmar;
        private Button botaoCancelar;

        private Models.Produto produto;

        public AlterarProduto(Models.Produto produto)
        {
            this.produto = produto;

            this.Text = "ALTERAR PRODUTO";
            this.Size = new System.Drawing.Size(280, 190);

            lblTexto = new Label();
            lblTexto.Text = "Alterar Produto";
            lblTexto.Location = new System.Drawing.Point(10, 5);
            lblTexto.AutoSize = true;
            this.Controls.Add(lblTexto);

            lblNome = new Label();
            lblNome.Text = "Nome:";
            lblNome.Location = new System.Drawing.Point(10, 35);
            lblNome.AutoSize = true;
            this.Controls.Add(lblNome);

            txtNome = new TextBox();
            txtNome.Location = new System.Drawing.Point(70, 32);
            txtNome.Size = new System.Drawing.Size(190, 20);
            txtNome.Text = produto.Nome;
            this.Controls.Add(txtNome);

            lblPreco = new Label();
            lblPreco.Text = "Preço:";
            lblPreco.Location = new System.Drawing.Point(10, 65);
            lblPreco.AutoSize = true;
            this.Controls.Add(lblPreco);

            txtPreco = new TextBox();
            txtPreco.Location = new System.Drawing.Point(70, 62);
            txtPreco.Size = new System.Drawing.Size(190, 20);
            txtPreco.Text = produto.Preco.ToString();
            this.Controls.Add(txtPreco);

            botaoConfirmar = new Button();
            botaoConfirmar.Text = "Confirmar";
            botaoConfirmar.Location = new System.Drawing.Point(70, 100);
            botaoConfirmar.Click += new EventHandler(Confirmar_Click);
            this.Controls.Add(botaoConfirmar);

            botaoCancelar = new Button();
            botaoCancelar.Text = "Cancelar";
            botaoCancelar.Location = new System.Drawing.Point(170, 100);
            botaoCancelar.Click += new EventHandler(Cancelar_Click);
            this.Controls.Add(botaoCancelar);

            this.ShowDialog();
        }

        public void Confirmar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            double preco = Double.Parse(txtPreco.Text);

            produto.Nome = nome;
            produto.Preco = preco;

            MessageBox.Show("Produto alterado com sucesso.");

            this.Close();
        }

        public void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}