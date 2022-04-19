using SlothingStoreSystem.CamadaDeDadosGeral;
using SlothingStoreSystem.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlothingStoreSystem
    {
    public partial class MenuPrincipal : Form

    {
        Conexao conexao = new Conexao();

        public MenuPrincipal()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EstoqueTempoReal estoque = new EstoqueTempoReal();
            estoque.Show();
            this.Hide();
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

        private void btnVenda_Click(object sender, EventArgs e)
        {
            RealizarVenda realizarVenda = new RealizarVenda();
            realizarVenda.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VendasRealizadas vendasrealizaidas = new VendasRealizadas();
            vendasrealizaidas.Show();
            this.Hide();
        }
    }
}
