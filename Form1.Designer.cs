namespace CS311_Project2_MJC
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
            pictDice1 = new PictureBox();
            pictDice2 = new PictureBox();
            btnRoll = new Button();
            txtResult = new TextBox();
            lblWallet = new Label();
            lblRoll = new Label();
            txtWallet = new TextBox();
            lblPoint = new Label();
            txtPoint = new TextBox();
            lblNumRolls = new Label();
            txtNumRolls = new TextBox();
            lblBet = new Label();
            txtBet = new TextBox();
            lblDollarSign = new Label();
            lblWinCon = new Label();
            lblLoseCon = new Label();
            lblHowToWin = new Label();
            lblHowToLose = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictDice1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictDice2).BeginInit();
            SuspendLayout();
            // 
            // pictDice1
            // 
            pictDice1.Image = Properties.Resources.dice6;
            pictDice1.Location = new Point(36, 73);
            pictDice1.Name = "pictDice1";
            pictDice1.Size = new Size(512, 512);
            pictDice1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictDice1.TabIndex = 0;
            pictDice1.TabStop = false;
            pictDice1.Click += pictDice1_Click;
            // 
            // pictDice2
            // 
            pictDice2.Image = Properties.Resources.dice6;
            pictDice2.Location = new Point(635, 73);
            pictDice2.Name = "pictDice2";
            pictDice2.Size = new Size(512, 512);
            pictDice2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictDice2.TabIndex = 1;
            pictDice2.TabStop = false;
            // 
            // btnRoll
            // 
            btnRoll.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoll.Location = new Point(484, 689);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(187, 62);
            btnRoll.TabIndex = 2;
            btnRoll.Text = "Roll!";
            btnRoll.UseVisualStyleBackColor = true;
            btnRoll.Click += btnRoll_Click;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResult.Location = new Point(603, 591);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(125, 43);
            txtResult.TabIndex = 4;
            // 
            // lblWallet
            // 
            lblWallet.AutoSize = true;
            lblWallet.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWallet.Location = new Point(990, 589);
            lblWallet.Name = "lblWallet";
            lblWallet.Size = new Size(101, 38);
            lblWallet.TabIndex = 5;
            lblWallet.Text = "Wallet";
            // 
            // lblRoll
            // 
            lblRoll.AutoSize = true;
            lblRoll.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoll.Location = new Point(434, 593);
            lblRoll.Name = "lblRoll";
            lblRoll.Size = new Size(163, 38);
            lblRoll.TabIndex = 6;
            lblRoll.Text = "You Rolled:";
            lblRoll.Click += lblRoll_Click;
            // 
            // txtWallet
            // 
            txtWallet.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtWallet.Location = new Point(976, 630);
            txtWallet.Name = "txtWallet";
            txtWallet.ReadOnly = true;
            txtWallet.Size = new Size(125, 38);
            txtWallet.TabIndex = 7;
            // 
            // lblPoint
            // 
            lblPoint.AutoSize = true;
            lblPoint.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPoint.Location = new Point(12, 598);
            lblPoint.Name = "lblPoint";
            lblPoint.Size = new Size(77, 31);
            lblPoint.TabIndex = 8;
            lblPoint.Text = "Point:";
            // 
            // txtPoint
            // 
            txtPoint.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPoint.Location = new Point(95, 591);
            txtPoint.Name = "txtPoint";
            txtPoint.ReadOnly = true;
            txtPoint.Size = new Size(91, 38);
            txtPoint.TabIndex = 9;
            // 
            // lblNumRolls
            // 
            lblNumRolls.AutoSize = true;
            lblNumRolls.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumRolls.Location = new Point(36, 20);
            lblNumRolls.Name = "lblNumRolls";
            lblNumRolls.Size = new Size(155, 25);
            lblNumRolls.TabIndex = 10;
            lblNumRolls.Text = "Number of Rolls:";
            // 
            // txtNumRolls
            // 
            txtNumRolls.BackColor = SystemColors.Menu;
            txtNumRolls.BorderStyle = BorderStyle.None;
            txtNumRolls.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNumRolls.Location = new Point(197, 18);
            txtNumRolls.Name = "txtNumRolls";
            txtNumRolls.ReadOnly = true;
            txtNumRolls.Size = new Size(38, 27);
            txtNumRolls.TabIndex = 11;
            txtNumRolls.Text = "0";
            // 
            // lblBet
            // 
            lblBet.AutoSize = true;
            lblBet.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBet.Location = new Point(1010, 689);
            lblBet.Name = "lblBet";
            lblBet.Size = new Size(61, 38);
            lblBet.TabIndex = 12;
            lblBet.Text = "Bet";
            // 
            // txtBet
            // 
            txtBet.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBet.Location = new Point(954, 730);
            txtBet.Name = "txtBet";
            txtBet.PlaceholderText = "enter your bet";
            txtBet.Size = new Size(171, 38);
            txtBet.TabIndex = 13;
            // 
            // lblDollarSign
            // 
            lblDollarSign.AutoSize = true;
            lblDollarSign.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDollarSign.Location = new Point(915, 728);
            lblDollarSign.Name = "lblDollarSign";
            lblDollarSign.Size = new Size(33, 38);
            lblDollarSign.TabIndex = 14;
            lblDollarSign.Text = "$";
            // 
            // lblWinCon
            // 
            lblWinCon.AutoSize = true;
            lblWinCon.Location = new Point(3, 730);
            lblWinCon.Name = "lblWinCon";
            lblWinCon.Size = new Size(131, 60);
            lblWinCon.TabIndex = 15;
            lblWinCon.Text = "7 or 11 on first roll\r\n\r\nRoll matches Point\r\n";
            // 
            // lblLoseCon
            // 
            lblLoseCon.AutoSize = true;
            lblLoseCon.Location = new Point(185, 730);
            lblLoseCon.Name = "lblLoseCon";
            lblLoseCon.Size = new Size(245, 60);
            lblLoseCon.TabIndex = 16;
            lblLoseCon.Text = "2, 3, or 12 on first roll\r\n\r\nRoll a 7 before matching your point";
            // 
            // lblHowToWin
            // 
            lblHowToWin.AutoSize = true;
            lblHowToWin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHowToWin.Location = new Point(9, 694);
            lblHowToWin.Name = "lblHowToWin";
            lblHowToWin.Size = new Size(118, 25);
            lblHowToWin.TabIndex = 17;
            lblHowToWin.Text = "How to Win:";
            // 
            // lblHowToLose
            // 
            lblHowToLose.AutoSize = true;
            lblHowToLose.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHowToLose.Location = new Point(185, 694);
            lblHowToLose.Name = "lblHowToLose";
            lblHowToLose.Size = new Size(122, 25);
            lblHowToLose.TabIndex = 18;
            lblHowToLose.Text = "How to Lose:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(749, 730);
            label1.Name = "label1";
            label1.Size = new Size(160, 40);
            label1.TabIndex = 19;
            label1.Text = "** You can only change\r\n     your bet on roll 0.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 808);
            Controls.Add(label1);
            Controls.Add(lblHowToLose);
            Controls.Add(lblHowToWin);
            Controls.Add(lblLoseCon);
            Controls.Add(lblWinCon);
            Controls.Add(lblDollarSign);
            Controls.Add(txtBet);
            Controls.Add(lblBet);
            Controls.Add(txtNumRolls);
            Controls.Add(lblNumRolls);
            Controls.Add(txtPoint);
            Controls.Add(lblPoint);
            Controls.Add(txtWallet);
            Controls.Add(lblRoll);
            Controls.Add(lblWallet);
            Controls.Add(txtResult);
            Controls.Add(btnRoll);
            Controls.Add(pictDice2);
            Controls.Add(pictDice1);
            Name = "Form1";
            Text = "Craps";
            ((System.ComponentModel.ISupportInitialize)pictDice1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictDice2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictDice1;
        private PictureBox pictDice2;
        private Button btnRoll;
        private TextBox txtResult;
        private Label lblWallet;
        private Label lblRoll;
        private TextBox txtWallet;
        private Label lblPoint;
        private TextBox txtPoint;
        private Label lblNumRolls;
        private TextBox txtNumRolls;
        private Label lblBet;
        private TextBox txtBet;
        private Label lblDollarSign;
        private Label lblWinCon;
        private Label lblLoseCon;
        private Label lblHowToWin;
        private Label lblHowToLose;
        private Label label1;
    }
}
