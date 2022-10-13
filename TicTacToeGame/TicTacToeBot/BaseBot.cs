namespace TicTacToeGame
{
    public abstract class BaseBot
    {
        protected abstract int FieldSize { get; }

        protected virtual int? MinimaxDepth { get; } = null;
        protected abstract char CheckWinner(string gameStateCopy);

        protected readonly char player;
        protected readonly char opponent;

        protected BaseBot(char player, char opponent)
        {
            this.player = player;
            this.opponent = opponent;
        }

        public int GetBestMove(string gameState)
        {
            int bestScore = int.MinValue;
            int index = 0;
            for (int i = 0; i < this.FieldSize; i++)
            {
                if (gameState[i] == '-')
                {
                    char[] oldGameState = gameState.ToCharArray();
                    oldGameState[i] = player;
                    gameState = new string(oldGameState);

                    int score = Minimax(gameState, 0, false);

                    oldGameState = gameState.ToCharArray();
                    oldGameState[i] = '-';
                    gameState = new string(oldGameState);

                    if (score > bestScore)
                    {
                        bestScore = score;
                        index = i;
                    }
                }
            }
            return index;
        }

        protected bool IsSpotsLeft(string gameState)
        {
            for (int i = 0; i < this.FieldSize; i++)
            {
                if (gameState[i] == '-')
                {
                    return true;
                }
            }
            return false;
        }

        private int GetScore(char player)
        {
            if (this.player == player)
            {
                return +10;
            }
            else if (this.opponent == player)
            {
                return -10;
            }
            else
            {
                return 0;
            }
        }

        private int Minimax(string gameState, int depth, bool isMaximizing)
        {
            if (this.MinimaxDepth.HasValue && depth == this.MinimaxDepth.Value)
            {
                return 0;
            }

            char winner = CheckWinner(gameState);
            if (winner != '/')
            {
                return GetScore(winner);
            }

            if (isMaximizing)
            {
                int bestScore = int.MinValue;
                for (int i = 0; i < this.FieldSize; i++)
                {
                    if (gameState[i] == '-')
                    {
                        char[] oldGameState = gameState.ToCharArray();
                        oldGameState[i] = player;
                        gameState = new string(oldGameState);

                        int score = Minimax(gameState, depth + 1, false);

                        oldGameState = gameState.ToCharArray();
                        oldGameState[i] = '-';
                        gameState = new string(oldGameState);

                        if (score > bestScore)
                        {
                            bestScore = score;
                        }
                    }
                }
                return bestScore;
            }
            else
            {
                int bestScore = int.MaxValue;
                for (int i = 0; i < this.FieldSize; i++)
                {
                    if (gameState[i] == '-')
                    {
                        char[] oldGameState = gameState.ToCharArray();
                        oldGameState[i] = opponent;
                        gameState = new string(oldGameState);

                        int score = Minimax(gameState, depth + 1, true);

                        oldGameState = gameState.ToCharArray();
                        oldGameState[i] = '-';
                        gameState = new string(oldGameState);

                        if (score < bestScore)
                        {
                            bestScore = score;
                        }
                    }
                }
                return bestScore;
            }
        }
    }
}
