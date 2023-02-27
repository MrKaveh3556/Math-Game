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
      this.Finish_Button = new System.Windows.Forms.Button();
      this.Score_Label = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.VerifyAnswer_Button = new System.Windows.Forms.Button();
      this.Result_Textbox = new System.Windows.Forms.TextBox();
      this.have_label = new System.Windows.Forms.Label();
      this.left_label = new System.Windows.Forms.Label();
      this.SecondsLeft_Label = new System.Windows.Forms.Label();
      this.label14 = new System.Windows.Forms.Label();
      this.Number2_Label = new System.Windows.Forms.Label();
      this.Operator_Label = new System.Windows.Forms.Label();
      this.Number1_Label = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // Finish_Button
      // 
      this.Finish_Button.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Finish_Button.Location = new System.Drawing.Point(83, 136);
      this.Finish_Button.Name = "Finish_Button";
      this.Finish_Button.Size = new System.Drawing.Size(168, 40);
      this.Finish_Button.TabIndex = 49;
      this.Finish_Button.Text = "Finish the Game";
      this.Finish_Button.UseVisualStyleBackColor = true;
      this.Finish_Button.Click += new System.EventHandler(this.Finish_Button_Click);
      // 
      // Score_Label
      // 
      this.Score_Label.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Score_Label.Location = new System.Drawing.Point(339, 10);
      this.Score_Label.Name = "Score_Label";
      this.Score_Label.Size = new System.Drawing.Size(40, 27);
      this.Score_Label.TabIndex = 48;
      this.Score_Label.Text = "0";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(248, 9);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(96, 27);
      this.label11.TabIndex = 47;
      this.label11.Text = "Your Score :";
      // 
      // VerifyAnswer_Button
      // 
      this.VerifyAnswer_Button.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.VerifyAnswer_Button.Location = new System.Drawing.Point(83, 86);
      this.VerifyAnswer_Button.Name = "VerifyAnswer_Button";
      this.VerifyAnswer_Button.Size = new System.Drawing.Size(168, 40);
      this.VerifyAnswer_Button.TabIndex = 46;
      this.VerifyAnswer_Button.Text = "Verify Answer";
      this.VerifyAnswer_Button.UseVisualStyleBackColor = true;
      this.VerifyAnswer_Button.Click += new System.EventHandler(this.VerifyAnswer_Button_Click);
      // 
      // Result_Textbox
      // 
      this.Result_Textbox.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Result_Textbox.Location = new System.Drawing.Point(224, 48);
      this.Result_Textbox.Name = "Result_Textbox";
      this.Result_Textbox.Size = new System.Drawing.Size(118, 32);
      this.Result_Textbox.TabIndex = 45;
      this.Result_Textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Equal_Textbox_KeyPress);
      // 
      // have_label
      // 
      this.have_label.AutoSize = true;
      this.have_label.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.have_label.Location = new System.Drawing.Point(12, 9);
      this.have_label.Name = "have_label";
      this.have_label.Size = new System.Drawing.Size(77, 27);
      this.have_label.TabIndex = 44;
      this.have_label.Text = "You have";
      // 
      // left_label
      // 
      this.left_label.AutoSize = true;
      this.left_label.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.left_label.Location = new System.Drawing.Point(113, 9);
      this.left_label.Name = "left_label";
      this.left_label.Size = new System.Drawing.Size(123, 27);
      this.left_label.TabIndex = 43;
      this.left_label.Text = "Second(s) left :)";
      // 
      // SecondsLeft_Label
      // 
      this.SecondsLeft_Label.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SecondsLeft_Label.Location = new System.Drawing.Point(85, 9);
      this.SecondsLeft_Label.Name = "SecondsLeft_Label";
      this.SecondsLeft_Label.Size = new System.Drawing.Size(33, 27);
      this.SecondsLeft_Label.TabIndex = 42;
      this.SecondsLeft_Label.Text = "30";
      // 
      // label14
      // 
      this.label14.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label14.Location = new System.Drawing.Point(198, 50);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(20, 27);
      this.label14.TabIndex = 41;
      this.label14.Text = "=";
      // 
      // Number2_Label
      // 
      this.Number2_Label.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Number2_Label.Location = new System.Drawing.Point(161, 50);
      this.Number2_Label.Name = "Number2_Label";
      this.Number2_Label.Size = new System.Drawing.Size(46, 27);
      this.Number2_Label.TabIndex = 40;
      this.Number2_Label.Text = "999";
      // 
      // Operator_Label
      // 
      this.Operator_Label.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Operator_Label.Location = new System.Drawing.Point(141, 50);
      this.Operator_Label.Name = "Operator_Label";
      this.Operator_Label.Size = new System.Drawing.Size(28, 27);
      this.Operator_Label.TabIndex = 39;
      this.Operator_Label.Text = "+";
      // 
      // Number1_Label
      // 
      this.Number1_Label.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Number1_Label.Location = new System.Drawing.Point(104, 50);
      this.Number1_Label.Name = "Number1_Label";
      this.Number1_Label.Size = new System.Drawing.Size(46, 27);
      this.Number1_Label.TabIndex = 38;
      this.Number1_Label.Text = "999";
      // 
      // timer1
      // 
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // Game_Form
      // 
      this.AcceptButton = this.VerifyAnswer_Button;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(435, 223);
      this.Controls.Add(this.Finish_Button);
      this.Controls.Add(this.Score_Label);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.VerifyAnswer_Button);
      this.Controls.Add(this.Result_Textbox);
      this.Controls.Add(this.have_label);
      this.Controls.Add(this.left_label);
      this.Controls.Add(this.SecondsLeft_Label);
      this.Controls.Add(this.label14);
      this.Controls.Add(this.Number2_Label);
      this.Controls.Add(this.Operator_Label);
      this.Controls.Add(this.Number1_Label);
      this.Name = "Game_Form";
      this.Text = "Game_Form";
      this.Load += new System.EventHandler(this.Game_Form_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    internal System.Windows.Forms.Button Finish_Button;
    internal System.Windows.Forms.Label Score_Label;
    internal System.Windows.Forms.Label label11;
    internal System.Windows.Forms.Button VerifyAnswer_Button;
    internal System.Windows.Forms.TextBox Result_Textbox;
    internal System.Windows.Forms.Label have_label;
    internal System.Windows.Forms.Label left_label;
    internal System.Windows.Forms.Label SecondsLeft_Label;
    internal System.Windows.Forms.Label label14;
    internal System.Windows.Forms.Label Number2_Label;
    internal System.Windows.Forms.Label Operator_Label;
    internal System.Windows.Forms.Label Number1_Label;
    private System.Windows.Forms.Timer timer1;
  }
}