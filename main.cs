using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlatUI;
using System.Net;

namespace idkkkkkk
{
    public partial class Dice : Form
    {
        public Dice()
        {
            InitializeComponent();
        }

        private void min_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
                {
                var a = min.Value;
                var b = max.Value;



                var a2 = a.ToString();
                var b2 = b.ToString();

                var a3 = Int32.Parse(a2);
                var b3 = Int32.Parse(b2);

                int random_number = new Random().Next(a3, b3);

                var final = random_number.ToString();

                var mssg = MessageBox.Show(final, "Dice");
                }
                catch (Exception)
                {
                Console.WriteLine("Error 1: Max is bigger than min.");
                MessageBox.Show("Min has to be smaller than max!", "Critical error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

