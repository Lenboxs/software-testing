using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoundTest2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int frequency = 523;
            int duration = 1000;
            Console.Beep(frequency, duration);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //D
            int frequency = 587;
            int duration = 1000;
            Console.Beep(frequency, duration);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //E
            int frequency = 659;
            int duration = 1000;
            Console.Beep(frequency, duration);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //F
            int frequency = 698;
            int duration = 1000;
            Console.Beep(frequency, duration);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //G
            int frequency = 784;
            int duration = 1000;
            Console.Beep(frequency, duration);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //A
            int frequency = 880;
            int duration = 1000;
            Console.Beep(frequency, duration);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //B
            int frequency = 988;
            int duration = 1000;
            Console.Beep(frequency, duration);
        }

        private void A(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.Enabled = true;
                button1.Text = "Ready to Play"; // Change button text
            }
        }
    }
}
