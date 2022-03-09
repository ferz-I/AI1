using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI
{
    public class AI
    {
        public Robot Robot = new();
        public Maze Maze = new();
        public bool MakeStep()
        {
            //достигли выхода?
            if (Maze[Robot.Location] == Cell.Exit) return false;
            //получаем значение ячейки слева
            var left = Maze[Robot.Location + Robot.Direction.Rotate(1)];
            //если слева нет стены - поворачиваем налево
            if (left != Cell.Wall)
                Robot.Direction = Robot.Direction.Rotate(1);
            else
                //пока впереди есть стена - поворачиваем направо
                while (Maze[Robot.Location + Robot.Direction] == Cell.Wall)
                    Robot.Direction = Robot.Direction.Rotate(-1);
            //идем вперед
            Robot.GoForward();
            return true;
        }
    }
}
