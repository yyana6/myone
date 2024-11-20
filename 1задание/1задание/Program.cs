using System;
public class progect
{
    public int x;
    private int y;
    public int Add (int e, int i)
    {
        x = e; y = i;
        return x+y;
    }
    public void res()
    {
        Console.WriteLine($"Результат операции:{y}");
    }
    public static void Main (string[] args)
    {
        progect progect = new progect();
        int sum = progect.Add(7, 4);
        Console.WriteLine($"Результат:{ sum}");
        progect.res();
    } 
}