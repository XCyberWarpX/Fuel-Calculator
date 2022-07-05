namespace Fuel_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculatebtn_Click(object sender, EventArgs e)
        {

            decimal kmtravNumber, litusedNumber, kmwantNumber;

            kmtravNumber = Decimal.Parse(kmtrav.Text);
            litusedNumber = Decimal.Parse(litused.Text);

            decimal kplResult = (kmtravNumber / litusedNumber);
            this.litperkm.Text = kplResult.ToString();

            kmwantNumber = Decimal.Parse(kmwant.Text);

            decimal litResult = (kmwantNumber / kplResult);
            this.litneed.Text = litResult.ToString();

        }

        private void kmtrav_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void litused_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void kmwant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}