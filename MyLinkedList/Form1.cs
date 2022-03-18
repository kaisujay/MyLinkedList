using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLinkedList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            MySingleLinkedList list = new MySingleLinkedList();
            list.AddLast(3);
            list.AddLast(5);
            list.AddLast(7);
            list.AddLast(9);
            list.AddLast(11);
            richTextBox1.Text = list.Display();
            list.AddFirst(10);
            list.AddFirst(1);
            list.AddLast(2);
            richTextBox1.Text = list.Display();
            list.AddBefore(11,55);
            richTextBox1.Text = list.Display();
            list.AddAfter(5, 77);
            richTextBox1.Text = list.Display();
            // --> 1 --> 10 --> 3 --> 5 --> 7 --> 9 --> 11 --> 2
            // --> 1 --> 10 --> 3 --> 5 --> 7 --> 9 --> 55 --> 11 --> 2
            // --> 1 --> 10 --> 3 --> 5 --> 77 --> 7 --> 9 --> 55 --> 11 --> 2
        }
    }
}
