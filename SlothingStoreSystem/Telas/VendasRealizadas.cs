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
    public partial class VendasRealizadas : Form
    {
        public VendasRealizadas()
        {
            InitializeComponent();
        }

        ConfigVizualizarVenda cvv = new ConfigVizualizarVenda();
        CamadaDadosRoupas cdr = new CamadaDadosRoupas();
        ConfigFiltroMarca cfm = new ConfigFiltroMarca();
        ConfigFiltroCategoria cfc = new ConfigFiltroCategoria();
        ConfigFiltroTamanho cft = new ConfigFiltroTamanho();
        CamadaDadosRevededoras revededoras = new CamadaDadosRevededoras();


        public void atttotal1()
        {
            lblTotalVendasComissoes.Text = "Total de Registros: " + Convert.ToString(dataListaValoresEComissoes.Rows.Count);
        }

        public void atttotal2()
        {
            lblTotalVendasCompletas.Text = "Total de Registros: " + Convert.ToString(dataListaEstoqueTemoReal.Rows.Count);
        }


        public void FiltroBotaoBuscarComissaoEValor()
        {
            if(txtdataInicioComissao.Text != "    -  -" && txtDataFinalComissao.Text != "    -  -" && cmbRevendedora.Text == "")
            {
                cvv.BuscarInformacoesPelaDataDeInicioEFinalTotalEVendas_SemFiltroDeVendedor(dataListaValoresEComissoes, txtdataInicioComissao.Text, txtDataFinalComissao.Text);
                atttotal1();
            }
            else if (txtdataInicioComissao.Text != "    -  -" && txtDataFinalComissao.Text != "    -  -" && cmbRevendedora.Text != "")
            {
                cvv.BuscarInformacoesPelaDataDeInicioEFinalTotalEVendas_ComFiltroDeVendedor(dataListaValoresEComissoes, txtdataInicioComissao.Text, txtDataFinalComissao.Text, cmbRevendedora.Text);
                atttotal1();
            }
            else if (txtdataInicioComissao.Text == "    -  -" && txtDataFinalComissao.Text == "    -  -" && cmbRevendedora.Text != "")
            {
                cvv.BuscarInformacoesPelaDataDeInicioEFinalTotalEVendas_SomenteComOFiltroRevendedora(dataListaValoresEComissoes, cmbRevendedora.Text);
                atttotal1();
            }

            else if (txtdataInicioComissao.Text == "    -  -" && txtDataFinalComissao.Text == "    -  -" && cmbRevendedora.Text == "")
            {
                cvv.BuscarInformacoesPelaDataDeInicioEFinalTotalEVendas_SomenteComOFiltroRevendedora(dataListaValoresEComissoes, cmbRevendedora.Text);
                atttotal1();
            }

           

        }

        public void FiltroBotaoBuscarVendasCompletas()
        {
            if (txtdataInicio.Text != "    -  -" && txtDataFinal.Text != "    -  -" && cmbRevendedora1.Text == "")
            {
                cvv.BuscarInformacoesPelaDataDeInicioEFinalTotalEVendas_SemFiltroDeVendedor_VendasCompletas(dataListaEstoqueTemoReal, txtdataInicio.Text, txtDataFinal.Text);
                atttotal2();
            }
            else if (txtdataInicio.Text != "    -  -" && txtDataFinal.Text != "    -  -" && cmbRevendedora1.Text != "")
            {
                cvv.BuscarInformacoesPelaDataDeInicioEFinalTotalEVendas_ComFiltroDeVendedor_VendasCompletas(dataListaEstoqueTemoReal, txtdataInicio.Text, txtDataFinal.Text, cmbRevendedora1.Text);
                atttotal2();
            }
            else if (txtdataInicio.Text == "    -  -" && txtDataFinal.Text == "    -  -" && cmbRevendedora1.Text == "")
            {
                cvv.BuscarTodasVendasRealizadasSemFiltro(dataListaEstoqueTemoReal);
                atttotal2();
            }

            else if (txtdataInicio.Text == "    -  -" && txtDataFinal.Text == "    -  -" && cmbRevendedora1.Text != "")
            {
                cvv.BuscarInformacoesPelaDataDeInicioEFinalTotalEVendas_SomenteComOFiltroRevendedora_VendasCompletas(dataListaEstoqueTemoReal, cmbRevendedora1.Text);
                atttotal1();
            }


        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void VendasRealizadas_Load(object sender, EventArgs e)
        {
            cvv.BuscarTodasVendasRealizadasSemFiltro(dataListaEstoqueTemoReal);
            revededoras.AdicionarRevendorasAoComboBoxFiltro(cmbRevendedora);
            revededoras.AdicionarRevendorasAoComboBoxFiltro(cmbRevendedora1);
            cvv.BuscarOTotalDasVendasEComissoesSemFiltro(dataListaValoresEComissoes);
            atttotal2();
            atttotal1();

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

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void btnBuscarVendas_Click(object sender, EventArgs e)
        {
            FiltroBotaoBuscarVendasCompletas();     
                }

        private void btnTotalComissao_Click(object sender, EventArgs e)
        {
            FiltroBotaoBuscarComissaoEValor();
        }
    }
}
