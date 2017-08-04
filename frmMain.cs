using System;
using System.Threading;
using System.Windows.Forms;
using TechWeek.Infra.CrossbarIo.Connection;
using TechWeek.Infra.CrossbarIo.RPC.Caller;
using TechWeek.Infra.CrossbarIo.Utils.Results.RPC;
using TechWeek.Pedidos.DTO;

namespace TechWeek.Pedidos
{
    delegate void SetTextCallback();

    public partial class frmMain : Form
    {
        //Variáveis
        private CrossbarConnection _conn;
        private Thread _thAtualizaICMS;
        private Thread _thAtualizaIPI;
        private object _lock = new object();

        //ICMS
        private decimal _baseCalculoICMS = 0M;
        private decimal _valorUnitICMS = 0M;
        private decimal _totalICMS = 0M;

        //IPI
        private decimal _baseCalculoIPI = 0M;
        private decimal _valorUnitIPI = 0M;
        private decimal _totalIPI = 0M;

        private decimal _total = 0M;

        //Construtor
        public frmMain()
        {
            InitializeComponent();

            this.InitControles();

            this.AtualizaControlesSaldos();

            this.AbrirConexao();
        }

        //Controles de Tela
        private void InitControles()
        {
            this.txtDataPedido.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            this.txtNumeroPedido.Text = Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 15);

            this.txtProduto.Text = string.Empty;

            this.txtValorUnitario.Text = "0";

            this.txtTotalICMSItem.Text = "0";
            this.txtBaseCalculoICMS.Text = "0";
            this.txtAliquotaICMS.Text = "0";
            this.txtReducaoBaseICMS.Text = "0";

            this.txtTotalIPIItem.Text = "0";
            this.txtBaseCalculoIPI.Text = "0";
            this.txtAliquotaIPI.Text = "0";
            this.txtReducaoBaseIPI.Text = "0";

            this.txtTotalICMS.Text = "0";
            this.txtTotalIPI.Text = "0";
            this.txtTotal.Text = "0";

            this.InitListView();
        }

        private void LimparAposAdicionarItem()
        {
            this.txtProduto.Text = string.Empty;

            this.txtValorUnitario.Text = "0";

            this.txtBaseCalculoICMS.Text = "0";
            this.txtAliquotaICMS.Text = "0";
            this.txtReducaoBaseICMS.Text = "0";
            this.txtTotalICMSItem.Text = "0";
            this._baseCalculoICMS = 0;
            this._valorUnitICMS = 0;

            this.txtBaseCalculoIPI.Text = "0";
            this.txtAliquotaIPI.Text = "0";
            this.txtReducaoBaseIPI.Text = "0";
            this.txtTotalIPIItem.Text = "0";
            this._baseCalculoIPI = 0;
            this._valorUnitIPI = 0;
        }

        private void AtualizaControlesSaldos()
        {
            lock (this._lock)
            {
                //ICMS
                this.txtBaseCalculoICMS.Text = this._baseCalculoICMS.ToString();
                this.txtTotalICMSItem.Text = this._valorUnitICMS.ToString();
                this.txtTotalICMS.Text = this._totalICMS.ToString();

                //IPI
                this.txtBaseCalculoIPI.Text = this._baseCalculoIPI.ToString();
                this.txtTotalIPIItem.Text = this._valorUnitIPI.ToString();
                this.txtTotalIPI.Text = this._totalIPI.ToString();

                //Total
                this.txtTotal.Text = this._total.ToString();
            }
        }

        private void Thread_Escrita()
        {
            if (this.txtTotalICMS.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(AtualizaControlesSaldos);
                this.Invoke(d);
            }
        }

        private void InitListView()
        {
            this.lvwItensPedido.View = View.Details;

            this.lvwItensPedido.Columns.Clear();
            this.lvwItensPedido.Items.Clear();

            this.lvwItensPedido.Columns.Add("Produto", -2, HorizontalAlignment.Center);
            this.lvwItensPedido.Columns.Add("Valor Unitário (R$)", -2, HorizontalAlignment.Center);
            this.lvwItensPedido.Columns.Add("Valor ICMS (R$)", -2, HorizontalAlignment.Center);
            this.lvwItensPedido.Columns.Add("Valor IPI (R$)", -2, HorizontalAlignment.Center);
        }

