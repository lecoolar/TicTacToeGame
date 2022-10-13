namespace TicTacToeGame
{
    public abstract class BaseGame
    {
        public abstract int FieldSize { get; protected set; }

        public bool IsGameOver { get; protected set; } = false;
        public string GameState => this.currentGameState;
        protected string currentGameState;

        protected char player;
        protected char opponent;
        protected char winner = '/';
        protected bool humanVsHuman;
        protected BaseBot bot;

        public BaseGame(char player, bool humanVsHuman = false)
        {
            this.humanVsHuman = humanVsHuman;
            this.player = player;
            opponent = player == 'X' ? 'O' : 'X';
        }

        protected void MakeFirstStepIfNeed()
        {
            if (player == 'O' && !this.humanVsHuman)
            {
                int index = bot.GetBestMove(currentGameState);
                if (index >= 0)
                {
                    IncrementNumberOfMoves();
                    SetNewGameState(index, 'X');
                }
            }
        }

        protected abstract void CheckWinner();

        public GameStatus MakeStep(int stepIdx)
        {
            IncrementNumberOfMoves();
            SetNewGameState(stepIdx, player);
            CheckWinner();
            if (IsGameOver)
            {
                SetNewGameState(FieldSize + 2, winner);
                return GameStatus.PlayerWin;
            }
            else if (GetMoveNumber() >= FieldSize)
            {
                IsGameOver = true;
                return GameStatus.Draw;
            }

            if (IsGameOver)
            {
                return GameStatus.End;
            }
            if (humanVsHuman)
            {
                player = player == 'X' ? 'O' : 'X';
                return GameStatus.InProgress;
            }
            int index = bot.GetBestMove(currentGameState);
            if (index >= 0)
            {
                IncrementNumberOfMoves();
                SetNewGameState(index, opponent);
            }
            CheckWinner();
            if (IsGameOver)
            {
                return GameStatus.BotWin;
            }
            else if (GetMoveNumber() >= 9)
            {
                IsGameOver = true;
                return GameStatus.Draw;
            }
            return GameStatus.InProgress;
        }

        private void IncrementNumberOfMoves()
        {
            int numberOfMoves = int.Parse(currentGameState[FieldSize + 1].ToString());
            numberOfMoves++;
            char[] oldGameState = currentGameState.ToCharArray();
            oldGameState[FieldSize + 1] = numberOfMoves.ToString()[0];
            string newGameState = new string(oldGameState);
            currentGameState = newGameState;
        }

        private int GetMoveNumber()
        {
            char moveNumber = currentGameState[FieldSize + 1];
            return int.Parse(moveNumber.ToString());
        }

        protected void SetWinner(char winner)
        {
            char[] oldGameState = currentGameState.ToCharArray();
            oldGameState[FieldSize + 2] = winner;
            string newGameState = new string(oldGameState);
            currentGameState = newGameState;
        }

        private void SetNewGameState(int index, char player)
        {
            char[] oldGameState = currentGameState.ToCharArray();
            oldGameState[index] = player;
            string newGameState = new string(oldGameState);
            currentGameState = newGameState;
        }
    }
}
