
namespace blackjackGUI
{
    partial class Blackjack
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blackjack));
            this.hitMeButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.splitButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.playerScore = new System.Windows.Forms.Label();
            this.dealerScore = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.victoryLabel = new System.Windows.Forms.Label();
            this.loseLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hitMeButton
            // 
            this.hitMeButton.Enabled = false;
            this.hitMeButton.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitMeButton.ForeColor = System.Drawing.Color.Black;
            this.hitMeButton.Location = new System.Drawing.Point(208, 348);
            this.hitMeButton.Margin = new System.Windows.Forms.Padding(4);
            this.hitMeButton.Name = "hitMeButton";
            this.hitMeButton.Size = new System.Drawing.Size(129, 42);
            this.hitMeButton.TabIndex = 0;
            this.hitMeButton.Text = "Pedir Carta";
            this.hitMeButton.UseVisualStyleBackColor = true;
            this.hitMeButton.Click += new System.EventHandler(this.hitMeButton_Click);
            // 
            // standButton
            // 
            this.standButton.Enabled = false;
            this.standButton.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standButton.ForeColor = System.Drawing.Color.Black;
            this.standButton.Location = new System.Drawing.Point(379, 348);
            this.standButton.Margin = new System.Windows.Forms.Padding(4);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(141, 42);
            this.standButton.TabIndex = 1;
            this.standButton.Text = "Parar Juego";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // splitButton
            // 
            this.splitButton.Enabled = false;
            this.splitButton.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitButton.Location = new System.Drawing.Point(502, 348);
            this.splitButton.Margin = new System.Windows.Forms.Padding(4);
            this.splitButton.Name = "splitButton";
            this.splitButton.Size = new System.Drawing.Size(100, 42);
            this.splitButton.TabIndex = 2;
            this.splitButton.Text = "Dividir";
            this.splitButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Black;
            this.startButton.Location = new System.Drawing.Point(23, 348);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(123, 42);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Comenzar";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore.Location = new System.Drawing.Point(203, 102);
            this.playerScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(121, 29);
            this.playerScore.TabIndex = 6;
            this.playerScore.Text = "Puntuación: ";
            // 
            // dealerScore
            // 
            this.dealerScore.AutoSize = true;
            this.dealerScore.Location = new System.Drawing.Point(20, 16);
            this.dealerScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dealerScore.Name = "dealerScore";
            this.dealerScore.Size = new System.Drawing.Size(0, 17);
            this.dealerScore.TabIndex = 9;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(161, 177);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 17);
            this.resultLabel.TabIndex = 10;
            // 
            // victoryLabel
            // 
            this.victoryLabel.AutoSize = true;
            this.victoryLabel.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.victoryLabel.Location = new System.Drawing.Point(18, 102);
            this.victoryLabel.Name = "victoryLabel";
            this.victoryLabel.Size = new System.Drawing.Size(98, 29);
            this.victoryLabel.TabIndex = 11;
            this.victoryLabel.Text = "Victorias: ";
            // 
            // loseLabel
            // 
            this.loseLabel.AutoSize = true;
            this.loseLabel.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loseLabel.Location = new System.Drawing.Point(402, 102);
            this.loseLabel.Name = "loseLabel";
            this.loseLabel.Size = new System.Drawing.Size(99, 29);
            this.loseLabel.TabIndex = 12;
            this.loseLabel.Text = "Derrotas: ";
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 46);
            this.label1.TabIndex = 13;
            this.label1.Text = "Blackjack Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(50, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(332, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "Dealer";
            // 
            // Blackjack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(551, 407);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loseLabel);
            this.Controls.Add(this.victoryLabel);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.dealerScore);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.splitButton);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.hitMeButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Blackjack";
            this.Text = "UPB\'s Blackjack";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hitMeButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Button splitButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label dealerScore;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label victoryLabel;
        private System.Windows.Forms.Label loseLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

