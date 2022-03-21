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
            this.lbxAvalaibleSpelers = new System.Windows.Forms.ListBox();
            this.lbxaddedSpelers = new System.Windows.Forms.ListBox();
            this.btAddSpeler = new System.Windows.Forms.Button();
            this.btRemoveSpeler = new System.Windows.Forms.Button();
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
            // TeamAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRemoveSpeler);
            this.Controls.Add(this.btAddSpeler);
            this.Controls.Add(this.lbxaddedSpelers);
            this.Controls.Add(this.lbxAvalaibleSpelers);
            this.Name = "TeamAdd";
            this.Text = "TeamAdd";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lbxAvalaibleSpelers;
        private ListBox lbxaddedSpelers;
        private Button btAddSpeler;
        private Button btRemoveSpeler;
    }
}