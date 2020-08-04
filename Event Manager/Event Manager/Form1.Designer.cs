namespace Event_Manager
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfBox = new System.Windows.Forms.NumericUpDown();
            this.fancyBox = new System.Windows.Forms.CheckBox();
            this.healthyBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tooLongLabel = new System.Windows.Forms.Label();
            this.birthdayCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cakeWriting = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberOfPeopleBirthday = new System.Windows.Forms.NumericUpDown();
            this.fancyBirthday = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of people";
            // 
            // numberOfBox
            // 
            this.numberOfBox.Location = new System.Drawing.Point(9, 19);
            this.numberOfBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfBox.Name = "numberOfBox";
            this.numberOfBox.Size = new System.Drawing.Size(115, 20);
            this.numberOfBox.TabIndex = 1;
            this.numberOfBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberOfBox.ValueChanged += new System.EventHandler(this.numberOfBox_ValueChanged);
            // 
            // fancyBox
            // 
            this.fancyBox.AutoSize = true;
            this.fancyBox.Location = new System.Drawing.Point(9, 45);
            this.fancyBox.Name = "fancyBox";
            this.fancyBox.Size = new System.Drawing.Size(115, 17);
            this.fancyBox.TabIndex = 2;
            this.fancyBox.Text = "Fancy Decorations";
            this.fancyBox.UseVisualStyleBackColor = true;
            this.fancyBox.CheckedChanged += new System.EventHandler(this.fancyBox_CheckedChanged);
            // 
            // healthyBox
            // 
            this.healthyBox.AutoSize = true;
            this.healthyBox.Location = new System.Drawing.Point(9, 68);
            this.healthyBox.Name = "healthyBox";
            this.healthyBox.Size = new System.Drawing.Size(96, 17);
            this.healthyBox.TabIndex = 3;
            this.healthyBox.Text = "Healthy Option";
            this.healthyBox.UseVisualStyleBackColor = true;
            this.healthyBox.CheckedChanged += new System.EventHandler(this.healthyBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cost";
            // 
            // costLabel
            // 
            this.costLabel.Location = new System.Drawing.Point(40, 88);
            this.costLabel.Name = "costLabel";
            this.costLabel.ReadOnly = true;
            this.costLabel.Size = new System.Drawing.Size(84, 20);
            this.costLabel.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(160, 168);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.costLabel);
            this.tabPage1.Controls.Add(this.numberOfBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.fancyBox);
            this.tabPage1.Controls.Add(this.healthyBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(152, 142);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DinnerParty";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tooLongLabel);
            this.tabPage2.Controls.Add(this.birthdayCost);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cakeWriting);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.numberOfPeopleBirthday);
            this.tabPage2.Controls.Add(this.fancyBirthday);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(152, 142);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BirthdayParty";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tooLongLabel
            // 
            this.tooLongLabel.AutoSize = true;
            this.tooLongLabel.BackColor = System.Drawing.Color.Red;
            this.tooLongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tooLongLabel.Location = new System.Drawing.Point(73, 65);
            this.tooLongLabel.Name = "tooLongLabel";
            this.tooLongLabel.Size = new System.Drawing.Size(71, 13);
            this.tooLongLabel.TabIndex = 10;
            this.tooLongLabel.Text = "TOO LONG";
            // 
            // birthdayCost
            // 
            this.birthdayCost.Location = new System.Drawing.Point(40, 107);
            this.birthdayCost.Name = "birthdayCost";
            this.birthdayCost.ReadOnly = true;
            this.birthdayCost.Size = new System.Drawing.Size(104, 20);
            this.birthdayCost.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Cost";
            // 
            // cakeWriting
            // 
            this.cakeWriting.Location = new System.Drawing.Point(9, 81);
            this.cakeWriting.Name = "cakeWriting";
            this.cakeWriting.Size = new System.Drawing.Size(135, 20);
            this.cakeWriting.TabIndex = 7;
            this.cakeWriting.TextChanged += new System.EventHandler(this.cakeWriting_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cake Writing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of people";
            // 
            // numberOfPeopleBirthday
            // 
            this.numberOfPeopleBirthday.Location = new System.Drawing.Point(9, 19);
            this.numberOfPeopleBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfPeopleBirthday.Name = "numberOfPeopleBirthday";
            this.numberOfPeopleBirthday.Size = new System.Drawing.Size(135, 20);
            this.numberOfPeopleBirthday.TabIndex = 4;
            this.numberOfPeopleBirthday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberOfPeopleBirthday.ValueChanged += new System.EventHandler(this.numberOfPeopleBirthday_ValueChanged);
            // 
            // fancyBirthday
            // 
            this.fancyBirthday.AutoSize = true;
            this.fancyBirthday.Location = new System.Drawing.Point(9, 45);
            this.fancyBirthday.Name = "fancyBirthday";
            this.fancyBirthday.Size = new System.Drawing.Size(115, 17);
            this.fancyBirthday.TabIndex = 5;
            this.fancyBirthday.Text = "Fancy Decorations";
            this.fancyBirthday.UseVisualStyleBackColor = true;
            this.fancyBirthday.CheckedChanged += new System.EventHandler(this.fancyBirthday_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(156, 165);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPeopleBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberOfBox;
        private System.Windows.Forms.CheckBox fancyBox;
        private System.Windows.Forms.CheckBox healthyBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox costLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label tooLongLabel;
        private System.Windows.Forms.TextBox birthdayCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cakeWriting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numberOfPeopleBirthday;
        private System.Windows.Forms.CheckBox fancyBirthday;
    }
}

