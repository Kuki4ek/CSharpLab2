using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int [] time1_1 = {dateTimePicker1.Value.Hour, dateTimePicker1.Value.Minute, dateTimePicker1.Value.Second };
            int [] time1_2 = { dateTimePicker2.Value.Hour, dateTimePicker2.Value.Minute, dateTimePicker2.Value.Second };
            Time Time1_1 = new Time(time1_1[0], time1_1[1], time1_1[2]);
            Time Time1_2 = new Time(time1_2[0], time1_2[1], time1_2[2]);
            Time Time1_3 = new Time();
            if (comboBox1.Text == "+")
            {
                Time1_3 = Time1_1 + Time1_2;
            }
            else
            {
                Time1_3 = Time1_1 - Time1_2;
            }
            textBox1.Text = Time1_3.day.ToString();
            textBox2.Text = Time1_3.hour.ToString();
            textBox3.Text = Time1_3.minute.ToString();
            textBox4.Text = Time1_3.second.ToString();
            //-----------------------------------------------
            int[] time2_1 = { int.Parse(textBox12.Text), int.Parse(textBox11.Text), int.Parse(textBox10.Text), int.Parse(textBox9.Text) };
            int[] time2_2 = { int.Parse(textBox16.Text), int.Parse(textBox15.Text), int.Parse(textBox14.Text), int.Parse(textBox13.Text) };
            Time Time2_1 = new Time(time2_1[0], time2_1[1], time2_1[2], time2_1[3]);
            Time Time2_2 = new Time(time2_2[0], time2_2[1], time2_2[2], time2_2[3]);
            Time Time2_3 = new Time();
            if (comboBox2.Text == "+")
            {
                Time2_3 = Time2_1 + Time2_2;
            }
            else
            {
                Time2_3 = Time2_1 - Time2_2;
            }
            textBox8.Text = Time2_3.day.ToString();
            textBox7.Text = Time2_3.hour.ToString();
            textBox6.Text = Time2_3.minute.ToString();
            textBox5.Text = Time2_3.second.ToString();
        }
    }
}
