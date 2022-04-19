using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlothingStoreSystem.CamadaDeDadosGeral
{
    class ConfigsRealizarVenda
    {

        public string Produto { get; set; }
        public string Tamanho { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public string Revendedora { get; set; }
        public decimal Comissao { get; set; }
        public int EstoqueAtual { get; set; }





        public void InserirVendaAtualizaEstoque(ComboBox combo, string produto, int quantidade, string tamanho, decimal preco, string revendedora, string idproduto, int estoqueatual)
        {

            this.Produto = produto;
            this.Tamanho = tamanho;
            this.Preco = preco;
            this.Quantidade = quantidade;
            this.Revendedora = revendedora;
            this.EstoqueAtual = estoqueatual;
            var cn = new SqlConnection();
            cn.ConnectionString = Conexao.Cn;


            var validacaodeestoque = estoqueatual - quantidade;

            
            var querySeForDona = @"INSERT INTO VendasRealizadas(idVenda, idProduto, Produto, Quantidade, Tamanho, Preco, Revendedora, ComissaoPelaVenda, DataVenda, PrecoUnitario)
                                                        VALUES
                                                         (NEWID(), @IdProduto, @NomeProduto, @Quantidade, @Tamanho, (@Preco * @Quantidade), @Revendedora, (@Preco * @Quantidade),GETDATE(), @Preco)";
           
            
            var queryUpdateEstoque = @"UPDATE A SET QuantidadeEmEstoque = @EstoqueAtual - @Quantidade FROM Produtos a WHERE id = @idProduto";



            var querySeNaoForDona = @"INSERT INTO VendasRealizadas(idVenda, idProduto, Produto, Quantidade, Tamanho, Preco, Revendedora, ComissaoPelaVenda, DataVenda, PrecoUnitario)
                                                        VALUES
                                                         (NEWID(), @IdProduto, @NomeProduto, @Quantidade, @Tamanho, (@Preco * @Quantidade), @Revendedora, (@Preco * 0.15 * @Quantidade) ,GETDATE(), @Preco)";


            try
            {
                    
                if(combo.Text == "") {
                    MessageBox.Show("É preciso que você insira um vendedora para a venda!!", " Admin/Loja - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(estoqueatual < 1)
                {
                    MessageBox.Show("Você não possui estoque disponivel deste produto!", " Admin/Loja - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(validacaodeestoque < 0)
                {
                    MessageBox.Show("Você não possui estoque disponivel para essa quantidade de Produto!\n\nPRODUTO: " + produto + "\nESTOQUE ATUAL: ["+ estoqueatual +"] itens.", " Admin/Loja - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else { 
                DialogResult opcao = MessageBox.Show("Deseja realmente realizar essa venda?", "Realizando venda - Admin/Loja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               
                    if (opcao == DialogResult.Yes) { 


                    if (revendedora == "Patricia/Dona")
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(querySeForDona, cn);
                    cmd.Parameters.AddWithValue("@NomeProduto", produto);
                    cmd.Parameters.AddWithValue("@IdProduto", idproduto);
                    cmd.Parameters.AddWithValue("@Quantidade", Convert.ToInt32(quantidade));
                    cmd.Parameters.AddWithValue("@Tamanho", tamanho);
                    cmd.Parameters.AddWithValue("@Preco", Convert.ToDecimal(preco));
                    cmd.Parameters.AddWithValue("@Revendedora", revendedora);
                    cmd.Parameters.AddWithValue("@EstoqueAtual", Convert.ToInt32(estoqueatual));

                            cmd.ExecuteNonQuery();
                    cn.Close();
                }
                else
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(querySeNaoForDona, cn);
                    cmd.Parameters.AddWithValue("@NomeProduto", produto);
                    cmd.Parameters.AddWithValue("@IdProduto", idproduto);
                    cmd.Parameters.AddWithValue("@Quantidade", Convert.ToInt32(quantidade));
                    cmd.Parameters.AddWithValue("@Tamanho", tamanho);
                    cmd.Parameters.AddWithValue("@Preco", Convert.ToDecimal(preco));
                    cmd.Parameters.AddWithValue("@Revendedora", revendedora);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                }
                        cn.Open();
                        SqlCommand cmd2 = new SqlCommand(queryUpdateEstoque, cn);
                        cmd2.Parameters.AddWithValue("@EstoqueAtual", Convert.ToInt32(estoqueatual));
                        cmd2.Parameters.AddWithValue("@Quantidade", Convert.ToInt32(quantidade));
                        cmd2.Parameters.AddWithValue("@IdProduto", idproduto);
                        cmd2.ExecuteNonQuery();
                        cn.Close();

        MessageBox.Show("Venda realizada com sucesso!", "Admin/Loja - Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    else
                {
                    MessageBox.Show("Operação cancelada", "Cancelamento de Venda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                }
            }

             catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: [" + ex + "]", " Admin/Loja - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();

                }
            }
        }

  
    
    
    


        //
    
    }


}

