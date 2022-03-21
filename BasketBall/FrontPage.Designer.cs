namespace BasketBall
{
    partial class FrontPage
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
            this.btTeamView = new System.Windows.Forms.Button();
            this.btTeamAdd = new System.Windows.Forms.Button();
            this.PersoonIngelogd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btTeamView
            // 
            this.btTeamView.Location = new System.Drawing.Point(77, 315);
            this.btTeamView.Name = "btTeamView";
            this.btTeamView.Size = new System.Drawing.Size(94, 54);
            this.btTeamView.TabIndex = 0;
            this.btTeamView.Text = "Team View";
            this.btTeamView.UseVisualStyleBackColor = true;
            this.btTeamView.Click += new System.EventHandler(this.btTeamView_Click);
            // 
            // btTeamAdd
            // 
            this.btTeamAdd.Location = new System.Drawing.Point(259, 315);
            this.btTeamAdd.Name = "btTeamAdd";
            this.btTeamAdd.Size = new System.Drawing.Size(109, 54);
            this.btTeamAdd.TabIndex = 1;
            this.btTeamAdd.Text = "Team Add";
            this.btTeamAdd.UseVisualStyleBackColor = true;
            this.btTeamAdd.Click += new System.EventHandler(this.btTeamAdd_Click);
            // 
            // PersoonIngelogd
            // 
            this.PersoonIngelogd.AutoSize = true;
            this.PersoonIngelogd.Location = new System.Drawing.Point(77, 83);
            this.PersoonIngelogd.Name = "PersoonIngelogd";
            this.PersoonIngelogd.Size = new System.Drawing.Size(121, 20);
            this.PersoonIngelogd.TabIndex = 2;
            this.PersoonIngelogd.Text = "PersoonIngelogd";
            // 
            // FrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PersoonIngelogd);
            this.Controls.Add(this.btTeamAdd);
            this.Controls.Add(this.btTeamView);
            this.Name = "FrontPage";
            this.Text = "FrontPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btTeamView;
        private Button btTeamAdd;
        private Label PersoonIngelogd;
    }
}