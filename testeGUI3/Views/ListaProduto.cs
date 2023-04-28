namespace Views {
    public class ListaProduto : Form {
        private Label lblTexto;
        private Button botaoSair;
        private Button botaoIncluir;
        private Button botaoAlterar;
        private Button botaoExcluir;
        private Button botaoConfirmar;        
	    private ListView listView;

        public ListaProduto() {
            this.Text = "LISTA PRODUTO";
            this.Size = new System.Drawing.Size(380, 380);
        
            lblTexto = new Label();
            lblTexto.Text = "Lista Produto";
            lblTexto.Location = new System.Drawing.Point(30, 5);
            lblTexto.AutoSize = true;
            this.Controls.Add(lblTexto);

            listView = new ListView();
            listView.Columns.Add("Id");
            listView.Columns.Add("Nome");
            listView.Columns.Add("Preço");
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView.View = View.Details;
            listView.FullRowSelect = true;

            this.ListRefresh();
            // listView.Items.Add(new ListViewItem(new string[] { "2", "gordo", "800"}));

            listView.Location = new Point(30, 30);
            listView.Size = new System.Drawing.Size(300, 250);
            listView.View = View.Details;

            
            this.Controls.Add(listView);

            botaoIncluir = new Button();

            botaoIncluir.Text = "Incluir";
            botaoIncluir.Location = new System.Drawing.Point(20, 300);
            botaoIncluir.Click += new EventHandler(Incluir_Click);
            this.Controls.Add(botaoIncluir);

            botaoAlterar = new Button();

            botaoAlterar.Text = "Alterar";
            botaoAlterar.Location = new System.Drawing.Point(100, 300);
            botaoAlterar.Click += new EventHandler(Alterar_Click);
            this.Controls.Add(botaoAlterar);

            botaoExcluir = new Button();

            botaoExcluir.Text = "Excluir";
            botaoExcluir.Location = new System.Drawing.Point(180, 300);
            botaoExcluir.Click += new EventHandler(Excluir_Click);
            this.Controls.Add(botaoExcluir);

            botaoSair = new Button();

            botaoSair.Text = "Voltar";
            botaoSair.Location = new System.Drawing.Point(260, 300);
            botaoSair.Click += new EventHandler(voltar_Click);
            this.Controls.Add(botaoSair);

            this.ShowDialog();
        }

        public void ListRefresh() {
            listView.Items.Clear();
            foreach(Models.Produto p in Models.Produto.Produtos) {
                listView.Items.Add(
                    new ListViewItem(new [] {
                        p.Id.ToString(), p.Nome, p.Preco.ToString()
                    }) 
                );    
            }
        }

        public void Incluir_Click(object sender, EventArgs e) {
            new IncluirProduto();
            this.ListRefresh();
        }

        public void Alterar_Click(object sender, EventArgs e) {
            if (listView.SelectedItems.Count > 0) {
                string idItem = listView.SelectedItems[0].Text;
                int id = Int32.Parse(idItem);
                Models.Produto produto = Models.Produto.Produtos.Find(p => p.Id == id);
                new AlterarProduto(produto);
                this.ListRefresh();
            } else {
                MessageBox.Show("Selecione um item da lista para alterar.");
            }
        }
        

        public void Excluir_Click(object sender, EventArgs e) {
            //string idItem = listView.SelectedItems[0].SubItems[1].Text;
            //string idItem = listView.SelectedItems[0].Text;
            //new ExcluirProduto(Int32.Parse(idItem));
            if (listView.SelectedItems.Count > 0) {
                string idItem = listView.SelectedItems[0].Text;
                int id = Int32.Parse(idItem);
                //Models.Produto produto = Models.Produto.Produtos.Find(p => p.Id == id);
                //new ExcluirProduto(Int32.Parse(idItem));
                var confirmResult = MessageBox.Show("Tem certeza que deseja excluir o produto selecionado?", "Confirmação", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes) {
                    Models.Produto produto = Models.Produto.Produtos.Find(p => p.Id == id);
                    Models.Produto.Produtos.Remove(produto);
                    this.ListRefresh();
                }
            } else {
                MessageBox.Show("Selecione um item da lista para excluir.");
            }            
            this.ListRefresh();
        }

        public void voltar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}