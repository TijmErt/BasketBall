namespace BasketBall
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btLeidingGevende = new System.Windows.Forms.Button();
            this.btCoach = new System.Windows.Forms.Button();
            this.btSpeler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btLeidingGevende
            // 
            this.btLeidingGevende.Location = new System.Drawing.Point(59, 62);
            this.btLeidingGevende.Name = "btLeidingGevende";
            this.btLeidingGevende.Size = new System.Drawing.Size(150, 65);
            this.btLeidingGevende.TabIndex = 0;
            this.btLeidingGevende.Text = "LeidingGevende (rob)";
            this.btLeidingGevende.UseVisualStyleBackColor = true;
            this.btLeidingGevende.Click += new System.EventHandler(this.btLeidingGevende_Click);
            // 
            // btCoach
            // 
            this.btCoach.Location = new System.Drawing.Point(59, 188);
            this.btCoach.Name = "btCoach";
            this.btCoach.Size = new System.Drawing.Size(150, 65);
            this.btCoach.TabIndex = 1;
            this.btCoach.Text = "Coach (Elco)";
            this.btCoach.UseVisualStyleBackColor = true;
            // 
            // btSpeler
            // 
            this.btSpeler.Location = new System.Drawing.Point(59, 321);
            this.btSpeler.Name = "btSpeler";
            this.btSpeler.Size = new System.Drawing.Size(150, 65);
            this.btSpeler.TabIndex = 2;
            this.btSpeler.Text = "Speler (Tijm)";
            this.btSpeler.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 450);
            this.Controls.Add(this.btSpeler);
            this.Controls.Add(this.btCoach);
            this.Controls.Add(this.btLeidingGevende);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btLeidingGevende;
        private Button btCoach;
        private Button btSpeler;
    }
}