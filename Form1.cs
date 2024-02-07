namespace WinFormsApp4
{


    public partial class Form1 : Form
    {

        double[] ventaSemanales = new double[7];
        double sumaVentas = 0;
        string nombreEmpleado = "";
        int i;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombreEmpleado = cb.Text;
            cb.Enabled = false;
            for (i = 1; i < ventaSemanales.Length; i++)
            {
                ventaSemanales[i] = double.Parse(Microsoft.VisualBasic.Interaction.InputBox("Proporcoiona la venta del dia 1v"));
                ListViewItem fila = new ListViewItem(i.ToString());
                fila.SubItems.Add(ventaSemanales[i].ToString());
                lvIAlmacenVentas.Items.Add(fila);
                sumaVentas += ventaSemanales[i];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lvDatosEmpleado.Items.Add("** Reporte ventas por empleado **");
            lvDatosEmpleado.Items.Add("Nombre del empleado: " + nombreEmpleado);
            lvDatosEmpleado.Items.Add("Ventas Semanales" + ventaSemanales.ToString()); 
        }
    }
}
