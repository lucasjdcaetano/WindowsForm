using System;
using System.Windows.Forms;

namespace Views {
    public class Programa
    {   
        private Label lblTexto;
        private TextBox txtDados;

        private Label lblNome;
        private TextBox txtNome;
        private Label lblPreco;
        private TextBox txtPreco;
        //#SAIR
        private Button botaoSair;

        //#INCLUIR
        public Form formIncluir;
        private Button botaoIncluir;

        //#ALTERAR
        public Form formAlterar;
        private Button botaoAlterar;
        
        //#PRODUTO
        public Form formListaProduto;
        private Button botaoProduto;

        //#EXCLUIR
        private Button botaoExcluir;

        private Button botaoConfirmar;

        private Button botaoCancelar;
        // Evento que é chamado quando o botão de enviar é clicado
    
        //***********LISTA PRODUTO************
        private void Incluir_Click(object sender, EventArgs e)
        {
            //formListaProduto.Close();    
            formIncluir = new Form();
            
            formIncluir.Text = "INCLUIR PRODUTO";
            formIncluir.Size = new System.Drawing.Size(380, 380);
            formIncluir.BackColor = ColorTranslator.FromHtml("#6495ED");
        
            lblTexto = new Label();
            lblTexto.Text = "Incluir Produto";
            lblTexto.Location = new System.Drawing.Point(10, 10);
            lblTexto.AutoSize = true;
            formIncluir.Controls.Add(lblTexto);

            // Cria uma label para nome
            lblNome = new Label();
            lblNome.Text = "Nome:";
            lblNome.Location = new System.Drawing.Point(10, 40);
            lblNome.AutoSize = true;
            formIncluir.Controls.Add(lblNome);

            // Cria uma caixa de texto para nome
            txtNome = new TextBox();
            txtNome.Location = new System.Drawing.Point(50, 40);
            txtNome.Size = new System.Drawing.Size(300, 20);
            formIncluir.Controls.Add(txtNome);

            // Cria uma label para nome
            lblPreco = new Label();
            lblPreco.Text = "Preço:";
            lblPreco.Location = new System.Drawing.Point(10, 80);
            lblPreco.AutoSize = true;
            formIncluir.Controls.Add(lblPreco);

            // Cria uma caixa de texto para nome
            txtPreco = new TextBox();
            txtPreco.Location = new System.Drawing.Point(50, 80);
            txtPreco.Size = new System.Drawing.Size(300, 20);
            formIncluir.Controls.Add(txtPreco);

            botaoConfirmar = new Button();

            botaoConfirmar.Text = "Cancelar";
            botaoConfirmar.Location = new System.Drawing.Point(180, 300);
            botaoConfirmar.Click += new EventHandler(Excluir_Click);
            formIncluir.Controls.Add(botaoConfirmar);

            botaoCancelar = new Button();

            botaoCancelar.Text = "Confirmar";
            botaoCancelar.Location = new System.Drawing.Point(260, 300);
            botaoCancelar.Click += new EventHandler(voltar_Click);
            formIncluir.Controls.Add(botaoCancelar);


            formIncluir.Show();
        }
        private void Alterar_Click(object sender, EventArgs e)
        {
            //formListaProduto.Close();    
            formAlterar = new Form();
            
            formAlterar.Text = "ALTERAR PRODUTO";
            formAlterar.Size = new System.Drawing.Size(380, 380);
            formAlterar.BackColor = ColorTranslator.FromHtml("#6495ED");


            formAlterar.Show();
        }
        private void Excluir_Click(object sender, EventArgs e)
        {
            
        }  
        private void voltar_Click(object sender, EventArgs e)
        {
            formListaProduto.Close();    
        }  

        static void Main()
        {
            Application.Run(new Menu());

            

        }
    }
}