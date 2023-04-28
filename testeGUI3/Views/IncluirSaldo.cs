using Models;
namespace Views
{
    public class IncluirSaldo : Form 
    {
        private Label lblTexto;
        private Label lblIdProduto;
        private TextBox txtIdProduto;
        private Label lblIdEstoque;
        private TextBox txtIdEstoque;
        private Label lblQuantidade;
        private TextBox txtQuantidade;        
        private Button botaoConfirmar;
        private Button botaoCancelar;
        private ListView listView;
        private List<Produto> produtos;
        private List<Estoque> estoques;
        

        public IncluirSaldo(List<Produto> produtos, List<Estoque> estoques)
        {
            this.produtos = produtos;
            this.estoques = estoques;
            
            
            //formListaProduto.Close();    
            
            this.Text = "INCLUIR SALDO";
            this.Size = new System.Drawing.Size(380, 300);
        
            lblTexto = new Label();
            lblTexto.Text = "Incluir Saldo";
            lblTexto.Location = new System.Drawing.Point(10, 10);
            lblTexto.AutoSize = true;
            this.Controls.Add(lblTexto);

            // Cria uma label para nome
            lblIdProduto = new Label();
            lblIdProduto.Text = "Id Produto:";
            lblIdProduto.Location = new System.Drawing.Point(10, 40);
            lblIdProduto.AutoSize = true;
            this.Controls.Add(lblIdProduto);

            // Cria uma caixa de texto para nome
            txtIdProduto = new TextBox();
            txtIdProduto.Location = new System.Drawing.Point(80, 40);
            txtIdProduto.Size = new System.Drawing.Size(100, 50);
            this.Controls.Add(txtIdProduto);

            lblIdEstoque = new Label();
            lblIdEstoque.Text = "Id Produto:";
            lblIdEstoque.Location = new System.Drawing.Point(10, 80);
            lblIdEstoque.AutoSize = true;
            this.Controls.Add(lblIdEstoque);

            // Cria uma caixa de texto para nome
            txtIdEstoque = new TextBox();
            txtIdEstoque.Location = new System.Drawing.Point(80, 80);
            txtIdEstoque.Size = new System.Drawing.Size(100, 50);
            this.Controls.Add(txtIdEstoque);

            // Cria uma label para nome
            lblQuantidade = new Label();
            lblQuantidade.Text = "Quantidade:";
            lblQuantidade.Location = new System.Drawing.Point(10, 120);
            lblQuantidade.AutoSize = true;
            this.Controls.Add(lblQuantidade);

            // Cria uma caixa de texto para nome
            txtQuantidade = new TextBox();
            txtQuantidade.Location = new System.Drawing.Point(80, 120);
            txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.Controls.Add(txtQuantidade);

            botaoConfirmar = new Button();

            botaoConfirmar.Text = "Confirmar";
            botaoConfirmar.Location = new System.Drawing.Point(100, 150);
            botaoConfirmar.Click += new EventHandler(Confimar_Click);
            this.Controls.Add(botaoConfirmar);

            botaoCancelar = new Button();

            botaoCancelar.Text = "Cancelar";
            botaoCancelar.Location = new System.Drawing.Point(200, 150);
            botaoCancelar.Click += new EventHandler(Cancelar_Click);
            this.Controls.Add(botaoCancelar);


            this.ShowDialog();
        }
        private void Confimar_Click(object sender, EventArgs e)
        {
            int idProduto = int.Parse(txtIdProduto.Text);
            int idEstoque = int.Parse(txtIdEstoque.Text);
            int quantidade = int.Parse(txtQuantidade.Text);

            // Verifica se os ids de produto e de estoque são válidos
            if (Produto.Produtos.Any(p => p.Id == idProduto) && Estoque.Estoques.Any(est => est.Id == idEstoque))
            {
                // Os ids são válidos, adiciona o item na lista
                new Models.Saldo(
                    idProduto,
                    idEstoque,
                    quantidade
                );
            }
            else
            {
                // Algum dos ids é inválido, exibe mensagem de erro
                MessageBox.Show("Id de produto ou de estoque inválido.");
            }
            this.Close();
        }
        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();    
        }  
    }
}