namespace OnlinePizzaThirstSatisfied
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnorder_Click(object sender, EventArgs e)
        {
            int order;
            if(rdodinein.Checked)
            {
                order = 1;
            }
            if(rdohomedelivery.Checked)
            {
                order = 2;
            }
            else 
            {
                order = 3;
            }
            string flavour;
            flavour = cbxflavour.SelectedItem.ToString();
            int size;
            if (rdosmall.Checked)
            {
                size = 1;
            }
            else if (rdomedium.Checked)
            {
                size = 2;
            }
            else
            {
                size = 3;
            }
            int quantity=Convert.ToInt32(numericUpDown.Value);
            MessageBox.Show("Order Type"+order+"Flavour"+flavour+"size"+size+"Qty"+quantity);

        }
    }
}