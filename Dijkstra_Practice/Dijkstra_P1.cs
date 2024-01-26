using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra_Practice
{
    internal class Dijkstra_P1
    {
        const int INF = 99999; // 최대값 설정 : 단절 표현

        // 그래프 배열값, 시작위치를 입력받아 방문여부, 최단거리, 직전 정점을 반환 
        public static void ShortestPath(int[,] graph, int start, out bool[] visited, out int[] distance, out int[]parents)
        {
            // ( 그래프 배열 행 크기 = 정점 갯수 )
            int size = graph.GetLength(0);

            visited = new bool[size];
            distance = new int[size];
            parents = new int[size];

            // 초기셋팅
            for(int i = 0; i < size;  i++)
            {
                visited[i] = false; // 방문 여부 - X
                distance[i] = INF;  // 거리 - 아직 모르므로 최대값으로 지정(단절)
                parents[i] = -1;    // 직전 정점 - 아직 모르므로 없는 셈 침
            }

            // 출발노드 거리 값 0으로 설정
            distance[start] = 0;

            // 모든 정점들 한번씩 싹 돌기
            for(int i = 0; i < size; i++)
            {
                // 다음으로 탐색할 정점 고르기
                int next = -1;          // 처음은 없는 상태
                int minDistance = INF;  // 현 시점의 최소거리 (처음엔 모르니까 무한대로 설정)
                
                for(int j = 0; j < size; j++)
                {
                    if (!visited[j] && distance[j] < minDistance) // 1. 아직 방문하지 않음 , 2. 현시점 최단거리보다 적은 거리의 정점 찾기
                    {
                        next = j;                   // 다음으로 탐색할 정점
                        minDistance = distance[j];  // 현 시점 최소 거리 설정
                    }
                }

                // 여태 찾은 거리값과 비교해서 더 작은 값으로 바꿔주기
                for(int j = 0; j < size; j++)
                {
                    if (distance[j] > distance[next] + graph[next, j])
                    {
                        distance[j] = distance[next] + graph[next, j];
                        // '정점 ~ j 까지의 거리'가
                        // '정점 ~ 현재 탐색중인 정점의 거리'와 '현재 탐색 중인 정점 ~ j까지의 거리'를 더한 것보다 작을 경우
                        // '현재 탐색 중인 정점 ~ j까지의 거리' = 최소거리로 판단하고 '정점 ~ j 까지의 거리' 값을 변경
                        parents[j] = next;
                        // 어떤 정점을 통해 j를 탐색했는지 = 현재 탐색중인 정점 
                    }
                }

                // 탐색 완료 - 방문 했었다고 바꿔주기
                visited[next] = true;
            }
        }
    }
}
