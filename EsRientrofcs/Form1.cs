using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using libreriaCS;
using System.IO;

namespace EsRientrofcs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aggiusta_Click(object sender, EventArgs e)
        {
            LibreriaCS l = new LibreriaCS();
            if (l.ContrAgg() == false)
            {
                l.aggiusta();
                MessageBox.Show("File aggiustato correttamente", "Avviso", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Operazione già effettuata", "Avviso", MessageBoxButtons.OK);
            }
        }

        private void ConCampi_Click(object sender, EventArgs e)
        {
            LibreriaCS l = new LibreriaCS();
            MessageBox.Show("I campi di questo file sono " + l.ContaCampi() + ".", "Numero dei campi", MessageBoxButtons.OK);
        }

        private void LMaxRec_Click(object sender, EventArgs e)
        {
            LibreriaCS l = new LibreriaCS();
            MessageBox.Show("La lunghezza massima dei record presenti è " + l.LungMaxRec() + " caratteri.", "Lunghezza Massima Record", MessageBoxButtons.OK);
        }

        private void AggRecord_Click(object sender, EventArgs e)
        {
            LibreriaCS l = new LibreriaCS();
            string[] div = new string[18];
            MessageBox.Show("Inserisci i campi del nuovo record che vuoi inserire:", "Aggiunta di un nuovo record");
            div[0] = Interaction.InputBox("Inserisci il Comune:", "Nuovo record");
            div[1] = Interaction.InputBox("Inserisci la Provincia:", "Nuovo record");
            div[2] = Interaction.InputBox("Inserisci la Regione:", "Nuovo record");
            div[3] = Interaction.InputBox("Inserisci la Tipologia:", "Nuovo record");
            div[4] = Interaction.InputBox("Inserisci la Categoria:", "Nuovo record");
            div[5] = Interaction.InputBox("Inserisci la Denominazione:", "Nuovo record");
            div[6] = Interaction.InputBox("Inserisci l'Indirizzo:", "Nuovo record");
            div[7] = Interaction.InputBox("Inserisci il CAP:", "Nuovo record");
            div[8] = Interaction.InputBox("Inserisci la Località:", "Nuovo record");
            div[9] = Interaction.InputBox("Inserisci la Frazione:", "Nuovo record");
            div[10] = Interaction.InputBox("Inserisci il Telefono:", "Nuovo record");
            div[11] = Interaction.InputBox("Inserisci il FAX:", "Nuovo record");
            div[12] = Interaction.InputBox("Inserisci l'Indirizzo posta elettronica:", "Nuovo record");
            div[13] = Interaction.InputBox("Inserisci il Sito Internet:", "Nuovo record");
            div[14] = Interaction.InputBox("Inserisci il Codice esercizio:", "Nuovo record");
            div[15] = Interaction.InputBox("Inserisci il numero di Camere:", "Nuovo record");
            div[16] = Interaction.InputBox("Inserisci i Posti letto standard:", "Nuovo record");
            div[17] = Interaction.InputBox("Inserisci i Posti letto aggiuntivi:", "Nuovo record");
            l.AggRec(div);
            MessageBox.Show("Record aggiunto correttamente", "Avviso");
        }

        private void VisCampi_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            LibreriaCS l = new LibreriaCS();
            int[] cvis = new int[3];
            MessageBox.Show("Scegli tre di questi campi, indicandone il numero corrispondente" +
                "\n0. Comune" +
                "\n1. Provincia" +
                "\n2. Regione" +
                "\n3. Tipologia" +
                "\n4. Categoria(Stelle)" +
                "\n5. Denominazione" +
                "\n6. Indirizzo" +
                "\n7. CAP" +
                "\n8. Località" +
                "\n9. Frazione" +
                "\n10. Telefono" +
                "\n11. FAX" +
                "\n12. Indirizzo Posta Elettronica" +
                "\n13. Sito Internet" +
                "\n14. Codice esercizio" +
                "\n15. Camere" +
                "\n16. Posti letto standard" +
                "\n17. Posti letto aggiuntivi", "Visualizza 3 Campi", MessageBoxButtons.OKCancel);
            for (int i = 0; i < cvis.Length; i++)
            {
                cvis[i] = int.Parse(Interaction.InputBox("Inserisci il numero:"));
            }
            string[] arr = l.EstrapolaCampi(cvis[0], cvis[1], cvis[2]);
            int j = 0;
            while (arr[j] != null)
            {
                ListViewItem Item = new ListViewItem();
                string[] div = arr[j].Split(';');
                if (j != 0)
                {
                    Item.Text = div[0];
                    for (int i = 1; i < div.Length; i++)
                    {
                        Item.SubItems.Add(div[i]);
                    }
                    listView1.Items.Add(Item);
                }
                j++;
            }
        }

        private void ricercare_Click(object sender, EventArgs e)
        {
            LibreriaCS l = new LibreriaCS();
            string ricerca = Interaction.InputBox("Inserisci il termine che vuoi ricercare");
            MessageBox.Show("Scegli il campo in cui vuoi cercarlo, indicandone il numero corrispondente" +
                        "\n0. Comune" +
                        "\n1. Provincia" +
                        "\n2. Regione" +
                        "\n3. Tipologia" +
                        "\n4. Categoria(Stelle)" +
                        "\n5. Denominazione" +
                        "\n6. Indirizzo" +
                        "\n7. CAP" +
                        "\n8. Località" +
                        "\n9. Frazione" +
                        "\n10. Telefono" +
                        "\n11. FAX" +
                        "\n12. Indirizzo Posta Elettronica" +
                        "\n13. Sito Internet" +
                        "\n14. Codice esercizio" +
                        "\n15. Camere" +
                        "\n16. Posti letto standard" +
                        "\n17. Posti letto aggiuntivi", "Visualizza 3 Campi", MessageBoxButtons.OKCancel);
            int campo = int.Parse(Interaction.InputBox("Inserisci il numero"));
            string[] ric = l.Ricerca(campo, ricerca);
            int j = 0;
            while (ric[j] != null)
            {
                ListViewItem Item = new ListViewItem();
                string[] div = ric[j].Split(';');
                Item.Text = div[0];
                for (int i = 1; i < div.Length; i++)
                {
                    Item.SubItems.Add(div[i]);
                }
                listView1.Items.Add(Item);
                j++;
            }
        }

        private void mod_Click(object sender, EventArgs e)
        {
            LibreriaCS l = new LibreriaCS();
            string ricerca = Interaction.InputBox("Inserisci il termine che vuoi modificare");
            string modifica = Interaction.InputBox("Inserisci la modifica");
            MessageBox.Show("Scegli il campo in cui vuoi cercarlo, indicandone il numero corrispondente" +
                        "\n0. Comune" +
                        "\n1. Provincia" +
                        "\n2. Regione" +
                        "\n3. Tipologia" +
                        "\n4. Categoria(Stelle)" +
                        "\n5. Denominazione" +
                        "\n6. Indirizzo" +
                        "\n7. CAP" +
                        "\n8. Località" +
                        "\n9. Frazione" +
                        "\n10. Telefono" +
                        "\n11. FAX" +
                        "\n12. Indirizzo Posta Elettronica" +
                        "\n13. Sito Internet" +
                        "\n14. Codice esercizio" +
                        "\n15. Camere" +
                        "\n16. Posti letto standard" +
                        "\n17. Posti letto aggiuntivi", "Visualizza 3 Campi", MessageBoxButtons.OKCancel);
            int campo = int.Parse(Interaction.InputBox("Inserisci il numero"));
            l.ModificaCampo(campo, ricerca, modifica);
            MessageBox.Show("Operazione Completata", "Avviso");
        }

        private void canclogica_Click(object sender, EventArgs e)
        {
            bool cor = false;
            LibreriaCS l = new LibreriaCS();
            string ricerca = Interaction.InputBox("Inserisci il termine che vuoi cancellare logicamente");
            MessageBox.Show("Scegli il campo in cui vuoi cercarlo, indicandone il numero corrispondente" +
                        "\n0. Comune" +
                        "\n1. Provincia" +
                        "\n2. Regione" +
                        "\n3. Tipologia" +
                        "\n4. Categoria(Stelle)" +
                        "\n5. Denominazione" +
                        "\n6. Indirizzo" +
                        "\n7. CAP" +
                        "\n8. Località" +
                        "\n9. Frazione" +
                        "\n10. Telefono" +
                        "\n11. FAX" +
                        "\n12. Indirizzo Posta Elettronica" +
                        "\n13. Sito Internet" +
                        "\n14. Codice esercizio" +
                        "\n15. Camere" +
                        "\n16. Posti letto standard" +
                        "\n17. Posti letto aggiuntivi", "Visualizza 3 Campi", MessageBoxButtons.OKCancel);
            int campo = int.Parse(Interaction.InputBox("Inserisci il numero"));
            l.CancRecLogica(campo, ricerca, cor);
            MessageBox.Show("Operazione completata", "Avviso");
        }

        private void reclogico_Click(object sender, EventArgs e)
        {
            bool cor = true;
            LibreriaCS l = new LibreriaCS();
            string ricerca = Interaction.InputBox("Inserisci il termine che vuoi cancellare logicamente");
            MessageBox.Show("Scegli il campo in cui vuoi cercarlo, indicandone il numero corrispondente" +
                        "\n0. Comune" +
                        "\n1. Provincia" +
                        "\n2. Regione" +
                        "\n3. Tipologia" +
                        "\n4. Categoria(Stelle)" +
                        "\n5. Denominazione" +
                        "\n6. Indirizzo" +
                        "\n7. CAP" +
                        "\n8. Località" +
                        "\n9. Frazione" +
                        "\n10. Telefono" +
                        "\n11. FAX" +
                        "\n12. Indirizzo Posta Elettronica" +
                        "\n13. Sito Internet" +
                        "\n14. Codice esercizio" +
                        "\n15. Camere" +
                        "\n16. Posti letto standard" +
                        "\n17. Posti letto aggiuntivi", "Visualizza 3 Campi", MessageBoxButtons.OKCancel);
            int campo = int.Parse(Interaction.InputBox("Inserisci il numero"));
            l.CancRecLogica(campo, ricerca, cor);
            MessageBox.Show("Operazione completata", "Avviso");
        }

        private void ricompattafile_Click(object sender, EventArgs e)
        {
            LibreriaCS l = new LibreriaCS();
            l.Ricompatta();
            MessageBox.Show("Operazione completata", "Avviso");
        }

        private void visualizzafile_Click(object sender, EventArgs e)
        {
            LibreriaCS l = new LibreriaCS();
            int j = 0;
            string[] arr = l.Visualizza();
            while (arr[j] != null)
            {
                ListViewItem Item = new ListViewItem();
                string[] div = arr[j].Split(';');
                if (j != 0)
                {
                    Item.Text = div[0];
                    for (int i = 1; i < div.Length; i++)
                    {
                        Item.SubItems.Add(div[i]);
                    }
                    listView1.Items.Add(Item);
                }
                j++;
            }
        }
    }
}
