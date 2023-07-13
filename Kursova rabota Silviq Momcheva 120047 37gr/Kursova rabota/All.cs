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
    public partial class All : Form
    {
        public All()
        {
            InitializeComponent();
            hotelBindingSource.DataSource = Form1.HotelList;
        }

        private void hotelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(Form1.FN, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, Form1.HotelList);
            fs.Close();
        }

        private void hotelBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
