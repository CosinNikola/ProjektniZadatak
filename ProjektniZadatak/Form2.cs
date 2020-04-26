using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektniZadatak
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Igrac i = new Igrac(textBox3.Text, textBox4.Text, Convert.ToInt32(textBox8.Text), Convert.ToDouble(textBox6.Text), comboBox1.SelectedItem.ToString(), Convert.ToDouble(textBox7.Text), comboBox2.SelectedItem.ToString(), textBox9.Text, textBox10.Text, bul());
            srediDataGridView();
            Igrac.potvrda();
            dataGridView1.Rows.Add(i.ime, i.prezime, i.godine, i.Visina, i.Tezina, i.Pozicija, i.Kategorija, i.Klub.Naziv, i.Klub.Grad);
            DialogResult rez = MessageBox.Show("Da li zelite dodatne podatke o igracu? ", "Dodatno", MessageBoxButtons.YesNo);
            if (rez==DialogResult.Yes)
            {
                i.dodatno();
            }
            else
            {
                this.Close();
            }

            DialogResult dia = MessageBox.Show("Da li zelite dodatne informacije o klubu? ", "O klubu", MessageBoxButtons.YesNo);
            if (dia == DialogResult.Yes)
                i.Klub.Filijala();
            else
                this.Close();
        }

        private void Reset()
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
        }

        private void srediDataGridView()
        {
            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "Ime";
            dataGridView1.Columns[1].Name = "Prezime";
            dataGridView1.Columns[2].Name = "Godine";
            dataGridView1.Columns[3].Name = "Visina";
            dataGridView1.Columns[4].Name = "Tezina";
            dataGridView1.Columns[5].Name = "Pozicija";
            dataGridView1.Columns[6].Name = "Kategorija";
            dataGridView1.Columns[7].Name = "Ime kluba";
            dataGridView1.Columns[8].Name = "Grad kluba";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public bool bul()
        {
            if (comboBox3.SelectedItem.ToString() == "Da")
                return true;
            else
                return false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Klub.stat();
        }

    }
}
