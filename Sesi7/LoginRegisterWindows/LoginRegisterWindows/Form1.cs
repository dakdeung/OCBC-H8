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

    public partial class Form1 : Form
    {
        Config db = new Config();
        public Form1()
        {
            InitializeComponent();

            db.Connect("userdata");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("SELECT * FROM `user_info` where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'");

            MessageBox.Show(db.Count() + " Hellow");
            if(db.Count() == 1)
            {
                MessageBox.Show("Success You will Login as" + db.Result(0, "names"));
                Dashboard dashboard = new Dashboard(db.Result(0, "names"), db.Result(0, "names"));
                textBox1.Clear();
                textBox2.Clear();
                dashboard.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
