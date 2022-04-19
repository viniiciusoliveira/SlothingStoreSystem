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
    class CamadaDadosRevededoras
    {

        public void AdicionarRevendorasAoComboBoxFiltro(ComboBox comboBoxCategoria)
        {
            var cn = new SqlConnection();
            cn.ConnectionString = Conexao.Cn;
            try
            {
                cn.Open();
                var query = @"SELECT id, Nome FROM Revendedoras ORDER BY Nome";
                SqlCommand cmd = new SqlCommand(query, cn);
                SqlDataReader leitorCarg = cmd.ExecuteReader();
                DataTable tableCarg = new DataTable();
                tableCarg.Load(leitorCarg);
                DataRow linha = tableCarg.NewRow();
                linha["id"] = "123";
                linha["Nome"] = "";
                tableCarg.Rows.InsertAt(linha, 0);
                comboBoxCategoria.DataSource = tableCarg;
                comboBoxCategoria.ValueMember = "id";
                comboBoxCategoria.DisplayMember = "Nome";
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


    }
}
