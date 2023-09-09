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
            LibreriaCS l = new LibreriaCS();
            int[] cvis = new int[3];
            Interaction.InputBox("0. Comune" +
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
                "\n17. Posti letto aggiuntivi", "Visualizza 3 Campi");
           /* for (int i = 0; i < cvis.Length; i++)
            {
                "Inserisci il numero:");
                cvis[i] = int.Parse(Console.ReadLine());
            }
            string[] arr = l.EstrapolaCampi(cvis[0], cvis[1], cvis[2]);
            int j = 0;
            while (arr[j] != null)
            {
                arr[j]);
                j++;
            }
            "Clicca un tasto per continuare...");
            Console.ReadLine();*/
        }
    }
}
