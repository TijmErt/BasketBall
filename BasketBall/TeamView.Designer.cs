namespace BasketBall
{
    partial class TeamView
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
            this.lbxPlayerList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PlayersClub = new System.Windows.Forms.Label();
            this.PlayerAge = new System.Windows.Forms.Label();
            this.PlayerTeamNumber = new System.Windows.Forms.Label();
            this.PlayerName = new System.Windows.Forms.Label();
            this.cbxTeamSelect = new System.Windows.Forms.ComboBox();
            this.cbClubSelect = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxPlayerList
            // 
            this.lbxPlayerList.FormattingEnabled = true;
            this.lbxPlayerList.ItemHeight = 20;
            this.lbxPlayerList.Location = new System.Drawing.Point(114, 123);
            this.lbxPlayerList.Name = "lbxPlayerList";
            this.lbxPlayerList.Size = new System.Drawing.Size(215, 264);
            this.lbxPlayerList.TabIndex = 0;
            this.lbxPlayerList.SelectedIndexChanged += new System.EventHandler(this.lbxPlayerList_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.PlayersClub);
            this.groupBox1.Controls.Add(this.PlayerAge);
            this.groupBox1.Controls.Add(this.PlayerTeamNumber);
            this.groupBox1.Controls.Add(this.PlayerName);
            this.groupBox1.Location = new System.Drawing.Point(412, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 326);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // PlayersClub
            // 
            this.PlayersClub.AutoSize = true;
            this.PlayersClub.Location = new System.Drawing.Point(31, 242);
            this.PlayersClub.Name = "PlayersClub";
            this.PlayersClub.Size = new System.Drawing.Size(39, 20);
            this.PlayersClub.TabIndex = 3;
            this.PlayersClub.Text = "Club";
            // 
            // PlayerAge
            // 
            this.PlayerAge.AutoSize = true;
            this.PlayerAge.Location = new System.Drawing.Point(31, 183);
            this.PlayerAge.Name = "PlayerAge";
            this.PlayerAge.Size = new System.Drawing.Size(59, 20);
            this.PlayerAge.TabIndex = 2;
            this.PlayerAge.Text = "Leeftijd";
            // 
            // PlayerTeamNumber
            // 
            this.PlayerTeamNumber.AutoSize = true;
            this.PlayerTeamNumber.Location = new System.Drawing.Point(31, 113);
            this.PlayerTeamNumber.Name = "PlayerTeamNumber";
            this.PlayerTeamNumber.Size = new System.Drawing.Size(139, 20);
            this.PlayerTeamNumber.TabIndex = 1;
            this.PlayerTeamNumber.Text = "PlayerTeamNumber";
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.Location = new System.Drawing.Point(31, 47);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(49, 20);
            this.PlayerName.TabIndex = 0;
            this.PlayerName.Text = "Naam";
            // 
            // cbxTeamSelect
            // 
            this.cbxTeamSelect.FormattingEnabled = true;
            this.cbxTeamSelect.Location = new System.Drawing.Point(114, 81);
            this.cbxTeamSelect.Name = "cbxTeamSelect";
            this.cbxTeamSelect.Size = new System.Drawing.Size(151, 28);
            this.cbxTeamSelect.TabIndex = 2;
            this.cbxTeamSelect.SelectedIndexChanged += new System.EventHandler(this.cbxTeamList_SelectedIndexChanged);
            // 
            // cbClubSelect
            // 
            this.cbClubSelect.FormattingEnabled = true;
            this.cbClubSelect.Location = new System.Drawing.Point(114, 47);
            this.cbClubSelect.Name = "cbClubSelect";
            this.cbClubSelect.Size = new System.Drawing.Size(151, 28);
            this.cbClubSelect.TabIndex = 3;
            // 
            // TeamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbClubSelect);
            this.Controls.Add(this.cbxTeamSelect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbxPlayerList);
            this.Name = "TeamView";
            this.Text = "TeamView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lbxPlayerList;
        private GroupBox groupBox1;
        private Label PlayersClub;
        private Label PlayerAge;
        private Label PlayerTeamNumber;
        private Label PlayerName;
        private ComboBox cbxTeamSelect;
        private ComboBox cbClubSelect;
    }
}