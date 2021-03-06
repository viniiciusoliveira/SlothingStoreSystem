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
    class ConfigFiltroMarca
    {

        public string NomeCategoria { get; set; }
        public string NomeMarca { get; set; }
        public string NomeTamnho { get; set; }

        /*  ===================================================================== 
                    CARREGA TODAS AS MARCAS NO COMBOBOX
       =====================================================================  */
        public void AdicionarMarcasAoComboBoxFiltro(ComboBox comboBoxMarca)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = Conexao.Cn;
            try
            {
                cn.Open();
                var query = @"SELECT id, Nome
                              FROM Marcas
                               ORDER BY Nome";
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader leitorCarg = cmd.ExecuteReader();
                DataTable tableCarg = new DataTable();
                tableCarg.Load(leitorCarg);
                DataRow linha = tableCarg.NewRow();
                linha["id"] = "123";
                linha["Nome"] = "";
                tableCarg.Rows.InsertAt(linha, 0);
                comboBoxMarca.DataSource = tableCarg;
                comboBoxMarca.ValueMember = "id";
                comboBoxMarca.DisplayMember = "Nome";
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
                                 SOMENTE FILTROS MARCA 
       =====================================================================  */
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


        //
    }
}
