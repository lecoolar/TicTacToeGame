using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public class Field
    {
        public List<Button> Buttons { get; set; }

        public string CurrentGameState { get; set; } = "----------0-";

        private int size = 100;
        private int location = 100;
        private int sizeInBlock = 70;

        public Field(int x)
        {
            Buttons = new List<Button>();
            var counter = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Button btn = new Button();
                    btn.BackColor = Color.Black;
                    btn.Size = new Size(size, size);
                    btn.Location = new Point(j * location + sizeInBlock, i * location + sizeInBlock);
                    btn.BackColor = Color.Aqua;
                    btn.Text = $"*";
                    btn.Name = $"{counter++}";

                    Buttons.Add(btn);
                }
            }
        }
    }
}
