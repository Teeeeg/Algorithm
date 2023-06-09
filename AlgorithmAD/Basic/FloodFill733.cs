namespace AlgorithmAD.Basic;

public class FloodFill733
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        if (image[sr][sc] == color)
        {
            return image;
        }

        var m = image.Length;
        var n = image[0].Length;
        var dirs = new List<(int rowDir, int colDir)> { (-1, 0), (0, -1), (0, 1), (1, 0) };

        var queue = new Queue<(int row, int col)>();
        var pixel = (sr, sc);
        queue.Enqueue(pixel);
        var oldColor = image[sr][sc];
        var set = new HashSet<int>();


        while (queue.Count != 0)
        {
            var curPixel = queue.Dequeue();
            image[curPixel.row][curPixel.col] = color;

            foreach (var dir in dirs)
            {
                var nexRow = curPixel.row + dir.rowDir;
                var nexCol = curPixel.col + dir.colDir;
                var nextPixel = (nexRow, nexCol);

                if (!(0 <= nexRow && nexRow < m) || !(0 <= nexCol && nexCol < n) || image[nexRow][nexCol] != oldColor)
                {
                    continue;
                }

                queue.Enqueue(nextPixel);
            }
        }

        return image;
    }

    public void Test()
    {
        int[][] image = { new int[] { 1, 1, 1 }, new int[] { 1, 1, 0 }, new int[] { 1, 0, 1 } };
        var sr = 1;
        var sc = 1;
        var color = 2;
        var res = FloodFill(image, sr, sc, color);

        foreach (var row in res)
        {
            foreach (var val in row)
            {
                System.Console.WriteLine(val);
            }
        }
    }
}
