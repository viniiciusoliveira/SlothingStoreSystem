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
    class ConfigFiltroTamanho
    {
       
        public string NomeCategoria { get; set; }
        public string NomeMarca { get; set; }
        public string NomeTamnho { get; set; }


        /*  ===================================================================== 
                      TODOS OS FILTROS --> MARCA + CATEGORIA + TAMANHO
         =====================================================================  */
        public void PesquisarProdutoComeFiltroTamnhoDeMarcaComCategoria(DataGridView data, string nome, string marca, string tamanho)
        {
            this.NomeMarca = marca;
            this.NomeCategoria = nome;
            this.NomeTamnho = tamanho;

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
                            WHERE b.Nome = @marca and c.EstacaoDoAno = @nomeCategoria and a.Tamanho = @tamanho";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@nomeCategoria", nome);
                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.Parameters.AddWithValue("@tamanho", tamanho);
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

       /*  ===================================================================== 
                             SOMENTE O FILTRO TAMANHO
         =====================================================================  */
                                                                                          
        public void PesquisarProdutoComSomenteFiltroTamnho(DataGridView data, string nome)
        {
            this.NomeTamnho = nome;

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
                            WHERE a.Tamanho = @nome";

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

        /*  ===================================================================== 
                            FILTRO TAMANHO E CATEGORIA
        =====================================================================  */

        public void PesquisarComFiltroTamnhoECategoria(DataGridView data, string nome, string tamanho)
        {
            this.NomeCategoria = nome;
            this.NomeTamnho = tamanho;

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
                            WHERE c.EstacaoDoAno = @nomeCategoria and a.Tamanho = @tamanho";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@nomeCategoria", nome);
                cmd.Parameters.AddWithValue("@tamanho", tamanho);
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


        /*  ===================================================================== 
                            FILTRO TAMANHO E MARCA
        =====================================================================  */


        public void PesquisarProdutoComFiltroTamnhoeMarcaa(DataGridView data,string marca, string tamanho)
        {
            this.NomeMarca = marca;
            this.NomeTamnho = tamanho;

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
                            WHERE b.Nome = @marca and a.Tamanho = @tamanho";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.Parameters.AddWithValue("@tamanho", tamanho);
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
