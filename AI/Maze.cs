using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace AI
{
	public class Maze
	{
		public static string path = "D:\\Python Projects\\AI1\\AI\\Maze.txt";
		private Cell[,] Items;
		public static Maze Load(string filePath)
		{
			var lines = File.ReadAllLines(filePath);
			var res = new Maze();
			res.Items = new Cell[lines[0].Length, lines.Length];
			for (int row = 0; row < lines.Length; row++)
				for (int col = 0; col < lines[row].Length; col++)
					res.Items[col, row] = (Cell)byte.Parse(lines[row][col].ToString());
			return res;
		}
		public static void Create(int size = 10)
        {
			Random r = new();
			StringBuilder[] maze = new StringBuilder[size + 2];
			for (int i = 0; i < size + 2; i++)
				maze[i] = new("");
			for (int i = 0; i < size + 2; i++)
				maze[0].Append(1);
			for (int i = 1; i < size + 1; i++)
			{
				maze[i].Append(1);
				for (int j = 0; j < size; j++)
					maze[i].Append((r.NextDouble() > 0.5) ? 1 : 0);
				maze[i].Append(1);
			}
			maze[r.Next() % size + 1][r.Next() % size + 1] = '2';
			for (int i = 0; i < size + 2; i++)
				maze[size + 1].Append(1);
			string[] mazze = new string [maze.Length];
			for (int j = 0; j < maze.Length; j++)
				mazze[j] = maze[j].ToString();
			File.WriteAllLines(path, mazze);
			Load(path);
        }
		public Cell this[int col, int row]
		{
			get { return Items[col, row]; }
		}
		public Cell this[Point p]
		{
			get { return Items[p.X, p.Y]; }
		}
		public int Height 
		{
			get { return Items.GetLength(1); }
		}
		public int Width
		{
			get { return Items.GetLength(0); }
		}
		
	}
	
}
