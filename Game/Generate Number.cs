using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math_Game.Properties;

namespace Math_Game
{
  internal class GenerateNumber
  {
    private string Level
    { get { return Settings.Default.Level; } }

    private string Operator
    { get { return Settings.Default.Operator; } }

    private int Time
    { get { return Settings.Default.Time; } }

    private Game_Form _gameForm { get; }

    public GenerateNumber(Game_Form gameForm) => _gameForm = gameForm;

    internal void CheckLevel()
    {
      if (Level == "medium")
        GenerateNumbers_Medium();
      else if (Level == "hard")
        GenerateNumbers_Hard();
      else
        GenerateNumbers_Easy();
    }

    internal void GenerateNumbers_Easy()
    {
      Random random = new Random();
      _gameForm.Number1_Label.Text = $"{random.Next(1, 9)}";
      _gameForm.Number2_Label.Text = $"{random.Next(1, 9)}";
    }

    internal void GenerateNumbers_Medium()
    {
      Random random = new Random();
      _gameForm.Number1_Label.Text = $"{random.Next(10, 99)}";
      _gameForm.Number2_Label.Text = $"{random.Next(10, 99)}";
    }

    internal void GenerateNumbers_Hard()
    {
      Random random = new Random();
      _gameForm.Number1_Label.Text = $"{random.Next(100, 999)}";
      _gameForm.Number2_Label.Text = $"{random.Next(100, 999)}";
    }
  }
}