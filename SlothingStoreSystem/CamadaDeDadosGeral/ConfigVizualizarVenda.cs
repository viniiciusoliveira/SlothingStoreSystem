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
    class ConfigVizualizarVenda
    {
        public string Produto { get; set; }
        public string Tamanho { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public string Revendedora { get; set; }
        public decimal Comissao { get; set; }
        public int EstoqueAtual { get; set; }
        public string Data1 { get; set; }
        public string Data2 { get; set; }


        // LISTA INICIAL COM TODOS OS DADOS DAS VENDAS
        public void BuscarTodasVendasRealizadasSemFiltro(DataGridView data)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = Conexao.Cn;


            var query = @"SELECT 
                            Produto as Produto
                            ,Quantidade as QuantidadeVendido
                            ,Tamanho as Tamanho
                            ,format(PrecoUnitario, 'c2', 'pt-br') as PreçoUnitario
                            ,format(Preco, 'c', 'pt-br') as PreçoTotalDaVenda
                            ,Revendedora as Revendedora
                            ,format(ComissaoPelaVenda, 'c', 'pt-br') as ComissaoPelaVenda
                            ,DataVenda as DataDaVenda
                            FROM VendasRealizadas
                            ORDER BY DataDaVenda DESC";
            try
            {
                cn.Open();
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
        // LISTA INICIAL COM TODOS OS DADOS DOS VALORES E COMISSOES

        public void BuscarOTotalDasVendasEComissoesSemFiltro(DataGridView data)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = Conexao.Cn;


            var query = @"SELECT 
                           SUM(CONVERT(DECIMAL(18,2), Preco)) as TotalDaVenda 
                           FROM VendasRealizadas";
            try
            {
                cn.Open();
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

        public void BuscarInformacoesPelaDataDeInicioEFinalTotalEVendas_SemFiltroDeVendedor(DataGridView data, string datainicio, string datafinal)
        {

            var cn = new SqlConnection();
            cn.ConnectionString = Conexao.Cn;


            var query = @"SELECT 
                           SUM(CONVERT(DECIMAL(18,2), Preco)) as TotalDaVenda 
                           FROM VendasRealizadas
                           WHERE DataVenda >= @datainicio and DataVenda <= @datafinal";

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@datainicio", datainicio);
                cmd.Parameters.AddWithValue("@datafinal", datafinal);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                data.DataSource = dt;
                cn.Close();
            }

            catch (Exception)
            {

                MessageBox.Show("Data não encontrada, tente outra data!", " Lanchonete Central - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

            }
        }

        public void BuscarInformacoesPelaDataDeInicioEFinalTotalEVendas_ComFiltroDeVendedor(DataGridView data, string datainicio, string datafinal, string vendedor)
        {

            var cn = new SqlConnection();
            cn.ConnectionString = Conexao.Cn;


            var query = @"SELECT 
                           SUM(CONVERT(DECIMAL(18,2), Preco)) as TotalDaVenda 
                           ,SUM(CONVERT(DECIMAL(18,2), ComissaoPelaVenda)) as TotalDeComissao
                           FROM VendasRealizadas
                           WHERE DataVenda >= @datainicio and DataVenda <= @datafinal and Revendedora = @revendedora";

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@datainicio", datainicio);
                cmd.Parameters.AddWithValue("@datafinal", datafinal);
                cmd.Parameters.AddWithValue("@revendedora", vendedor);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                data.DataSource = dt;
                cn.Close();
            }

            catch (Exception)
            {

                MessageBox.Show("Data não encontrada, tente outra data!", " Lanchonete Central - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 //MessageBox.Show(":" + ex);
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

            }
        }


        public void BuscarInformacoesPelaDataDeInicioEFinalTotalEVendas_SomenteComOFiltroRevendedora(DataGridView data, string vendedor)
        {

            var cn = new SqlConnection();
            cn.ConnectionString = Conexao.Cn;


            var query = @"SELECT 
                           SUM(CONVERT(DECIMAL(18,2), Preco)) as TotalDaVenda 
                           ,SUM(CONVERT(DECIMAL(18,2), ComissaoPelaVenda)) as TotalDeComissao
                           FROM VendasRealizadas
                           WHERE Revendedora = @revendedora";

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@revendedora", vendedor);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                data.DataSource = dt;
                cn.Close();
            }

            catch (Exception)
            {

                MessageBox.Show("data não encontrada, tente outra!", " Lanchonete Central - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show(":" + ex);
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

            }
        }

        // PARTE DE VENDAS COMPLETAS //


        public void BuscarInformacoesPelaDataDeInicioEFinalTotalEVendas_SemFiltroDeVendedor_VendasCompletas(DataGridView data, string datainicio, string datafinal)
        {

            var cn = new SqlConnection();
            cn.ConnectionString = Conexao.Cn;


            var query = @"SELECT 
                           Produto as Produto
                           ,Quantidade as QuantidadeVendido
                           ,Tamanho as Tamanho
                           ,format(PrecoUnitario, 'c2', 'pt-br') as PrecoUnitario
                           ,format(Preco, 'c2', 'pt-br') as PreçoDeVenda
                           ,Revendedora as Revendedora
                           ,format(ComissaoPelaVenda, 'c2', 'pt-br') as ComissaoPelaVenda
                           ,DataVenda as DataDaVenda
                           FROM VendasRealizadas
                           WHERE DataVenda >= @datainicio and DataVenda <= @datafinal
                            ORDER BY DataDaVenda DESC";

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@datainicio", datainicio);
                cmd.Parameters.AddWithValue("@datafinal", datafinal);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                data.DataSource = dt;
                cn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(":" + ex);

                //MessageBox.Show("Revendedora não encontrada, tente outra!", " Lanchonete Central - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

            }
        }

        public void BuscarInformacoesPelaDataDeInicioEFinalTotalEVendas_ComFiltroDeVendedor_VendasCompletas(DataGridView data, string datainicio, string datafinal, string vendedor)
        {

            var cn = new SqlConnection();
            cn.ConnectionString = Conexao.Cn;


            var query = @"SELECT 
                           Produto as Produto
                           ,Quantidade as QuantidadeVendido
                           ,Tamanho as Tamanho
                           ,format(PrecoUnitario, 'c2', 'pt-br') as PreçoUnitario
                           ,format(Preco, 'c2', 'pt-br') as PreçoDeVenda
                           ,Revendedora as Revendedora
                           ,format(ComissaoPelaVenda, 'c2', 'pt-br') as ComissaoPelaVenda
                           ,DataVenda as DataDaVenda
                           FROM VendasRealizadas
                           WHERE DataVenda >= @datainicio and DataVenda <= @datafinal and Revendedora = @revendedora
                            ORDER BY DataDaVenda DESC";

            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@datainicio", datainicio);
                cmd.Parameters.AddWithValue("@datafinal", datafinal);
                cmd.Parameters.AddWithValue("@revendedora", vendedor);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                data.DataSource = dt;
                cn.Close();
            }

            catch (Exception ex)
            {

                //MessageBox.Show("Revendedora não encontrada, tente outra!", " Lanchonete Central - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(":" + ex);
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

            }
        }


        public void BuscarInformacoesPelaDataDeInicioEFinalTotalEVendas_SomenteComOFiltroRevendedora_VendasCompletas(DataGridView data, string vendedor)
        {

            var cn = new SqlConnection();
            cn.ConnectionString = Conexao.Cn;


            var query = @"SELECT 
                           Produto as Produto
                           ,Quantidade as QuantidadeVendido
                           ,Tamanho as Tamanho
                           ,format(PrecoUnitario, 'c2', 'pt-br') as PreçoUnitario
                           ,format(Preco, 'c2', 'pt-br') as PreçoDeVenda
                           ,Revendedora as Revendedora
                           ,format(ComissaoPelaVenda, 'c2', 'pt-br') as ComissaoPelaVenda
                           ,DataVenda as DataDaVenda
                           FROM VendasRealizadas
                           WHERE Revendedora = @revendedora
                           ORDER BY DataDaVenda DESC";
            


            try
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@revendedora", vendedor);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                data.DataSource = dt;
                cn.Close();
            }

            catch (Exception ex)
            {

                //MessageBox.Show("Revendedora não encontrada, tente outra!", " Lanchonete Central - Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(":" + ex);
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

            }
        }




        //
    }
}
    

