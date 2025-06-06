﻿namespace CadastroBanco
{
    partial class FormVisualizarCarrinho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVisualizarCarrinho));
            this.dataGridViewDados = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdVendida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.telefone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPagamento = new System.Windows.Forms.ComboBox();
            this.tbTotalPagar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLimparCarrinho = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataPrazo = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDados
            // 
            this.dataGridViewDados.AllowUserToAddRows = false;
            this.dataGridViewDados.AllowUserToDeleteRows = false;
            this.dataGridViewDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDados.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewDados.ColumnHeadersHeight = 40;
            this.dataGridViewDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.pagLivro,
            this.categoria,
            this.descricao,
            this.quantidade,
            this.preco,
            this.qtdVendida});
            this.dataGridViewDados.Location = new System.Drawing.Point(8, 12);
            this.dataGridViewDados.MultiSelect = false;
            this.dataGridViewDados.Name = "dataGridViewDados";
            this.dataGridViewDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDados.Size = new System.Drawing.Size(936, 408);
            this.dataGridViewDados.TabIndex = 10;
            this.dataGridViewDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDados_CellContentClick);
            this.dataGridViewDados.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDados_CellValueChanged);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 30;
            // 
            // pagLivro
            // 
            this.pagLivro.HeaderText = "Pag do livro";
            this.pagLivro.Name = "pagLivro";
            this.pagLivro.ReadOnly = true;
            this.pagLivro.Width = 60;
            // 
            // categoria
            // 
            this.categoria.HeaderText = "Categoria";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            this.categoria.Width = 75;
            // 
            // descricao
            // 
            this.descricao.HeaderText = "Peça";
            this.descricao.Name = "descricao";
            this.descricao.Width = 450;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "Quantidade em Estoque";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Width = 150;
            // 
            // preco
            // 
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            this.preco.Width = 60;
            // 
            // qtdVendida
            // 
            this.qtdVendida.HeaderText = "Quantidade Vendida";
            this.qtdVendida.Name = "qtdVendida";
            this.qtdVendida.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemover.BackColor = System.Drawing.Color.Salmon;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(12, 426);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(99, 40);
            this.btnRemover.TabIndex = 11;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFinalizarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarCompra.Location = new System.Drawing.Point(954, 319);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(199, 101);
            this.btnFinalizarCompra.TabIndex = 12;
            this.btnFinalizarCompra.Text = "Finalizar\r\ncompra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = false;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(950, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(950, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Telefone:";
            // 
            // nome
            // 
            this.nome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nome.Location = new System.Drawing.Point(953, 68);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(148, 20);
            this.nome.TabIndex = 16;
            // 
            // telefone
            // 
            this.telefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.telefone.Location = new System.Drawing.Point(953, 107);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(100, 20);
            this.telefone.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(951, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Pagamento";
            // 
            // cbPagamento
            // 
            this.cbPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPagamento.FormattingEnabled = true;
            this.cbPagamento.Items.AddRange(new object[] {
            "Realizado",
            "Pendente"});
            this.cbPagamento.Location = new System.Drawing.Point(953, 28);
            this.cbPagamento.Name = "cbPagamento";
            this.cbPagamento.Size = new System.Drawing.Size(121, 21);
            this.cbPagamento.TabIndex = 22;
            this.cbPagamento.SelectedIndexChanged += new System.EventHandler(this.CbPagamento_SelectedIndexChanged);
            // 
            // tbTotalPagar
            // 
            this.tbTotalPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTotalPagar.Enabled = false;
            this.tbTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalPagar.Location = new System.Drawing.Point(1053, 291);
            this.tbTotalPagar.Name = "tbTotalPagar";
            this.tbTotalPagar.Size = new System.Drawing.Size(100, 22);
            this.tbTotalPagar.TabIndex = 23;
            this.tbTotalPagar.TextChanged += new System.EventHandler(this.tbTotalPagar_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(951, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Total a pagar:";
            // 
            // btnLimparCarrinho
            // 
            this.btnLimparCarrinho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLimparCarrinho.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLimparCarrinho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCarrinho.Location = new System.Drawing.Point(117, 426);
            this.btnLimparCarrinho.Name = "btnLimparCarrinho";
            this.btnLimparCarrinho.Size = new System.Drawing.Size(64, 40);
            this.btnLimparCarrinho.TabIndex = 25;
            this.btnLimparCarrinho.Text = "Limpar";
            this.btnLimparCarrinho.UseVisualStyleBackColor = false;
            this.btnLimparCarrinho.Click += new System.EventHandler(this.btnLimparCarrinho_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pix",
            "Dinheiro",
            "Cartão Debito",
            "Cartão Crédito",
            "Transferência Bancária",
            "Crédito Loja"});
            this.comboBox1.Location = new System.Drawing.Point(954, 153);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(951, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Formas de Pagamento:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(950, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Data prevista de pagamento (opcional)";
            // 
            // dataPrazo
            // 
            this.dataPrazo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataPrazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataPrazo.Location = new System.Drawing.Point(953, 193);
            this.dataPrazo.Name = "dataPrazo";
            this.dataPrazo.Size = new System.Drawing.Size(200, 26);
            this.dataPrazo.TabIndex = 30;
            this.dataPrazo.Value = new System.DateTime(2024, 11, 26, 0, 0, 0, 0);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::CadastroBanco.Properties.Resources.duvida;
            this.pictureBox2.Location = new System.Drawing.Point(1131, 445);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FormVisualizarCarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 480);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dataPrazo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnLimparCarrinho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTotalPagar);
            this.Controls.Add(this.cbPagamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.dataGridViewDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVisualizarCarrinho";
            this.Text = "Carrinho";
            this.Load += new System.EventHandler(this.FormVisualizarCarrinho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDados;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox telefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPagamento;
        private System.Windows.Forms.TextBox tbTotalPagar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLimparCarrinho;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dataPrazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdVendida;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}