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
    class CamadaDadosRoupas
    {

        public string NomeCategoria { get; set; }
        public string NomeMarca { get; set; }





        // METODO QUE ALIMENTA AS INFIORMAÇÕES DO FILTRO CATEGORIAS
        public void AdicionarCategoriasAoComboBoxFiltro(ComboBox comboBox, string nomeMarca)
        {
            this.NomeMarca = nomeMarca;

            var cn = new SqlConnection();
            cn.ConnectionString = Conexao.Cn;


            try
            {
                cn.Open();
                var query = @"SELECT a.id, a.EstacaoDoAno + ' - ' + a.Sexo as EstacaoDoAno FROM Categorias a
                               JOIN Marcas b ON a.idMarca = b.id
                                  WHERE b.Nome = @nome
	                                ORDER BY a.EstacaoDoAno";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@nome", nomeMarca);
                SqlDataReader leitorCarg = cmd.ExecuteReader();
                DataTable tableCarg = new DataTable();
                tableCarg.Load(leitorCarg);
                DataRow linha = tableCarg.NewRow();
                linha["id"] = "123";
                linha["EstacaoDoAno"] = "";
                tableCarg.Rows.InsertAt(linha, 0);
                comboBox.DataSource = tableCarg;
                comboBox.ValueMember = "id";
                comboBox.DisplayMember = "EstacaoDoAno";

                cn.Close();



            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro: [" + ex + "]", " Lanchonete Central - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

            }

        }


        // METODO QUE FAZ A BUSCA SEM FILTRO
        public void PesquisarProdutoComSomenteFiltroMarca(DataGridView data, string nome)
        {


            this.NomeMarca = nome;

            var cn = new SqlConnection();
            cn.ConnectionString = Conexao.Cn;

            try
            {

                cn.Open();
                var query = @"SELECT 
                                a.id as IdProduto
                            ,b.Nome as NomeMarca
                            ,c.EstacaoDoAno as DescriçãoCategoria
                            ,d.Descricao as DescriçãoSubCategoria
                            ,a.Descricao as NomeProduto
                            ,convert(decimal(18,2),a.Preco) as PreçoProduto
                            ,a.Tamanho as Tamanho
                            ,a.QuantidadeEmEstoque as QuantidadeEmEstoque
                            ,a.UltimaCargaDeEstoque as UltimaCargaDeEstoque
                            FROM Produtos a
                            JOIN Marcas b on a.idMarca = b.id
                            JOIN Categorias c on a.idCategoria = c.id
                            JOIN SubCategorias D on a.idSubCategoria = d.id
                            WHERE b.Nome = @nome";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@nome", nome);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                data.DataSource = dt;

                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro: [" + ex + "]", " Lanchonete Central - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

        

        
        }

        // busca completa sem filtro --> Usado quando abrir a parte de estoque ou quando remover todos os filtros.
        public void BuscaCompletaDeTodoEstoqueSemFiltro(DataGridView data)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = Conexao.Cn;

            try
            {

                cn.Open();
                var query = @"SELECT 
                            TOP 50
                            a.id as IdProduto
                            ,b.Nome as NomeMarca
                            ,c.EstacaoDoAno as DescriçãoCategoria
                            ,d.Descricao as DescriçãoSubCategoria
                            ,a.Descricao as NomeProduto
                            ,convert(decimal(18,2),a.Preco) as PreçoProduto
                            ,a.Tamanho as Tamanho
                            ,a.QuantidadeEmEstoque as QuantidadeEmEstoque
                            ,a.UltimaCargaDeEstoque as UltimaCargaDeEstoque
                            FROM Produtos a
                            JOIN Marcas b on a.idMarca = b.id
                            JOIN Categorias c on a.idCategoria = c.id
                            JOIN SubCategorias D on a.idSubCategoria = d.id
							ORDER BY b.Nome";
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                data.DataSource = dt;

                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro: [" + ex + "]", " Lanchonete Central - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

        }


        public void PesquisarTudSemFiltro(DataGridView data) { 
            
            
            var cn = new SqlConnection();
            cn.ConnectionString = Conexao.Cn;

            try
            {

                cn.Open();
                var query = @"SELECT 
                            TOP 50
                            a.id as IdProduto
                            ,b.Nome as NomeMarca
                            ,c.EstacaoDoAno as DescriçãoCategoria
                            ,d.Descricao as DescriçãoSubCategoria
                            ,a.Descricao as NomeProduto
                            ,convert(decimal(18,2),a.Preco) as PreçoProduto
                            ,a.Tamanho as Tamanho
                            ,a.QuantidadeEmEstoque as QuantidadeEmEstoque
                            ,a.UltimaCargaDeEstoque as UltimaCargaDeEstoque
                            FROM Produtos a
                            JOIN Marcas b on a.idMarca = b.id
                            JOIN Categorias c on a.idCategoria = c.id
                            JOIN SubCategorias D on a.idSubCategoria = d.id
							ORDER BY b.Nome";
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                data.DataSource = dt;

                cn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro: [" + ex + "]", " Lanchonete Central - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }

        }
                

    
        
        //







    }
     }

