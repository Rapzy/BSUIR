using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int offset = 0;
            int margin = 40;

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        panel1.Controls.Clear();
                        AddField("Name", offset += margin);
                        AddField("Type", offset += margin);
                        break;
                    }
                case 1:
                    {
                        panel1.Controls.Clear();
                        AddField("Name", offset += margin);
                        AddField("Type", offset += margin);
                        AddField("Clip Size", offset += margin);
                        AddField("Ammo", offset += margin);
                        break;
                    }
                case 2:
                    {
                        panel1.Controls.Clear();
                        AddField("Name", offset += margin);
                        AddField("Type", offset += margin);
                        AddField("Clip Size", offset += margin);
                        AddField("Ammo", offset += margin);
                        AddField("Fire Rate", offset += margin);
                        break;
                    }
            }
        }
        public void AddField(string name, int offset)
        {
            TextBox txt = new TextBox();
            txt.Name = comboBox1.SelectedItem+"Box"+name.Replace(" ","");
            txt.Height = 15;
            txt.Width = 150;
            txt.Top = offset;
            panel1.Controls.Add(txt);

            Label lbl = new Label();
            lbl.Text = name;
            lbl.Top = offset - 15;
            panel1.Controls.Add(lbl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
