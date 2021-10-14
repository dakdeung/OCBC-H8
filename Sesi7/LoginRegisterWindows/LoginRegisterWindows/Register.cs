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
    public partial class Register : Form
    {
        Config db = new Config();
        public Register()
        {
            InitializeComponent();

            db.Connect("userdata");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Execute("INSERT INTO `user_info` (`id`,`names`,`username`,`password`) VALUES (NULL,'"+ textBox1.Text+"','"+textBox2+"','"+textBox3.Text+"');");

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
