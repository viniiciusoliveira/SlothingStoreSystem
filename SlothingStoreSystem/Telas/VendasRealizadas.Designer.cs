
namespace SlothingStoreSystem.Telas
{
    partial class VendasRealizadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendasRealizadas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTotalVendasCompletas = new System.Windows.Forms.Label();
            this.btnBuscarVendas = new System.Windows.Forms.Button();
            this.cmbRevendedora1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtdataInicio = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dataListaEstoqueTemoReal = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTotalVendasComissoes = new System.Windows.Forms.Label();
            this.btnTotalComissao = new System.Windows.Forms.Button();
            this.cmbRevendedora = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataFinalComissao = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdataInicioComissao = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataListaValoresEComissoes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabcontrol.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaEstoqueTemoReal)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaValoresEComissoes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button16);
            this.panel1.Controls.Add(this.button15);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 52);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(160, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(484, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "ACOMPANHAMENTO DE VENDAS E COMISSÕES";
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
            this.button16.Location = new System.Drawing.Point(902, 1);
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
            this.button15.Location = new System.Drawing.Point(960, 0);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(52, 52);
            this.button15.TabIndex = 2;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // tabcontrol
            // 
            this.tabcontrol.Controls.Add(this.tabPage1);
            this.tabcontrol.Controls.Add(this.tabPage2);
            this.tabcontrol.Location = new System.Drawing.Point(2, 71);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(1012, 414);
            this.tabcontrol.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTotalVendasCompletas);
            this.tabPage1.Controls.Add(this.btnBuscarVendas);
            this.tabPage1.Controls.Add(this.cmbRevendedora1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtDataFinal);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txtdataInicio);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.dataListaEstoqueTemoReal);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1004, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vendas Realizadas";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblTotalVendasCompletas
            // 
            this.lblTotalVendasCompletas.AutoSize = true;
            this.lblTotalVendasCompletas.Location = new System.Drawing.Point(696, 55);
            this.lblTotalVendasCompletas.Name = "lblTotalVendasCompletas";
            this.lblTotalVendasCompletas.Size = new System.Drawing.Size(44, 15);
            this.lblTotalVendasCompletas.TabIndex = 42;
            this.lblTotalVendasCompletas.Text = "label16";
            // 
            // btnBuscarVendas
            // 
            this.btnBuscarVendas.BackColor = System.Drawing.Color.Gray;
            this.btnBuscarVendas.FlatAppearance.BorderSize = 0;
            this.btnBuscarVendas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarVendas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarVendas.Location = new System.Drawing.Point(884, 28);
            this.btnBuscarVendas.Name = "btnBuscarVendas";
            this.btnBuscarVendas.Size = new System.Drawing.Size(114, 25);
            this.btnBuscarVendas.TabIndex = 41;
            this.btnBuscarVendas.Text = "Buscar";
            this.btnBuscarVendas.UseVisualStyleBackColor = false;
            this.btnBuscarVendas.Click += new System.EventHandler(this.btnBuscarVendas_Click);
            // 
            // cmbRevendedora1
            // 
            this.cmbRevendedora1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRevendedora1.FormattingEnabled = true;
            this.cmbRevendedora1.Location = new System.Drawing.Point(672, 13);
            this.cmbRevendedora1.Name = "cmbRevendedora1";
            this.cmbRevendedora1.Size = new System.Drawing.Size(172, 23);
            this.cmbRevendedora1.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(529, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 23);
            this.label9.TabIndex = 39;
            this.label9.Text = "REVENDEDORA:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(176, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(383, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(401, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Ano-Mês-data";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(194, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Ano-Mês-data";
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDataFinal.Location = new System.Drawing.Point(397, 13);
            this.txtDataFinal.Mask = "0000-00-00";
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(76, 25);
            this.txtDataFinal.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(302, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 22);
            this.label14.TabIndex = 33;
            this.label14.Text = "Data Final:";
            // 
            // txtdataInicio
            // 
            this.txtdataInicio.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtdataInicio.Location = new System.Drawing.Point(191, 12);
            this.txtdataInicio.Mask = "0000-00-00";
            this.txtdataInicio.Name = "txtdataInicio";
            this.txtdataInicio.Size = new System.Drawing.Size(75, 25);
            this.txtdataInicio.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(87, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 22);
            this.label15.TabIndex = 31;
            this.label15.Text = "Data Inicial:";
            // 
            // dataListaEstoqueTemoReal
            // 
            this.dataListaEstoqueTemoReal.AllowUserToAddRows = false;
            this.dataListaEstoqueTemoReal.AllowUserToDeleteRows = false;
            this.dataListaEstoqueTemoReal.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataListaEstoqueTemoReal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaEstoqueTemoReal.Location = new System.Drawing.Point(3, 76);
            this.dataListaEstoqueTemoReal.Name = "dataListaEstoqueTemoReal";
            this.dataListaEstoqueTemoReal.ReadOnly = true;
            this.dataListaEstoqueTemoReal.RowTemplate.Height = 25;
            this.dataListaEstoqueTemoReal.Size = new System.Drawing.Size(998, 310);
            this.dataListaEstoqueTemoReal.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblTotalVendasComissoes);
            this.tabPage2.Controls.Add(this.btnTotalComissao);
            this.tabPage2.Controls.Add(this.cmbRevendedora);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtDataFinalComissao);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtdataInicioComissao);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dataListaValoresEComissoes);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1004, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Total Vendas - Comissoes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTotalVendasComissoes
            // 
            this.lblTotalVendasComissoes.AutoSize = true;
            this.lblTotalVendasComissoes.Location = new System.Drawing.Point(696, 61);
            this.lblTotalVendasComissoes.Name = "lblTotalVendasComissoes";
            this.lblTotalVendasComissoes.Size = new System.Drawing.Size(44, 15);
            this.lblTotalVendasComissoes.TabIndex = 43;
            this.lblTotalVendasComissoes.Text = "label16";
            // 
            // btnTotalComissao
            // 
            this.btnTotalComissao.BackColor = System.Drawing.Color.Gray;
            this.btnTotalComissao.FlatAppearance.BorderSize = 0;
            this.btnTotalComissao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalComissao.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTotalComissao.Location = new System.Drawing.Point(853, 25);
            this.btnTotalComissao.Name = "btnTotalComissao";
            this.btnTotalComissao.Size = new System.Drawing.Size(114, 25);
            this.btnTotalComissao.TabIndex = 42;
            this.btnTotalComissao.Text = "Buscar";
            this.btnTotalComissao.UseVisualStyleBackColor = false;
            this.btnTotalComissao.Click += new System.EventHandler(this.btnTotalComissao_Click);
            // 
            // cmbRevendedora
            // 
            this.cmbRevendedora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRevendedora.FormattingEnabled = true;
            this.cmbRevendedora.Location = new System.Drawing.Point(604, 23);
            this.cmbRevendedora.Name = "cmbRevendedora";
            this.cmbRevendedora.Size = new System.Drawing.Size(172, 23);
            this.cmbRevendedora.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(461, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 23);
            this.label8.TabIndex = 29;
            this.label8.Text = "REVENDEDORA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(108, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(315, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(333, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ano-Mês-data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(126, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ano-Mês-data";
            // 
            // txtDataFinalComissao
            // 
            this.txtDataFinalComissao.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtDataFinalComissao.Location = new System.Drawing.Point(329, 23);
            this.txtDataFinalComissao.Mask = "0000-00-00";
            this.txtDataFinalComissao.Name = "txtDataFinalComissao";
            this.txtDataFinalComissao.Size = new System.Drawing.Size(76, 25);
            this.txtDataFinalComissao.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(234, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 22;
            this.label1.Text = "Data Final:";
            // 
            // txtdataInicioComissao
            // 
            this.txtdataInicioComissao.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtdataInicioComissao.Location = new System.Drawing.Point(123, 22);
            this.txtdataInicioComissao.Mask = "0000-00-00";
            this.txtdataInicioComissao.Name = "txtdataInicioComissao";
            this.txtdataInicioComissao.Size = new System.Drawing.Size(75, 25);
            this.txtdataInicioComissao.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Data Inicial:";
            // 
            // dataListaValoresEComissoes
            // 
            this.dataListaValoresEComissoes.AllowUserToAddRows = false;
            this.dataListaValoresEComissoes.AllowUserToDeleteRows = false;
            this.dataListaValoresEComissoes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataListaValoresEComissoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaValoresEComissoes.Location = new System.Drawing.Point(0, 79);
            this.dataListaValoresEComissoes.Name = "dataListaValoresEComissoes";
            this.dataListaValoresEComissoes.ReadOnly = true;
            this.dataListaValoresEComissoes.RowTemplate.Height = 25;
            this.dataListaValoresEComissoes.Size = new System.Drawing.Size(998, 301);
            this.dataListaValoresEComissoes.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(38, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 25);
            this.button1.TabIndex = 32;
            this.button1.Text = "Voltar Menu Principal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VendasRealizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1016, 524);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabcontrol);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VendasRealizadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VendasRealizadas";
            this.Load += new System.EventHandler(this.VendasRealizadas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabcontrol.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaEstoqueTemoReal)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaValoresEComissoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataListaEstoqueTemoReal;
        private System.Windows.Forms.DataGridView dataListaValoresEComissoes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtDataFinalComissao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtdataInicioComissao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRevendedora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscarVendas;
        private System.Windows.Forms.ComboBox cmbRevendedora1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox txtDataFinal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox txtdataInicio;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnTotalComissao;
        private System.Windows.Forms.Label lblTotalVendasCompletas;
        private System.Windows.Forms.Label lblTotalVendasComissoes;
    }
}