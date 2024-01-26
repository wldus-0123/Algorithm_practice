using System.Runtime.InteropServices;

namespace Searching_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 문제 1 : 양방향 연결그래프
            bool[,] graph1 = new bool[8, 8] // 2차원 배열 생성
            {
                {false, false, true, false, true, false, false, false},
                {false, false, true, false, false, true, false, false},
                {true, true, false, false, false, true, true, false},
                {false,false,false,false,false,false,false,true},
                {true, false, false, false, false, false, false, true},
                {false, true, true, false, false, false, false, false},
                {false, false, true, false, false, false, false, false},
                {false, false, false, true, true, false, false, false},
            };

            // 문제 2 : 단방향 연결그래프
            bool[,] graph2 = new bool[8, 8]
           {
                {false, false, false, false, false, false, false, false},
                {false, false, false, false, false, false, false, false},
                {false, false, false, false, true, true, false, false},
                {false, true, false, false, false, true, false, true},
                {false, false, false, false, false, false, false, false},
                {false, true, false, false, false, false, false, false},
                {false, false, true, false, false, true, false, false},
                {false, false, false, false, false, false, true, false},
           };


            // 문제 3 : 양방향 가중치 그래프
            const int INF = int.MaxValue;
            int[,] graph3 = new int[8, 8]
            {
                {0,4,INF,INF,6,INF,INF,INF},
                {4,0,5,4,INF,8,2,INF},
                {INF,5,0,INF,9,INF,INF,INF},
                {INF,4,INF,0,INF,INF,INF,INF},
                {6,INF,9,INF,0,INF,5,INF},
                {INF,8,INF,INF,INF,0,INF,1},
                {INF,2,INF,INF,5,INF,0,INF},
                {INF,INF,INF,INF,INF,1,INF,0},
            };

        }
    }
}
