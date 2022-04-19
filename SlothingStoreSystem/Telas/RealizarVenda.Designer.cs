
namespace SlothingStoreSystem.Telas
{
    partial class RealizarVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealizarVenda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.txtEstoqueAtual = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRealizarVenda = new System.Windows.Forms.Button();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.cmbRevendedora = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataListaEstoqueTemoReal = new System.Windows.Forms.DataGridView();
            this.cmbTamanho = new System.Windows.Forms.ComboBox();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.cmbBuscarCategoria = new System.Windows.Forms.ComboBox();
            this.lblcmbBuscarCategoria = new System.Windows.Forms.Label();
            this.cmbBuscarMarca = new System.Windows.Forms.ComboBox();
            this.lblBuscarMarca = new System.Windows.Forms.Label();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaEstoqueTemoReal)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.button15);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 58);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "REALIZAR VENDA";
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Gray;
            this.button16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button16.BackgroundImage")));
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Image = ((System.Drawing.Image)(resources.GetObject("button16.Image")));
            this.button16.Location = new System.Drawing.Point(848, 3);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(52, 52);
            this.button16.TabIndex = 3;
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button15.BackgroundImage")));
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.Location = new System.Drawing.Point(906, 3);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(52, 52);
            this.button15.TabIndex = 2;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // txtEstoqueAtual
            // 
            this.txtEstoqueAtual.Location = new System.Drawing.Point(844, 162);
            this.txtEstoqueAtual.Name = "txtEstoqueAtual";
            this.txtEstoqueAtual.Size = new System.Drawing.Size(100, 23);
            this.txtEstoqueAtual.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.btnRealizarVenda);
            this.tabPage2.Controls.Add(this.txtTamanho);
            this.tabPage2.Controls.Add(this.txtPreco);
            this.tabPage2.Controls.Add(this.txtQuantidade);
            this.tabPage2.Controls.Add(this.txtProduto);
            this.tabPage2.Controls.Add(this.cmbRevendedora);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(947, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Realizar Venda";
            // 
            // btnRealizarVenda
            // 
            this.btnRealizarVenda.BackColor = System.Drawing.Color.Gray;
            this.btnRealizarVenda.FlatAppearance.BorderSize = 0;
            this.btnRealizarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarVenda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRealizarVenda.Location = new System.Drawing.Point(667, 286);
            this.btnRealizarVenda.Name = "btnRealizarVenda";
            this.btnRealizarVenda.Size = new System.Drawing.Size(273, 38);
            this.btnRealizarVenda.TabIndex = 30;
            this.btnRealizarVenda.Text = "Realizar Venda";
            this.btnRealizarVenda.UseVisualStyleBackColor = false;
            this.btnRealizarVenda.Click += new System.EventHandler(this.btnRealizarVenda_Click);
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(116, 163);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(131, 22);
            this.txtTamanho.TabIndex = 29;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(82, 230);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(247, 22);
            this.txtPreco.TabIndex = 26;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(137, 104);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(131, 22);
            this.txtQuantidade.TabIndex = 22;
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(108, 51);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(532, 22);
            this.txtProduto.TabIndex = 21;
            // 
            // cmbRevendedora
            // 
            this.cmbRevendedora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRevendedora.FormattingEnabled = true;
            this.cmbRevendedora.Location = new System.Drawing.Point(519, 234);
            this.cmbRevendedora.Name = "cmbRevendedora";
            this.cmbRevendedora.Size = new System.Drawing.Size(172, 22);
            this.cmbRevendedora.TabIndex = 28;
            this.cmbRevendedora.SelectedIndexChanged += new System.EventHandler(this.cmbRevendedora_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(379, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "REVENDEDORA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(11, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "PREÇO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "TAMANHO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(11, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "QUANTIDADE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "PRODUTO:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 25);
            this.button1.TabIndex = 31;
            this.button1.Text = "Voltar Menu Principal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTotal);
            this.tabPage1.Controls.Add(this.dataListaEstoqueTemoReal);
            this.tabPage1.Controls.Add(this.cmbTamanho);
            this.tabPage1.Controls.Add(this.lblTamanho);
            this.tabPage1.Controls.Add(this.cmbBuscarCategoria);
            this.tabPage1.Controls.Add(this.lblcmbBuscarCategoria);
            this.tabPage1.Controls.Add(this.cmbBuscarMarca);
            this.tabPage1.Controls.Add(this.lblBuscarMarca);
            this.tabPage1.Controls.Add(this.txtIdProduto);
            this.tabPage1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(947, 344);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Procurar Roupa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataListaEstoqueTemoReal
            // 
            this.dataListaEstoqueTemoReal.AllowUserToAddRows = false;
            this.dataListaEstoqueTemoReal.AllowUserToDeleteRows = false;
            this.dataListaEstoqueTemoReal.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataListaEstoqueTemoReal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaEstoqueTemoReal.Location = new System.Drawing.Point(3, 74);
            this.dataListaEstoqueTemoReal.Name = "dataListaEstoqueTemoReal";
            this.dataListaEstoqueTemoReal.ReadOnly = true;
            this.dataListaEstoqueTemoReal.RowTemplate.Height = 25;
            this.dataListaEstoqueTemoReal.Size = new System.Drawing.Size(945, 267);
            this.dataListaEstoqueTemoReal.TabIndex = 24;
            this.dataListaEstoqueTemoReal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListaEstoqueTemoReal_CellContentClick);
            this.dataListaEstoqueTemoReal.DoubleClick += new System.EventHandler(this.dataListaEstoqueTemoReal_DoubleClick_1);
            // 
            // cmbTamanho
            // 
            this.cmbTamanho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTamanho.FormattingEnabled = true;
            this.cmbTamanho.Items.AddRange(new object[] {
            "",
            "P",
            "M",
            "G",
            "GG",
            "1",
            "2",
            "3",
            "4",
            "6",
            "8",
            "10",
            "12",
            "14",
            "16"});
            this.cmbTamanho.Location = new System.Drawing.Point(749, 16);
            this.cmbTamanho.Name = "cmbTamanho";
            this.cmbTamanho.Size = new System.Drawing.Size(128, 22);
            this.cmbTamanho.TabIndex = 23;
            this.cmbTamanho.SelectedIndexChanged += new System.EventHandler(this.cmbTamanho_SelectedIndexChanged_1);
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTamanho.Location = new System.Drawing.Point(644, 18);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(102, 23);
            this.lblTamanho.TabIndex = 22;
            this.lblTamanho.Text = "TAMANHO:";
            // 
            // cmbBuscarCategoria
            // 
            this.cmbBuscarCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarCategoria.FormattingEnabled = true;
            this.cmbBuscarCategoria.Location = new System.Drawing.Point(478, 15);
            this.cmbBuscarCategoria.Name = "cmbBuscarCategoria";
            this.cmbBuscarCategoria.Size = new System.Drawing.Size(128, 22);
            this.cmbBuscarCategoria.TabIndex = 21;
            this.cmbBuscarCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarCategoria_SelectedIndexChanged_1);
            // 
            // lblcmbBuscarCategoria
            // 
            this.lblcmbBuscarCategoria.AutoSize = true;
            this.lblcmbBuscarCategoria.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcmbBuscarCategoria.Location = new System.Drawing.Point(368, 17);
            this.lblcmbBuscarCategoria.Name = "lblcmbBuscarCategoria";
            this.lblcmbBuscarCategoria.Size = new System.Drawing.Size(107, 23);
            this.lblcmbBuscarCategoria.TabIndex = 20;
            this.lblcmbBuscarCategoria.Text = "CATEGORIA:";
            // 
            // cmbBuscarMarca
            // 
            this.cmbBuscarMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarMarca.FormattingEnabled = true;
            this.cmbBuscarMarca.Items.AddRange(new object[] {
            "Selecione"});
            this.cmbBuscarMarca.Location = new System.Drawing.Point(200, 14);
            this.cmbBuscarMarca.Name = "cmbBuscarMarca";
            this.cmbBuscarMarca.Size = new System.Drawing.Size(128, 22);
            this.cmbBuscarMarca.TabIndex = 19;
            this.cmbBuscarMarca.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarMarca_SelectedIndexChanged_1);
            // 
            // lblBuscarMarca
            // 
            this.lblBuscarMarca.AutoSize = true;
            this.lblBuscarMarca.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuscarMarca.Location = new System.Drawing.Point(120, 16);
            this.lblBuscarMarca.Name = "lblBuscarMarca";
            this.lblBuscarMarca.Size = new System.Drawing.Size(77, 23);
            this.lblBuscarMarca.TabIndex = 18;
            this.lblBuscarMarca.Text = "MARCA:";
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Location = new System.Drawing.Point(422, 142);
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(100, 22);
            this.txtIdProduto.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(955, 372);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(786, 53);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(42, 14);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "label7";
            // 
            // RealizarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtEstoqueAtual);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RealizarVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RealizarVenda";
            this.Load += new System.EventHandler(this.RealizarVenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaEstoqueTemoReal)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox txtEstoqueAtual;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.ComboBox cmbRevendedora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataListaEstoqueTemoReal;
        private System.Windows.Forms.ComboBox cmbTamanho;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.ComboBox cmbBuscarCategoria;
        private System.Windows.Forms.Label lblcmbBuscarCategoria;
        private System.Windows.Forms.ComboBox cmbBuscarMarca;
        private System.Windows.Forms.Label lblBuscarMarca;
        private System.Windows.Forms.TextBox txtIdProduto;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnRealizarVenda;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTotal;
    }
}