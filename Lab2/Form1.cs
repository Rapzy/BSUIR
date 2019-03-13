﻿using System;
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
        List<Steelarm> steelarms = new List<Steelarm>();
        List<Rifle> rifles = new List<Rifle>();
        List<Pistol> pistols = new List<Pistol>();
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Name";
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
                        break;
                    }
                case 1:
                    {
                        panel1.Controls.Clear();
                        AddField("Name", offset += margin);
                        AddField("Clip Size", offset += margin);
                        break;
                    }
                case 2:
                    {
                        panel1.Controls.Clear();
                        AddField("Name", offset += margin);
                        AddField("Clip Size", offset += margin);
                        AddField("Fire Rate", offset += margin);
                        break;
                    }
            }
        }
        public void AddField(string name, int offset)
        {
            TextBox txt = new TextBox();
            txt.Name = name.Replace(" ","")+"TextBox";
            txt.Height = 15;
            txt.Width = 150;
            txt.Top = offset;
            Console.WriteLine(txt.Name);
            panel1.Controls.Add(txt);

            Label lbl = new Label();
            lbl.Text = name;
            lbl.Top = offset - 15;
            panel1.Controls.Add(lbl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        steelarms.Add(new Steelarm(panel1.Controls["NameTextBox"].Text));  
                        break;
                    }
                case 1:
                    {
                        string name = panel1.Controls["NameTextBox"].Text;
                        int clip_size = Convert.ToInt16(panel1.Controls["ClipSizeTextBox"].Text);
                        pistols.Add(new Pistol(name, clip_size));
                        break;
                    }
                case 2:
                    {
                        string name = panel1.Controls["NameTextBox"].Text;
                        int clip_size = Convert.ToInt16(panel1.Controls["ClipSizeTextBox"].Text);
                        int fire_rate = Convert.ToInt16(panel1.Controls["FireRateTextBox"].Text);
                        rifles.Add(new Rifle(name, clip_size, fire_rate));
                        break;
                    }
            }
            
            foreach (Steelarm gun in steelarms)
            {
                comboBox2.Items.Add(gun);
            }
            foreach (Pistol gun in pistols)
            {
                comboBox2.Items.Add(gun);
            }
            foreach (Rifle gun in rifles)
            {
                comboBox2.Items.Add(gun);
            }
            comboBox2.SelectedIndex = 0;
            foreach (Control obj in panel1.Controls)
            {
                obj.ResetText();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            object selected = comboBox2.SelectedItem;
            GetGunType(selected).Shoot();
        }
        public void UpdateInfo() {
            l
        }
        public Gun GetGunType(object obj)
        {
            if (obj is Steelarm)
            {
                return (Steelarm)obj;
            }
            else if (obj is Pistol)
            {
                return (Pistol)obj;
            }
            else if (obj is Rifle)
            {
                return (Rifle)obj;
            }
            return (Firearm)obj;
        }
    }
}
