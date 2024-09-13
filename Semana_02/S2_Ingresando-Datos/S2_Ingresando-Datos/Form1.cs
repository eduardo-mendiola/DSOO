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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El DATO 1 es: -->> " + txtDato1.Text + " y el DATO 2 es: -->> "
                + txtDato2.Text, "DATOS DESDE TextBox",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        string datoUno;
        string datoDos;

        datoUno = Convert.ToString(Microsoft.VisualBasic.Interaction.InputBox("Ingresar el valor del DATO 1", "PRIMER DATO","ingrese aqui"));

        datoDos = Convert.ToString(Microsoft.VisualBasic.Interaction.InputBox("Ingresar el valor del DATO 2", "SEGUNDO DATO", "ingrese aqui"));




    }
}
