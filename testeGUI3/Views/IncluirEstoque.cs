namespace Views
{
    public class IncluirEstoque : Form 
    {
        private Label lblTexto;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblPreco;
        private TextBox txtPreco;
        private Button botaoConfirmar;
        private Button botaoCancelar;
        public IncluirEstoque(){  
            
            this.Text = "INCLUIR ESTOQUE";
            this.Size = new System.Drawing.Size(380, 200);
        
            lblTexto = new Label();
            lblTexto.Text = "Incluir Estoque";
            lblTexto.Location = new System.Drawing.Point(10, 10);
            lblTexto.AutoSize = true;
            this.Controls.Add(lblTexto);

            // Cria uma label para nome
            lblNome = new Label();
            lblNome.Text = "Nome:";
            lblNome.Location = new System.Drawing.Point(10, 40);
            lblNome.AutoSize = true;
            this.Controls.Add(lblNome);

            // Cria uma caixa de texto para nome
            txtNome = new TextBox();
            txtNome.Location = new System.Drawing.Point(50, 40);
            txtNome.Size = new System.Drawing.Size(300, 20);
            this.Controls.Add(txtNome);

            botaoConfirmar = new Button();

            botaoConfirmar.Text = "Confirmar";
            botaoConfirmar.Location = new System.Drawing.Point(100, 120);
            botaoConfirmar.Click += new EventHandler(Confimar_Click);
            this.Controls.Add(botaoConfirmar);

            botaoCancelar = new Button();

            botaoCancelar.Text = "Cancelar";
            botaoCancelar.Location = new System.Drawing.Point(200, 120);
            botaoCancelar.Click += new EventHandler(Cancelar_Click);
            this.Controls.Add(botaoCancelar);


            this.ShowDialog();
        }
        private void Confimar_Click(object sender, EventArgs e)
        {
            new Models.Estoque(
                txtNome.Text
            );
            this.Close();
        }
        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();    
        }  
    }
}