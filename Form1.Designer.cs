namespace RaceTrack
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Dog4 = new System.Windows.Forms.PictureBox();
            this.Dog3 = new System.Windows.Forms.PictureBox();
            this.Dog2 = new System.Windows.Forms.PictureBox();
            this.Dog1 = new System.Windows.Forms.PictureBox();
            this.BGImage = new System.Windows.Forms.PictureBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.BetAmount = new System.Windows.Forms.NumericUpDown();
            this.DogNumber = new System.Windows.Forms.NumericUpDown();
            this.JoeButton = new System.Windows.Forms.RadioButton();
            this.BobButton = new System.Windows.Forms.RadioButton();
            this.AlButton = new System.Windows.Forms.RadioButton();
            this.Player = new System.Windows.Forms.Label();
            this.BetsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.JoeBet = new System.Windows.Forms.Label();
            this.BobBet = new System.Windows.Forms.Label();
            this.AlBet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // Dog4
            // 
            this.Dog4.Image = global::RaceTrack.Properties.Resources.dog;
            this.Dog4.Location = new System.Drawing.Point(12, 169);
            this.Dog4.Name = "Dog4";
            this.Dog4.Size = new System.Drawing.Size(77, 18);
            this.Dog4.TabIndex = 8;
            this.Dog4.TabStop = false;
            // 
            // Dog3
            // 
            this.Dog3.Image = ((System.Drawing.Image)(resources.GetObject("Dog3.Image")));
            this.Dog3.Location = new System.Drawing.Point(12, 115);
            this.Dog3.Name = "Dog3";
            this.Dog3.Size = new System.Drawing.Size(77, 18);
            this.Dog3.TabIndex = 7;
            this.Dog3.TabStop = false;
            // 
            // Dog2
            // 
            this.Dog2.Image = ((System.Drawing.Image)(resources.GetObject("Dog2.Image")));
            this.Dog2.Location = new System.Drawing.Point(12, 61);
            this.Dog2.Name = "Dog2";
            this.Dog2.Size = new System.Drawing.Size(77, 18);
            this.Dog2.TabIndex = 6;
            this.Dog2.TabStop = false;
            // 
            // Dog1
            // 
            this.Dog1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Dog1.Image = ((System.Drawing.Image)(resources.GetObject("Dog1.Image")));
            this.Dog1.Location = new System.Drawing.Point(12, 12);
            this.Dog1.Name = "Dog1";
            this.Dog1.Size = new System.Drawing.Size(77, 18);
            this.Dog1.TabIndex = 5;
            this.Dog1.TabStop = false;
            // 
            // BGImage
            // 
            this.BGImage.Image = ((System.Drawing.Image)(resources.GetObject("BGImage.Image")));
            this.BGImage.Location = new System.Drawing.Point(1, 2);
            this.BGImage.Name = "BGImage";
            this.BGImage.Size = new System.Drawing.Size(601, 203);
            this.BGImage.TabIndex = 4;
            this.BGImage.TabStop = false;
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(507, 347);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 9;
            this.RunButton.Text = "Race";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // BetAmount
            // 
            this.BetAmount.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BetAmount.Location = new System.Drawing.Point(176, 345);
            this.BetAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BetAmount.Name = "BetAmount";
            this.BetAmount.Size = new System.Drawing.Size(45, 20);
            this.BetAmount.TabIndex = 10;
            this.BetAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // DogNumber
            // 
            this.DogNumber.Location = new System.Drawing.Point(435, 345);
            this.DogNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.DogNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DogNumber.Name = "DogNumber";
            this.DogNumber.Size = new System.Drawing.Size(47, 20);
            this.DogNumber.TabIndex = 11;
            this.DogNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // JoeButton
            // 
            this.JoeButton.AutoSize = true;
            this.JoeButton.Location = new System.Drawing.Point(43, 260);
            this.JoeButton.Name = "JoeButton";
            this.JoeButton.Size = new System.Drawing.Size(42, 17);
            this.JoeButton.TabIndex = 12;
            this.JoeButton.TabStop = true;
            this.JoeButton.Text = "Joe";
            this.JoeButton.UseVisualStyleBackColor = true;
            this.JoeButton.CheckedChanged += new System.EventHandler(this.JoeButton_CheckedChanged);
            // 
            // BobButton
            // 
            this.BobButton.AutoSize = true;
            this.BobButton.Location = new System.Drawing.Point(43, 284);
            this.BobButton.Name = "BobButton";
            this.BobButton.Size = new System.Drawing.Size(44, 17);
            this.BobButton.TabIndex = 13;
            this.BobButton.TabStop = true;
            this.BobButton.Text = "Bob";
            this.BobButton.UseVisualStyleBackColor = true;
            this.BobButton.CheckedChanged += new System.EventHandler(this.BobButton_CheckedChanged);
            // 
            // AlButton
            // 
            this.AlButton.AutoSize = true;
            this.AlButton.Location = new System.Drawing.Point(43, 307);
            this.AlButton.Name = "AlButton";
            this.AlButton.Size = new System.Drawing.Size(34, 17);
            this.AlButton.TabIndex = 14;
            this.AlButton.TabStop = true;
            this.AlButton.Text = "Al";
            this.AlButton.UseVisualStyleBackColor = true;
            this.AlButton.CheckedChanged += new System.EventHandler(this.AlButton_CheckedChanged);
            // 
            // Player
            // 
            this.Player.AutoSize = true;
            this.Player.Location = new System.Drawing.Point(27, 352);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(36, 13);
            this.Player.TabIndex = 15;
            this.Player.Text = "Player";
            // 
            // BetsButton
            // 
            this.BetsButton.Location = new System.Drawing.Point(83, 345);
            this.BetsButton.Name = "BetsButton";
            this.BetsButton.Size = new System.Drawing.Size(75, 23);
            this.BetsButton.TabIndex = 16;
            this.BetsButton.Text = "Bets";
            this.BetsButton.UseVisualStyleBackColor = true;
            this.BetsButton.Click += new System.EventHandler(this.BetsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Buckts on dog number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Minimum Bet 5$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Bets";
            // 
            // JoeBet
            // 
            this.JoeBet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.JoeBet.Location = new System.Drawing.Point(403, 264);
            this.JoeBet.Name = "JoeBet";
            this.JoeBet.Size = new System.Drawing.Size(179, 13);
            this.JoeBet.TabIndex = 20;
            this.JoeBet.Text = "Joe\'s Bet";
            // 
            // BobBet
            // 
            this.BobBet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BobBet.Location = new System.Drawing.Point(403, 286);
            this.BobBet.Name = "BobBet";
            this.BobBet.Size = new System.Drawing.Size(179, 15);
            this.BobBet.TabIndex = 21;
            this.BobBet.Text = "Bob\'s Bet";
            // 
            // AlBet
            // 
            this.AlBet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AlBet.Location = new System.Drawing.Point(403, 307);
            this.AlBet.Name = "AlBet";
            this.AlBet.Size = new System.Drawing.Size(179, 17);
            this.AlBet.TabIndex = 22;
            this.AlBet.Text = "Al\'s Bet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 391);
            this.Controls.Add(this.AlBet);
            this.Controls.Add(this.BobBet);
            this.Controls.Add(this.JoeBet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BetsButton);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.AlButton);
            this.Controls.Add(this.BobButton);
            this.Controls.Add(this.JoeButton);
            this.Controls.Add(this.DogNumber);
            this.Controls.Add(this.BetAmount);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.Dog4);
            this.Controls.Add(this.Dog3);
            this.Controls.Add(this.Dog2);
            this.Controls.Add(this.Dog1);
            this.Controls.Add(this.BGImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DogNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BGImage;
        private System.Windows.Forms.PictureBox Dog1;
        private System.Windows.Forms.PictureBox Dog2;
        private System.Windows.Forms.PictureBox Dog3;
        private System.Windows.Forms.PictureBox Dog4;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.NumericUpDown BetAmount;
        private System.Windows.Forms.NumericUpDown DogNumber;
        private System.Windows.Forms.RadioButton JoeButton;
        private System.Windows.Forms.RadioButton BobButton;
        private System.Windows.Forms.RadioButton AlButton;
        private System.Windows.Forms.Label Player;
        private System.Windows.Forms.Button BetsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label JoeBet;
        private System.Windows.Forms.Label BobBet;
        private System.Windows.Forms.Label AlBet;
    }
}

