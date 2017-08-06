namespace TechWeek.Pedidos
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtTotalIPIItem = new System.Windows.Forms.TextBox();
            this.lblTotalIPIItem = new System.Windows.Forms.Label();
            this.txtTotalICMSItem = new System.Windows.Forms.TextBox();
            this.lblTotalICMSItem = new System.Windows.Forms.Label();
            this.txtReducaoBaseIPI = new System.Windows.Forms.TextBox();
            this.lblReducaoBaseIPI = new System.Windows.Forms.Label();
            this.txtBaseCalculoIPI = new System.Windows.Forms.TextBox();
            this.lblValorIPI = new System.Windows.Forms.Label();
            this.txtAliquotaIPI = new System.Windows.Forms.TextBox();
            this.lblAliquotaIPI = new System.Windows.Forms.Label();
            this.txtReducaoBaseICMS = new System.Windows.Forms.TextBox();
            this.lblReducaoBaseICMS = new System.Windows.Forms.Label();
            this.txtBaseCalculoICMS = new System.Windows.Forms.TextBox();
            this.lblValorICMS = new System.Windows.Forms.Label();
            this.txtAliquotaICMS = new System.Windows.Forms.TextBox();
            this.lblAliquotaICMS = new System.Windows.Forms.Label();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDataPedido = new System.Windows.Forms.TextBox();
            this.lblDataPedido = new System.Windows.Forms.Label();
            this.txtNumeroPedido = new System.Windows.Forms.TextBox();
            this.lblNumeroPedido = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotalIPI = new System.Windows.Forms.TextBox();
            this.lblTotalIPI = new System.Windows.Forms.Label();
            this.txtTotalICMS = new System.Windows.Forms.TextBox();
            this.lblTotalICMS = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lvwItensPedido = new System.Windows.Forms.ListView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdicionarItem);
            this.groupBox2.Controls.Add(this.btnCalcular);
            this.groupBox2.Controls.Add(this.txtTotalIPIItem);
            this.groupBox2.Controls.Add(this.lblTotalIPIItem);
            this.groupBox2.Controls.Add(this.txtTotalICMSItem);
            this.groupBox2.Controls.Add(this.lblTotalICMSItem);
            this.groupBox2.Controls.Add(this.txtReducaoBaseIPI);
            this.groupBox2.Controls.Add(this.lblReducaoBaseIPI);
            this.groupBox2.Controls.Add(this.txtBaseCalculoIPI);
            this.groupBox2.Controls.Add(this.lblValorIPI);
            this.groupBox2.Controls.Add(this.txtAliquotaIPI);
            this.groupBox2.Controls.Add(this.lblAliquotaIPI);
            this.groupBox2.Controls.Add(this.txtReducaoBaseICMS);
            this.groupBox2.Controls.Add(this.lblReducaoBaseICMS);
            this.groupBox2.Controls.Add(this.txtBaseCalculoICMS);
            this.groupBox2.Controls.Add(this.lblValorICMS);
            this.groupBox2.Controls.Add(this.txtAliquotaICMS);
            this.groupBox2.Controls.Add(this.lblAliquotaICMS);
            this.groupBox2.Controls.Add(this.txtValorUnitario);
            this.groupBox2.Controls.Add(this.lblValorUnitario);
            this.groupBox2.Controls.Add(this.txtProduto);
            this.groupBox2.Controls.Add(this.lblProduto);
            this.groupBox2.Location = new System.Drawing.Point(2, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 215);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Itens do Pedido";
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Location = new System.Drawing.Point(441, 175);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(119, 23);
            this.btnAdicionarItem.TabIndex = 20;
            this.btnAdicionarItem.Text = "&Adicionar Item";
            this.btnAdicionarItem.UseVisualStyleBackColor = true;
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(298, 175);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(119, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtTotalIPIItem
            // 
            this.txtTotalIPIItem.Location = new System.Drawing.Point(441, 140);
            this.txtTotalIPIItem.Name = "txtTotalIPIItem";
            this.txtTotalIPIItem.ReadOnly = true;
            this.txtTotalIPIItem.Size = new System.Drawing.Size(121, 20);
            this.txtTotalIPIItem.TabIndex = 19;
            this.txtTotalIPIItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalIPIItem
            // 
            this.lblTotalIPIItem.AutoSize = true;
            this.lblTotalIPIItem.Location = new System.Drawing.Point(438, 124);
            this.lblTotalIPIItem.Name = "lblTotalIPIItem";
            this.lblTotalIPIItem.Size = new System.Drawing.Size(73, 13);
            this.lblTotalIPIItem.TabIndex = 18;
            this.lblTotalIPIItem.Text = "Total IPI Item:";
            // 
            // txtTotalICMSItem
            // 
            this.txtTotalICMSItem.Location = new System.Drawing.Point(441, 87);
            this.txtTotalICMSItem.Name = "txtTotalICMSItem";
            this.txtTotalICMSItem.ReadOnly = true;
            this.txtTotalICMSItem.Size = new System.Drawing.Size(121, 20);
            this.txtTotalICMSItem.TabIndex = 17;
            this.txtTotalICMSItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalICMSItem
            // 
            this.lblTotalICMSItem.AutoSize = true;
            this.lblTotalICMSItem.Location = new System.Drawing.Point(438, 71);
            this.lblTotalICMSItem.Name = "lblTotalICMSItem";
            this.lblTotalICMSItem.Size = new System.Drawing.Size(86, 13);
            this.lblTotalICMSItem.TabIndex = 16;
            this.lblTotalICMSItem.Text = "Total ICMS Item:";
            // 
            // txtReducaoBaseIPI
            // 
            this.txtReducaoBaseIPI.Location = new System.Drawing.Point(154, 140);
            this.txtReducaoBaseIPI.Name = "txtReducaoBaseIPI";
            this.txtReducaoBaseIPI.Size = new System.Drawing.Size(121, 20);
            this.txtReducaoBaseIPI.TabIndex = 5;
            this.txtReducaoBaseIPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblReducaoBaseIPI
            // 
            this.lblReducaoBaseIPI.AutoSize = true;
            this.lblReducaoBaseIPI.Location = new System.Drawing.Point(151, 124);
            this.lblReducaoBaseIPI.Name = "lblReducaoBaseIPI";
            this.lblReducaoBaseIPI.Size = new System.Drawing.Size(97, 13);
            this.lblReducaoBaseIPI.TabIndex = 14;
            this.lblReducaoBaseIPI.Text = "Red Base Cálc IPI:";
            // 
            // txtBaseCalculoIPI
            // 
            this.txtBaseCalculoIPI.Location = new System.Drawing.Point(298, 140);
            this.txtBaseCalculoIPI.Name = "txtBaseCalculoIPI";
            this.txtBaseCalculoIPI.ReadOnly = true;
            this.txtBaseCalculoIPI.Size = new System.Drawing.Size(121, 20);
            this.txtBaseCalculoIPI.TabIndex = 13;
            this.txtBaseCalculoIPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblValorIPI
            // 
            this.lblValorIPI.AutoSize = true;
            this.lblValorIPI.Location = new System.Drawing.Point(295, 124);
            this.lblValorIPI.Name = "lblValorIPI";
            this.lblValorIPI.Size = new System.Drawing.Size(88, 13);
            this.lblValorIPI.TabIndex = 12;
            this.lblValorIPI.Text = "Base Cálculo IPI:";
            // 
            // txtAliquotaIPI
            // 
            this.txtAliquotaIPI.Location = new System.Drawing.Point(10, 140);
            this.txtAliquotaIPI.Name = "txtAliquotaIPI";
            this.txtAliquotaIPI.Size = new System.Drawing.Size(121, 20);
            this.txtAliquotaIPI.TabIndex = 4;
            this.txtAliquotaIPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAliquotaIPI
            // 
            this.lblAliquotaIPI.AutoSize = true;
            this.lblAliquotaIPI.Location = new System.Drawing.Point(7, 124);
            this.lblAliquotaIPI.Name = "lblAliquotaIPI";
            this.lblAliquotaIPI.Size = new System.Drawing.Size(64, 13);
            this.lblAliquotaIPI.TabIndex = 10;
            this.lblAliquotaIPI.Text = "Aliquota IPI:";
            // 
            // txtReducaoBaseICMS
            // 
            this.txtReducaoBaseICMS.Location = new System.Drawing.Point(154, 87);
            this.txtReducaoBaseICMS.Name = "txtReducaoBaseICMS";
            this.txtReducaoBaseICMS.Size = new System.Drawing.Size(121, 20);
            this.txtReducaoBaseICMS.TabIndex = 3;
            this.txtReducaoBaseICMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblReducaoBaseICMS
            // 
            this.lblReducaoBaseICMS.AutoSize = true;
            this.lblReducaoBaseICMS.Location = new System.Drawing.Point(151, 71);
            this.lblReducaoBaseICMS.Name = "lblReducaoBaseICMS";
            this.lblReducaoBaseICMS.Size = new System.Drawing.Size(110, 13);
            this.lblReducaoBaseICMS.TabIndex = 8;
            this.lblReducaoBaseICMS.Text = "Red Base Cálc ICMS:";
            // 
            // txtBaseCalculoICMS
            // 
            this.txtBaseCalculoICMS.Location = new System.Drawing.Point(298, 87);
            this.txtBaseCalculoICMS.Name = "txtBaseCalculoICMS";
            this.txtBaseCalculoICMS.ReadOnly = true;
            this.txtBaseCalculoICMS.Size = new System.Drawing.Size(121, 20);
            this.txtBaseCalculoICMS.TabIndex = 7;
            this.txtBaseCalculoICMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblValorICMS
            // 
            this.lblValorICMS.AutoSize = true;
            this.lblValorICMS.Location = new System.Drawing.Point(295, 71);
            this.lblValorICMS.Name = "lblValorICMS";
            this.lblValorICMS.Size = new System.Drawing.Size(101, 13);
            this.lblValorICMS.TabIndex = 6;
            this.lblValorICMS.Text = "Base Cálculo ICMS:";
            // 
            // txtAliquotaICMS
            // 
            this.txtAliquotaICMS.Location = new System.Drawing.Point(10, 87);
            this.txtAliquotaICMS.Name = "txtAliquotaICMS";
            this.txtAliquotaICMS.Size = new System.Drawing.Size(121, 20);
            this.txtAliquotaICMS.TabIndex = 2;
            this.txtAliquotaICMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAliquotaICMS
            // 
            this.lblAliquotaICMS.AutoSize = true;
            this.lblAliquotaICMS.Location = new System.Drawing.Point(7, 71);
            this.lblAliquotaICMS.Name = "lblAliquotaICMS";
            this.lblAliquotaICMS.Size = new System.Drawing.Size(79, 13);
            this.lblAliquotaICMS.TabIndex = 4;
            this.lblAliquotaICMS.Text = "Alíquota ICMS:";
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Location = new System.Drawing.Point(441, 37);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(121, 20);
            this.txtValorUnitario.TabIndex = 1;
            this.txtValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Location = new System.Drawing.Point(438, 21);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(73, 13);
            this.lblValorUnitario.TabIndex = 2;
            this.lblValorUnitario.Text = "Valor Unitário:";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(10, 37);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(409, 20);
            this.txtProduto.TabIndex = 0;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(7, 20);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDataPedido);
            this.groupBox1.Controls.Add(this.lblDataPedido);
            this.groupBox1.Controls.Add(this.txtNumeroPedido);
            this.groupBox1.Controls.Add(this.lblNumeroPedido);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 75);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Pedido";
            // 
            // txtDataPedido
            // 
            this.txtDataPedido.Location = new System.Drawing.Point(583, 37);
            this.txtDataPedido.Name = "txtDataPedido";
            this.txtDataPedido.ReadOnly = true;
            this.txtDataPedido.Size = new System.Drawing.Size(121, 20);
            this.txtDataPedido.TabIndex = 3;
            this.txtDataPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDataPedido
            // 
            this.lblDataPedido.AutoSize = true;
            this.lblDataPedido.Location = new System.Drawing.Point(582, 21);
            this.lblDataPedido.Name = "lblDataPedido";
            this.lblDataPedido.Size = new System.Drawing.Size(84, 13);
            this.lblDataPedido.TabIndex = 2;
            this.lblDataPedido.Text = "Data do Pedido:";
            // 
            // txtNumeroPedido
            // 
            this.txtNumeroPedido.Location = new System.Drawing.Point(10, 37);
            this.txtNumeroPedido.Name = "txtNumeroPedido";
            this.txtNumeroPedido.Size = new System.Drawing.Size(265, 20);
            this.txtNumeroPedido.TabIndex = 0;
            // 
            // lblNumeroPedido
            // 
            this.lblNumeroPedido.AutoSize = true;
            this.lblNumeroPedido.Location = new System.Drawing.Point(7, 20);
            this.lblNumeroPedido.Name = "lblNumeroPedido";
            this.lblNumeroPedido.Size = new System.Drawing.Size(98, 13);
            this.lblNumeroPedido.TabIndex = 0;
            this.lblNumeroPedido.Text = "Número do Pedido:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.txtTotalIPI);
            this.groupBox3.Controls.Add(this.lblTotalIPI);
            this.groupBox3.Controls.Add(this.txtTotalICMS);
            this.groupBox3.Controls.Add(this.lblTotalICMS);
            this.groupBox3.Location = new System.Drawing.Point(577, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(135, 215);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totais";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Black;
            this.txtTotal.Location = new System.Drawing.Point(8, 140);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(121, 20);
            this.txtTotal.TabIndex = 11;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(2, 122);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(121, 13);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalIPI
            // 
            this.txtTotalIPI.Location = new System.Drawing.Point(8, 85);
            this.txtTotalIPI.Name = "txtTotalIPI";
            this.txtTotalIPI.ReadOnly = true;
            this.txtTotalIPI.Size = new System.Drawing.Size(121, 20);
            this.txtTotalIPI.TabIndex = 7;
            this.txtTotalIPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalIPI
            // 
            this.lblTotalIPI.Location = new System.Drawing.Point(3, 69);
            this.lblTotalIPI.Name = "lblTotalIPI";
            this.lblTotalIPI.Size = new System.Drawing.Size(121, 13);
            this.lblTotalIPI.TabIndex = 6;
            this.lblTotalIPI.Text = "Total IPI";
            this.lblTotalIPI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalICMS
            // 
            this.txtTotalICMS.Location = new System.Drawing.Point(6, 37);
            this.txtTotalICMS.Name = "txtTotalICMS";
            this.txtTotalICMS.ReadOnly = true;
            this.txtTotalICMS.Size = new System.Drawing.Size(121, 20);
            this.txtTotalICMS.TabIndex = 5;
            this.txtTotalICMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalICMS
            // 
            this.lblTotalICMS.Location = new System.Drawing.Point(5, 19);
            this.lblTotalICMS.Name = "lblTotalICMS";
            this.lblTotalICMS.Size = new System.Drawing.Size(121, 13);
            this.lblTotalICMS.TabIndex = 4;
            this.lblTotalICMS.Text = "Total ICMS";
            this.lblTotalICMS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnLimpar);
            this.groupBox4.Controls.Add(this.lvwItensPedido);
            this.groupBox4.Location = new System.Drawing.Point(2, 298);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(710, 225);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Itens do Pedido";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(585, 196);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(119, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lvwItensPedido
            // 
            this.lvwItensPedido.GridLines = true;
            this.lvwItensPedido.Location = new System.Drawing.Point(10, 20);
            this.lvwItensPedido.MultiSelect = false;
            this.lvwItensPedido.Name = "lvwItensPedido";
            this.lvwItensPedido.Size = new System.Drawing.Size(694, 170);
            this.lvwItensPedido.TabIndex = 0;
            this.lvwItensPedido.UseCompatibleStateImageBehavior = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 526);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TechWeek Pedidos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtReducaoBaseIPI;
        private System.Windows.Forms.Label lblReducaoBaseIPI;
        private System.Windows.Forms.TextBox txtBaseCalculoIPI;
        private System.Windows.Forms.Label lblValorIPI;
        private System.Windows.Forms.TextBox txtAliquotaIPI;
        private System.Windows.Forms.Label lblAliquotaIPI;
        private System.Windows.Forms.TextBox txtReducaoBaseICMS;
        private System.Windows.Forms.Label lblReducaoBaseICMS;
        private System.Windows.Forms.TextBox txtBaseCalculoICMS;
        private System.Windows.Forms.Label lblValorICMS;
        private System.Windows.Forms.TextBox txtAliquotaICMS;
        private System.Windows.Forms.Label lblAliquotaICMS;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDataPedido;
        private System.Windows.Forms.Label lblDataPedido;
        private System.Windows.Forms.TextBox txtNumeroPedido;
        private System.Windows.Forms.Label lblNumeroPedido;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTotalIPIItem;
        private System.Windows.Forms.Label lblTotalIPIItem;
        private System.Windows.Forms.TextBox txtTotalICMSItem;
        private System.Windows.Forms.Label lblTotalICMSItem;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotalIPI;
        private System.Windows.Forms.Label lblTotalIPI;
        private System.Windows.Forms.TextBox txtTotalICMS;
        private System.Windows.Forms.Label lblTotalICMS;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ListView lvwItensPedido;
    }
}

