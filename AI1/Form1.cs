using AI;
using System.Text;
namespace App
{
    public partial class Form1 : Form
    {
        object s;
        EventArgs ev;
        Form1 form;
        public Form1()
        {
            form = this;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            s = sender;
            ev = e;
            Maze maze = new Maze();
            maze = Maze.Load(Maze.path);
            for (int i = 0; i < maze.Width; i++)
            {
                grid.Columns.Add("c" + i.ToString(), i.ToString());
                grid.Columns[i].Width = 15;
            }
            for (int i = 0; i < maze.Height; i++)
            {
                grid.Rows.Add();
                grid.Rows[i].Height = 15;
            }
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                grid.Rows[i].HeaderCell.Value = i.ToString();
            }
            grid.RowHeadersWidth = 56;
            for (int i = 0; i < maze.Width; i++)
                for (int j = 0; j < maze.Height; j++)
                {
                    if (maze[i, j] == Cell.Wall)
                        grid[i, j].Style.BackColor = Color.Black;
                    if(maze[i, j] == Cell.Exit)
                        grid[i, j].Style.BackColor = Color.Red;
                }
        }

        private void maze_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            Process p = new(Int32.Parse(x.Text), Int32.Parse(y.Text));
            grid[p.robot.Location.X, p.robot.Location.Y].Style.BackColor = Color.Blue;
            AI.Point curLoc = new(p.robot.Location.X, p.robot.Location.Y);
            do
            {
                grid[curLoc.X, curLoc.Y].Style.BackColor = Color.Green;
                curLoc = new(p.robot.Location.X, p.robot.Location.Y);
                grid[p.robot.Location.X, p.robot.Location.Y].Style.BackColor = Color.Blue;
            }
            while (p.ai.MakeStep());
            if (p.ai.Maze[p.robot.Location] == Cell.Wall || p.ai.Maze[p.robot.Location] != Cell.Exit)
                MessageBox.Show("Error! Uncorrect start position.");
            grid[p.robot.Location.X, p.robot.Location.Y].Style.BackColor = Color.Blue;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Create_Click(object sender, EventArgs e)
        {
            if(mazeSize.Text != "")
                Maze.Create(Convert.ToInt32(mazeSize.Text));
            else
                Maze.Create();
            Renew(sender, e);
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void mark_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(Maze.path);
            StringBuilder[] maze = new StringBuilder[lines.Length];
            for (int i = 0; i < lines.Length; i++)
                maze[i] = new(lines[i]);
            for (int i = 0; i < lines.Length; i++)
                for (int j = 0; j < lines[0].Length; j++)
                    if (maze[i][j] == '2')
                        maze[i][j] = '0';
            maze[Convert.ToInt32(yfin.Text)][Convert.ToInt32(xfin.Text)] = '2';
            for (int i = 0; i < lines.Length; i++)
                lines[i] = maze[i].ToString();
            File.WriteAllLines(Maze.path, lines);
            Renew(sender, e);
        }
        private void Renew(object sender, EventArgs e)
        {
            grid.Rows.Clear();
            grid.Columns.Clear();
            Form1_Load(sender, e);
        }
    }
}