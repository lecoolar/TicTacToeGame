namespace TicTacToeGame
{
    public class ClassicGame : BaseGame
    {
        public override int FieldSize { get; protected set; } = 9;

        public ClassicGame(char player, bool humanVsHuman = false) : base(player, humanVsHuman)
        {
            currentGameState = "----------0-";
            bot = new ClassicBot(opponent, player);
            MakeFirstStepIfNeed();
        }

        protected override void CheckWinner()
        {
            if (currentGameState != null && currentGameState.Length >= 9)
            {
                if (currentGameState[0] == currentGameState[1] 
                    && currentGameState[1] == currentGameState[2] 
                    && currentGameState[0] != '-') 
                {
                    winner = currentGameState[1];
                    SetWinner(winner);
                    IsGameOver = true;
                }
                else if (currentGameState[3] == currentGameState[4] 
                    && currentGameState[3] == currentGameState[5] 
                    && currentGameState[3] != '-') 
                {
                    winner = currentGameState[3];
                    SetWinner(winner);
                    IsGameOver = true;
                }
                else if (currentGameState[6] == currentGameState[7] 
                    && currentGameState[6] == currentGameState[8] 
                    && currentGameState[6] != '-') 
                {
                    winner = currentGameState[6];
                    SetWinner(winner);
                    IsGameOver = true;
                }
                else if (currentGameState[0] == currentGameState[3] 
                    && currentGameState[0] == currentGameState[6] 
                    && currentGameState[0] != '-') 
                {
                    winner = currentGameState[0];
                    SetWinner(winner);
                    IsGameOver = true;
                }
                else if (currentGameState[1] == currentGameState[4] 
                    && currentGameState[1] == currentGameState[7] 
                    && currentGameState[1] != '-') 
                {
                    winner = currentGameState[1];
                    SetWinner(winner);
                    IsGameOver = true;
                }
                else if (currentGameState[2] == currentGameState[5] 
                    && currentGameState[2] == currentGameState[8] 
                    && currentGameState[2] != '-') 
                {
                    winner = currentGameState[2];
                    SetWinner(winner);
                    IsGameOver = true;
                }
                else if (currentGameState[0] == currentGameState[4] 
                    && currentGameState[0] == currentGameState[8] 
                    && currentGameState[0] != '-') 
                {
                    winner = currentGameState[0];
                    SetWinner(winner);
                    IsGameOver = true;
                }
                else if (currentGameState[2] == currentGameState[4] 
                    && currentGameState[2] == currentGameState[6] 
                    && currentGameState[2] != '-') 
                {
                    winner = currentGameState[2];
                    SetWinner(winner);
                    IsGameOver = true;
                }
                else
                {
                    winner = '/';
                    IsGameOver = false;
                }
            }
            else
            {
                winner = '/';
                IsGameOver = false;
            }
        }
    }
}
