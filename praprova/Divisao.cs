using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praprova
{
    public partial class Divisao : Form
    {
        public Divisao()
        {
            InitializeComponent();
            lb_resultado.Text = "";
        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            try //quando acontecer um erro
            {
                int a = Convert.ToInt32(tx_valor1.Text);
                int b = Convert.ToInt32(tx_valor2.Text);

                int c = a / b;

                MessageBox.Show(c.ToString());


            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao dividir!");
            }
            finally
            {
                MessageBox.Show("Vai executar de qualquer forma");
            }
            
        }
    }
}

//erro ao dividir
