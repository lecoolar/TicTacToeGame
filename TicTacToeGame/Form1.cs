using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        Field Field;
        BaseGame ticTacToeGame;
        const char sideX = 'X';
        const char sideO = 'O';
        char whoMove = 'X';
        char humanSide;
        char humanSide2;
        bool humanVsHuman = false;
        bool botVsBot = false;
        char aiSide;


        public Form1()
        {
            InitializeComponent();
        }

        private void Pozition_Click(object sender, EventArgs e)
        {
            if (whoMove == humanSide || humanVsHuman)
            {
                GameStatus state;
                var btn = (Button)sender;
                btn.Text = whoMove.ToString();

                state = ticTacToeGame.MakeStep(int.Parse(btn.Name));
                btn.Click -= Pozition_Click;

                RefreshFields();
                ValidateGameState(state);
                whoMove = humanSide;
            }
        }

        private void ValidateGameState(GameStatus state)
        {

            if (humanVsHuman)
            {
                if (whoMove == humanSide)
                {
                    WhoMoveLabel.Text = $"Сейчас ходит сторона {humanSide2}";
                    whoMove = humanSide2;
                }
                else
                {
                    WhoMoveLabel.Text = $"Сейчас ходит сторона {humanSide}";
                    whoMove = humanSide;
                }
            }
            else
            {
                WhoMoveLabel.Text = $"Сейчас ходит сторона {aiSide}";
                whoMove = aiSide;
            }

            if (state == GameStatus.BotWin || state == GameStatus.PlayerWin)
            {
                foreach (var button in Field.Buttons)
                {
                    button.Click -= Pozition_Click;
                }
                var winSide = state == GameStatus.BotWin ? aiSide : humanSide;
                MessageBox.Show($"Сторона {winSide} победила");
                WhoMoveLabel.Text = $"Игра закончена";
            }
            if (state == GameStatus.Draw)
            {
                foreach (var button in Field.Buttons)
                {
                    button.Click -= Pozition_Click;
                }
                MessageBox.Show($"Ничья");
            }
            if (state != GameStatus.InProgress)
            {
                WhoMoveLabel.Text = $"Игра закончена";
            }
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            humanVsHuman = false;
            botVsBot = false;
            whoMove = 'X';
            if (Field != null)
            {
                foreach (var btn in Field.Buttons)
                {
                    Controls.Remove(btn);
                }
            }
            if (sizeFieldComboBox.SelectedItem != null && gameModeСomboBox.SelectedItem != null)
            {
                switch (gameModeСomboBox.SelectedIndex)
                {
                    case 0:
                        humanSide = SideXRadioButton.Checked ? sideX : sideO;
                        aiSide = SideXRadioButton.Checked ? sideO : sideX;
                        break;
                    case 1:
                        humanSide = SideXRadioButton.Checked ? sideX : sideO;
                        humanSide2 = SideXRadioButton.Checked ? sideO : sideX;
                        humanVsHuman = true;
                        break;
                    case 2:
                        botVsBot = true;
                        break;
                }

                ChangeFieldSize();

                Field = new Field(int.Parse(sizeFieldComboBox.SelectedItem.ToString()));

                foreach (var btn in Field.Buttons)
                {
                    if (!botVsBot)
                    {
                        btn.Click += Pozition_Click;
                    }
                    Controls.Add(btn);
                }

                if (whoMove == aiSide && !humanVsHuman)
                {
                    RefreshFields();
                }

                StartButton.Text = "Рестарт";

                if (botVsBot)
                {
                    await RunBotSimulation();
                }
                else
                {
                    if (Field.Buttons.Count == 9)
                    {
                        ticTacToeGame = new ClassicGame(sideX);
                    }
                    else
                    {
                        ticTacToeGame = new BigGame(sideX);
                    }
                }
            }
            else
            {
                if (sizeFieldComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Выберите размер");
                }
                if (gameModeСomboBox.SelectedItem == null)
                {
                    MessageBox.Show("Выберите режим");
                }
            }
        }

        private async Task RunBotSimulation()
        {
            BaseBot bot;

            if (Field.Buttons.Count == 9)
            {
                bot = new ClassicBot(sideX, sideO);
                ticTacToeGame = new ClassicGame(sideX);
            }
            else
            {
                bot = new BigBot(sideX, sideO);
                ticTacToeGame = new BigGame(sideX);
            }

            var isFirstStep = true;

            while (!ticTacToeGame.IsGameOver)
            {
                int botStep = 0;
                if (isFirstStep)
                {
                    botStep = new Random().Next(0, 8);
                    isFirstStep = false;
                }
                else
                {
                    botStep = bot.GetBestMove(ticTacToeGame.GameState);
                }

                Field.Buttons[botStep].Text = string.Join(string.Empty, sideX);

                await Task.Delay(2000);
                var state = ticTacToeGame.MakeStep(botStep);
                ValidateGameState(state);
                RefreshFields();
                await Task.Delay(2000);
            }
        }

        private void ChangeFieldSize()
        {
            if (int.Parse(sizeFieldComboBox.SelectedItem.ToString()) == 3)
            {
                this.Size = new System.Drawing.Size(816, 489);
            }
            else if (int.Parse(sizeFieldComboBox.SelectedItem.ToString()) == 5)
            {
                this.Size = new System.Drawing.Size(816, 816);
            }
        }

        private void RefreshFields()
        {
            Field.CurrentGameState = ticTacToeGame.GameState;

            for (int i = 0; i < Field.Buttons.Count; i++)
            {
                if (Field.CurrentGameState[i] != '-')
                {
                    Field.Buttons[i].Text = string.Join(string.Empty, Field.CurrentGameState[i]);
                    Field.Buttons[i].Click -= Pozition_Click;
                }
                if (botVsBot)
                {
                    whoMove = whoMove == sideX ? sideO : sideX;
                    WhoMoveLabel.Text = $"Сейчас ходит ходит игрок {whoMove}";
                }
                else
                {
                    WhoMoveLabel.Text = $"Сейчас ходит ходит игрок {humanSide}";
                    whoMove = humanSide;
                }
            }
        }
    }
}
