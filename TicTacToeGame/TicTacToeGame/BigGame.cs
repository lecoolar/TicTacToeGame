namespace TicTacToeGame
{
    public class BigGame : BaseGame
    {
        public override int FieldSize { get; protected set; } = 25;

        public BigGame(char player, bool humanVsHuman = false) : base(player, humanVsHuman)
        {
            for (int i = 0; i < FieldSize; i++)
            {
                currentGameState += '-';
            }
            currentGameState += "-0-";
            bot = new BigBot(opponent, player);
            MakeFirstStepIfNeed();
        }

        protected override void CheckWinner()
        {
            if (currentGameState != null && currentGameState.Length >= 25)
            {
                if (currentGameState[0] == currentGameState[1]
                        && currentGameState[1] == currentGameState[2]
                        && currentGameState[1] == currentGameState[3]
                        && currentGameState[1] == currentGameState[4]
                        && currentGameState[0] != '-')
                {
                    winner = currentGameState[0];
                    SetWinner(winner);
                    IsGameOver = true;
                }
                else if (currentGameState[5] == currentGameState[6]
                            && currentGameState[6] == currentGameState[7]
                            && currentGameState[6] == currentGameState[8]
                            && currentGameState[6] == currentGameState[9]
                            && currentGameState[5] != '-')
                {
                    winner = currentGameState[5];
                    SetWinner(winner);
                    IsGameOver = true;
                }
                else if (currentGameState[10] == currentGameState[11]
                    && currentGameState[11] == currentGameState[12]
                    && currentGameState[11] == currentGameState[13]
                    && currentGameState[11] == currentGameState[14]
                    && currentGameState[10] != '-')
                {
                    winner = currentGameState[10];
                    SetWinner(winner);
                    IsGameOver = true;
                }
                else if (currentGameState[15] == currentGameState[16]
                    && currentGameState[16] == currentGameState[17]
                    && currentGameState[16] == currentGameState[18]
                    && currentGameState[16] == currentGameState[19]
                    && currentGameState[15] != '-')
                {
                    winner = currentGameState[15];
                    SetWinner(winner);
                    IsGameOver = true;
                }
                else if (currentGameState[20] == currentGameState[21]
                    && currentGameState[21] == currentGameState[22]
                    && currentGameState[21] == currentGameState[23]
                    && currentGameState[21] == currentGameState[24]
                    && currentGameState[20] != '-')
                {
                    winner = currentGameState[20];
                    SetWinner(winner);
                    IsGameOver = true;
                }


                //# Row Winning
                else if (currentGameState[0] == currentGameState[5]
                    && currentGameState[5] == currentGameState[10]
                    && currentGameState[5] == currentGameState[15]
                    && currentGameState[5] == currentGameState[20]
                    && currentGameState[0] != '-')
                {
                    winner = currentGameState[0];
                    SetWinner(winner);
                    IsGameOver = true;
                }
                else if (currentGameState[1] == currentGameState[6]
                    && currentGameState[6] == currentGameState[11]
                    && currentGameState[6] == currentGameState[15]
                    && currentGameState[6] == currentGameState[21]
                    && currentGameState[1] != '-')
                {
                    winner = currentGameState[1];
                    SetWinner(winner);
                    IsGameOver = true;
                }
                else if (currentGameState[2] == currentGameState[7]
                    && currentGameState[7] == currentGameState[12]
                    && currentGameState[7] == currentGameState[17]
                    && currentGameState[7] == currentGameState[22]
                    && currentGameState[2] != '-')
                {
                    winner = currentGameState[2];
                    SetWinner(winner);
                    IsGameOver = true;
                }
                else if (currentGameState[3] == currentGameState[8]
                    && currentGameState[8] == currentGameState[13]
                    && currentGameState[8] == currentGameState[18]
                    && currentGameState[8] == currentGameState[23]
                    && currentGameState[3] != '-')
                {
                    winner = currentGameState[3];
                    SetWinner(winner);
                    IsGameOver = true;
                }
                else if (currentGameState[4] == currentGameState[9]
                    && currentGameState[9] == currentGameState[14]
                    && currentGameState[9] == currentGameState[19]
                    && currentGameState[9] == currentGameState[24]
                    && currentGameState[4] != '-')
                {
                    winner = currentGameState[4];
                    SetWinner(winner);
                    IsGameOver = true;
                }

                //# Diagonal left to right Winning
                else if (currentGameState[0] == currentGameState[6]
                    && currentGameState[6] == currentGameState[12]
                    && currentGameState[6] == currentGameState[18]
                    && currentGameState[6] == currentGameState[24]
                    && currentGameState[0] != '-')
                {
                    winner = currentGameState[0];
                    SetWinner(winner);
                    IsGameOver = true;
                }

                //# Diagonal right to left Winning
                else if (currentGameState[20] == currentGameState[16]
                    && currentGameState[16] == currentGameState[12]
                    && currentGameState[16] == currentGameState[8]
                    && currentGameState[16] == currentGameState[4]
                    && currentGameState[20] != '-')
                {
                    winner = currentGameState[20];
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