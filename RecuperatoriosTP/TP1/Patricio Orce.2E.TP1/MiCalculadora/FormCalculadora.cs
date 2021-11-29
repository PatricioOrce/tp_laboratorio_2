using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Convierte el valor de todos los campos al Default.
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = String.Empty;
            this.txtNumero2.Text = String.Empty;
            this.lblResultado.Text = "0";
            this.cmbOperador.SelectedIndex = -1;

        }
        /// <summary>
        /// Al abrirse el form inicia con todos los campos que vienen por Default.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        /// <summary>
        /// Cierra el formulario posterior a una confirmacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Realiza la confirmacion del cierre de el form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Limpia todos los campos llamando al metodo Limpiar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        /// <summary>
        /// Al opimir el boton se validan todos los campos y se realiza la operacion correspondiente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado;
            double num1, num2;

            if (!(this.cmbOperador.SelectedItem is null || string.IsNullOrWhiteSpace(this.cmbOperador.SelectedItem.ToString())))
            {
                
                if (double.TryParse(this.txtNumero1.Text, out num1) && double.TryParse(this.txtNumero2.Text, out num2))
                {
                    if (char.TryParse(this.cmbOperador.SelectedItem.ToString(), out char operador))
                    {
                        switch (operador)
                        {
                            case '+':
                            case '-':
                            case '*':
                            case '/':
                                resultado = Calculadora.Operar(new Operando(this.txtNumero1.Text), new Operando(this.txtNumero2.Text), operador);
                                if (resultado == double.MinValue)
                                {
                                    this.lblResultado.Text = "Math Error";
                                }
                                else
                                {
                                    this.lblResultado.Text = resultado.ToString();
                                }
                                this.listOperaciones.Items.Add($"{this.txtNumero1.Text} {operador} {this.txtNumero2.Text} = {this.lblResultado.Text}");
                                break;
                            default:
                                this.cmbOperador.SelectedIndex = 1;
                                resultado = Calculadora.Operar(new Operando(this.txtNumero1.Text), new Operando(this.txtNumero2.Text), operador);
                                break;
                        }
                    }
                    this.txtNumero1.Text = String.Empty;
                    this.txtNumero2.Text = String.Empty;
                    this.cmbOperador.SelectedIndex = -1;
                }

            }
            else if(!(this.txtNumero1.Text == ""|| this.txtNumero2.Text == "")
                    && (double.TryParse(this.txtNumero1.Text, out num1) 
                    && double.TryParse(this.txtNumero2.Text, out num2)))
            {
                this.cmbOperador.SelectedIndex = 1;
                this.lblResultado.Text = Calculadora.Operar(new Operando(this.txtNumero1.Text), new Operando(this.txtNumero2.Text), Convert.ToChar(this.cmbOperador.SelectedItem)).ToString();
                this.listOperaciones.Items.Add($"{this.txtNumero1.Text} {this.cmbOperador.SelectedItem} {this.txtNumero2.Text} = {this.lblResultado.Text}");
            }

            //            else
            //{
            //    this.txtNumero1.Text = " ";
            //    this.txtNumero2.Text = " ";
            //    this.lblResultado.Text = V;
            //    this.listOperaciones.Items.Add(V);
            //}


        }
        /// <summary>
        /// Al oprimir el boton se valida que el numero del resultado sea decimal y de ser el caso lo convierte a binario, caso contrario 
        /// devuelve "Valor invalido".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando operando = new Operando();
            this.listOperaciones.Items.Add($"Dec: '{this.lblResultado.Text}' Bin: '{operando.DecimalBinario(this.lblResultado.Text)}'");
        }
        /// <summary>
        /// Al oprimir el boton se valida que el numero del resultado sea binario y de ser el caso lo convierte a decimal, caso contrario
        /// devuelve "Valor invalido"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando operando = new Operando();
            this.listOperaciones.Items.Add($"Bin: '{this.lblResultado.Text}' Dec: '{operando.BinarioDecimal(this.lblResultado.Text)}'");
        }
    }
}
