namespace BasketBall
{
    partial class TeamAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbxAvalaibleSpelers = new System.Windows.Forms.ListBox();
            this.lbxaddedSpelers = new System.Windows.Forms.ListBox();
            this.btAddSpeler = new System.Windows.Forms.Button();
            this.btRemoveSpeler = new System.Windows.Forms.Button();
            this.cbxLeeftijdsCatagorie = new System.Windows.Forms.ComboBox();
            this.tbxTeamName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbClubSelect = new System.Windows.Forms.ComboBox();
            this.bBSpelersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bBSpelersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxAvalaibleSpelers
            // 
            this.lbxAvalaibleSpelers.FormattingEnabled = true;
            this.lbxAvalaibleSpelers.ItemHeight = 20;
            this.lbxAvalaibleSpelers.Location = new System.Drawing.Point(139, 144);
            this.lbxAvalaibleSpelers.Name = "lbxAvalaibleSpelers";
            this.lbxAvalaibleSpelers.Size = new System.Drawing.Size(193, 264);
            this.lbxAvalaibleSpelers.TabIndex = 0;
            // 
            // lbxaddedSpelers
            // 
            this.lbxaddedSpelers.FormattingEnabled = true;
            this.lbxaddedSpelers.ItemHeight = 20;
            this.lbxaddedSpelers.Location = new System.Drawing.Point(462, 144);
            this.lbxaddedSpelers.Name = "lbxaddedSpelers";
            this.lbxaddedSpelers.Size = new System.Drawing.Size(178, 264);
            this.lbxaddedSpelers.TabIndex = 1;
            // 
            // btAddSpeler
            // 
            this.btAddSpeler.Location = new System.Drawing.Point(338, 221);
            this.btAddSpeler.Name = "btAddSpeler";
            this.btAddSpeler.Size = new System.Drawing.Size(118, 42);
            this.btAddSpeler.TabIndex = 2;
            this.btAddSpeler.Text = ">>>";
            this.btAddSpeler.UseVisualStyleBackColor = true;
            this.btAddSpeler.Click += new System.EventHandler(this.btAddSpeler_Click);
            // 
            // btRemoveSpeler
            // 
            this.btRemoveSpeler.Location = new System.Drawing.Point(338, 293);
            this.btRemoveSpeler.Name = "btRemoveSpeler";
            this.btRemoveSpeler.Size = new System.Drawing.Size(118, 42);
            this.btRemoveSpeler.TabIndex = 3;
            this.btRemoveSpeler.Text = "<<<";
            this.btRemoveSpeler.UseVisualStyleBackColor = true;
            this.btRemoveSpeler.Click += new System.EventHandler(this.btRemoveSpeler_Click);
            // 
            // cbxLeeftijdsCatagorie
            // 
            this.cbxLeeftijdsCatagorie.FormattingEnabled = true;
            this.cbxLeeftijdsCatagorie.Location = new System.Drawing.Point(139, 38);
            this.cbxLeeftijdsCatagorie.Name = "cbxLeeftijdsCatagorie";
            this.cbxLeeftijdsCatagorie.Size = new System.Drawing.Size(151, 28);
            this.cbxLeeftijdsCatagorie.TabIndex = 5;
            this.cbxLeeftijdsCatagorie.SelectedIndexChanged += new System.EventHandler(this.cbxLeeftijdsCatagorie_SelectedIndexChanged);
            // 
            // tbxTeamName
            // 
            this.tbxTeamName.Location = new System.Drawing.Point(139, 86);
            this.tbxTeamName.Name = "tbxTeamName";
            this.tbxTeamName.Size = new System.Drawing.Size(193, 27);
            this.tbxTeamName.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.cbClubSelect);
            this.groupBox1.Location = new System.Drawing.Point(504, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 62);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temp";
            // 
            // cbClubSelect
            // 
            this.cbClubSelect.FormattingEnabled = true;
            this.cbClubSelect.Location = new System.Drawing.Point(15, 23);
            this.cbClubSelect.Name = "cbClubSelect";
            this.cbClubSelect.Size = new System.Drawing.Size(151, 28);
            this.cbClubSelect.TabIndex = 8;
            this.cbClubSelect.SelectedIndexChanged += new System.EventHandler(this.cbClubSelect_SelectedIndexChanged);
            // 
            // bBSpelersBindingSource
            // 
            this.bBSpelersBindingSource.DataSource = typeof(BBClassLib.BBPersoon);
            // 
            // TeamAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbxTeamName);
            this.Controls.Add(this.cbxLeeftijdsCatagorie);
            this.Controls.Add(this.btRemoveSpeler);
            this.Controls.Add(this.btAddSpeler);
            this.Controls.Add(this.lbxaddedSpelers);
            this.Controls.Add(this.lbxAvalaibleSpelers);
            this.Name = "TeamAdd";
            this.Text = "TeamAdd";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bBSpelersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbxAvalaibleSpelers;
        private ListBox lbxaddedSpelers;
        private Button btAddSpeler;
        private Button btRemoveSpeler;
        private ComboBox cbxLeeftijdsCatagorie;
        private TextBox tbxTeamName;
        private GroupBox groupBox1;
        private ComboBox cbClubSelect;
        private BindingSource bBSpelersBindingSource;
    }
}