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
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(184, 63);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(595, 362);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

