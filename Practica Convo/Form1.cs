using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Convo
{
    public partial class Form1 : Form
    {
        private float Saldo = 0;
        private int Contador = 0;

        public Form1()
        {
            InitializeComponent();
            richTextBox1.ReadOnly = true;
            dataGridView1.Columns.Add("", "Acción");
            dataGridView1.Columns.Add("", "Cantidad");
            dataGridView1.Columns.Add("", "Fecha/Hora");
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            lblSaldo.Text = $"C$ {Saldo.ToString("N2")}";
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            try
            {
                Validar(out float Cantidad);
                Saldo += Cantidad;
                MessageBox.Show("Se depositó con éxito!");
                richTextBox1.Text += $"Depósito: C$ {Cantidad} \n";
                txtCantidad.Clear();

                dataGridView1.Rows.Add("Depósito", Cantidad, DateTime.Now.ToString());
                Contador++;
                LblMov.Text = $"Lista de Movimientos    {Contador}";
                btnSaldo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Validar(out float Cantidad)
        {
            if (String.IsNullOrEmpty(txtCantidad.Text) || !float.TryParse(txtCantidad.Text, out float C))
            {
                throw new ArgumentException("El No. es inválido!");
            }
            Cantidad = C;
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            try
            {
                Validar(out float Cantidad);
                if (Cantidad > Saldo)
                {
                    MessageBox.Show("No puede retirar una cantidad mayor a su saldo!");
                    return;
                }
                else
                {
                    Saldo -= Cantidad;
                    MessageBox.Show("Se retiró con éxito!");
                    richTextBox1.Text += $"Retiro: C$ {Cantidad} \n";
                    txtCantidad.Clear();

                    dataGridView1.Rows.Add("Retiro", Cantidad, DateTime.Now.ToString());
                    Contador++;
                    LblMov.Text = $"Lista de Movimientos    {Contador}";
                    btnSaldo.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}