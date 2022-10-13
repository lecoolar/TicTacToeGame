namespace TicTacToeGame
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
            this.SideXRadioButton = new System.Windows.Forms.RadioButton();
            this.SideORadioButton = new System.Windows.Forms.RadioButton();
            this.ChooseSideLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.WhoMoveLabel = new System.Windows.Forms.Label();
            this.sizeFieldComboBox = new System.Windows.Forms.ComboBox();
            this.gameModeСomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SideXRadioButton
            // 
            this.SideXRadioButton.AutoSize = true;
            this.SideXRadioButton.Location = new System.Drawing.Point(652, 43);
            this.SideXRadioButton.Name = "SideXRadioButton";
            this.SideXRadioButton.Size = new System.Drawing.Size(32, 17);
            this.SideXRadioButton.TabIndex = 0;
            this.SideXRadioButton.TabStop = true;
            this.SideXRadioButton.Text = "X";
            this.SideXRadioButton.UseVisualStyleBackColor = true;
            // 
            // SideORadioButton
            // 
            this.SideORadioButton.AutoSize = true;
            this.SideORadioButton.Location = new System.Drawing.Point(652, 75);
            this.SideORadioButton.Name = "SideORadioButton";
            this.SideORadioButton.Size = new System.Drawing.Size(33, 17);
            this.SideORadioButton.TabIndex = 1;
            this.SideORadioButton.TabStop = true;
            this.SideORadioButton.Text = "O";
            this.SideORadioButton.UseVisualStyleBackColor = true;
            // 
            // ChooseSideLabel
            // 
            this.ChooseSideLabel.AutoSize = true;
            this.ChooseSideLabel.Location = new System.Drawing.Point(649, 9);
            this.ChooseSideLabel.Name = "ChooseSideLabel";
            this.ChooseSideLabel.Size = new System.Drawing.Size(100, 13);
            this.ChooseSideLabel.TabIndex = 2;
            this.ChooseSideLabel.Text = "Выберите сторону";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(652, 246);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // WhoMoveLabel
            // 
            this.WhoMoveLabel.AutoSize = true;
            this.WhoMoveLabel.Location = new System.Drawing.Point(245, 9);
            this.WhoMoveLabel.Name = "WhoMoveLabel";
            this.WhoMoveLabel.Size = new System.Drawing.Size(0, 13);
            this.WhoMoveLabel.TabIndex = 4;
            // 
            // sizeFieldComboBox
            // 
            this.sizeFieldComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeFieldComboBox.FormattingEnabled = true;
            this.sizeFieldComboBox.Items.AddRange(new object[] {
            "3",
            "5"});
            this.sizeFieldComboBox.Location = new System.Drawing.Point(652, 127);
            this.sizeFieldComboBox.Name = "sizeFieldComboBox";
            this.sizeFieldComboBox.Size = new System.Drawing.Size(121, 21);
            this.sizeFieldComboBox.TabIndex = 5;
            // 
            // gameModeСomboBox
            // 
            this.gameModeСomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameModeСomboBox.FormattingEnabled = true;
            this.gameModeСomboBox.Items.AddRange(new object[] {
            "Игрок против бота",
            "Игрок против Игрока",
            "Бот против Бота"});
            this.gameModeСomboBox.Location = new System.Drawing.Point(652, 173);
            this.gameModeСomboBox.Name = "gameModeСomboBox";
            this.gameModeСomboBox.Size = new System.Drawing.Size(121, 21);
            this.gameModeСomboBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(649, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Размер Поля";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Режим Игры";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameModeСomboBox);
            this.Controls.Add(this.sizeFieldComboBox);
            this.Controls.Add(this.WhoMoveLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ChooseSideLabel);
            this.Controls.Add(this.SideORadioButton);
            this.Controls.Add(this.SideXRadioButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton SideXRadioButton;
        private System.Windows.Forms.RadioButton SideORadioButton;
        private System.Windows.Forms.Label ChooseSideLabel;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label WhoMoveLabel;
        private System.Windows.Forms.ComboBox sizeFieldComboBox;
        private System.Windows.Forms.ComboBox gameModeСomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

