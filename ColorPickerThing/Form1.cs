using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ColorPickerThing
{
    public partial class Form1 : Form
    {
        public int ranCount = 0;
        public Game1 game = new Game1();

        Random rand = new Random();

        public int Red
        {
            get { return Convert.ToInt32(numericUpDown1.Value); }
        }

        public int Green
        {
            get { return Convert.ToInt32(numericUpDown2.Value); }
        }

        public int Blue
        {
            get { return Convert.ToInt32(numericUpDown3.Value); }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ranCount++;
            label5.Text = Convert.ToString(ranCount);

            numericUpDown1.Value = rand.Next(0, 255);
            numericUpDown2.Value = rand.Next(0, 255);
            numericUpDown3.Value = rand.Next(0, 255);
        }
    }
}
