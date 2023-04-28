namespace Views {

    public class Menu : Form
    {   
        private Label lblTexto;
        private Button botaoSair;
        private Button botaoProduto;

        private Button botaoEstoque;
        private Button botaoSaldo;
        
        
        public Menu()
        
        {

            
            // Configura a janela do programa
            Text = "MENU";
            Size = new System.Drawing.Size(230, 250);
            //BackColor = ColorTranslator.FromHtml("#6495ED");

            // Cria uma label para login
            lblTexto = new Label();
            lblTexto.Text = "MENU";
            lblTexto.Location = new System.Drawing.Point(90, 10);
            lblTexto.AutoSize = true;
            Controls.Add(lblTexto);

            botaoProduto = new Button();

            botaoProduto.Text = "PRODUTO";
            botaoProduto.Size = new System.Drawing.Size(100, 20);
            botaoProduto.Location = new System.Drawing.Point(60, 40);
            botaoProduto.Click += new EventHandler(botaoProduto_Click);
            Controls.Add(botaoProduto);

            botaoEstoque = new Button();

            botaoEstoque.Text = "ESTOQUE";
            botaoEstoque.Size = new System.Drawing.Size(100, 20);
            botaoEstoque.Location = new System.Drawing.Point(60, 80);
            botaoEstoque.Click += new EventHandler(botaoEstoque_Click);
            Controls.Add(botaoEstoque);

            botaoSaldo = new Button();

            botaoSaldo.Text = "SALDO";
            botaoSaldo.Size = new System.Drawing.Size(100, 20);
            botaoSaldo.Location = new System.Drawing.Point(60, 120);
            botaoSaldo.Click += new EventHandler(botaoSaldo_Click);
            Controls.Add(botaoSaldo);

            botaoSair = new Button();

            botaoSair.Text = "SAIR";
            botaoSair.Size = new System.Drawing.Size(100, 20);
            botaoSair.Location = new System.Drawing.Point(60, 160);
            botaoSair.Click += new EventHandler(botaoSair_Click);
            Controls.Add(botaoSair);


        }

        private void botaoSair_Click(object sender, EventArgs e)
        {
            Close();    
        }  

        public static void botaoProduto_Click(object sender, EventArgs e) {
            new ListaProduto();        }

        public static void botaoEstoque_Click(object sender, EventArgs e) {
            new ListaEstoque();
        }
        public static void botaoSaldo_Click(object sender, EventArgs e) {
            new ListaSaldo();
        }
    }
}