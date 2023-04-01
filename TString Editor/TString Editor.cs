﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TString_Editor
{
    public partial class TString_Editor : Form
    {
        About a;
        Controller c;
        Donate d;
        StringBinaryReader br;
        StringBinaryWriter bw;

        public TString_Editor()
        {
            InitializeComponent();
        }

        private void TString_Editor_Load(object sender, EventArgs e)
        {
            AddButton.Enabled = false;
            DeleteButton.Enabled = false;
            SaveButton.Enabled = false;

            MessageBox.Show("If you want more editors, support the project with a donation", "Information",
                                                   MessageBoxButtons.OK,
                                                   MessageBoxIcon.Information);
        }

        //Frame Open Tcd File
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OFD.Filter = "TString.tcd|TString*.tcd|All tcd|*.tcd|All Files|*.*";
            OFD.Title = "Open TString";
            OFD.FileName = "TString.tcd";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                Loads(OFD.OpenFile());
            }
        }

        //Load Tcd File...
        private void Loads(Stream direction)
        {
            br = new StringBinaryReader(direction);
            c = new Controller(br.ReadUInt16());
            for (int i = 0; i < c.Structures.Length; i++)
            {
                c.Structures[i] = new Structure();
                c.Structures[i].ID = br.ReadInt16();
                c.Structures[i].String = br.ReadString();
            }
            DrawList();
            br.Close();
            AddButton.Enabled = true;
            DeleteButton.Enabled = true;
            SaveButton.Enabled = true;
        }

        //Draw in ListBox
        private void DrawList()
        {
            ListBox.Items.Clear();
            StatusStrip.Items.Clear();

            for (int i = 0; i < c.Structures.Length; i++)
            {
                ListBox.Items.Add(i + ": " + c.Structures[i].String);
            }

            StatusStrip.Items.Add(CountToolStripStatusLabel + " " + c.Structures.Length + "                                                                    " + CopyrightToolStripStatusLabel);
        }

        //Select Structure from ListBox
        private Int16 GetSelectedStructure()
        {
            if (ListBox.SelectedItem != null)
            {
                String[] split = new String[10];
                split = ListBox.SelectedItem.ToString().Split(Convert.ToChar(":"));
                return Convert.ToInt16(split[0]);
            }
            else
            {
                return -1;
            }
        }

        //Select Structure from ListBox2
        private Int16 GetSelectedStructure2()
        {
            if (ListBox2.SelectedItem != null)
            {
                String[] split = new String[10];
                split = ListBox2.SelectedItem.ToString().Split(Convert.ToChar(":"));
                return Convert.ToInt16(split[0]);
            }
            else
            {
                return -1;
            }
        }

        //Insert Structure in ListBox
        private void InsertStructureBox(Int32 selection)
        {
            try
            {
                if (selection != -1)
                {
                    IDTextBox.Text = Convert.ToString(c.Structures[selection].ID);
                    StringTextBox.Text = Convert.ToString(c.Structures[selection].String);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Index ListBox1
        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InsertStructureBox(GetSelectedStructure());
        }

        //Index ListBox2
        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            InsertStructureBox(GetSelectedStructure2());
        }

        //Search in ListBox
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == "")
            {
                ListBox.Show();
                ListBox2.Hide();
            }
            else
            {
                ListBox2.Show();
                ListBox2.Items.Clear();
                foreach (var item in ListBox.Items)
                {
                    if (item.ToString().Contains(SearchTextBox.Text))
                    {
                        ListBox2.Items.Add(item);
                    }
                }
            }
        }

        //Add new String
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                c.RaiseStructureSize();
                c.Structures[c.Structures.Length - 1] = new Structure();
                DrawList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Delete String
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            c.DeleteStructure(GetSelectedStructure());
            DrawList();
        }

        //Save String
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Int16 selection = GetSelectedStructure();
                if (selection != -1)
                {
                    Int16 dwIDo = c.Structures[selection].ID;
                    c.Structures[selection].ID = Convert.ToInt16(IDTextBox.Text);
                    c.Structures[selection].String = Convert.ToString(StringTextBox.Text);

                    object[] o = new object[2];
                    o[0] = IDTextBox.Text;
                    o[1] = StringTextBox.Text;
                    DrawList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Save Tcd Structure
        private void Save(Stream direction)
        {
            bw = new StringBinaryWriter(direction);
            bw.Write(Convert.ToInt16(c.Structures.Length));
            for (int i = 0; i < c.Structures.Length; i++)
            {
                bw.Write(c.Structures[i].ID);
                bw.Write(c.Structures[i].String);
            }
            bw.Close();
        }

        //Frame Save Tcd File
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SFD.Filter = "TString.tcd|TString*.tcd|All tcd|*.tcd|All Files|*.*";
            SFD.Title = "Save TString";
            SFD.FileName = "TString.tcd";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                Save(SFD.OpenFile());
                MessageBox.Show("Saved", "TString Editor",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
            }
        }

        //Link for my GitHub :D =)          (All right reserved)
        private void CopyrightToolStripStatusLabel_Click(object sender, EventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable to open link.");
            }
        }

        private void VisitLink()
        {
            CopyrightToolStripStatusLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/SlayerHasher");
        }

        //About
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            a = new About();
            a.Show();
        }
        //Donate
        private void DonateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            d = new Donate();
            d.Show();
        }
    }
}