        private void CarrregaItensListView()
        {
            var item = new ListViewItem(new[] 
            {
                this.txtProduto.Text.ToString(),
                this.txtValorUnitario.Text.ToString(),
                this._valorUnitICMS.ToString(),
                this._valorUnitIPI.ToString()
            });

            this.lvwItensPedido.Items.Add(item);
        }
        
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            this._total = this._total + decimal.Parse(this.txtValorUnitario.Text);

            using (var callerICMS = new Caller<CalculoICMSRetorno, CalculoICMSParametro>(this._conn))
            {
                var execIcms = callerICMS.Run(new CallerResult<CalculoICMSRetorno, CalculoICMSParametro>
                {
                    NomeMetodo = "br.com.techweek.service.icms.calc",
                    Parametros = new CalculoICMSParametro
                    {
                        Aliquota = decimal.Parse(this.txtAliquotaICMS.Text),
                        ValorItem = decimal.Parse(this.txtValorUnitario.Text),
                        ReducaoBaseCalculo = decimal.Parse(this.txtReducaoBaseICMS.Text)
                    },
                    Resultado = this.AtualizaSaldoICMS
                });
            }

            using (var callerIPI = new Caller<CalculoIPIRetorno, CalculoIPIParametro>(this._conn))
            {
                var execIpi = callerIPI.Run(new CallerResult<CalculoIPIRetorno, CalculoIPIParametro>
                {
                    NomeMetodo = "br.com.techweek.service.ipi.calc",
                    Parametros = new CalculoIPIParametro
                    {
                        Aliquota = decimal.Parse(this.txtAliquotaIPI.Text),
                        ValorItem = decimal.Parse(this.txtValorUnitario.Text),
                        ReducaoBaseCalculo = decimal.Parse(this.txtReducaoBaseIPI.Text)
                    },
                    Resultado = this.AtualizaSaldoIPI
                });
            }

            this._thAtualizaICMS = new Thread(new ThreadStart(this.Thread_Escrita));
            this._thAtualizaIPI = new Thread(new ThreadStart(this.Thread_Escrita));
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            this.CarrregaItensListView();

            this.LimparAposAdicionarItem();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.InitControles();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Conexão Crossbar.IO
            this._conn?.Dispose();

            //Thread ICMS
            this._thAtualizaICMS?.Join();
            this._thAtualizaICMS?.Interrupt();
            this._thAtualizaICMS = null;

            //Thread IPI
            this._thAtualizaIPI?.Join();
            this._thAtualizaIPI?.Interrupt();
            this._thAtualizaIPI = null;
        }

        //Conexão Crossbar.IO
        private bool AbrirConexao()
        {
            this._conn = new CrossbarConnection();

            this._conn.Initilize(new ConnectionParameters
            {
                ServerAddress = "192.168.1.6",
                Port = 8081,
                ServerRealm = "im_soft"
            });

            var resConn = this._conn.Connect();

            var res = resConn.Result;

            return res;
        }

        //Callbacks
        private void AtualizaSaldoICMS(CalculoICMSRetorno valorICMS)
        {
            this._baseCalculoICMS = valorICMS.BaseCalculo;
            this._valorUnitICMS = valorICMS.Valor;
            this._totalICMS = this._totalICMS + valorICMS.Valor;

            if ((this._thAtualizaICMS.ThreadState != ThreadState.Running) && (this._thAtualizaICMS.ThreadState != ThreadState.Aborted))
            {
                this._thAtualizaICMS.Start();
                this._thAtualizaICMS.Join();
                this._thAtualizaICMS.Interrupt();
            }
        }

        private void AtualizaSaldoIPI(CalculoIPIRetorno valorIPI)
        {
            this._baseCalculoIPI = valorIPI.BaseCalculo;
            this._valorUnitIPI = valorIPI.Valor;
            this._totalIPI = this._totalIPI + valorIPI.Valor;

            this._total = this._total + valorIPI.Valor;

            if ((this._thAtualizaIPI.ThreadState != ThreadState.Running) && (this._thAtualizaIPI.ThreadState != ThreadState.Aborted))
            {
                this._thAtualizaIPI.Start();
                this._thAtualizaIPI.Join();
                this._thAtualizaIPI.Interrupt();
            }
        }
    }
}
