namespace CS311_Project2_MJC
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        int rollResult;
        int counter = 0;
        double wallet = 100.00;
        double bet;
        int point;

        public Form1()
        {
            InitializeComponent();
            txtWallet.Text = wallet.ToString("C");
        }
        private void pictDice1_Click(object sender, EventArgs e) //not used
        {

        }
        private void rollDice() //uses switch statements to generate random numbers for each dice. 
        {
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            if (wallet == 0.00)
            {
                MessageBox.Show("Sorry you do not have the funds to play.");
            }//end if
            else
            {
                try
                {
                    switch (dice1)
                    {
                        case 1:
                            pictDice1.Image = Image.FromFile("..//..//..//Resources//dice1.png");
                            break;
                        case 2:
                            pictDice1.Image = Image.FromFile("..//..//..//Resources//dice2.png");
                            break;
                        case 3:
                            pictDice1.Image = Image.FromFile("..//..//..//Resources//dice3.png");
                            break;
                        case 4:
                            pictDice1.Image = Image.FromFile("..//..//..//Resources//dice4.png");
                            break;
                        case 5:
                            pictDice1.Image = Image.FromFile("..//..//..//Resources//dice5.png");
                            break;
                        case 6:
                            pictDice1.Image = Image.FromFile("..//..//..//Resources//dice6.png");
                            break;
                        default:
                            pictDice1.Image = Image.FromFile("..//..//..//Resources//dice1.png");
                            break;
                    }//end switch
                }//end try
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }//end catch


                try
                {
                    switch (dice2)
                    {
                        case 1:
                            pictDice2.Image = Image.FromFile("..//..//..//Resources//dice1.png");
                            break;
                        case 2:
                            pictDice2.Image = Image.FromFile("..//..//..//Resources//dice2.png");
                            break;
                        case 3:
                            pictDice2.Image = Image.FromFile("..//..//..//Resources//dice3.png");
                            break;
                        case 4:
                            pictDice2.Image = Image.FromFile("..//..//..//Resources//dice4.png");
                            break;
                        case 5:
                            pictDice2.Image = Image.FromFile("..//..//..//Resources//dice5.png");
                            break;
                        case 6:
                            pictDice2.Image = Image.FromFile("..//..//..//Resources//dice6.png");
                            break;
                        default:
                            pictDice2.Image = Image.FromFile("..//..//..//Resources//dice1.png");
                            break;
                    }//end switch
                }//end try
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }//end catch

                rollResult = dice1 + dice2;

            }//end else


        }//end rollDice

        private void outcome() //checks result of roll and number of rolls that have been made to calculate outcome of the game.
        {
            if ((counter == 1 && rollResult == 7) || (counter == 1 && rollResult == 11))
            {
                MessageBox.Show("Great first roll! \nYou Win!");
                wallet = wallet + bet;
                txtWallet.Text = wallet.ToString("C");
                counter = 0;
            }//end if
            else if ((counter == 1 && rollResult == 2) || (counter == 1 && rollResult == 3) || (counter == 1 && rollResult == 12))
            {
                MessageBox.Show("Craps! \nYou Lose!");
                wallet = wallet - bet;
                txtWallet.Text = wallet.ToString("C");
                counter = 0;
            }//end else if
            else if ((counter == 1 && rollResult == 4) || (counter == 1 && rollResult == 5) || (counter == 1 && rollResult == 6) || (counter == 1 && rollResult == 8) || (counter == 1 && rollResult == 9) || (counter == 1 && rollResult == 10))
            {
                point = rollResult;
                txtPoint.Text = point.ToString();
            }//end else if
            else if (counter > 1 && rollResult == point)
            {
                MessageBox.Show("You made your point! \nYou Win!");
                wallet = wallet + bet;
                txtWallet.Text = wallet.ToString("C");
                counter = 0;
                txtPoint.Text = "";
            }//end else if
            else if (counter > 1 && rollResult == 7)
            {
                MessageBox.Show("Craps! \nYou Lose!");
                wallet = wallet - bet;
                txtWallet.Text = wallet.ToString("C");
                counter = 0;
                txtPoint.Text = "";
            }//end else if

        }
        private void calculate_score() //runs the methods in appropriate order and checks for correct bet.
        {
            try
            {
                if (double.Parse(txtBet.Text) < wallet) //checks to ensure bet is affordable.
                {
                    bet = double.Parse(txtBet.Text);
                    counter++;
                    rollDice();
                    txtResult.Text = rollResult.ToString();
                    txtNumRolls.Text = counter.ToString();
                    outcome();
                    txtNumRolls.Text = counter.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Bet. Please enter a numerical value that you can afford.");
                    txtBet.Text = "";
                }
            }//end try
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }//end catch
        }

        private void btnRoll_Click(object sender, EventArgs e) //upon clicking the roll button, the calculate_score method will be called and bets will be locked.
        {
            
            calculate_score();
            if (counter > 0)
            {
                txtBet.ReadOnly = true;
            }
            else
            {
                txtBet.ReadOnly = false;
            }

        }//end btnRoll_Click

        private void lblRoll_Click(object sender, EventArgs e) //not used.
        {

        }
    }//end class
}//end namespace
