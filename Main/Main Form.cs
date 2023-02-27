using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Math_Game.Game;
using Math_Game.Properties;

namespace Math_Game
{
  public partial class Main_Form : Form
  {
    public Main_Form()
    {
      InitializeComponent();
    }

    private void Start_Button_Click(object sender, EventArgs e)
    {
      SetSettingValues();
      Hide();
      new Game_Form().ShowDialog();
      Show();
    }

    private void SetSettingValues()
    {
      CheckSetting check = new CheckSetting(this);
      Settings.Default.Level = check.CheckLevel();
      Settings.Default.Operator = check.CheckOperator();
      Settings.Default.Time = check.CheckTime();
    }
  }
}