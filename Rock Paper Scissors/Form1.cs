using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_Scissors
{
    public partial class App : Form
    {
        int userScore = 0;
        int computerScore = 0;
        Random computer = new Random();
        string userChoice = "";
        string computerChoice = "";
        bool showMessage = false;

        List<string> options = new List<string>()
        {
            "Rock",
            "Paper",
            "Scissor"
        };

        public App()
        {
            InitializeComponent();
        }

        private void setResult(string result, bool allowShowing=true)
        {
            resultLabel.Text = $"Result: {result}";
            if (showMessage == true && allowShowing == true)
            {
                MessageBox.Show(result, "Rock Paper Scissors Game");
            }
        }
        private bool setUserChoice(string choice = "")
        {
            if (choice == "")
            {
                return false;
            }

            userChoiceLabel.Text = $"User Choice: {choice}";
            userChoice = choice;
            return true;
        }

        private bool setComputerChoice(string choice = "")
        {
            if (choice == "")
            {
                return false;
            }

            computerChoiceLabel.Text = $"Computer Choice: {choice}";
            computerChoice = choice;
            return true;
        }

        private void setUserScore(int score=0)
        {
            userScore = score;
            scoreLabel.Text = $"Your Score: {score}";
        }

        private void setComputerScore(int score=0)
        {
            computerScore = score;
            computerScoreLabel.Text = $"Computer Score: {score}";
        }

        private string getComputerChoice()
        {
            int choiceIndex = computer.Next(options.Count);
            string choice = options[choiceIndex];
            return choice;
        }

        private void incrementUserScore()
        {
            int new_score = userScore + 1;
            setUserScore(new_score);
        }
        
        private void incrementComputerScore()
        {
            int new_score = computerScore + 1;
            setComputerScore(new_score);
        }

        private void resetGame(bool show=false)
        {
            if (show == true)
            {
                string gameName = "Rock Paper Scissors Game";
                int diffrence = Math.Abs(userScore - computerScore);

                if (userScore > computerScore)
                {
                    MessageBox.Show($"You won against the computer during the round with a diffrence of {diffrence}", gameName);
                } else if (userScore < computerScore)
                {
                    MessageBox.Show($"You lost against the computer during the round with a diffrence of {diffrence}", gameName);
                } else
                {
                    MessageBox.Show($"You draw against the computer during the round with a diffrence of {diffrence}", gameName);
                }
                
            }

            setUserScore(0);
            setComputerScore(0);
            setResult("None", false);
            setUserChoice("Not Selected");
            setComputerChoice("Not Selected");
        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void App_Load(object sender, EventArgs e)
        {
            resetGame();
        }

        private void playGame(string option)
        {
            string selectedOption = getComputerChoice();

            setComputerChoice(selectedOption);
            setUserChoice(option);

            option = option.ToLower();
            selectedOption = selectedOption.ToLower();

            /*
             * 0: Not Selected
             * 1: Draw
             * 2: Loss
             * 3: Win
            */


            switch (selectedOption)
            {
                case "rock" when option == "rock":
                    {
                        setResult("You drew with the computer.");
                        return;
                    }
                case "rock" when option == "paper": {
                        setResult("You won against the computer.");
                        incrementUserScore();
                        return;
                    }
                case "rock" when option == "scissor": {
                        setResult("You lost to the computer.");
                        incrementComputerScore();
                        return;
                    }
                case "paper" when option == "rock":
                    {
                        setResult("You lost to the computer.");
                        incrementComputerScore();
                        return;
                    }
                case "paper" when option == "paper":
                    {
                        setResult("You drew with the computer.");
                        return;
                    }
                case "paper" when option == "scissor":
                    {
                        setResult("You won against the computer.");
                        incrementUserScore();
                        return;
                    }
                case "scissor" when option == "rock":
                    {
                        setResult("You won against the computer.");
                        incrementUserScore();
                        return;
                    }
                case "scissor" when option == "paper":
                    {
                        setResult("You lost to the computer.");
                        incrementComputerScore();
                        return;
                    }
                case "scissor" when option == "scissor":
                    {
                        setResult("You drew with the computer.");
                        return;
                    }
            }
        }
        private void rockButton_Click(object sender, EventArgs e)
        {
            playGame("Rock");
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            playGame("Paper");
        }

        private void scissorButton_Click(object sender, EventArgs e)
        {
            playGame("Scissor");
        }
    }
}
