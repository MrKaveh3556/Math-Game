namespace Math_Game
{
  partial class Game_Form
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.label14 = new System.Windows.Forms.Label();
      this.SecondsLeft_Label = new System.Windows.Forms.Label();
      this.have_label = new System.Windows.Forms.Label();
      this.VerifyAnswer_Button = new System.Windows.Forms.Button();
      this.label11 = new System.Windows.Forms.Label();
      this.Score_Label = new System.Windows.Forms.Label();
      this.Finish_Button = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.Level_Label = new System.Windows.Forms.Label();
      this.Result_Textbox = new System.Windows.Forms.TextBox();
      this.Number1_Label = new System.Windows.Forms.Label();
      this.Operator_Label = new System.Windows.Forms.Label();
      this.Number2_Label = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // timer1
      // 
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // label14
      // 
      this.label14.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label14.Location = new System.Drawing.Point(99, 105);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(20, 27);
      this.label14.TabIndex = 41;
      this.label14.Text = "=";
      // 
      // SecondsLeft_Label
      // 
      this.SecondsLeft_Label.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SecondsLeft_Label.Location = new System.Drawing.Point(117, 9);
      this.SecondsLeft_Label.Name = "SecondsLeft_Label";
      this.SecondsLeft_Label.Size = new System.Drawing.Size(33, 27);
      this.SecondsLeft_Label.TabIndex = 42;
      this.SecondsLeft_Label.Text = "30";
      // 
      // have_label
      // 
      this.have_label.AutoSize = true;
      this.have_label.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.have_label.Location = new System.Drawing.Point(7, 8);
      this.have_label.Name = "have_label";
      this.have_label.Size = new System.Drawing.Size(116, 27);
      this.have_label.TabIndex = 44;
      this.have_label.Text = "زمان باقی مانده :";
      // 
      // VerifyAnswer_Button
      // 
      this.VerifyAnswer_Button.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.VerifyAnswer_Button.Location = new System.Drawing.Point(12, 138);
      this.VerifyAnswer_Button.Name = "VerifyAnswer_Button";
      this.VerifyAnswer_Button.Size = new System.Drawing.Size(192, 40);
      this.VerifyAnswer_Button.TabIndex = 46;
      this.VerifyAnswer_Button.Text = "ثبت جواب";
      this.VerifyAnswer_Button.UseVisualStyleBackColor = true;
      this.VerifyAnswer_Button.Click += new System.EventHandler(this.VerifyAnswer_Button_Click);
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(7, 35);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(84, 27);
      this.label11.TabIndex = 47;
      this.label11.Text = "امتیاز شما :";
      // 
      // Score_Label
      // 
      this.Score_Label.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Score_Label.Location = new System.Drawing.Point(98, 36);
      this.Score_Label.Name = "Score_Label";
      this.Score_Label.Size = new System.Drawing.Size(40, 27);
      this.Score_Label.TabIndex = 48;
      this.Score_Label.Text = "0";
      // 
      // Finish_Button
      // 
      this.Finish_Button.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Finish_Button.Location = new System.Drawing.Point(12, 188);
      this.Finish_Button.Name = "Finish_Button";
      this.Finish_Button.Size = new System.Drawing.Size(192, 40);
      this.Finish_Button.TabIndex = 49;
      this.Finish_Button.Text = "پایان بازی";
      this.Finish_Button.UseVisualStyleBackColor = true;
      this.Finish_Button.Click += new System.EventHandler(this.Finish_Button_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(7, 63);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(88, 27);
      this.label2.TabIndex = 50;
      this.label2.Text = "مرحله شما :";
      // 
      // Level_Label
      // 
      this.Level_Label.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Level_Label.Location = new System.Drawing.Point(98, 64);
      this.Level_Label.Name = "Level_Label";
      this.Level_Label.Size = new System.Drawing.Size(40, 27);
      this.Level_Label.TabIndex = 51;
      this.Level_Label.Text = "1";
      // 
      // Result_Textbox
      // 
      this.Result_Textbox.Font = new System.Drawing.Font("Vazirmatn", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Result_Textbox.Location = new System.Drawing.Point(12, 104);
      this.Result_Textbox.Name = "Result_Textbox";
      this.Result_Textbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.Result_Textbox.Size = new System.Drawing.Size(84, 28);
      this.Result_Textbox.TabIndex = 52;
      // 
      // Number1_Label
      // 
      this.Number1_Label.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Number1_Label.Location = new System.Drawing.Point(118, 105);
      this.Number1_Label.Name = "Number1_Label";
      this.Number1_Label.Size = new System.Drawing.Size(46, 27);
      this.Number1_Label.TabIndex = 53;
      this.Number1_Label.Text = "9";
      this.Number1_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // Operator_Label
      // 
      this.Operator_Label.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Operator_Label.Location = new System.Drawing.Point(152, 105);
      this.Operator_Label.Name = "Operator_Label";
      this.Operator_Label.Size = new System.Drawing.Size(28, 27);
      this.Operator_Label.TabIndex = 54;
      this.Operator_Label.Text = "+";
      // 
      // Number2_Label
      // 
      this.Number2_Label.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Number2_Label.Location = new System.Drawing.Point(169, 105);
      this.Number2_Label.Name = "Number2_Label";
      this.Number2_Label.Size = new System.Drawing.Size(46, 27);
      this.Number2_Label.TabIndex = 55;
      this.Number2_Label.Text = "9";
      this.Number2_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // Game_Form
      // 
      this.AcceptButton = this.VerifyAnswer_Button;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(216, 248);
      this.Controls.Add(this.Number2_Label);
      this.Controls.Add(this.Operator_Label);
      this.Controls.Add(this.Number1_Label);
      this.Controls.Add(this.Result_Textbox);
      this.Controls.Add(this.Level_Label);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.Finish_Button);
      this.Controls.Add(this.Score_Label);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.VerifyAnswer_Button);
      this.Controls.Add(this.have_label);
      this.Controls.Add(this.SecondsLeft_Label);
      this.Controls.Add(this.label14);
      this.Name = "Game_Form";
      this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.RightToLeftLayout = true;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_Form_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_Form_FormClosed);
      this.Load += new System.EventHandler(this.Game_Form_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    internal System.Windows.Forms.Timer timer1;
    internal System.Windows.Forms.Label label14;
    internal System.Windows.Forms.Label SecondsLeft_Label;
    internal System.Windows.Forms.Label have_label;
    internal System.Windows.Forms.Button VerifyAnswer_Button;
    internal System.Windows.Forms.Label label11;
    internal System.Windows.Forms.Label Score_Label;
    internal System.Windows.Forms.Button Finish_Button;
    internal System.Windows.Forms.Label label2;
    internal System.Windows.Forms.Label Level_Label;
    internal System.Windows.Forms.TextBox Result_Textbox;
    internal System.Windows.Forms.Label Number1_Label;
    internal System.Windows.Forms.Label Operator_Label;
    internal System.Windows.Forms.Label Number2_Label;
  }
}