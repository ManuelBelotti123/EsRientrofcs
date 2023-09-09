namespace EsRientrofcs
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.aggiusta = new System.Windows.Forms.Button();
            this.ConCampi = new System.Windows.Forms.Button();
            this.LMaxRec = new System.Windows.Forms.Button();
            this.AggRecord = new System.Windows.Forms.Button();
            this.VisCampi = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.comune = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.provincia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.regione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tipologia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.denominazione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.indirizzo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.localita = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.frazione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.indposel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.web = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ces = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.camere = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pls = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pla = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ricercare = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.canclogica = new System.Windows.Forms.Button();
            this.reclogico = new System.Windows.Forms.Button();
            this.ricompattafile = new System.Windows.Forms.Button();
            this.visualizzafile = new System.Windows.Forms.Button();
            this.mval = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTIONE FILE CSV";
            // 
            // aggiusta
            // 
            this.aggiusta.Location = new System.Drawing.Point(18, 47);
            this.aggiusta.Name = "aggiusta";
            this.aggiusta.Size = new System.Drawing.Size(130, 23);
            this.aggiusta.TabIndex = 1;
            this.aggiusta.Text = "Aggiusta";
            this.aggiusta.UseVisualStyleBackColor = true;
            this.aggiusta.Click += new System.EventHandler(this.aggiusta_Click);
            // 
            // ConCampi
            // 
            this.ConCampi.Location = new System.Drawing.Point(18, 77);
            this.ConCampi.Name = "ConCampi";
            this.ConCampi.Size = new System.Drawing.Size(130, 23);
            this.ConCampi.TabIndex = 2;
            this.ConCampi.Text = "Conta Campi";
            this.ConCampi.UseVisualStyleBackColor = true;
            this.ConCampi.Click += new System.EventHandler(this.ConCampi_Click);
            // 
            // LMaxRec
            // 
            this.LMaxRec.Location = new System.Drawing.Point(18, 107);
            this.LMaxRec.Name = "LMaxRec";
            this.LMaxRec.Size = new System.Drawing.Size(130, 23);
            this.LMaxRec.TabIndex = 3;
            this.LMaxRec.Text = "Lunghezza Massima";
            this.LMaxRec.UseVisualStyleBackColor = true;
            this.LMaxRec.Click += new System.EventHandler(this.LMaxRec_Click);
            // 
            // AggRecord
            // 
            this.AggRecord.Location = new System.Drawing.Point(18, 137);
            this.AggRecord.Name = "AggRecord";
            this.AggRecord.Size = new System.Drawing.Size(130, 23);
            this.AggRecord.TabIndex = 4;
            this.AggRecord.Text = "Aggiunta Record";
            this.AggRecord.UseVisualStyleBackColor = true;
            this.AggRecord.Click += new System.EventHandler(this.AggRecord_Click);
            // 
            // VisCampi
            // 
            this.VisCampi.Location = new System.Drawing.Point(18, 167);
            this.VisCampi.Name = "VisCampi";
            this.VisCampi.Size = new System.Drawing.Size(130, 23);
            this.VisCampi.TabIndex = 5;
            this.VisCampi.Text = "Visualizza tre campi";
            this.VisCampi.UseVisualStyleBackColor = true;
            this.VisCampi.Click += new System.EventHandler(this.VisCampi_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.comune,
            this.provincia,
            this.regione,
            this.tipologia,
            this.categoria,
            this.denominazione,
            this.indirizzo,
            this.cap,
            this.localita,
            this.frazione,
            this.telefono,
            this.fax,
            this.indposel,
            this.web,
            this.ces,
            this.camere,
            this.pls,
            this.pla,
            this.mval});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(184, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(595, 362);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // comune
            // 
            this.comune.Text = "Comune";
            // 
            // provincia
            // 
            this.provincia.Text = "Provincia";
            // 
            // regione
            // 
            this.regione.Text = "Regione";
            // 
            // tipologia
            // 
            this.tipologia.Text = "Tipologia";
            // 
            // categoria
            // 
            this.categoria.Text = "Categoria";
            // 
            // denominazione
            // 
            this.denominazione.Text = "Denominazione";
            // 
            // indirizzo
            // 
            this.indirizzo.Text = "Indirizzo";
            // 
            // cap
            // 
            this.cap.Text = "CAP";
            // 
            // localita
            // 
            this.localita.Text = "Località";
            // 
            // frazione
            // 
            this.frazione.Text = "Frazione";
            // 
            // telefono
            // 
            this.telefono.Text = "Telefono";
            // 
            // fax
            // 
            this.fax.Text = "FAX";
            // 
            // indposel
            // 
            this.indposel.Text = "Ind. Pos. El.";
            // 
            // web
            // 
            this.web.Text = "Web";
            // 
            // ces
            // 
            this.ces.Text = "Codice Es.";
            // 
            // camere
            // 
            this.camere.Text = "Camere";
            // 
            // pls
            // 
            this.pls.Text = "P. Letto Standard";
            // 
            // pla
            // 
            this.pla.Text = "P. Letto Agg.";
            // 
            // ricercare
            // 
            this.ricercare.Location = new System.Drawing.Point(18, 197);
            this.ricercare.Name = "ricercare";
            this.ricercare.Size = new System.Drawing.Size(130, 23);
            this.ricercare.TabIndex = 7;
            this.ricercare.Text = "Ricerca";
            this.ricercare.UseVisualStyleBackColor = true;
            this.ricercare.Click += new System.EventHandler(this.ricercare_Click);
            // 
            // mod
            // 
            this.mod.Location = new System.Drawing.Point(18, 227);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(130, 23);
            this.mod.TabIndex = 8;
            this.mod.Text = "Modifica";
            this.mod.UseVisualStyleBackColor = true;
            this.mod.Click += new System.EventHandler(this.mod_Click);
            // 
            // canclogica
            // 
            this.canclogica.Location = new System.Drawing.Point(18, 257);
            this.canclogica.Name = "canclogica";
            this.canclogica.Size = new System.Drawing.Size(130, 23);
            this.canclogica.TabIndex = 9;
            this.canclogica.Text = "Canc Logica";
            this.canclogica.UseVisualStyleBackColor = true;
            this.canclogica.Click += new System.EventHandler(this.canclogica_Click);
            // 
            // reclogico
            // 
            this.reclogico.Location = new System.Drawing.Point(18, 286);
            this.reclogico.Name = "reclogico";
            this.reclogico.Size = new System.Drawing.Size(130, 23);
            this.reclogico.TabIndex = 10;
            this.reclogico.Text = "Recupero Logico";
            this.reclogico.UseVisualStyleBackColor = true;
            this.reclogico.Click += new System.EventHandler(this.reclogico_Click);
            // 
            // ricompattafile
            // 
            this.ricompattafile.Location = new System.Drawing.Point(18, 315);
            this.ricompattafile.Name = "ricompattafile";
            this.ricompattafile.Size = new System.Drawing.Size(130, 23);
            this.ricompattafile.TabIndex = 11;
            this.ricompattafile.Text = "Ricompatta";
            this.ricompattafile.UseVisualStyleBackColor = true;
            this.ricompattafile.Click += new System.EventHandler(this.ricompattafile_Click);
            // 
            // visualizzafile
            // 
            this.visualizzafile.Location = new System.Drawing.Point(18, 344);
            this.visualizzafile.Name = "visualizzafile";
            this.visualizzafile.Size = new System.Drawing.Size(130, 23);
            this.visualizzafile.TabIndex = 12;
            this.visualizzafile.Text = "Visualizza";
            this.visualizzafile.UseVisualStyleBackColor = true;
            this.visualizzafile.Click += new System.EventHandler(this.visualizzafile_Click);
            // 
            // mval
            // 
            this.mval.Text = "MioValore";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.visualizzafile);
            this.Controls.Add(this.ricompattafile);
            this.Controls.Add(this.reclogico);
            this.Controls.Add(this.canclogica);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.ricercare);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.VisCampi);
            this.Controls.Add(this.AggRecord);
            this.Controls.Add(this.LMaxRec);
            this.Controls.Add(this.ConCampi);
            this.Controls.Add(this.aggiusta);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button aggiusta;
        private System.Windows.Forms.Button ConCampi;
        private System.Windows.Forms.Button LMaxRec;
        private System.Windows.Forms.Button AggRecord;
        private System.Windows.Forms.Button VisCampi;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader comune;
        private System.Windows.Forms.ColumnHeader provincia;
        private System.Windows.Forms.ColumnHeader regione;
        private System.Windows.Forms.ColumnHeader tipologia;
        private System.Windows.Forms.ColumnHeader categoria;
        private System.Windows.Forms.ColumnHeader denominazione;
        private System.Windows.Forms.ColumnHeader indirizzo;
        private System.Windows.Forms.ColumnHeader cap;
        private System.Windows.Forms.ColumnHeader localita;
        private System.Windows.Forms.ColumnHeader frazione;
        private System.Windows.Forms.ColumnHeader telefono;
        private System.Windows.Forms.ColumnHeader fax;
        private System.Windows.Forms.ColumnHeader indposel;
        private System.Windows.Forms.ColumnHeader web;
        private System.Windows.Forms.ColumnHeader ces;
        private System.Windows.Forms.ColumnHeader camere;
        private System.Windows.Forms.ColumnHeader pls;
        private System.Windows.Forms.ColumnHeader pla;
        private System.Windows.Forms.Button ricercare;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.Button canclogica;
        private System.Windows.Forms.Button reclogico;
        private System.Windows.Forms.Button ricompattafile;
        private System.Windows.Forms.Button visualizzafile;
        private System.Windows.Forms.ColumnHeader mval;
    }
}

