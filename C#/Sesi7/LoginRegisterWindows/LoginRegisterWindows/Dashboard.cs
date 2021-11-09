using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegisterWindows
{

    public partial class Dashboard : Form
    {
        private static Array ListID;
        private static Array ListFirstname;
        private static Array ListLastname;
        private static Array ListTelephone;
        private static Array ListAddress;
        Config db = new Config();
        public Dashboard(string nama, string username)
        {
            InitializeComponent();
            db.Connect("userdata");
            initView(nama,username);
            getData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void initView(string nama, string username)
        {
            textBox1.Text = nama;
            textBox2.Text = username;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
        }

        private void getData()
        {
            db.ExecuteSelect("SELECT * FROM `user_info` ");
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
