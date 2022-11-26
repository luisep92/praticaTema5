namespace Practica5_Entornos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = 'o';
            int numPalabras = 0;
            double coste;

            textoTelegrama = txtTelegrama.Text;
            numPalabras = Utils.CountWords(textoTelegrama);

            if (cbUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }

            if (tipoTelegrama == 'o') //ordinario
            {
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 2.5 + 0.5 * (numPalabras - 10);
            }  
            else if (tipoTelegrama == 'u') //urgente
            {
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + 0.75 * (numPalabras - 10);
            }
            else
            {
                coste = 0;
            }
                
            txtPrecio.Text = coste.ToString() + " euros";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}