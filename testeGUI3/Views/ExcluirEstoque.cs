namespace Views {
    public class ExcluirEstoque : Form {
        private Models.Estoque estoque;

        public ExcluirEstoque(int id) {
            estoque = Models.Estoque.Estoques.Find(p => p.Id == id);
            if (estoque != null) {
                DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja excluir o estoque " + estoque.Nome + "?", "Confirmação", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) {
                    Models.Estoque.Estoques.Remove(estoque);
                    MessageBox.Show("Estoque excluído com sucesso.");
                }
            } else {
                MessageBox.Show("Estoque não encontrado.");
            }
            this.Close();
        }
    }
}