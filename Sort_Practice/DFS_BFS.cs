using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Practice
{
    internal class DFS_BFS
    {
        // 깊이 우선 탐색
        public static void DFS(bool[,] graph, int start, out bool[] visited, out int[] parents)
        {
            visited = new bool[graph.GetLength(0)]; // 방문 여부
            parents = new int[graph.GetLength(0)];  // 연결되어있는 노드 

            // GetLength(0) 행의 개수 / GetLength(1) 열의 개수

            // 초기 셋팅 
            for(int i = 0; i < graph.GetLength(0); i++)
            {
                visited[i] = false;
                parents[i] = -1;
            }

            SearchNode(graph, start, visited, parents); // 실제로 탐색하는 과정
        }

        public static void SearchNode(bool[,]graph, int start, bool[] visited, int[] parents)
        {
            visited[start] = true; // 처음 시작 부분 = 방문 O

            for(int i = 0; i < graph.GetLength(0); i++)  // 여기서 돌면서 모든 정점 체크함 
            {
                if (graph[start, i] && !visited[i]) // graph[열, 행] // 정점과 연결되어 있지만 방문하지 않았을 경우
                {
                    parents[i] = start;
                    SearchNode(graph, i, visited, parents);  
                }
            }
        }

        // 너비 우선 탐색 : 큐 사용, 모든 분기 탐색한 뒤 다음 깊이 분기들을 탐색

        public static void BFS(bool[,]graph, int start, out bool[] visited, out int[]parents)
        {
            visited = new bool[graph.GetLength(0)];
            parents = new int[graph.GetLength(0)];

            for(int i = 0; i < graph.GetLength(0); i++)
            {
                visited[i] = false;
                parents[i] = -1;
            }

            visited[start] = true; // 시작 정점 방문 ㅇㅋ

            Queue<int> temp = new Queue<int>();  // 임시 저장소 큐 생성

            temp.Enqueue(start);  // 큐에 시작 정점 삽입

            visited[start] = true; // 처음 시작한 부분 방문처리 O

            while(temp.Count > 0)  // 큐 안에 아무것도 안남을 때까지 반복하기
            {
                int next = temp.Dequeue(); // 이미 방문이 완료되었고, 자식들을 확인할 정점 (큐에서 삭제)
                for(int i = 0; i < graph.GetLength(0); i++)
                {
                    if (graph[start, i] && !visited[i] ) // 연결되어 있는 정점이면서 방문한 적 없는 정점일 때
                    {
                        visited[i] = true;  // 방문여부 O
                        parents[i] = next;  // 부모노드 
                        temp.Enqueue(i);    // 큐에 넣어서 연결된 다른 노드들까지 돌 수 있게 반복

                    }
                }
            }

        }
    }
}
