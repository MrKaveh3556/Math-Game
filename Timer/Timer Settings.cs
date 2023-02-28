using Math_Game.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Game.Timer
{
  internal class TimerSettings
  {
    private Game_Form _form;

    public TimerSettings(Game_Form form) => _form = form;

    internal void EnableTimer() => _form.timer1.Enabled = true;

    internal void DisableTimer() => _form.timer1.Enabled = false;

    internal void SetTimer()
    {
      int time = Settings.Default.Time;
      _form.SecondsLeft_Label.Text = time.ToString();
      _form.secondsLeft = time;
    }
  }
}