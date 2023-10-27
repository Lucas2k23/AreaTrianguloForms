using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaTrianguloForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txbResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                double n1, n2, area;

                //Obter os valores dos textboxes:
                n1 = double.Parse(txbNum1.Text);
                n2 = double.Parse(txbNum2.Text);

                area = (n1 * n2 / 2);

                //Mostrar o resultado no txbResultado
                txbResultado.Text = area.ToString();
            }
            catch
            {
                MessageBox.Show("Dados invalidos informados");
                
                // Limpar os txbs:
                txbResultado.Clear();
                txbNum1.Clear();
                txbNum2.Clear();
            }
            

        }
    }
}
