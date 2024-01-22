namespace Backtracking_Practice
{
    internal class Program
    {
        // 1부터 N까지 자연수 중에서 M개를 고른 수열
        // 같은 수를 여러 번 골라도 된다.

        // 백트래킹 : 모든 경우의 수를 전부 고려하는 알고리즘
        // int [0] = 1. int[1] = 1 이런식으로 할건데 머시발어쩌라는겨
        // 재귀로 풀라는데 재귀를 못만들겟다고요오오



        static void Main(string[] args)
        {
            int n = 3;
            int m = 3;
            int[] result = new int[m]; // 2칸짜리 배열 = int[0]이 1일 때 int[1]은 1인 배열 출력, 이후 int[1]이 2인 배열 출력

            int a = 0;

            for(int k = 0; k < n; k++)
            {
                result[0] = k + 1; 

                if(result.Length> 1) 
                {
                    for (int i = 0; i < n; i++)
                    {
                        result[1] = i + 1;
                        foreach (int j in result)
                        {
                            Console.Write(j);
                            Console.Write(' ');
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    foreach (int j in result)
                    {
                        Console.Write(j);
                        Console.Write(' ');
                    }
                    Console.WriteLine();
                }            
            }        
        }
    }
}
