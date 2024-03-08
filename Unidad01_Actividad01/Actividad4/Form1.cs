using System;
using System.Windows.Forms;

namespace Analisis4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Agrega elementos a la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ingresarbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(valorTxb.Text))
            {
                listNumbers.Items.Add(valorTxb.Text);
                valorTxb.Clear();
                valorTxb.Focus();
            }
        }

        /// <summary>
        /// Realiza los 4 calculos requeridos en un evento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MayorImparesNegativos();
            PorcentajeCeros();
            PromedioImparesPositivos();
            MayorParesPositivos();
        }

        /// <summary>
        /// Obtiene el mayor de los numeros impares
        /// </summary>
        private void MayorImparesNegativos()
        {
            int mayorneg = int.MinValue;
            bool hayNumerosNegativosPares = false;

            for (int i = 0; i < listNumbers.Items.Count; i++)
            {
                string valor = listNumbers.Items[i].ToString();
                int numero = int.Parse(valor);

                if (numero < 0 && numero % 2 == 0)
                {
                    hayNumerosNegativosPares = true;

                    if (numero > mayorneg)
                    {
                        mayorneg = numero;
                        mayorNegativotxb.Text = mayorneg.ToString();
                    }
                }
            }

            if (!hayNumerosNegativosPares)
            {
                mayorNegativotxb.Text = "No hay números negativos pares";
            }
        }

        /// <summary>
        /// Obtiene el procentaje de ceros en la lista
        /// </summary>
        private void PorcentajeCeros()
        {
            double cantidadnumeros = listNumbers.Items.Count;
            double cantidadceros = 0;
            double porcentaje = 0;
            for (int i = 0; i < listNumbers.Items.Count; i++)
            {
                string valor = listNumbers.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero == 0)
                {
                    cantidadceros = cantidadceros + 1;
                }
            }
            porcentaje = (cantidadceros / cantidadnumeros) * 100;
            porcentajeCerostxb.Text = porcentaje.ToString() + "%";
        }

        /// <summary>
        /// Obtiene el promedio de numeros impares positivos
        /// </summary>
        private void PromedioImparesPositivos()
        {
            double prom;
            double cantidadimpares = 0;
            double suma = 0;

            for (int i = 0; i < listNumbers.Items.Count; i++)
            {
                string valor = listNumbers.Items[i].ToString();
                int numero = int.Parse(valor);

                if (numero > 0 && numero % 2 != 0)
                {
                    suma += numero;
                    cantidadimpares++;
                }
            }

            if (cantidadimpares > 0)
            {
                prom = suma / cantidadimpares;
                promedioImparestxb.Text = prom.ToString();
            }
            else
            {
                promedioImparestxb.Text = "No hay números impares positivos";
            }
        }

        /// <summary>
        /// Obtiene el mayor de los numeros positivos pares
        /// </summary>
        private void MayorParesPositivos()
        {
            int mayor = 0;
            for (int i = 0; i < listNumbers.Items.Count; i++)
            {
                string valor = listNumbers.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero > 0 && numero % 2 == 0)
                {
                    if (numero > mayor)
                        mayor = numero;
                }
            }
            mayorPositivotxb.Text = mayor.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
