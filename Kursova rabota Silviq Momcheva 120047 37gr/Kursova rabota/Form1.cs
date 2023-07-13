using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Kursova_rabota
{
    public partial class Form1 : Form
    {
        public static List<Hotel> HotelList = new List<Hotel>();
        public const string FN = "hotel.dat";
        public BinaryFormatter bf = new BinaryFormatter();
        public FileStream fs;
        public Form1()
        {
            InitializeComponent();
            if (File.Exists(FN))
            {
                fs = new FileStream(FN, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                if (fs.Length > 0)
                    HotelList =(List<Hotel>) bf.Deserialize(fs);
                fs.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(FN))
            {
                fs = new FileStream(FN, FileMode.CreateNew);
                fs.Close();
            }
            hotelBindingSource.DataSource = Form1.HotelList;
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void именаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new All().ShowDialog();
        }

        private void номерНаСтаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddItems().ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {

                if (dataGridView1[2, i].Value.ToString() == "апартамент")
                {

                    dataGridView1[4, i].Value = int.Parse(textBox1.Text) * int.Parse(dataGridView1[3, i].Value.ToString());

                }
                if (dataGridView1[2, i].Value.ToString() == "студио")
                {
                    dataGridView1[4, i].Value = int.Parse(textBox2.Text) * int.Parse(dataGridView1[3, i].Value.ToString());
                }
                if (dataGridView1[2, i].Value.ToString() == "единична")
                {
                    dataGridView1[4, i].Value = int.Parse(textBox3.Text) * int.Parse(dataGridView1[3, i].Value.ToString());
                }
                if (dataGridView1[2, i].Value.ToString() == "двойна")
                {
                    dataGridView1[4, i].Value = int.Parse(textBox4.Text) * int.Parse(dataGridView1[3, i].Value.ToString());
                }
                if (dataGridView1[2, i].Value.ToString() == "лукс")
                {
                    dataGridView1[4, i].Value = int.Parse(textBox5.Text) * int.Parse(dataGridView1[3, i].Value.ToString());
                }
             
            }
            
        }

        private void бройДниПрестойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Наистина ли искате да затворите приложението?","Изход",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void типСтаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Наистина ли искате да съхраните данните?", "Съхраняване", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                FileStream fs = new FileStream(Form1.FN, FileMode.OpenOrCreate);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, Form1.HotelList);
                fs.Close();
                MessageBox.Show("Данните бяха съхранени успешно!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int broi = 0;int suma = 0;
           
            for (int row = 0; row < dataGridView1.RowCount - 1; row++)
            {
               
                    if (dataGridView1.Rows[row].Cells[2].Value.ToString() == "апартамент")
                    {
                        broi+= int.Parse(dataGridView1.Rows[row].Cells[3].Value.ToString());
                    suma+= int.Parse(dataGridView1.Rows[row].Cells[4].Value.ToString());    

                    }
            }
            listBox1.Items.Add(" Апартамент: "+suma+" лв. -        "+broi+" дни");

            suma = 0; broi = 0;
            for (int row = 0; row < dataGridView1.RowCount - 1; row++)
            {

                if (dataGridView1.Rows[row].Cells[2].Value.ToString() == "студио")
                {
                    broi+= int.Parse(dataGridView1.Rows[row].Cells[3].Value.ToString());
                    suma+= int.Parse(dataGridView1.Rows[row].Cells[4].Value.ToString());

                }
            }
            listBox1.Items.Add(" Студио: " + suma + " лв. -                   " + broi+" дни");



            suma = 0; broi = 0;
            for (int row = 0; row < dataGridView1.RowCount - 1; row++)
            {

                if (dataGridView1.Rows[row].Cells[2].Value.ToString() == "единична")
                {
                    broi+= int.Parse(dataGridView1.Rows[row].Cells[3].Value.ToString());
                    suma+= int.Parse(dataGridView1.Rows[row].Cells[4].Value.ToString());

                }
            }
            listBox1.Items.Add(" Единична: " + suma + " лв. -               " + broi+" дни");




            suma = 0; broi = 0;
            for (int row = 0; row < dataGridView1.RowCount - 1; row++)
            {

                if (dataGridView1.Rows[row].Cells[2].Value.ToString() == "двойна")
                {
                    broi+= int.Parse(dataGridView1.Rows[row].Cells[3].Value.ToString());
                    suma+= int.Parse(dataGridView1.Rows[row].Cells[4].Value.ToString());

                }
            }
            listBox1.Items.Add(" Двойна: " + suma + "   лв. -              " + broi+" дни");



            suma = 0; broi = 0;
            for (int row = 0; row < dataGridView1.RowCount - 1; row++)
            {

                if (dataGridView1.Rows[row].Cells[2].Value.ToString() == "лукс")
                {
                    broi+= int.Parse(dataGridView1.Rows[row].Cells[3].Value.ToString());
                    suma+= int.Parse(dataGridView1.Rows[row].Cells[4].Value.ToString());

                }
            }
            listBox1.Items.Add(" Лукс: " + suma + " лв. -                    " + broi+" дни");








        }
    }
}
