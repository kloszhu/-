using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button17_Click(object sender, EventArgs e)
        {

        }
        List<Button> ButtonsList = new List<Button>();
        private void Form1_Load(object sender, EventArgs e)
        {
            ButtonsList.Add(button1);
            ButtonsList.Add(button2);
            ButtonsList.Add(button3);
            ButtonsList.Add(button4);
            ButtonsList.Add(button5);
            ButtonsList.Add(button6);
            ButtonsList.Add(button7);
            ButtonsList.Add(button8);
            ButtonsList.Add(button9);
            ButtonsList.Add(button10);
            ButtonsList.Add(button11);
            ButtonsList.Add(button12);
            ButtonsList.Add(button13);
            ButtonsList.Add(button14);
            ButtonsList.Add(button15);
            ButtonsList.Add(button16);
            ButtonsList.Add(button17);
            foreach (Button item in ButtonsList)
            {
                item.Click += Item_Click;
            }

        }
        private StringBuilder InputCac = new StringBuilder();
        private void Item_Click(object sender, EventArgs e)
        {
           
            var buttonclick = (Button)sender;

            if (buttonclick.Text == "✖")
            {
                AddText("*");
            }
            else if (buttonclick.Text == "➗")
            {
                AddText(@"/");
            }
            else if (buttonclick.Text == "清除")
            {
                Clear();
            }
            else if (buttonclick.Text == "后退")
            {
                Back();
            }
            else if (buttonclick.Text == "=")
            {
                richTextBox1.AppendText("=");
                DataTable dataTable = new DataTable();
               
                var result = dataTable.Compute(InputCac.ToString(), null);
                richTextBox1.AppendText(result.ToString());
                InputCac.Clear();
                //InputCac.Append(result);
                richTextBox1.AppendText("\n");
            }
            else {
                AddText(buttonclick.Text);
            }
            ShowScreen(buttonclick.Text);
        }

        private void ShowScreen(string text)
        {
            if (text == "清除")
            {
                return;
            }
            else if (text == "后退")
            {
                return;
            }
            else if (text=="=")
            {
                return;
            }
            richTextBox1.AppendText(text);
        }

        private void Back()
        {
            InputCac.Remove(InputCac.Length - 1,1);
        }

        private void Clear()
        {
            InputCac.Clear();
        }

        private void AddText(string v)
        {
            if (InputCac.Length==0)
            {
                InputCac.Append("0");
            }
            InputCac.Append(v);
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length==0)
            {
                return;
            }
            richTextBox1.Text = richTextBox1.Text.Remove((richTextBox1.Text.Length - 1));
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
