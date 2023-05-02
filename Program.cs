var tuple1 = (1, 2);
var tuple2 = (2, 3);
var set = new HashSet<(int, int)>();

set.Add(tuple1);
set.Add(tuple2);
System.Console.WriteLine(set.Contains((2, 3)));