using System;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty 
                && textBox2.Text != String.Empty 
                && textBox3.Text != String.Empty
                && textBox4.Text != String.Empty)
               
            {
                Materialsdoc.AddMaterials(new Materials(textBox1.Text,
                    Convert.ToInt16(textBox2.Text),
                    Convert.ToInt16(textBox3.Text), 
                    Convert.ToInt16(textBox4.Text)));
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Materialsdoc.materials;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int received = 0;
            int issued = 0;
            int leftovers1 = 0;
            int Rsum = 0;
            foreach (Materials i in Materialsdoc.materials)
            {
                leftovers1 += i.Leftovers_start;
                received += i.Received;
                issued += i.Issued;
                Rsum += i.Leftovers_end;
            }
            label5.Text = "Остаток на начала периода: " + leftovers1;
            label6.Text = "Получено: " + received;
            label7.Text = "Выдано: " + issued;
            label9.Text = "Остаток на конец периода: " + Rsum;
        }
    }
}
