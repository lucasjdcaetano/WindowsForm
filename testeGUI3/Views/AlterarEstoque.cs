namespace Views
{
    public class AlterarEstoque : Form
    {
        private Label lblTexto;
        private Label lblNome;
        private Label lblPreco;
        private TextBox txtNome;
        private TextBox txtPreco;
        private Button botaoConfirmar;
        private Button botaoCancelar;

        private Models.Estoque estoque;

        public AlterarEstoque(Models.Estoque estoque)
        {
            this.estoque = estoque;

            this.Text = "ALTERAR ESTOQUE";
            this.Size = new System.Drawing.Size(280, 190);

            lblTexto = new Label();
            lblTexto.Text = "Alterar Estoque";
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
            txtNome.Text = estoque.Nome;
            this.Controls.Add(txtNome);

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

            estoque.Nome = nome;

            MessageBox.Show("Estoque alterado com sucesso.");

            this.Close();
        }

        public void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}