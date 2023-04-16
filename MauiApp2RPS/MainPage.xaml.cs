namespace MauiApp2RPS;

public partial class MainPage : ContentPage
{
    readonly string[] Choices = { "ROCK", "PAPER", "SCISSORS" };

    public MainPage()
    {
        InitializeComponent();
    }


    private void UserClick1 (object sender, EventArgs e)
    {
        DisplayUser.Text = Choices[0];
        Random CompChoice = new Random();
        var RandomChoice = CompChoice.Next(Choices.Length);
        DisplayComp.Text = Choices[RandomChoice];
    }
    private void UserClick2(object sender, EventArgs e)
    {
        DisplayUser.Text = Choices[1];
        Random CompChoice = new Random();
        var RandomChoice = CompChoice.Next(Choices.Length);
        DisplayComp.Text = Choices[RandomChoice];
        WiningCondition();
    }
    private void UserClick3(object sender, EventArgs e)
    {
        DisplayUser.Text = Choices[2];
        Random CompChoice = new Random();
        var RandomChoice = CompChoice.Next(Choices.Length);
        DisplayComp.Text = Choices[RandomChoice];
        WiningCondition();
    }

    private void WiningCondition()
        {
            if (DisplayUser.Text == Choices[0] && DisplayComp.Text == Choices[0])
            {
                DisplayResults.Text = ("It's a draw!");
            }
            else if (DisplayUser.Text == Choices[1] && DisplayComp.Text == Choices[1])
            {
                DisplayResults.Text = ("It's a draw!");
            }
            else if (DisplayUser.Text == Choices[2] && DisplayComp.Text == Choices[2])
            {
                DisplayResults.Text = ("It's a draw!");
            }
            else if (DisplayUser.Text == Choices[0] && DisplayComp.Text == Choices[1])
            {
                DisplayResults.Text = ("You lost!");
            }
            else if (DisplayUser.Text == Choices[1] && DisplayComp.Text == Choices[0])
            {
                DisplayResults.Text = ("You won!");
            }
            else if (DisplayUser.Text == Choices[1] && DisplayComp.Text == Choices[2])
            {
                DisplayResults.Text = ("You lost!");
            }
            else if (DisplayUser.Text == Choices[2] && DisplayComp.Text == Choices[1])
            {
                DisplayResults.Text = ("You won!!");
            }
            else if (DisplayUser.Text == Choices[0] && DisplayComp.Text == Choices[2])
            {
                DisplayResults.Text = ("You won!");
            }
            else if (DisplayUser.Text == Choices[2] && DisplayComp.Text == Choices[0])
            {
                DisplayResults.Text = ("You lost!");
            }
            else
            {
                DisplayResults.Text = ("Invalid choice");
            }
        }
    }



