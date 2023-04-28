namespace Views {
    public class ExcluirProduto : Form {
        private Models.Produto produto;

        public ExcluirProduto(int id) {
            produto = Models.Produto.Produtos.Find(p => p.Id == id);
            if (produto != null) {
                DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir o produto " + produto.Nome + "?", "Confirmação", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {
                    Models.Produto.Produtos.Remove(produto);
                    MessageBox.Show("Produto excluído com sucesso.");
                }
            } else {
                MessageBox.Show("Produto não encontrado.");
            }
            this.Close();
        }
    }
}