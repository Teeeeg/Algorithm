namespace AlgorithmAD.Basic;

public class NumberofIslands200
{
    private IList<(int rowDir, int colDir)> dirs = new List<(int rowDir, int colDir)> { (0, 1), (1, 0), (-1, 0), (0, -1) };

    public int NumIslands(char[][] grid)
    {
        var res = 0;

        for (int row = 0; row < grid.Length; row++)
        {
            for (int col = 0; col < grid[0].Length; col++)
            {
                if (grid[row][col] != '1')
                {
                    continue;
                }
                grid[row][col] = '0';
                BFS(grid, row, col);
                res++;
            }
        }

        return res;
    }

    private void BFS(char[][] grid, int row, int col)
    {
        var queue = new Queue<(int row, int col)>();
        queue.Enqueue((row, col));

        while (queue.Count > 0)
        {
            var cur = queue.Dequeue();

            foreach (var dir in dirs)
            {
                var next = (cur.row + dir.rowDir, cur.col + dir.colDir);
                if (!(0 <= next.Item1 && next.Item1 < grid.Length) ||
                !(0 <= next.Item2 && next.Item2 < grid[0].Length) ||
                grid[next.Item1][next.Item2] != '1')
                {
                    continue;
                }

                grid[next.Item1][next.Item2] = '0';
                queue.Enqueue(next);
            }
        }
    }

    public void Test()
    {
        char[][] grid = {
            new char[] { '1', '1', '1', '1', '0' },
            new char[] { '1', '1', '0', '1', '0' },
            new char[] { '1', '1', '0', '0', '0' },
            new char[] { '0', '0', '0', '0', '1' },
        };

        var res = NumIslands(grid);

        System.Console.WriteLine(res);
    }
}
