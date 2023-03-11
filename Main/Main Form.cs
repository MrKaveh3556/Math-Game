using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Math_Game.Properties;
using static DevExpress.Utils.Drawing.Helpers.NativeMethods;

namespace Math_Game
{
  public partial class Main_Form : Form
  {
    private SpeechSynthesizer _MrRobot = new SpeechSynthesizer();

    public Main_Form()
    {
      InitializeComponent();
    }

    private void Main_Form_Load(object sender, EventArgs e)
    {
      //_MrRobot.SpeakAsync("Welcome to the Math Game");
      //if (DateTime.Now.Year == 2023)
      //{
      //  var (day, month, year) = Miladi_To_Shamsi(
      //    DateTime.Now.Day,
      //    DateTime.Now.Month,
      //    DateTime.Now.Year);

      //  SayDate(day, month, year);
      //}
      //else
      //{
      //  SayDate(
      //    DateTime.Now.Day,
      //    DateTime.Now.Month,
      //    DateTime.Now.Year);
      //}
    }

    #region Date

    private (int day, int month, int year) Miladi_To_Shamsi
      (int day, int month, int year)
    {
      PersianCalendar p = new PersianCalendar();
      DateTime date = new DateTime(year, month, day);
      int y, m, d;
      y = p.GetYear(date);
      m = p.GetMonth(date);
      d = p.GetDayOfMonth(date);
      return (d, m, y);
    }

    private void SayDate(int day, int month, int year)
    {
      _MrRobot.SpeakAsync($"Today is {day}th day of month");
      _MrRobot.SpeakAsync($"{month}th month of year");
      _MrRobot.SpeakAsync($"{year} year!");
      _MrRobot.SpeakAsync("I hope you will enjoy this game");
    }

    #endregion Date

    private void Start_Button_Click(object sender, EventArgs e)
    {
      MuteSound();
      SetSettingValues();
      Hide();
      new Game_Form().ShowDialog();
      Show();
    }

    private void MuteSound()
    {
      while (_MrRobot.State == SynthesizerState.Speaking) { /*wait*/ }
    }

    private void SetSettingValues()
    {
      Settings.Default.Level = CheckLevel();
      Settings.Default.Operator = CheckOperator();
      Settings.Default.Time = CheckTime();
    }

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

    internal bool CheckMedium() => Medium_Radio.Checked;

    internal bool CheckHard() => Hard_Radio.Checked;

    internal bool CheckMines() => Mines_Radio.Checked;

    internal bool CheckMultiple() => Multiple_Radio.Checked;

    internal bool CheckDivision() => Division_Radio.Checked;

    internal bool CheckTwenty() => Twenty_Radio.Checked;

    internal bool CheckThirty() => Thirty_Radio.Checked;

    #endregion Check Values
  }
}