
namespace SlothingStoreSystem.Telas
{
    partial class EstoqueTempoReal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstoqueTempoReal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.dataListaEstoqueTemoReal = new System.Windows.Forms.DataGridView();
            this.lblBuscarMarca = new System.Windows.Forms.Label();
            this.cmbBuscarMarca = new System.Windows.Forms.ComboBox();
            this.lblcmbBuscarCategoria = new System.Windows.Forms.Label();
            this.cmbBuscarCategoria = new System.Windows.Forms.ComboBox();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.cmbTamanho = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaEstoqueTemoReal)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(800, 52);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "ESTOQUE EM TEMPO REAL";
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
            this.button16.Location = new System.Drawing.Point(690, 0);
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
            this.button15.Location = new System.Drawing.Point(748, 0);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(52, 52);
            this.button15.TabIndex = 2;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // dataListaEstoqueTemoReal
            // 
            this.dataListaEstoqueTemoReal.AllowUserToAddRows = false;
            this.dataListaEstoqueTemoReal.AllowUserToDeleteRows = false;
            this.dataListaEstoqueTemoReal.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataListaEstoqueTemoReal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaEstoqueTemoReal.Location = new System.Drawing.Point(0, 156);
            this.dataListaEstoqueTemoReal.Name = "dataListaEstoqueTemoReal";
            this.dataListaEstoqueTemoReal.ReadOnly = true;
            this.dataListaEstoqueTemoReal.RowTemplate.Height = 25;
            this.dataListaEstoqueTemoReal.Size = new System.Drawing.Size(800, 415);
            this.dataListaEstoqueTemoReal.TabIndex = 2;
            this.dataListaEstoqueTemoReal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListaEstoqueTemoReal_CellContentClick);
            // 
            // lblBuscarMarca
            // 
            this.lblBuscarMarca.AutoSize = true;
            this.lblBuscarMarca.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBuscarMarca.Location = new System.Drawing.Point(0, 87);
            this.lblBuscarMarca.Name = "lblBuscarMarca";
            this.lblBuscarMarca.Size = new System.Drawing.Size(77, 23);
            this.lblBuscarMarca.TabIndex = 4;
            this.lblBuscarMarca.Text = "MARCA:";
            // 
            // cmbBuscarMarca
            // 
            this.cmbBuscarMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarMarca.FormattingEnabled = true;
            this.cmbBuscarMarca.Items.AddRange(new object[] {
            "Selecione"});
            this.cmbBuscarMarca.Location = new System.Drawing.Point(83, 87);
            this.cmbBuscarMarca.Name = "cmbBuscarMarca";
            this.cmbBuscarMarca.Size = new System.Drawing.Size(128, 23);
            this.cmbBuscarMarca.TabIndex = 8;
            this.cmbBuscarMarca.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarMarca_SelectedIndexChanged);
            this.cmbBuscarMarca.Click += new System.EventHandler(this.cmbBuscarMarca_Click);
            // 
            // lblcmbBuscarCategoria
            // 
            this.lblcmbBuscarCategoria.AutoSize = true;
            this.lblcmbBuscarCategoria.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcmbBuscarCategoria.Location = new System.Drawing.Point(235, 87);
            this.lblcmbBuscarCategoria.Name = "lblcmbBuscarCategoria";
            this.lblcmbBuscarCategoria.Size = new System.Drawing.Size(107, 23);
            this.lblcmbBuscarCategoria.TabIndex = 9;
            this.lblcmbBuscarCategoria.Text = "CATEGORIA:";
            // 
            // cmbBuscarCategoria
            // 
            this.cmbBuscarCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarCategoria.FormattingEnabled = true;
            this.cmbBuscarCategoria.Location = new System.Drawing.Point(348, 87);
            this.cmbBuscarCategoria.Name = "cmbBuscarCategoria";
            this.cmbBuscarCategoria.Size = new System.Drawing.Size(128, 23);
            this.cmbBuscarCategoria.TabIndex = 10;
            this.cmbBuscarCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarCategoria_SelectedIndexChanged);
            this.cmbBuscarCategoria.Click += new System.EventHandler(this.cmbBuscarCategoria_Click);
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTamanho.Location = new System.Drawing.Point(505, 87);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(102, 23);
            this.lblTamanho.TabIndex = 16;
            this.lblTamanho.Text = "TAMANHO:";
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
            this.cmbTamanho.Location = new System.Drawing.Point(614, 87);
            this.cmbTamanho.Name = "cmbTamanho";
            this.cmbTamanho.Size = new System.Drawing.Size(128, 23);
            this.cmbTamanho.TabIndex = 17;
            this.cmbTamanho.SelectedIndexChanged += new System.EventHandler(this.cmbTamanho_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(584, 577);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 30);
            this.button1.TabIndex = 32;
            this.button1.Text = "Voltar Menu Principal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(614, 135);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(38, 15);
            this.lblTotal.TabIndex = 33;
            this.lblTotal.Text = "label1";
            // 
            // EstoqueTempoReal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbTamanho);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.cmbBuscarCategoria);
            this.Controls.Add(this.lblcmbBuscarCategoria);
            this.Controls.Add(this.cmbBuscarMarca);
            this.Controls.Add(this.lblBuscarMarca);
            this.Controls.Add(this.dataListaEstoqueTemoReal);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EstoqueTempoReal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EstoqueTempoReal";
            this.Load += new System.EventHandler(this.EstoqueTempoReal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaEstoqueTemoReal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.DataGridView dataListaEstoqueTemoReal;
        private System.Windows.Forms.Label lblBuscarMarca;
        private System.Windows.Forms.ComboBox cmbBuscarMarca;
        private System.Windows.Forms.Label lblcmbBuscarCategoria;
        private System.Windows.Forms.ComboBox cmbBuscarCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.ComboBox cmbTamanho;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTotal;
    }
}