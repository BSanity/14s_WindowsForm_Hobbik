using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;    
using System.Threading.Tasks;
using System.Windows.Forms;

   
namespace WinForm_OpenSav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Hobbik.Items.Add("Úszás");
            Hobbik.Items.Add("Horgászat");
            Hobbik.Items.Add("Futás");

            saveFileDialog1.FileOk += (senderFile, eFile) =>
            {
                try
                {
                    //string kiirando= ;
                   // File.(fileName, Hobbik.Items.Cast<string>().ToArray());
                    string fileName = saveFileDialog1.FileName;
                    StreamWriter sw = new StreamWriter(fileName);
                    sw.Write(Nev.Text+";");
                    sw.Write(Date.Text+";");
                    sw.Write(textBox3.Text+";");

                   


                    if (no.Checked==true)
                    {
                        sw.Write("Nő;"); 
                    }
                    else
                    {
                        sw.Write("Férfi;");
                    }
                    foreach (var item in Hobbik.Items)
                    {
                        sw.Write(item+",");
                    }
                   
                    sw.Close();
                               
                }
                catch (IOException)
                {

                    MessageBox.Show("Hiba Nem sikerolt a kiiras");
                }
            };

            openFileDialog1.FileOk += (sender, e) =>
            {
                try 
                {
                    StreamReader sw = new StreamReader(openFileDialog1.FileName);
                    string sor = sw.ReadLine();
                    string[] nev = sor.Split(';');
                    Nev.Text = nev[0];
                    Date.Text = nev[1]; 
                    Hobbik.Text = nev[2];
                    if (nev[3] == "Nő")
                    {
                        no.Checked = true;
                    }
                    if (nev[3] == "Férfi")
                    {
                        ferfi.Checked = true;
                    }
                    string[] hobbitok = nev[4].Split(',');
                    Hobbik.Items.Clear();
                    for (int i = 0; i < hobbitok.Length; i++)
                    {
                        Hobbik.Items.Add(hobbitok[i]);
                        if (hobbitok[i] == nev[2])
                        {
                            Hobbik.SelectedItem = hobbitok[i];
                        }

                    }


                  
                    

                }
                catch (IOException)
                {

                    MessageBox.Show("Hiba! sikertelen betoltes");
                }
            };

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listSzovegek_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Betöltés_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            


        }

        private void Mentés_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            
        }



        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Hobbik.Items.Add(Nev.Text);
                Nev.Text = "";
            }
        }

       

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Hozzaadas_Click(object sender, EventArgs e)
        {
               
                Hobbik.Items.Add(textBox3.Text);
                           

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
           

        }

        private void no_CheckedChanged(object sender, EventArgs e)
        {


        }
    }
}
