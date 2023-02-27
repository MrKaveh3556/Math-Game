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

    public Game_Form()
    {
      InitializeComponent();
    }

    private void Game_Form_Load(object sender, EventArgs e)
    {
      EnableTimer();
      SetTimer();
      new GenerateNumber(this).CheckLevel();
    }

    private void EnableTimer() => timer1.Enabled = true;

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
        Close();
        //finish the game
      }
    }
  }
}