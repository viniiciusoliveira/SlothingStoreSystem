using SlothingStoreSystem.CamadaDeDadosGeral;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlothingStoreSystem.Telas
{
    public partial class RealizarVenda : Form
    {
        public RealizarVenda()
        {
            InitializeComponent();
        }

        CamadaDadosRoupas cdr = new CamadaDadosRoupas();
        ConfigFiltroMarca cfm = new ConfigFiltroMarca();
        ConfigFiltroCategoria cfc = new ConfigFiltroCategoria();
        ConfigFiltroTamanho cft = new ConfigFiltroTamanho();
        CamadaDadosRevededoras revededoras = new CamadaDadosRevededoras();
        ConfigsRealizarVenda configsRealizarVenda = new ConfigsRealizarVenda();


        public void DesabilitarCampos(bool valor) {

            this.txtProduto.Enabled = valor;
            this.txtPreco.Enabled = valor;
            this.txtQuantidade.Enabled = valor;
            this.txtTamanho.Enabled = valor;
            this.cmbRevendedora.Enabled = valor;
            this.btnRealizarVenda.Enabled = valor;
        }

        public void LimparCampos()
        {
            this.txtProduto.Text = string.Empty;
            this.txtPreco.Text = string.Empty;
            this.txtQuantidade.Text = string.Empty;
            this.txtTamanho.Text = string.Empty;
            this.cmbRevendedora.Text = string.Empty;
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



        private void button16_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

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

        public void atttotal()
        {
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListaEstoqueTemoReal.Rows.Count);

        }

        private void RealizarVenda_Load(object sender, EventArgs e)
        {
            cfc.AdicionarMarcasAoComboBoxFiltro(cmbBuscarCategoria);
            revededoras.AdicionarRevendorasAoComboBoxFiltro(cmbRevendedora);
            cfm.AdicionarMarcasAoComboBoxFiltro(cmbBuscarMarca);
            DesabilitarCampos(false);
            LimparCampos();
            atttotal();


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

        private void cmbBuscarMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegraDeFiltroBuscaEstoque();
        }

        private void cmbRevendedora_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataListaEstoqueTemoReal_DoubleClick(object sender, EventArgs e)
        {
            this.txtProduto.Text = Convert.ToString(this.dataListaEstoqueTemoReal.CurrentRow.Cells["NomeMarca"].Value) + " - " + Convert.ToString(this.dataListaEstoqueTemoReal.CurrentRow.Cells["NomeProduto"].Value);
            this.txtTamanho.Text = Convert.ToString(this.dataListaEstoqueTemoReal.CurrentRow.Cells["Tamanho"].Value);
            this.txtPreco.Text = Convert.ToString(this.dataListaEstoqueTemoReal.CurrentRow.Cells["PreçoProduto"].Value);
            this.txtIdProduto.Text = Convert.ToString(this.dataListaEstoqueTemoReal.CurrentRow.Cells["IdProduto"].Value);
            this.txtEstoqueAtual.Text = Convert.ToString(this.dataListaEstoqueTemoReal.CurrentRow.Cells["QuantidadeEmEstoque"].Value);
            DesabilitarCampos(true);

            this.tabControl1.SelectedIndex = 1;

        }

        private void cmbBuscarMarca_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            RegraDeFiltroBuscaEstoque();
        }

        private void dataListaEstoqueTemoReal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbBuscarCategoria_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            RegraDeFiltroBuscaEstoque();
        }

        private void cmbTamanho_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            RegraDeFiltroBuscaEstoque();
        
            
             
        }

        private void dataListaEstoqueTemoReal_DoubleClick_1(object sender, EventArgs e)
        {
            this.txtProduto.Text = Convert.ToString(this.dataListaEstoqueTemoReal.CurrentRow.Cells["NomeMarca"].Value) + " - " + Convert.ToString(this.dataListaEstoqueTemoReal.CurrentRow.Cells["NomeProduto"].Value);
            this.txtTamanho.Text = Convert.ToString(this.dataListaEstoqueTemoReal.CurrentRow.Cells["Tamanho"].Value);
            this.txtPreco.Text = Convert.ToString(this.dataListaEstoqueTemoReal.CurrentRow.Cells["PreçoProduto"].Value);
            this.txtIdProduto.Text = Convert.ToString(this.dataListaEstoqueTemoReal.CurrentRow.Cells["IdProduto"].Value);
            this.txtEstoqueAtual.Text = Convert.ToString(this.dataListaEstoqueTemoReal.CurrentRow.Cells["QuantidadeEmEstoque"].Value);
            DesabilitarCampos(true);
            this.tabControl1.SelectedIndex = 1;

        }

        private void btnRealizarVenda_Click(object sender, EventArgs e)
        {
            configsRealizarVenda.InserirVendaAtualizaEstoque(cmbRevendedora, txtProduto.Text, Convert.ToInt32(txtQuantidade.Text), txtTamanho.Text, Convert.ToDecimal(txtPreco.Text), cmbRevendedora.Text, txtIdProduto.Text, Convert.ToInt32(txtEstoqueAtual.Text));
            DesabilitarCampos(false);
            LimparCampos();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cfc.AdicionarMarcasAoComboBoxFiltro(cmbBuscarCategoria);
            revededoras.AdicionarRevendorasAoComboBoxFiltro(cmbRevendedora);
            cfm.AdicionarMarcasAoComboBoxFiltro(cmbBuscarMarca);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void cmbRevendedora_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
