﻿namespace OrarioVideolezioni
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabella = new System.Windows.Forms.DataGridView();
            this.apriLink_btn = new System.Windows.Forms.Button();
            this.autostart_check = new System.Windows.Forms.CheckBox();
            this.refresher = new System.Windows.Forms.Timer(this.components);
            this.menuprincipale = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importaDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esportaDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aggiungiRigaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rimuoviRigaSelezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gestisciMaterieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informazioniSullapplicazioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paginaGitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ricaricabtn = new System.Windows.Forms.Button();
            this.salvadb = new System.Windows.Forms.SaveFileDialog();
            this.importadb = new System.Windows.Forms.OpenFileDialog();
            this.confermaOpenCk = new System.Windows.Forms.CheckBox();
            this.iconatray = new System.Windows.Forms.NotifyIcon(this.components);
            this.nascondiFinestra = new System.Windows.Forms.Button();
            this.modificaRigaSelezionataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tabella)).BeginInit();
            this.menuprincipale.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabella
            // 
            this.tabella.AllowUserToAddRows = false;
            this.tabella.AllowUserToDeleteRows = false;
            this.tabella.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabella.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabella.Location = new System.Drawing.Point(12, 27);
            this.tabella.Name = "tabella";
            this.tabella.ReadOnly = true;
            this.tabella.Size = new System.Drawing.Size(933, 515);
            this.tabella.TabIndex = 0;
            this.tabella.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabella_CellContentClick);
            this.tabella.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.cambioSortColonna);
            // 
            // apriLink_btn
            // 
            this.apriLink_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.apriLink_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apriLink_btn.Location = new System.Drawing.Point(13, 549);
            this.apriLink_btn.Name = "apriLink_btn";
            this.apriLink_btn.Size = new System.Drawing.Size(130, 23);
            this.apriLink_btn.TabIndex = 1;
            this.apriLink_btn.Text = "APRI LINK ATTIVO";
            this.apriLink_btn.UseVisualStyleBackColor = true;
            this.apriLink_btn.Click += new System.EventHandler(this.apriLink_btn_Click);
            // 
            // autostart_check
            // 
            this.autostart_check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.autostart_check.AutoSize = true;
            this.autostart_check.Location = new System.Drawing.Point(156, 553);
            this.autostart_check.Name = "autostart_check";
            this.autostart_check.Size = new System.Drawing.Size(129, 17);
            this.autostart_check.TabIndex = 5;
            this.autostart_check.Text = "Apri link in automatico";
            this.autostart_check.UseVisualStyleBackColor = true;
            this.autostart_check.CheckedChanged += new System.EventHandler(this.autostart_check_CheckedChanged);
            // 
            // refresher
            // 
            this.refresher.Interval = 5000;
            this.refresher.Tick += new System.EventHandler(this.refresher_Tick);
            // 
            // menuprincipale
            // 
            this.menuprincipale.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.orarioToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuprincipale.Location = new System.Drawing.Point(0, 0);
            this.menuprincipale.Name = "menuprincipale";
            this.menuprincipale.Size = new System.Drawing.Size(958, 24);
            this.menuprincipale.TabIndex = 7;
            this.menuprincipale.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importaDatabaseToolStripMenuItem,
            this.esportaDatabaseToolStripMenuItem,
            this.toolStripSeparator1,
            this.esciToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importaDatabaseToolStripMenuItem
            // 
            this.importaDatabaseToolStripMenuItem.Name = "importaDatabaseToolStripMenuItem";
            this.importaDatabaseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.importaDatabaseToolStripMenuItem.Text = "Apri Database";
            this.importaDatabaseToolStripMenuItem.Click += new System.EventHandler(this.importaDatabaseToolStripMenuItem_Click);
            // 
            // esportaDatabaseToolStripMenuItem
            // 
            this.esportaDatabaseToolStripMenuItem.Name = "esportaDatabaseToolStripMenuItem";
            this.esportaDatabaseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.esportaDatabaseToolStripMenuItem.Text = "Salva Database";
            this.esportaDatabaseToolStripMenuItem.Click += new System.EventHandler(this.esportaDatabaseToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // orarioToolStripMenuItem
            // 
            this.orarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aggiungiRigaToolStripMenuItem,
            this.modificaRigaSelezionataToolStripMenuItem,
            this.rimuoviRigaSelezToolStripMenuItem,
            this.toolStripSeparator2,
            this.gestisciMaterieToolStripMenuItem});
            this.orarioToolStripMenuItem.Name = "orarioToolStripMenuItem";
            this.orarioToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.orarioToolStripMenuItem.Text = "Orario";
            // 
            // aggiungiRigaToolStripMenuItem
            // 
            this.aggiungiRigaToolStripMenuItem.Name = "aggiungiRigaToolStripMenuItem";
            this.aggiungiRigaToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.aggiungiRigaToolStripMenuItem.Text = "Aggiungi Riga";
            this.aggiungiRigaToolStripMenuItem.Click += new System.EventHandler(this.apriFinestraAggRiga);
            // 
            // rimuoviRigaSelezToolStripMenuItem
            // 
            this.rimuoviRigaSelezToolStripMenuItem.Name = "rimuoviRigaSelezToolStripMenuItem";
            this.rimuoviRigaSelezToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.rimuoviRigaSelezToolStripMenuItem.Text = "Rimuovi Riga Selezionata";
            this.rimuoviRigaSelezToolStripMenuItem.Click += new System.EventHandler(this.rimuoviRigaSelezionata_click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
            // 
            // gestisciMaterieToolStripMenuItem
            // 
            this.gestisciMaterieToolStripMenuItem.Name = "gestisciMaterieToolStripMenuItem";
            this.gestisciMaterieToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.gestisciMaterieToolStripMenuItem.Text = "Gestisci Materie";
            this.gestisciMaterieToolStripMenuItem.Click += new System.EventHandler(this.gestisciMaterieToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informazioniSullapplicazioneToolStripMenuItem,
            this.paginaGitHubToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // informazioniSullapplicazioneToolStripMenuItem
            // 
            this.informazioniSullapplicazioneToolStripMenuItem.Name = "informazioniSullapplicazioneToolStripMenuItem";
            this.informazioniSullapplicazioneToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.informazioniSullapplicazioneToolStripMenuItem.Text = "Informazioni sull\'applicazione";
            this.informazioniSullapplicazioneToolStripMenuItem.Click += new System.EventHandler(this.informazioniSullapplicazioneToolStripMenuItem_Click);
            // 
            // paginaGitHubToolStripMenuItem
            // 
            this.paginaGitHubToolStripMenuItem.Name = "paginaGitHubToolStripMenuItem";
            this.paginaGitHubToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.paginaGitHubToolStripMenuItem.Text = "Pagina GitHub";
            this.paginaGitHubToolStripMenuItem.Click += new System.EventHandler(this.paginaGitHubToolStripMenuItem_Click);
            // 
            // ricaricabtn
            // 
            this.ricaricabtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ricaricabtn.Location = new System.Drawing.Point(870, 549);
            this.ricaricabtn.Name = "ricaricabtn";
            this.ricaricabtn.Size = new System.Drawing.Size(75, 23);
            this.ricaricabtn.TabIndex = 8;
            this.ricaricabtn.Text = "RICARICA";
            this.ricaricabtn.UseVisualStyleBackColor = true;
            this.ricaricabtn.Click += new System.EventHandler(this.ricaricabtn_click);
            // 
            // salvadb
            // 
            this.salvadb.FileName = "database.db";
            this.salvadb.Filter = "File di Database|*.db";
            this.salvadb.Title = "Esportazione database...";
            // 
            // importadb
            // 
            this.importadb.Filter = "File di Database|*.db";
            this.importadb.Title = "Importazione database...";
            // 
            // confermaOpenCk
            // 
            this.confermaOpenCk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.confermaOpenCk.AutoSize = true;
            this.confermaOpenCk.Location = new System.Drawing.Point(291, 553);
            this.confermaOpenCk.Name = "confermaOpenCk";
            this.confermaOpenCk.Size = new System.Drawing.Size(216, 17);
            this.confermaOpenCk.TabIndex = 9;
            this.confermaOpenCk.Text = "Non chiedere conferma per apertura link";
            this.confermaOpenCk.UseVisualStyleBackColor = true;
            this.confermaOpenCk.CheckedChanged += new System.EventHandler(this.confermaOpenCk_CheckedChanged);
            // 
            // iconatray
            // 
            this.iconatray.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.iconatray.Icon = ((System.Drawing.Icon)(resources.GetObject("iconatray.Icon")));
            this.iconatray.Text = "Orario Videolezioni";
            this.iconatray.Visible = true;
            this.iconatray.MouseClick += new System.Windows.Forms.MouseEventHandler(this.iconatray_MouseClick);
            // 
            // nascondiFinestra
            // 
            this.nascondiFinestra.Location = new System.Drawing.Point(758, 549);
            this.nascondiFinestra.Name = "nascondiFinestra";
            this.nascondiFinestra.Size = new System.Drawing.Size(106, 23);
            this.nascondiFinestra.TabIndex = 10;
            this.nascondiFinestra.Text = "RIDUCI IN TRAY";
            this.nascondiFinestra.UseVisualStyleBackColor = true;
            this.nascondiFinestra.Click += new System.EventHandler(this.nascondiFinestra_Click);
            // 
            // modificaRigaSelezionataToolStripMenuItem
            // 
            this.modificaRigaSelezionataToolStripMenuItem.Name = "modificaRigaSelezionataToolStripMenuItem";
            this.modificaRigaSelezionataToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.modificaRigaSelezionataToolStripMenuItem.Text = "Modifica Riga Selezionata";
            this.modificaRigaSelezionataToolStripMenuItem.Click += new System.EventHandler(this.modificaRigaSelezionataToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 582);
            this.Controls.Add(this.nascondiFinestra);
            this.Controls.Add(this.confermaOpenCk);
            this.Controls.Add(this.ricaricabtn);
            this.Controls.Add(this.autostart_check);
            this.Controls.Add(this.apriLink_btn);
            this.Controls.Add(this.tabella);
            this.Controls.Add(this.menuprincipale);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuprincipale;
            this.MinimumSize = new System.Drawing.Size(392, 299);
            this.Name = "Form1";
            this.Text = "Orario Videolezioni";
            this.Load += new System.EventHandler(this.finestraCaricata);
            ((System.ComponentModel.ISupportInitialize)(this.tabella)).EndInit();
            this.menuprincipale.ResumeLayout(false);
            this.menuprincipale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabella;
        private System.Windows.Forms.Button apriLink_btn;
        private System.Windows.Forms.CheckBox autostart_check;
        private System.Windows.Forms.Timer refresher;
        private System.Windows.Forms.MenuStrip menuprincipale;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importaDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esportaDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aggiungiRigaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rimuoviRigaSelezToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestisciMaterieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informazioniSullapplicazioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paginaGitHubToolStripMenuItem;
        private System.Windows.Forms.Button ricaricabtn;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog salvadb;
        private System.Windows.Forms.OpenFileDialog importadb;
        private System.Windows.Forms.CheckBox confermaOpenCk;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.NotifyIcon iconatray;
        private System.Windows.Forms.Button nascondiFinestra;
        private System.Windows.Forms.ToolStripMenuItem modificaRigaSelezionataToolStripMenuItem;
    }
}

