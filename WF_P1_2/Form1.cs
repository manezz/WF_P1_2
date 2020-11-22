using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_P1_2
{
    public partial class Form1 : Form
    {
        public string message;
        public int Count { get; }
        public class Kontakt
        {
            public string Fornavn { get; set; }
            public String Efternavn { get; set; }
            public string TellefonNummer { get; set; }
        }


        public Form1()
        {
            InitializeComponent();
        }

        List<Kontakt> kontakter = new List<Kontakt>();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TekstBoks_Fornavn_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_KontaktFormular_Click(object sender, EventArgs e)
        {

        }

        private void Label_Efternavn_Click(object sender, EventArgs e)
        {

        }

        private void Label_Fornavn_Click(object sender, EventArgs e)
        {

        }

        private void TekstBoks_Efternavn_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_TfN_Click(object sender, EventArgs e)
        {

        }

        private void TekstBoks_TfN_TextChanged(object sender, EventArgs e)
        {

        }

        private void Knap_VisListe_Click(object sender, EventArgs e)
        {
            foreach (Kontakt k in kontakter)
            {
                message += $"Fornavn: {k.Fornavn}{Environment.NewLine}" +
                    $"Efternavn: {k.Efternavn}{Environment.NewLine}" +
                    $"Tellefonnummer: {k.TellefonNummer}{Environment.NewLine}" +
                    $"{Environment.NewLine}";
            }
            MessageBox.Show(message);
        }

        private void Knap_Tilfoj_Click(object sender, EventArgs e)
        {
            kontakter.Add(new Kontakt {
                Fornavn = (TekstBoks_Fornavn.Text).ToString(),
                Efternavn = (TekstBoks_Efternavn.Text).ToString(),
                TellefonNummer = (TekstBoks_TfN.Text).ToString()
                });
        }

        private void Knap_Fjern_Click(object sender, EventArgs e)
        {
            int u = ;
            foreach (Kontakt k in kontakter)
            {
                if ((TekstBoks_Fornavn.Text).ToString() == k.Fornavn
                    && (TekstBoks_Efternavn.Text).ToString() == k.Efternavn
                    && (TekstBoks_TfN.Text).ToString() == k.TellefonNummer)
                {
                    kontakter.RemoveAt(u);
                }
            }
        }

    }
}
