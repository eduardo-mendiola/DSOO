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
            1. Ingresar los datos desde los textBox y mostrarlos en cuadro de dialogo. Usar el bot�n �Aceptar�. 
        */
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El DATO 1 es: -->> " + txtDato1.Text + " y el DATO 2 es: -->> "
                + txtDato2.Text, "DATOS DESDE TextBox",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        /*
            2. Tomar el ejercicio 1, pero los datos deben ser ingresados tambi�n en un cuadro de di�logo.
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
            3. Usando el bot�n �C�lculo� solicitar con un cuadro de di�logo el ingreso de dos n�meros
            (es un cuadro de dialogo para cada dato) y mostrar cu�l es el n�mero m�s grande.  
            La forma de declaraci�n, lectura de datos num�ricos y uso de condicional lo viste en la semana 
            1 y lo ejercitaste desde el modo consola. Simplemente debes adaptarlo a este nuevo modo. 
        */
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Numero1;
            int Numero2;

            Numero1 = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingresar un n�mero entero", "PRIMER NUMERO", "Ingrese aqu�"));

            Numero2 = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingresar un n�mero entero", "SEGUNDO NUMERO", "Ingrese aqu�"));

            if (Numero1 > Numero2)
            {
                MessageBox.Show("El PRIMER n�mero es MAYOR al SEGUNDO n�mero", "NUMERO MAYOR", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("El SEGUNDO n�mero es MAYOR al PRIMER n�mero", "NUMERO MAYOR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
