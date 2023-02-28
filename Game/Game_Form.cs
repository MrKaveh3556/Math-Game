using Math_Game.Game;
using Math_Game.Properties;
using Math_Game.Timer;
using System;
using System.Drawing;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game
{
  public partial class Game_Form : Form
  {
    internal int secondsLeft { get; set; } = 0;

    internal int Point { get; set; } = 0;
    internal int Level { get; set; } = 1;

    internal SpeechSynthesizer _MrRobot = new SpeechSynthesizer();

    public Game_Form()
    {
      InitializeComponent();
    }

    private void Game_Form_Load(object sender, EventArgs e)
    {
      TimerSettings timerSettings = new TimerSettings(this);
      timerSettings.EnableTimer();
      timerSettings.SetTimer();
      Operator_Label.Text = Settings.Default.Operator;
      new GenerateNumber(this).CheckLevel();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      secondsLeft--;
      SecondsLeft_Label.Text = secondsLeft.ToString();
      if (secondsLeft == -1)
      {
        new CheckAnswers(this).Lose();
        Close();
      }
    }

    private void VerifyAnswer_Button_Click(object sender, EventArgs e) =>
      new CheckAnswers(this).VerifyAnswer();

    private void Equal_Textbox_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((e.KeyChar != Convert.ToChar(8))
        && (e.KeyChar < '0' || e.KeyChar > '9'))
        e.Handled = true;
    }

    private void Finish_Button_Click(object sender, EventArgs e)
    {
      FinishTheGame();
      Close();
    }

    private void FinishTheGame()
    {
      new TimerSettings(this).DisableTimer();
      _MrRobot.Speak(
        $@"you've got {Point} points!
        Thanks for Playing! I hope you enjoyed!");
    }

    private void Game_Form_FormClosing(object sender, FormClosingEventArgs e)
    {
      FinishTheGame();
      //ask user to save game or not
    }

    private void Game_Form_FormClosed(object sender, FormClosedEventArgs e)
    {
      //save the game
    }
  }
}