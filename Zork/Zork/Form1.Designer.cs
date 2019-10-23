namespace Zork
{
    partial class Zork
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
            this.NewGame = new System.Windows.Forms.Button();
            this.Continue = new System.Windows.Forms.Button();
            this.LoadGame = new System.Windows.Forms.Button();
            this.ExitGame = new System.Windows.Forms.Button();
            this.ZorkText = new System.Windows.Forms.Label();
            this.WelcomeMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewGame
            // 
            this.NewGame.Location = new System.Drawing.Point(16, 78);
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(100, 30);
            this.NewGame.TabIndex = 0;
            this.NewGame.Text = "New Game";
            this.NewGame.UseVisualStyleBackColor = true;
            // 
            // Continue
            // 
            this.Continue.Location = new System.Drawing.Point(16, 145);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(100, 30);
            this.Continue.TabIndex = 1;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            // 
            // LoadGame
            // 
            this.LoadGame.Location = new System.Drawing.Point(16, 210);
            this.LoadGame.Name = "LoadGame";
            this.LoadGame.Size = new System.Drawing.Size(100, 30);
            this.LoadGame.TabIndex = 2;
            this.LoadGame.Text = "Load Game";
            this.LoadGame.UseVisualStyleBackColor = true;
            // 
            // ExitGame
            // 
            this.ExitGame.Location = new System.Drawing.Point(16, 282);
            this.ExitGame.Name = "ExitGame";
            this.ExitGame.Size = new System.Drawing.Size(100, 30);
            this.ExitGame.TabIndex = 3;
            this.ExitGame.Text = "Exit Game";
            this.ExitGame.UseVisualStyleBackColor = true;
            // 
            // ZorkText
            // 
            this.ZorkText.AutoSize = true;
            this.ZorkText.Font = new System.Drawing.Font("OCR A Extended", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZorkText.Location = new System.Drawing.Point(255, 210);
            this.ZorkText.Name = "ZorkText";
            this.ZorkText.Size = new System.Drawing.Size(311, 111);
            this.ZorkText.TabIndex = 4;
            this.ZorkText.Text = "Zork";
            // 
            // WelcomeMessage
            // 
            this.WelcomeMessage.AutoSize = true;
            this.WelcomeMessage.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeMessage.Location = new System.Drawing.Point(269, 165);
            this.WelcomeMessage.Name = "WelcomeMessage";
            this.WelcomeMessage.Size = new System.Drawing.Size(285, 29);
            this.WelcomeMessage.TabIndex = 5;
            this.WelcomeMessage.Text = "\"Welcome Message\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(260, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 5);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // Zork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.WelcomeMessage);
            this.Controls.Add(this.ZorkText);
            this.Controls.Add(this.ExitGame);
            this.Controls.Add(this.LoadGame);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.NewGame);
            this.Name = "Zork";
            this.Text = "Zork";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewGame;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Button LoadGame;
        private System.Windows.Forms.Button ExitGame;
        private System.Windows.Forms.Label ZorkText;
        private System.Windows.Forms.Label WelcomeMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

