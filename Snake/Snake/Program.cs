// See https://aka.ms/new-console-template for more information
class Point
{
    public int x;
    public int y;
    public char sym;
    public void Draw()
    {
        Console.SetCursorPosition(x, y);
        Console.Write(sym);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point();
        p1.x = 1;
        p1.y = 3;
        p1.sym = '*';

        Point p2 = new Point();
        p2.x = 4;
        p2.y = 5;
        p2.sym = '#';

        p1.Draw();
        p2.Draw();

        Console.ReadLine();
    }
}