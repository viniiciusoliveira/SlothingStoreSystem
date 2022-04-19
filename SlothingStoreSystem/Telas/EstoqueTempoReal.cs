using SlothingStoreSystem.CamadaDeDadosGeral;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlothingStoreSystem.Telas
{
    public partial class EstoqueTempoReal : Form
    {
        public EstoqueTempoReal()
        {
            InitializeComponent();
        }

        CamadaDadosRoupas cdr = new CamadaDadosRoupas();
        ConfigFiltroMarca cfm = new ConfigFiltroMarca();
        ConfigFiltroCategoria cfc = new ConfigFiltroCategoria();
        ConfigFiltroTamanho cft = new ConfigFiltroTamanho();
        ConfigVizualizarVenda cvv = new ConfigVizualizarVenda();


        public void atttotal()
        {
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListaEstoqueTemoReal.Rows.Count);

        }


        public void RegraDeFiltroBuscaEstoque()
        {
            // --> FILTROS UNICOS //

            // SE TUDO ESTIVER SEM FILTRO
            if (cmbBuscarMarca.Text == "" && cmbBuscarCategoria.Text == "" && cmbTamanho.Text == "")
            {
                cdr.PesquisarTudSemFiltro(dataListaEstoqueTemoReal);
                atttotal();
            }
            // SE SOMENTE A MARCA 
            else if (cmbBuscarMarca.Text != "" && cmbBuscarCategoria.Text == "" && cmbTamanho.Text == "")
            {
                cfm.PesquisarProdutoComSomenteFiltroMarca(dataListaEstoqueTemoReal, cmbBuscarMarca.Text);
                atttotal();
            }
            // SE SOMENTE A CATEGORIA 
            else if (cmbBuscarMarca.Text == "" && cmbBuscarCategoria.Text != "" && cmbTamanho.Text == "")
            {
                cfc.PesquisarProdutoComSomenteFiltroCategoria(dataListaEstoqueTemoReal, cmbBuscarCategoria.Text);
                atttotal();
            }
            // SE SOMENTE A TAMANHO 
            else if (cmbBuscarMarca.Text == "" && cmbBuscarCategoria.Text == "" && cmbTamanho.Text != "")
            {
                cft.PesquisarProdutoComSomenteFiltroTamnho(dataListaEstoqueTemoReal, cmbTamanho.Text);
                atttotal();
            }

            // SE TIVER DOIS FILTROS


            // SE TIVER FILTRADO MARCA E CATEGORIA
            else if (cmbBuscarMarca.Text != "" && cmbBuscarCategoria.Text != "" && cmbTamanho.Text == "")
            {
                cfc.PesquisarProdutoComSomenteFiltroDeMarcaComCategoria(dataListaEstoqueTemoReal, cmbBuscarCategoria.Text, cmbBuscarMarca.Text);
                atttotal();
            }
            // SE TIVER MARCA E TAMANHO
            else if (cmbBuscarMarca.Text != "" && cmbBuscarCategoria.Text == "" && cmbTamanho.Text != "")
            {
                cft.PesquisarProdutoComFiltroTamnhoeMarcaa(dataListaEstoqueTemoReal, cmbBuscarMarca.Text, cmbTamanho.Text);
                atttotal();
            }
            // SE TIVER CATEGORIA E TAMANHO
            else if (cmbBuscarMarca.Text == "" && cmbBuscarCategoria.Text != "" && cmbTamanho.Text != "")
            {
                cfc.PesquisarComFiltroTamnhoECategoria(dataListaEstoqueTemoReal, cmbBuscarCategoria.Text, cmbTamanho.Text);
                atttotal();
            }

            // SE TIVER TODOS COM FILTRO

            else if (cmbBuscarMarca.Text != "" && cmbBuscarCategoria.Text != "" && cmbTamanho.Text != "")
            {
                cft.PesquisarProdutoComeFiltroTamnhoDeMarcaComCategoria(dataListaEstoqueTemoReal, cmbBuscarCategoria.Text, cmbBuscarMarca.Text, cmbTamanho.Text);
                atttotal();
            }
        }


        public void DesabilitarFiltros(bool valor)
        {
            this.lblBuscarMarca.Visible = valor;
            this.lblcmbBuscarCategoria.Visible = valor;
            this.cmbBuscarMarca.Visible = valor;
            this.cmbBuscarCategoria.Visible = valor;
            this.lblTamanho.Visible = valor;
            this.cmbTamanho.Visible = valor;
        }

        public void FiltrosBuscaAvançada(bool valor)
        {
            this.lblBuscarMarca.Visible = valor;
            this.lblcmbBuscarCategoria.Visible = valor;
            this.cmbBuscarMarca.Visible = valor;
            this.cmbBuscarCategoria.Visible = valor;
            this.lblTamanho.Visible = true;
            this.cmbTamanho.Visible = true;
        }

        public void FiltrosBuscaSimples()
        {
            this.lblTamanho.Visible = true;
            this.cmbTamanho.Visible = true;
        }


        private void EstoqueTempoReal_Load(object sender, EventArgs e)
        {
            cfc.AdicionarMarcasAoComboBoxFiltro(cmbBuscarCategoria);
            atttotal();

        }

        private void linklblBuscaSimples_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FiltrosBuscaSimples();
            FiltrosBuscaAvançada(false);
            this.cmbBuscarMarca.Text = string.Empty;
            this.cmbBuscarCategoria.Text = string.Empty;

        }

        private void linklblBuscaAvançada_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FiltrosBuscaAvançada(true);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var opcao = MessageBox.Show("Deseja realmente sair?", "Lanchonete Central", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcao == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void cmbBuscarCategoria_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbBuscarMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

            RegraDeFiltroBuscaEstoque();
            RegraDeFiltroBuscaEstoque();

        }

        private void cmbBuscarMarca_Click(object sender, EventArgs e)
        {
            cfm.AdicionarMarcasAoComboBoxFiltro(cmbBuscarMarca);

        }

        private void cmbBuscarCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegraDeFiltroBuscaEstoque();
        }

        private void cmbTamanho_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegraDeFiltroBuscaEstoque();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void dataListaEstoqueTemoReal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }





        //
    }

}
