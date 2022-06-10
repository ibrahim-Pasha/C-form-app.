using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace okul_ödevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            string cinsiyet = "a";

            if (radioButton1.Checked) cinsiyet = "Bay";
            else if (radioButton2.Checked) cinsiyet = "Bayan";

            dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, cinsiyet);


            if (dataGridView1.Rows.Count == 10)
            {
                this.addBtn.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cinsiyet = "a";

            if (radioButton1.Checked) cinsiyet = "Bay";
            else if (radioButton2.Checked) cinsiyet = "Bayan";

            int bayanPara = 0;
            int erkekPara = 0;
            int toplam = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                cinsiyet = Convert.ToString(dataGridView1.Rows[i].Cells[3].Value);
                if
                (Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) == Convert.ToString(dataGridView1.Rows[i].Cells[1].Value) && Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) > 2 && cinsiyet == "Bayan")
                {
                    bayanPara += (Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) * 50 + 300);
                }

                else if
                (Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) == Convert.ToString(dataGridView1.Rows[i].Cells[1].Value) && Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) > 2 && cinsiyet == "Bay")
                {
                    erkekPara += (Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) * 25 + 150);
                }
                else
                {
                    bayanPara += 0;
                    erkekPara += 0;
                }

            }
            toplam += bayanPara + erkekPara;
            textBox5.Text = Convert.ToString(toplam);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cinsiyet="s";
            int erkekCocuk = 0;

            for (int a = 0; a < dataGridView1.Rows.Count; a++)
            {
                cinsiyet = Convert.ToString(dataGridView1.Rows[a].Cells[3].Value);
                if (cinsiyet == "Bay")
                {
                    erkekCocuk += Convert.ToInt32(dataGridView1.Rows[a].Cells[2].Value);
                }
            }
            textBox6.Text = Convert.ToString(erkekCocuk);
        }
    }
}
