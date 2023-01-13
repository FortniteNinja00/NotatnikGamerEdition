using System.Drawing.Text;
using System.Windows.Forms;

namespace Notatnik
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "Plik Tekstowy|*.txt|Plik PDF|*.pdf|Plik Word|*.doc";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
        }

        private void wczytajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void trybNocnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
           richTextBox1.BackColor= Color.Black;
           richTextBox1.ForeColor= Color.White;
           
        }

        private void wy³¹czTrybNocnyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.White;
            richTextBox1.ForeColor = Color.Black;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string slowa = richTextBox1.Text.Trim();
            label1.Text = "Iloœæ s³ów: " + Liczslowa(slowa);

        }
        private int Liczslowa(string slowa)
        {
            string[] wszystkie = slowa.Split(' ');
            return wszystkie.Length;
        }

        private void wyjdŸIZapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "Plik Tekstowy|*.txt|Plik PDF|*.pdf|Plik Word|*.doc";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
            Application.Exit();
        }

        private void wyjdŸBezZapisywaniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void poka¿ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Show();
        }

        private void ukryjToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Hide();  
        }

        private void pomocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "To jest Notatnik Gamer Edition. Czym siê ró¿ni? W przycisku Plik mo¿esz zapisaæ swoje dzie³o na 3 ró¿ne sposoby! Mo¿esz równie¿ wczytaæ inny plik, aby go tu edytowaæ, lub po prostu zamkn¹æ. W ustawieniach mo¿esz w³¹czyæ lub wy³¹czyæ tryb nocny oraz ukryæ i pokazaæ licznik s³ów!";
            string caption = "Notatnik";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            
        }
    }
    }

