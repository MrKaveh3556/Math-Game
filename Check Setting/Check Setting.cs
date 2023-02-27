using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Game.Game
{
  internal class CheckSetting
  {
    private Main_Form _form { get; }

    public CheckSetting(Main_Form form) => _form = form;

    #region Return Values

    internal string CheckLevel()
    {
      string level = "easy";
      if (CheckMedium())
      {
        level = "medium";
      }
      else if (CheckHard())
      {
        level = "hard";
      }
      return level;
    }

    internal string CheckOperator()
    {
      string operatorvalue = "+";
      if (CheckMines())
      {
        operatorvalue = "-";
      }
      else if (CheckMultiple())
      {
        operatorvalue = "*";
      }
      else if (CheckDivision())
      {
        operatorvalue = "/";
      }
      return operatorvalue;
    }

    internal int CheckTime()
    {
      int time = 10;
      if (CheckTwenty())
      {
        time = 20;
      }
      else if (CheckThirty())
      {
        time = 30;
      }
      return time;
    }

    #endregion Return Values

    #region Check Values

    internal bool CheckMedium() => _form.Medium_Radio.Checked;

    internal bool CheckHard() => _form.Hard_Radio.Checked;

    internal bool CheckMines() => _form.Mines_Radio.Checked;

    internal bool CheckMultiple() => _form.Multiple_Radio.Checked;

    internal bool CheckDivision() => _form.Division_Radio.Checked;

    internal bool CheckTwenty() => _form.Twenty_Radio.Checked;

    internal bool CheckThirty() => _form.Thirty_Radio.Checked;

    #endregion Check Values
  }
}