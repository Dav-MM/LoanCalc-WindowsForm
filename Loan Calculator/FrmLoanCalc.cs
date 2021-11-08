using Loan_Calculator.CustomControlItem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace Loan_Calculator
{
    public partial class FrmLoanCalc : Form
    {
        public FrmLoanCalc()
        {
            InitializeComponent();
        }

        private void FrmLoanCalc_Load(object sender, EventArgs e)
        {
            LoadCbxPrestamo();
            LoadCbxCuotaMensual();
            
        }
        private void CbxTipoPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTxtTasa();
        }

        private void FrmLoanCalc_Click(object sender, EventArgs e)
        {
            LoanCal();
        }
        private void LoanCal()
        {
            try
            {
                ComboBoxItem selectedLoan = CbxTipoPrestamo.SelectedItem as ComboBoxItem;
                ComboBoxItem selectedCuote = CbxCuota.SelectedItem as ComboBoxItem;

                if (selectedLoan.Value == null)
                {
                    MessageBox.Show("Debe seleccionar el tipo de prestamo","Advertencia");
                }
                else if (selectedCuote.Value == null)
                {
                    MessageBox.Show("Debe seleccionar a cuentas cuotas desea pagar el prestamo", "advertencia");
                }
                else if (string.IsNullOrEmpty(TxtMonto.Text))
                {
                    MessageBox.Show("Manito, coloque la cantidad, ¿Que prestamo' va a calcular sin un monto?...");
                }
                else
                {
                    double cantidad = Convert.ToDouble(TxtMonto.Text);
                    LoanCalculator loanCalculator = new();
                    int loan = Convert.ToInt32(selectedLoan.Value);
                    int cuote = Convert.ToInt32(selectedCuote.Value);
                    double result = loanCalculator.LoanCalculation(cantidad, loan, cuote);
                    TxtResult.Text = Convert.ToString(result);
                }
  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Manito, coloque un valor numerico", "Error");
            } 
        }

        private void LoadTxtTasa()
        {
            ComboBoxItem selectedLoan = CbxTipoPrestamo.SelectedItem as ComboBoxItem;
            int valor = Convert.ToInt32(selectedLoan.Value);
            if (valor == 1)
            {
                TxtTasaInteres.Text = "22%";
            }
            else if (valor == 2)
            {
                TxtTasaInteres.Text = "12%";
            }
            else if (valor ==3)
            {
                TxtTasaInteres.Text = "8%";
            }
            else
            {
                TxtTasaInteres.Text = "Tasa de interes";
            }
        }
        private void LoadCbxCuotaMensual()
        {
            ComboBoxItem defaultOption = new() {
                Text = "Cantidad de meses",
                Value = null
            };

            for (int i = 12; i < 121; i = i + 12)
            {
                ComboBoxItem item = new();
                item.Text = $"{i} Meses";
                item.Value = i;
                CbxCuota.Items.Add(item);
            }
            CbxCuota.Items.Add(defaultOption);
                CbxCuota.SelectedItem = defaultOption;
        }
        private void LoadCbxPrestamo()
        {
            ComboBoxItem defaultOption = new()
            {
                Text = "Seleccione una opcion",
                Value = null
                };
            ComboBoxItem personal = new()
            {
                Text = "Personal",
                Value = 1
            };
            ComboBoxItem automovil = new()
            {
                Text = "Automovil",
                Value = 2
            };
            ComboBoxItem hipotecario = new()
            {
                Text = "Hipotecario",
                Value = 3
            };

            CbxTipoPrestamo.Items.Add(defaultOption);
            CbxTipoPrestamo.Items.Add(personal);
            CbxTipoPrestamo.Items.Add(automovil);
            CbxTipoPrestamo.Items.Add(hipotecario);
            CbxTipoPrestamo.SelectedItem = defaultOption;

            
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

      
    }
}
