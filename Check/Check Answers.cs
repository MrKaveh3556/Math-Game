using Math_Game.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Game.Game
{
  internal class CheckAnswers
  {
    public string Level
    { get { return Settings.Default.Level; } }

    public string Operator
    { get { return Settings.Default.Operator; } }

    public int Time
    { get { return Settings.Default.Time; } }

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