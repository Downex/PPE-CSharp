using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm.Class_gestion;
using WindowsForm.Class_jeux;

namespace WindowsForm
{
    public partial class ListeMot : Form
    {
        private List<Mot> lesMots;
        //private List<Conjugaison> lesConjugaisons;

        public ListeMot()
        {
            InitializeComponent();
        }        

        private void ListeMot_Load(object sender, EventArgs e)
        {
            Tab1();
        }

        private void Tab1()
        {
            lesMots = Bdd.SelectAllNoms();
            foreach (Nom unMot in lesMots)
            {
                string[] row = new string[]
                {
                    unMot.getTexte(), unMot.GetGenre()
                };
                dataGridView1.Rows.Add(row);
            }
        }
        private void Tab2()
        {
            lesMots = Bdd.SelectAllPronoms();
            foreach (Pronom unMot in lesMots)
            {
                string[] row = new string[]
                {
                    unMot.getTexte(), unMot.GetGenre()
                };
                dataGridView1.Rows.Add(row);
            }
        }
        private void Tab3()
        {
            lesMots = Bdd.SelectAllVerbes();
            foreach (Verbe unMot in lesMots)
            {
                string[] row = new string[]
                {
                    unMot.getTexte(), unMot.GetGenre()
                };
                dataGridView1.Rows.Add(row);
            }
        }
        private void Tab4()
        {
            lesMots = Bdd.SelectAllAdjectifs();
            foreach (Adjectif unMot in lesMots)
            {
                string[] row = new string[]
                {
                    unMot.getTexte(), unMot.GetFonction()
                };
                dataGridView1.Rows.Add(row);
            }
        }

        private void Tab5()
        {
            lesMots = Bdd.SelectAllArticles();
            foreach(Article unMot in lesMots)
            {
                string[] row = new string[]
                {
                    unMot.getTexte(), unMot.GetPluriel()
                };
                dataGridView1.Rows.Add(row);
            }
        }
        private void Tab6()
        {
            lesMots = Bdd.SelectAllAdverbes();
            foreach (Adverbe unMot in lesMots)
            {
                string[] row = new string[]
                {
                    unMot.getTexte(), "Adverbe"
                };
                dataGridView1.Rows.Add(row);
            }
        }

        /* --- Nom --- */
        private void button4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Veuillez entrer un texte valide", "Alerte");
            }
            else
            {
                string[] row = new string[]
                {
                    textBox1.Text, "Nom", textBox2.Text, comboBox1.Text
                };
                dataGridView1.Rows.Add(row);
                Bdd.InsertNom(textBox1.Text, textBox2.Text, comboBox1.Text);
                                
                textBox1.Clear();
                textBox2.Clear();
                comboBox1.SelectedIndex = -1;
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        /* --- Pronom --- */
        private void button3_Click(object sender, EventArgs e)
        {
            int pluriel = 0;
            if (String.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Veuillez entrer un texte valide", "Alerte");
            }
            else
            {
                string[] row = new string[]
                {
                    textBox3.Text,"Pronom", pluriel.ToString(), comboBox2.Text
                };
                dataGridView1.Rows.Add(row);
                if(checkBox1.Checked == true)
                {
                    pluriel = 1;
                }
                else
                {
                    pluriel = 0;
                }
                Bdd.InsertPronom(textBox3.Text, pluriel.ToString(), comboBox2.Text);

                textBox3.Clear();
                checkBox1.Checked = false;
                comboBox2.SelectedIndex = -1;
            }
        }

        /* --- Verbe --- */
        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Veuillez entrer un texte valide", "Alerte");
            }
            else
            {
                string[] row = new string[]
                {
                    textBox4.Text, "Verbe", comboBox3.Text
                };
                dataGridView1.Rows.Add(row);
                Bdd.InsertVerbe(textBox4.Text, comboBox3.Text);
                int last = Bdd.GetLastIdVerbe();
                Bdd.InsertConjugaison(textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, last);

                textBox4.Clear();
                comboBox3.SelectedIndex = -1;
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
            }
        }

        /* --- Adjectif --- */
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox12.Text))
            {
                MessageBox.Show("Veuillez entrer un texte valide", "Alerte");
            }
            else
            {
                string[] row = new string[]
                {
                    textBox12.Text, "Adjectif", textBox13.Text, textBox14.Text, textBox15.Text, comboBox4.Text
                };
                dataGridView1.Rows.Add(row);
                Bdd.InsertAdjectif(textBox12.Text, textBox13.Text, textBox14.Text, textBox15.Text, comboBox4.Text);

                textBox12.Clear();
                textBox13.Clear();
                textBox14.Clear();
                textBox15.Clear();
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
        }

        private void Adjectif_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl.SelectedIndex == 0)
            {
                dataGridView1.Rows.Clear();
                Tab1();
            }
            else if (TabControl.SelectedIndex == 1)
            {
                dataGridView1.Rows.Clear();
                Tab2();
            }
            else if (TabControl.SelectedIndex == 2)
            {
                dataGridView1.Rows.Clear();
                Tab3();
            }
            else if (TabControl.SelectedIndex == 3)
            {
                dataGridView1.Rows.Clear();
                Tab4();
            }
            else if(TabControl.SelectedIndex == 4)
            {
                dataGridView1.Rows.Clear();
                Tab5();
            }
            else if(TabControl.SelectedIndex == 5)
            {
                dataGridView1.Rows.Clear();
                Tab6();
            }
        }

        /* --- Pronom --- */
        private void button5_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox16.Text))
            {
                MessageBox.Show("Veuillez entrer un texte valide", "Alerte");
            }
            else
            {
                string[] row = new string[]
                {
                    textBox16.Text, "Article", textBox17.Text, textBox18.Text
                };
                dataGridView1.Rows.Add(row);
                Bdd.InsertArticle(textBox16.Text, textBox17.Text, textBox18.Text);

                textBox16.Clear();
                textBox17.Clear();
                textBox18.Clear();
            }
        }

        /* --- Adverbe --- */
        private void button6_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox19.Text))
            {
                MessageBox.Show("Veuillez entrer un texte valide", "Alerte");
            }
            else
            {
                string[] row = new string[]
                {
                    textBox19.Text, "Adverbe"
                };
                dataGridView1.Rows.Add(row);
                Bdd.InsertAdverbe(textBox19.Text);

                textBox19.Clear();
            }
        }
    }
}
