using Math_Game.Properties;
using Math_Game.Timer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game.Game
{
  internal class CheckAnswers
  {
    #region Properties

    public string Difficulty
    { get { return Settings.Default.Level; } }

    public string Operator
    { get { return Settings.Default.Operator; } }

    public int Time
    { get { return Settings.Default.Time; } }

    #endregion Properties

    private Game_Form _form { get; }

    public CheckAnswers(Game_Form form) => _form = form;

    internal void VerifyAnswer() => _VerifyAnswer();

    private void _VerifyAnswer()
    {
      int number1 = Convert.ToInt32(_form.Number1_Label.Text.Trim());
      int number2 = Convert.ToInt32(_form.Number2_Label.Text.Trim());
      int result = Convert.ToInt32(_form.Result_Textbox.Text.Trim());

      if (CheckAnswer(number1, number2, result))
      {
        GetScore();
        new GenerateNumber(_form).CheckLevel();
      }
      else
      {
        new TimerSettings(_form).DisableTimer();
        Lose();
        _form.Close();
      }

      _form.Result_Textbox.Text = "";
    }

    #region Get Score

    private void GetScore()
    {
      GetPoint();

      LevelUp();

      new TimerSettings(_form).SetTimer();
    }

    private void GetPoint()
    {
      _form.Point++;
      _form.Score_Label.Text = _form.Point.ToString();
      if (_form.Point % 10 == 0 && _form.Point != 0)
      {
        _form._MrRobot.SpeakAsync(
          $"Congratulation! you've got {_form.Point} points");
      }
    }

    private void LevelUp()
    {
      if (_form.Point % 20 == 0 && _form.Point != 0)
      {
        _form.Level++;
        _form._MrRobot.SpeakAsync(
          $"You reach Level {_form.Level}! Keep Going");
        _form.Level_Label.Text = Difficulty.ToString();
      }
    }

    #endregion Get Score

    internal void Lose()
    {
      string point = _form.Score_Label.Text.Trim();
      MessageBox.Show(
        $"Unfortunately You Lose :( but you get {point} Points!");
    }

    public bool CheckAnswer(int number1, int number2, int result)
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
  }
}