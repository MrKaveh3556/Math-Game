namespace Math_Game
{
  public partial class Main_Form
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
      this.label1 = new System.Windows.Forms.Label();
      this.Start_Button = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.Easy_Radio = new System.Windows.Forms.RadioButton();
      this.Medium_Radio = new System.Windows.Forms.RadioButton();
      this.Hard_Radio = new System.Windows.Forms.RadioButton();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.Plus_Radio = new System.Windows.Forms.RadioButton();
      this.Mines_Radio = new System.Windows.Forms.RadioButton();
      this.Multiple_Radio = new System.Windows.Forms.RadioButton();
      this.Division_Radio = new System.Windows.Forms.RadioButton();
      this.label10 = new System.Windows.Forms.Label();
      this.label9 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.Ten_Radio = new System.Windows.Forms.RadioButton();
      this.Thirty_Radio = new System.Windows.Forms.RadioButton();
      this.Twenty_Radio = new System.Windows.Forms.RadioButton();
      this.label22 = new System.Windows.Forms.Label();
      this.label21 = new System.Windows.Forms.Label();
      this.label20 = new System.Windows.Forms.Label();
      this.label19 = new System.Windows.Forms.Label();
      this.Speaking_Timer = new System.Windows.Forms.Timer(this.components);
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(37, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(190, 27);
      this.label1.TabIndex = 0;
      this.label1.Text = "به بازی ریاضیات خوش آمدید";
      // 
      // Start_Button
      // 
      this.Start_Button.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Start_Button.Location = new System.Drawing.Point(33, 468);
      this.Start_Button.Name = "Start_Button";
      this.Start_Button.Size = new System.Drawing.Size(168, 40);
      this.Start_Button.TabIndex = 17;
      this.Start_Button.Text = "Start the Game";
      this.Start_Button.UseVisualStyleBackColor = true;
      this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.Easy_Radio);
      this.groupBox1.Controls.Add(this.Medium_Radio);
      this.groupBox1.Controls.Add(this.Hard_Radio);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Location = new System.Drawing.Point(15, 39);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(218, 128);
      this.groupBox1.TabIndex = 38;
      this.groupBox1.TabStop = false;
      // 
      // Easy_Radio
      // 
      this.Easy_Radio.AutoSize = true;
      this.Easy_Radio.Checked = true;
      this.Easy_Radio.Location = new System.Drawing.Point(136, 47);
      this.Easy_Radio.Name = "Easy_Radio";
      this.Easy_Radio.Size = new System.Drawing.Size(14, 13);
      this.Easy_Radio.TabIndex = 19;
      this.Easy_Radio.TabStop = true;
      this.Easy_Radio.UseVisualStyleBackColor = true;
      // 
      // Medium_Radio
      // 
      this.Medium_Radio.AutoSize = true;
      this.Medium_Radio.Location = new System.Drawing.Point(136, 73);
      this.Medium_Radio.Name = "Medium_Radio";
      this.Medium_Radio.Size = new System.Drawing.Size(14, 13);
      this.Medium_Radio.TabIndex = 18;
      this.Medium_Radio.UseVisualStyleBackColor = true;
      // 
      // Hard_Radio
      // 
      this.Hard_Radio.AutoSize = true;
      this.Hard_Radio.Location = new System.Drawing.Point(136, 100);
      this.Hard_Radio.Name = "Hard_Radio";
      this.Hard_Radio.Size = new System.Drawing.Size(14, 13);
      this.Hard_Radio.TabIndex = 17;
      this.Hard_Radio.UseVisualStyleBackColor = true;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(168, 40);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(44, 27);
      this.label6.TabIndex = 16;
      this.label6.Text = "آسان";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(153, 67);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(59, 27);
      this.label5.TabIndex = 15;
      this.label5.Text = "متوسط";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(161, 94);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(51, 27);
      this.label4.TabIndex = 14;
      this.label4.Text = "سخت";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(32, 16);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(180, 27);
      this.label2.TabIndex = 13;
      this.label2.Text = "سختی بازی را انتخاب کنید :";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.Plus_Radio);
      this.groupBox2.Controls.Add(this.Mines_Radio);
      this.groupBox2.Controls.Add(this.Multiple_Radio);
      this.groupBox2.Controls.Add(this.Division_Radio);
      this.groupBox2.Controls.Add(this.label10);
      this.groupBox2.Controls.Add(this.label9);
      this.groupBox2.Controls.Add(this.label8);
      this.groupBox2.Controls.Add(this.label7);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Location = new System.Drawing.Point(12, 173);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(221, 151);
      this.groupBox2.TabIndex = 39;
      this.groupBox2.TabStop = false;
      // 
      // Plus_Radio
      // 
      this.Plus_Radio.AutoSize = true;
      this.Plus_Radio.Checked = true;
      this.Plus_Radio.Location = new System.Drawing.Point(171, 38);
      this.Plus_Radio.Name = "Plus_Radio";
      this.Plus_Radio.Size = new System.Drawing.Size(14, 13);
      this.Plus_Radio.TabIndex = 25;
      this.Plus_Radio.TabStop = true;
      this.Plus_Radio.UseVisualStyleBackColor = true;
      // 
      // Mines_Radio
      // 
      this.Mines_Radio.AutoSize = true;
      this.Mines_Radio.Location = new System.Drawing.Point(171, 65);
      this.Mines_Radio.Name = "Mines_Radio";
      this.Mines_Radio.Size = new System.Drawing.Size(14, 13);
      this.Mines_Radio.TabIndex = 24;
      this.Mines_Radio.UseVisualStyleBackColor = true;
      // 
      // Multiple_Radio
      // 
      this.Multiple_Radio.AutoSize = true;
      this.Multiple_Radio.Location = new System.Drawing.Point(171, 89);
      this.Multiple_Radio.Name = "Multiple_Radio";
      this.Multiple_Radio.Size = new System.Drawing.Size(14, 13);
      this.Multiple_Radio.TabIndex = 23;
      this.Multiple_Radio.UseVisualStyleBackColor = true;
      // 
      // Division_Radio
      // 
      this.Division_Radio.AutoSize = true;
      this.Division_Radio.Location = new System.Drawing.Point(171, 117);
      this.Division_Radio.Name = "Division_Radio";
      this.Division_Radio.Size = new System.Drawing.Size(14, 13);
      this.Division_Radio.TabIndex = 22;
      this.Division_Radio.UseVisualStyleBackColor = true;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(194, 32);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(21, 27);
      this.label10.TabIndex = 21;
      this.label10.Text = "+";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(194, 59);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(19, 27);
      this.label9.TabIndex = 20;
      this.label9.Text = "-";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(194, 86);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(19, 27);
      this.label8.TabIndex = 19;
      this.label8.Text = "*";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(194, 113);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(24, 27);
      this.label7.TabIndex = 18;
      this.label7.Text = "%";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(6, 8);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(218, 27);
      this.label3.TabIndex = 17;
      this.label3.Text = "عملگر ریاضی خود را انتخاب کنید :";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.Ten_Radio);
      this.groupBox3.Controls.Add(this.Thirty_Radio);
      this.groupBox3.Controls.Add(this.Twenty_Radio);
      this.groupBox3.Controls.Add(this.label22);
      this.groupBox3.Controls.Add(this.label21);
      this.groupBox3.Controls.Add(this.label20);
      this.groupBox3.Controls.Add(this.label19);
      this.groupBox3.Location = new System.Drawing.Point(12, 330);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(221, 132);
      this.groupBox3.TabIndex = 40;
      this.groupBox3.TabStop = false;
      // 
      // Ten_Radio
      // 
      this.Ten_Radio.AutoSize = true;
      this.Ten_Radio.Checked = true;
      this.Ten_Radio.Location = new System.Drawing.Point(164, 48);
      this.Ten_Radio.Name = "Ten_Radio";
      this.Ten_Radio.Size = new System.Drawing.Size(14, 13);
      this.Ten_Radio.TabIndex = 46;
      this.Ten_Radio.TabStop = true;
      this.Ten_Radio.UseVisualStyleBackColor = true;
      // 
      // Thirty_Radio
      // 
      this.Thirty_Radio.AutoSize = true;
      this.Thirty_Radio.Location = new System.Drawing.Point(164, 103);
      this.Thirty_Radio.Name = "Thirty_Radio";
      this.Thirty_Radio.Size = new System.Drawing.Size(14, 13);
      this.Thirty_Radio.TabIndex = 45;
      this.Thirty_Radio.UseVisualStyleBackColor = true;
      // 
      // Twenty_Radio
      // 
      this.Twenty_Radio.AutoSize = true;
      this.Twenty_Radio.Location = new System.Drawing.Point(164, 75);
      this.Twenty_Radio.Name = "Twenty_Radio";
      this.Twenty_Radio.Size = new System.Drawing.Size(14, 13);
      this.Twenty_Radio.TabIndex = 44;
      this.Twenty_Radio.UseVisualStyleBackColor = true;
      // 
      // label22
      // 
      this.label22.AutoSize = true;
      this.label22.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label22.Location = new System.Drawing.Point(183, 42);
      this.label22.Name = "label22";
      this.label22.Size = new System.Drawing.Size(30, 27);
      this.label22.TabIndex = 43;
      this.label22.Text = "10";
      // 
      // label21
      // 
      this.label21.AutoSize = true;
      this.label21.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label21.Location = new System.Drawing.Point(183, 69);
      this.label21.Name = "label21";
      this.label21.Size = new System.Drawing.Size(30, 27);
      this.label21.TabIndex = 42;
      this.label21.Text = "20";
      // 
      // label20
      // 
      this.label20.AutoSize = true;
      this.label20.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label20.Location = new System.Drawing.Point(183, 96);
      this.label20.Name = "label20";
      this.label20.Size = new System.Drawing.Size(30, 27);
      this.label20.TabIndex = 41;
      this.label20.Text = "30";
      // 
      // label19
      // 
      this.label19.AutoSize = true;
      this.label19.Font = new System.Drawing.Font("Vazirmatn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label19.Location = new System.Drawing.Point(34, 16);
      this.label19.Name = "label19";
      this.label19.Size = new System.Drawing.Size(181, 27);
      this.label19.TabIndex = 40;
      this.label19.Text = "زمان را انتخاب کنید (ثانیه) :";
      // 
      // Speaking_Timer
      // 
      this.Speaking_Timer.Interval = 1000;
      // 
      // Main_Form
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(261, 520);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.Start_Button);
      this.Controls.Add(this.label1);
      this.Name = "Main_Form";
      this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "فرم اصلی";
      this.Load += new System.EventHandler(this.Main_Form_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.Label label1;
    internal System.Windows.Forms.Button Start_Button;
    internal System.Windows.Forms.GroupBox groupBox1;
    internal System.Windows.Forms.RadioButton Easy_Radio;
    internal System.Windows.Forms.RadioButton Medium_Radio;
    internal System.Windows.Forms.RadioButton Hard_Radio;
    internal System.Windows.Forms.Label label6;
    internal System.Windows.Forms.Label label5;
    internal System.Windows.Forms.Label label4;
    internal System.Windows.Forms.Label label2;
    internal System.Windows.Forms.GroupBox groupBox2;
    internal System.Windows.Forms.RadioButton Plus_Radio;
    internal System.Windows.Forms.RadioButton Mines_Radio;
    internal System.Windows.Forms.RadioButton Multiple_Radio;
    internal System.Windows.Forms.RadioButton Division_Radio;
    internal System.Windows.Forms.Label label10;
    internal System.Windows.Forms.Label label9;
    internal System.Windows.Forms.Label label8;
    internal System.Windows.Forms.Label label7;
    internal System.Windows.Forms.Label label3;
    internal System.Windows.Forms.GroupBox groupBox3;
    internal System.Windows.Forms.RadioButton Ten_Radio;
    internal System.Windows.Forms.RadioButton Thirty_Radio;
    internal System.Windows.Forms.RadioButton Twenty_Radio;
    internal System.Windows.Forms.Label label22;
    internal System.Windows.Forms.Label label21;
    internal System.Windows.Forms.Label label20;
    internal System.Windows.Forms.Label label19;
    private System.Windows.Forms.Timer Speaking_Timer;
  }
}

