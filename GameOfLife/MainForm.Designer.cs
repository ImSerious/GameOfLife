namespace GameOfLife
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelDraw = new System.Windows.Forms.Panel();
            this.bStart = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelCellsSpawnedFixed = new System.Windows.Forms.Label();
            this.lCellsDestroyedFixed = new System.Windows.Forms.Label();
            this.lGenerationFixed = new System.Windows.Forms.Label();
            this.lCellsFixed = new System.Windows.Forms.Label();
            this.lGenerations = new System.Windows.Forms.Label();
            this.lCells = new System.Windows.Forms.Label();
            this.lDestroyed = new System.Windows.Forms.Label();
            this.lCreated = new System.Windows.Forms.Label();
            this.tbSpawnCount = new System.Windows.Forms.TextBox();
            this.tbScale = new System.Windows.Forms.TextBox();
            this.trackTime = new System.Windows.Forms.TrackBar();
            this.lTime = new System.Windows.Forms.Label();
            this.lCellulesFixed = new System.Windows.Forms.Label();
            this.lEchelleFixed = new System.Windows.Forms.Label();
            this.lMs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackTime)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDraw
            // 
            this.panelDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panelDraw.Location = new System.Drawing.Point(0, 0);
            this.panelDraw.Name = "panelDraw";
            this.panelDraw.Size = new System.Drawing.Size(1000, 500);
            this.panelDraw.TabIndex = 0;
            this.panelDraw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GridClick);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(23, 522);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(151, 53);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.StartClick);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // labelCellsSpawnedFixed
            // 
            this.labelCellsSpawnedFixed.AutoSize = true;
            this.labelCellsSpawnedFixed.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCellsSpawnedFixed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCellsSpawnedFixed.Location = new System.Drawing.Point(770, 514);
            this.labelCellsSpawnedFixed.Name = "labelCellsSpawnedFixed";
            this.labelCellsSpawnedFixed.Size = new System.Drawing.Size(90, 19);
            this.labelCellsSpawnedFixed.TabIndex = 4;
            this.labelCellsSpawnedFixed.Text = "Cellules crées";
            // 
            // lCellsDestroyedFixed
            // 
            this.lCellsDestroyedFixed.AutoSize = true;
            this.lCellsDestroyedFixed.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCellsDestroyedFixed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lCellsDestroyedFixed.Location = new System.Drawing.Point(747, 532);
            this.lCellsDestroyedFixed.Name = "lCellsDestroyedFixed";
            this.lCellsDestroyedFixed.Size = new System.Drawing.Size(113, 19);
            this.lCellsDestroyedFixed.TabIndex = 5;
            this.lCellsDestroyedFixed.Text = "Cellules détruites";
            // 
            // lGenerationFixed
            // 
            this.lGenerationFixed.AutoSize = true;
            this.lGenerationFixed.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGenerationFixed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lGenerationFixed.Location = new System.Drawing.Point(777, 567);
            this.lGenerationFixed.Name = "lGenerationFixed";
            this.lGenerationFixed.Size = new System.Drawing.Size(83, 19);
            this.lGenerationFixed.TabIndex = 7;
            this.lGenerationFixed.Text = "Générations";
            // 
            // lCellsFixed
            // 
            this.lCellsFixed.AutoSize = true;
            this.lCellsFixed.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCellsFixed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lCellsFixed.Location = new System.Drawing.Point(805, 550);
            this.lCellsFixed.Name = "lCellsFixed";
            this.lCellsFixed.Size = new System.Drawing.Size(55, 19);
            this.lCellsFixed.TabIndex = 6;
            this.lCellsFixed.Text = "Cellules";
            // 
            // lGenerations
            // 
            this.lGenerations.AutoSize = true;
            this.lGenerations.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lGenerations.ForeColor = System.Drawing.Color.DarkGray;
            this.lGenerations.Location = new System.Drawing.Point(865, 568);
            this.lGenerations.Name = "lGenerations";
            this.lGenerations.Size = new System.Drawing.Size(17, 19);
            this.lGenerations.TabIndex = 11;
            this.lGenerations.Text = "0";
            // 
            // lCells
            // 
            this.lCells.AutoSize = true;
            this.lCells.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCells.ForeColor = System.Drawing.Color.DarkGray;
            this.lCells.Location = new System.Drawing.Point(865, 551);
            this.lCells.Name = "lCells";
            this.lCells.Size = new System.Drawing.Size(17, 19);
            this.lCells.TabIndex = 10;
            this.lCells.Text = "0";
            // 
            // lDestroyed
            // 
            this.lDestroyed.AutoSize = true;
            this.lDestroyed.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDestroyed.ForeColor = System.Drawing.Color.DarkGray;
            this.lDestroyed.Location = new System.Drawing.Point(865, 533);
            this.lDestroyed.Name = "lDestroyed";
            this.lDestroyed.Size = new System.Drawing.Size(17, 19);
            this.lDestroyed.TabIndex = 9;
            this.lDestroyed.Text = "0";
            // 
            // lCreated
            // 
            this.lCreated.AutoSize = true;
            this.lCreated.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCreated.ForeColor = System.Drawing.Color.DarkGray;
            this.lCreated.Location = new System.Drawing.Point(865, 515);
            this.lCreated.Name = "lCreated";
            this.lCreated.Size = new System.Drawing.Size(17, 19);
            this.lCreated.TabIndex = 8;
            this.lCreated.Text = "0";
            // 
            // tbSpawnCount
            // 
            this.tbSpawnCount.Location = new System.Drawing.Point(264, 524);
            this.tbSpawnCount.Name = "tbSpawnCount";
            this.tbSpawnCount.Size = new System.Drawing.Size(100, 22);
            this.tbSpawnCount.TabIndex = 2;
            this.tbSpawnCount.Text = "5000";
            // 
            // tbScale
            // 
            this.tbScale.Location = new System.Drawing.Point(264, 549);
            this.tbScale.Name = "tbScale";
            this.tbScale.Size = new System.Drawing.Size(100, 22);
            this.tbScale.TabIndex = 12;
            this.tbScale.Text = "5";
            // 
            // trackTime
            // 
            this.trackTime.Location = new System.Drawing.Point(386, 522);
            this.trackTime.Maximum = 1000;
            this.trackTime.Minimum = 100;
            this.trackTime.Name = "trackTime";
            this.trackTime.Size = new System.Drawing.Size(308, 56);
            this.trackTime.SmallChange = 100;
            this.trackTime.TabIndex = 3;
            this.trackTime.TickFrequency = 100;
            this.trackTime.Value = 100;
            this.trackTime.Scroll += new System.EventHandler(this.TimeScroll);
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Location = new System.Drawing.Point(533, 558);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(32, 17);
            this.lTime.TabIndex = 15;
            this.lTime.Text = "100";
            // 
            // lCellulesFixed
            // 
            this.lCellulesFixed.AutoSize = true;
            this.lCellulesFixed.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCellulesFixed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lCellulesFixed.Location = new System.Drawing.Point(205, 526);
            this.lCellulesFixed.Name = "lCellulesFixed";
            this.lCellulesFixed.Size = new System.Drawing.Size(55, 19);
            this.lCellulesFixed.TabIndex = 16;
            this.lCellulesFixed.Text = "Cellules";
            // 
            // lEchelleFixed
            // 
            this.lEchelleFixed.AutoSize = true;
            this.lEchelleFixed.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEchelleFixed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lEchelleFixed.Location = new System.Drawing.Point(209, 550);
            this.lEchelleFixed.Name = "lEchelleFixed";
            this.lEchelleFixed.Size = new System.Drawing.Size(50, 19);
            this.lEchelleFixed.TabIndex = 17;
            this.lEchelleFixed.Text = "Echelle";
            // 
            // lMs
            // 
            this.lMs.AutoSize = true;
            this.lMs.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMs.Location = new System.Drawing.Point(537, 573);
            this.lMs.Name = "lMs";
            this.lMs.Size = new System.Drawing.Size(26, 13);
            this.lMs.TabIndex = 18;
            this.lMs.Text = "(ms)";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(999, 598);
            this.Controls.Add(this.lMs);
            this.Controls.Add(this.lEchelleFixed);
            this.Controls.Add(this.lCellulesFixed);
            this.Controls.Add(this.lTime);
            this.Controls.Add(this.tbScale);
            this.Controls.Add(this.lGenerations);
            this.Controls.Add(this.lCells);
            this.Controls.Add(this.lDestroyed);
            this.Controls.Add(this.lCreated);
            this.Controls.Add(this.lGenerationFixed);
            this.Controls.Add(this.lCellsFixed);
            this.Controls.Add(this.lCellsDestroyedFixed);
            this.Controls.Add(this.labelCellsSpawnedFixed);
            this.Controls.Add(this.trackTime);
            this.Controls.Add(this.tbSpawnCount);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.panelDraw);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conway\'s game of life";
            this.Load += new System.EventHandler(this.Loading);
            ((System.ComponentModel.ISupportInitialize)(this.trackTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDraw;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelCellsSpawnedFixed;
        private System.Windows.Forms.Label lCellsDestroyedFixed;
        private System.Windows.Forms.Label lGenerationFixed;
        private System.Windows.Forms.Label lCellsFixed;
        private System.Windows.Forms.Label lGenerations;
        private System.Windows.Forms.Label lCells;
        private System.Windows.Forms.Label lDestroyed;
        private System.Windows.Forms.Label lCreated;
        private System.Windows.Forms.TextBox tbSpawnCount;
        private System.Windows.Forms.TextBox tbScale;
        private System.Windows.Forms.TrackBar trackTime;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.Label lCellulesFixed;
        private System.Windows.Forms.Label lEchelleFixed;
        private System.Windows.Forms.Label lMs;
    }
}

