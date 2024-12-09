namespace Task9;

class Program
{
    static void Main(string[] args)
    {
        int[] x = {2,5,9,4,13,6};
        Array.Sort(x);

        foreach (int i in x){
            Console.WriteLine(i);
        }
    }
}
