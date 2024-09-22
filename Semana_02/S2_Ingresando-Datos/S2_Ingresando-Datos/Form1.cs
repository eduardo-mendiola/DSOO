using System.Drawing;
using System.Windows.Forms;

namespace S2_Ingresando_Datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
            1. Ingresar los datos desde los textBox y mostrarlos en cuadro de dialogo. Usar el botón “Aceptar”. 
        */
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El DATO 1 es: -->> " + txtDato1.Text + " y el DATO 2 es: -->> "
                + txtDato2.Text, "DATOS DESDE TextBox",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        /*
            2. Tomar el ejercicio 1, pero los datos deben ser ingresados también en un cuadro de diálogo.
        */
        private void btnDatos_Click(object sender, EventArgs e)
        {
            string datoUno;
            string datoDos;

            datoUno = Convert.ToString(Microsoft.VisualBasic.Interaction.InputBox("Ingresar el valor del DATO 1", "PRIMER DATO", "ingrese aqui"));

            datoDos = Convert.ToString(Microsoft.VisualBasic.Interaction.InputBox("Ingresar el valor del DATO 2", "SEGUNDO DATO", "ingrese aqui"));

            MessageBox.Show("El DATO 1 es:-->> " + datoUno + " y el DATO 2 es: -->>" + datoDos, "DATOS DESDE CUADRO DE DIALOGO", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        /*
            3. Usando el botón “Cálculo” solicitar con un cuadro de diálogo el ingreso de dos números
            (es un cuadro de dialogo para cada dato) y mostrar cuál es el número más grande.  
            La forma de declaración, lectura de datos numéricos y uso de condicional lo viste en la semana 
            1 y lo ejercitaste desde el modo consola. Simplemente debes adaptarlo a este nuevo modo. 
        */
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Numero1;
            int Numero2;

            Numero1 = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingresar un número entero", "PRIMER NUMERO", "Ingrese aquí"));

            Numero2 = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingresar un número entero", "SEGUNDO NUMERO", "Ingrese aquí"));

            if (Numero1 > Numero2)
            {
                MessageBox.Show("El PRIMER número es MAYOR al SEGUNDO número", "NUMERO MAYOR", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("El SEGUNDO número es MAYOR al PRIMER número", "NUMERO MAYOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
