using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova___2_Bimestre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pd_cadastrar_Click(object sender, EventArgs e)
        {
            // Variaveis Produto
            double codigo = Convert.ToDouble(pd_codigo.Text);
            string unidade = pd_unidade.Text;
            string descricao = pd_descricao.Text;
            double valor = Convert.ToDouble(pd_valor.Text);

            // Variaveis Financeiras
            double pis = Convert.ToDouble(pd_pis.Text);
            double icms = Convert.ToDouble(pd_icms.Text);
            double confins = Convert.ToDouble(pd_confins.Text);
            double lucro = Convert.ToDouble(pd_lucro.Text);

            // Verificar select vazio
            if (pd_unidade.Text == null || pd_unidade.Text == "") MessageBox.Show("ERR0: INSIRA UMA UNIDADE");
            else
            {
                // Criar produto
                Produto produto = new Produto(codigo, unidade, descricao, valor);

                // Definir valor de venda
                produto.valorTotal = Imposto.CalcValorTotal(produto.valor, lucro, pis, icms, confins, produto.unidade);

                // Retorno 
                pd_valorRenda.Text = $"Valor de Venda: {produto.valorTotal.ToString("C2")}";
            }

        }
    }
}
