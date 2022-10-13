namespace TicTacToeGame
{
    public class ClassicBot : BaseBot
    {
        protected override int FieldSize => 9;

        public ClassicBot(char player, char opponent) : base(player, opponent)
        {
        }

        protected override char CheckWinner(string gameStateCopy)
        {
            if (gameStateCopy[0].ToString() == gameStateCopy[1].ToString() 
                && gameStateCopy[1].ToString() == gameStateCopy[2].ToString() 
                && gameStateCopy[0].ToString() != "-") 
            {
                return gameStateCopy[1];
            }
            else if (gameStateCopy[3].ToString() == gameStateCopy[4].ToString() 
                && gameStateCopy[3].ToString() == gameStateCopy[5].ToString() 
                && gameStateCopy[3].ToString() != "-") 
            {
                return gameStateCopy[3];
            }
            else if (gameStateCopy[6].ToString() == gameStateCopy[7].ToString() 
                && gameStateCopy[6].ToString() == gameStateCopy[8].ToString() 
                && gameStateCopy[6].ToString() != "-") 
            {
                return gameStateCopy[6];
            }
            else if (gameStateCopy[0].ToString() == gameStateCopy[3].ToString() 
                && gameStateCopy[0].ToString() == gameStateCopy[6].ToString() 
                && gameStateCopy[0].ToString() != "-") 
            {
                return gameStateCopy[0];
            }
            else if (gameStateCopy[1].ToString() == gameStateCopy[4].ToString()
                && gameStateCopy[1].ToString() == gameStateCopy[7].ToString() 
                && gameStateCopy[1].ToString() != "-") 
            {
                return gameStateCopy[1];
            }
            else if (gameStateCopy[2].ToString() == gameStateCopy[5].ToString()
                && gameStateCopy[2].ToString() == gameStateCopy[8].ToString() 
                && gameStateCopy[2].ToString() != "-") 
            {
                return gameStateCopy[2];
            }
            else if (gameStateCopy[0].ToString() == gameStateCopy[4].ToString()
                && gameStateCopy[0].ToString() == gameStateCopy[8].ToString()
                && gameStateCopy[0].ToString() != "-") 
            {
                return gameStateCopy[0];
            }
            else if (gameStateCopy[2].ToString() == gameStateCopy[4].ToString() 
                && gameStateCopy[2].ToString() == gameStateCopy[6].ToString()
                && gameStateCopy[2].ToString() != "-") 
            {
                return gameStateCopy[2];
            }
            else
            {
                if (IsSpotsLeft(gameStateCopy))
                {
                    return '/';
                }
                return '-';
            }
        }
    }
}
