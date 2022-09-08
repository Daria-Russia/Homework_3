

//Task 21
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

int k = (x1-x2);
int l = (y1-y2);
int m = (z1-z2);

Console.Writeline(Math.Sqrt(k*k+l*l+m*m));

