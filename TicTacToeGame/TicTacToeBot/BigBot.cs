namespace TicTacToeGame
{
    public class BigBot : BaseBot
    {
        protected override int FieldSize => 25;
        protected override int? MinimaxDepth { get; } = 3;

        public BigBot(char player, char opponent) : base(player, opponent)
        {
        }

        protected override char CheckWinner(string gameStateCopy)
        {
            int[] horizontal = new int[10] { 0, 1, 5, 6, 10, 11, 15, 16, 20, 21 };
            foreach (var i in horizontal)
            {
                if (gameStateCopy[i].ToString() != "-"
                    && gameStateCopy[i].ToString() == gameStateCopy[i + 1].ToString()
                    && gameStateCopy[i].ToString() == gameStateCopy[i + 2].ToString()
                    && gameStateCopy[i].ToString() == gameStateCopy[i + 3].ToString())
                {
                    return gameStateCopy[i];
                }
            }
            //# Possible Diagonal wins, left to right
            int[] l_diagonal = new int[4] { 0, 1, 5, 6 };
            foreach (var i in l_diagonal)
            {
                if (gameStateCopy[i].ToString() != "-"
                    && gameStateCopy[i].ToString() == gameStateCopy[i + 5 + 1].ToString()
                    && gameStateCopy[i].ToString() == gameStateCopy[i + 10 + 2].ToString()
                    && gameStateCopy[i].ToString() == gameStateCopy[i + 15 + 3].ToString())
                {
                    return gameStateCopy[i];
                }
            }
            //# Possible Diagonal wins, right to left
            int[] r_diagonal = new int[4] { 3, 4, 8, 9 };
            foreach (var i in r_diagonal)
            {
                if (gameStateCopy[i].ToString() != "-"
                    && gameStateCopy[i].ToString() == gameStateCopy[i + 5 - 1].ToString()
                    && gameStateCopy[i].ToString() == gameStateCopy[i + 10 - 2].ToString()
                    && gameStateCopy[i].ToString() == gameStateCopy[i + 15 - 3].ToString())
                {
                    return gameStateCopy[i];
                }
            }
            //# Possible Vertical wins             
            for (int i = 0; i < 10; i++)
            {
                if (gameStateCopy[i].ToString() != "-"
                    && gameStateCopy[i].ToString() == gameStateCopy[i + 5].ToString()
                    && gameStateCopy[i].ToString() == gameStateCopy[i + 10].ToString()
                    && gameStateCopy[i].ToString() == gameStateCopy[i + 15].ToString())
                {
                    return gameStateCopy[i];
                }
            }
            if (IsSpotsLeft(gameStateCopy))
            {
                return '/';
            }
            return '-';
        }
    }
}