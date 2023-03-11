using DevExpress.Data.Filtering;
using Math_Game.Properties;
using Math_Game.Timer;
using System;
using System.Drawing;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Utils.Drawing.Helpers.NativeMethods;

namespace Math_Game
{
  public partial class Game_Form : Form
  {
    #region Properties

    public string Difficulty
    { get { return Settings.Default.Level; } }

    public string Operator
    { get { return Settings.Default.Operator; } }

    public int Time
    { get { return Settings.Default.Time; } }

    internal int secondsLeft { get; set; } = 0;

    internal int Point { get; set; } = 0;

    internal int Level { get; set; } = 1;

    internal SpeechSynthesizer _MrRobot = new SpeechSynthesizer();

    #endregion Properties

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
        Lose();
        Close();
      }
    }

    private void VerifyAnswer_Button_Click(object sender, EventArgs e) =>
      _VerifyAnswer();

    #region Answer Arena

    private void _VerifyAnswer()
    {
      CheckAnswer();
      ClearTextBox();
    }

    private void CheckAnswer()
    {
      int number1 = Convert.ToInt32(Number1_Label.Text.Trim());
      int number2 = Convert.ToInt32(Number2_Label.Text.Trim());
      int result = Convert.ToInt32(Result_Textbox.Text.Trim());

      if (CheckResult(number1, number2, result))
      {
        GetScore();
        new GenerateNumber(this).CheckLevel();
      }
      else
      {
        new TimerSettings(this).DisableTimer();
        Lose();
        Close();
      }
    }

    #region Get Score

    private void GetScore()
    {
      GetPoint();

      LevelUp();

      new TimerSettings(this).SetTimer();
    }

    private void GetPoint()
    {
      Point++;
      Score_Label.Text = $"{Point}";
      if (Point % 10 == 0 && Point != 0)
      {
        _MrRobot.SpeakAsync(
          $"Congratulation! you've got {Point} points");
      }
    }

    private void LevelUp()
    {
      if (Point % 20 == 0 && Point != 0)
      {
        Level++;
        Level_Label.Text = Level.ToString();
        _MrRobot.SpeakAsync(
          $"You reach Level {Level}! Keep Going");
      }
    }

    #endregion Get Score

    internal void Lose()
    {
      string point = Score_Label.Text.Trim();
      MessageBox.Show(
        $"Unfortunately You Lose :( but you get {point} Points!");
    }

    private void ClearTextBox() => Result_Textbox.Text = "";

    #endregion Answer Arena

    public bool CheckResult(int number1, int number2, int result)
    {
      if (CheckPlus())
      {
        return Sum(number1, number2) == result;
      }
      else if (CheckMines())
      {
        return Mines(number1, number2) == result;
      }
      else if (CheckMultiple())
      {
        return Multiple(number1, number2) == result;
      }
      else
      {
        return Division(number1, number2) == result;
      }
    }

    #region Check Operators

    public bool CheckPlus() => Operator == "+";

    public bool CheckMines() => Operator == "-";

    public bool CheckMultiple() => Operator == "*";

    public bool CheckDivision() => Operator == "/";

    #endregion Check Operators

    #region Return Operation

    private int Sum(int number1, int number2) => number1 + number2;

    private int Mines(int number1, int number2) => number1 - number2;

    private int Multiple(int number1, int number2) => number1 * number2;

    private int Division(int number1, int number2) => number1 / number2;

    #endregion Return Operation

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