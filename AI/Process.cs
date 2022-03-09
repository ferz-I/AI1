using System;
using System.IO;
using System.Threading;

namespace AI
{
    public class Process
    {
        Maze maze = Maze.Load(Maze.path);
        public Robot robot;
        public AI ai;
        public Process()
        {
            robot = new() { Location = new Point { X = 1, Y = 1 } };
            ai = new() { Robot = robot, Maze = maze };
        }
        public Process(int x, int y)
        {
            robot = new() { Location = new Point { X = x, Y = y } };
            ai = new() { Robot = robot, Maze = maze };
        }
    }
    
}