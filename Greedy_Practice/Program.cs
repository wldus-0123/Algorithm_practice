using System.Reflection.PortableExecutable;

namespace Greedy_Practice
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();

            int[]time = new int[n];

            for (int i = 0; i < n; i++)
            {
                time[i] = int.Parse(input[i]);
            }
            

            Array.Sort(time);  // 1,2,3,3,4 - 1,3,6,9,13

            int answer = 0;

            for (int i = 0; i < time.Length; i++)
            { 
                answer += time[i];
                if(i < time.Length-1) { time[i + 1] += time[i]; }
            }

            
            Console.WriteLine(answer);
        }
    }
}
