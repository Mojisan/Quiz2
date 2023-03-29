using System;
public class Program {
    public static void Main(string[] args)
    {
        Loop();
    }
    public static int InputN() {
        Console.Write("Input contestant number : ");
        return int.Parse(Console.ReadLine());
    }
    public static int InputK() {
        Console.Write("Input care amount : ");
        return int.Parse(Console.ReadLine());
    }
    public static int InputG() {
        Console.Write("Input gender : ");
        return int.Parse(Console.ReadLine());
    }
    public static int InputS1() {
        Console.Write("Input Score 1 : ");
        return int.Parse(Console.ReadLine());
    }
    public static int InputS2() {
        Console.Write("Input Score 2 : ");
        return int.Parse(Console.ReadLine());
    }
    public static void Loop() {
        int N = InputN();
        int K = InputK();
        int i = 1;
        if ((N > 1 && N <= 10000) && (K >= 1 && K <= 10000)) {
            int D1 = K;
            int D2 = K;
            while ((D1 > 0 || D2 > 0) && i <= N) {
                int G = InputG();
                int S1 = InputS1();
                int S2 = InputS2();
                if (S1 >= 9 && S2 >= 9) {
                    int check = director(G);
                    if (D1 == 0) {
                        continue;
                    }
                    if (check == 1) D1--;
                    else D2--;
                    Console.WriteLine(check);
                    Console.WriteLine("Number : {0}",i);
                } 
                else if (S1 >= 9 && S2 < 9) {
                    Console.WriteLine("1");
                    D1--;
                    Console.WriteLine("Number : {0}",i);
                }
                else if (S1 < 9 && S2 >= 9) {
                    Console.WriteLine("2");
                    D2--;
                    Console.WriteLine("Number : {0}",i);
                }
                i++;
        }
        }
    }
    public static int director(int G) {
        if (G == 1) return 1;
        return 2;
    }
}