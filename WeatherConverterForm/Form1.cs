using WeatherConverter;

namespace WeatherConverterForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Conversor conversor = new Conversor();

        public void C2F(int temperatura)
        {
            txtResultado.Text = conversor.CelsiusToFahrenheit(temperatura).ToString();
        }

        public void C2K(int temperatura)
        {
            txtResultado.Text = conversor.CelsiusToKelvin(temperatura).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temperatura = int.Parse(txtTemperatura.Text);

            if(rb1.Checked)
            {
                C2F(temperatura);
            }
            else
            {
                C2K(temperatura);
            }
        }
    }
}
