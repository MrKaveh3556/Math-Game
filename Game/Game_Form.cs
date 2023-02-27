using Math_Game.Game;
using Math_Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game
{
  public partial class Game_Form : Form
  {
    private int secondsLeft { get; set; } = 0;

    private int Point { get; set; } = 0;

    public Game_Form()
    {
      InitializeComponent();
    }

    private void Game_Form_Load(object sender, EventArgs e)
    {
      EnableTimer();
      SetTimer();
      Operator_Label.Text = Settings.Default.Operator;
      new GenerateNumber(this).CheckLevel();
    }

    #region Timer

    private void EnableTimer() => timer1.Enabled = true;

    private void DisableTimer() => timer1.Enabled = false;

    private void SetTimer()
    {
      int time = Settings.Default.Time;
      SecondsLeft_Label.Text = time.ToString();
      secondsLeft = time;
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

    #endregion Timer

    private void VerifyAnswer_Button_Click(object sender, EventArgs e)
    {
      int number1 = Convert.ToInt32(Number1_Label.Text.Trim());
      int number2 = Convert.ToInt32(Number2_Label.Text.Trim());
      int result = Convert.ToInt32(Result_Textbox.Text.Trim());

      if (new CheckAnswers().CheckAnswer(number1, number2, result))
      {
        GetScore();
        new GenerateNumber(this).CheckLevel();
      }
      else
      {
        DisableTimer();
        Lose();
        Close();
      }
      Result_Textbox.Text = "";
    }

    private void GetScore()
    {
      Point++;
      Score_Label.Text = Point.ToString();
      SetTimer();
    }

    private void Lose()
    {
      string point = Score_Label.Text.Trim();
      MessageBox.Show(
        $"Unfortunately You Lose :( but you get {point} Points!");
    }

    private void Equal_Textbox_KeyPress(object sender, KeyPressEventArgs e)
    {
      if ((e.KeyChar != Convert.ToChar(8))
        && (e.KeyChar < '0' || e.KeyChar > '9'))
        e.Handled = true;
    }

    private void Finish_Button_Click(object sender, EventArgs e)
    {
      DisableTimer();
      string point = Score_Label.Text.Trim();
      MessageBox.Show(
        $"you get {point} points!");
      Close();
    }
  }
}