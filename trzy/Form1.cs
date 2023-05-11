using System.Diagnostics.CodeAnalysis;

namespace trzy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
            label1.Font = new Font("Arial", 10);
        }

        int suma = 0;
        

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            suma = (int)numericUpDown1.Value;
            suma += (int)numericUpDown2.Value;
            label1.Text = suma.ToString();

        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            suma = (int)numericUpDown2.Value;
            suma += (int)numericUpDown1.Value;
            label1.Text = suma.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            label1.Text = "Suma liczb";
            numericUpDown3.Value = 10;
        }

        
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", (int)numericUpDown3.Value);
        }

      
    }
}