using System.Collections.Generic;
using System;
using System.ComponentModel;

namespace LinkedList_Intermediate
{
    internal class Program
    {
        // < 요세푸스 순열 문제 >

        /*요세푸스 문제는 다음과 같다.
         1번부터 N번까지 N명의 사람이 원을 이루면서 앉아있고, 양의 정수 K(≤ N)가 주어진다. 
         이제 순서대로 K번째 사람을 제거한다. 
         한 사람이 제거되면 남은 사람들로 이루어진 원을 따라 이 과정을 계속해 나간다. 
         이 과정은 N명의 사람이 모두 제거될 때까지 계속된다. 
         원에서 사람들이 제거되는 순서를 (N, K)-요세푸스 순열이라고 한다. 
         예를 들어 (7, 3)-요세푸스 순열은 <3, 6, 2, 7, 5, 1, 4>이다.
         N과 K가 주어지면 (N, K)-요세푸스 순열을 구하는 프로그램을 작성하시오. */

        static void Main(string[] args)
        {
            LinkedList<int> josephus = new LinkedList<int>();

            int n = 7;  // N = 인원
            int k = 3;  // K = 인원
              
            for(int i = 1; i < n+1; i++)
            {
                josephus.AddLast(i);
            }

            while(josephus.Count>0) // 연결리스트의 크기..?가 남아있을 때만 돌리기
            {
                for(int i = 1; i <= k; i++)
                {
                    LinkedListNode<int> node = josephus.First;
                    if (i == k)
                    {
                        //빠지기
                        josephus.Remove(node);
                        Console.Write($"{node.Value} ");
                    }
                    else
                    {
                        //뒤로 들어가기
                        josephus.Remove(node);
                        josephus.AddLast(node);
                    }
                }
            }
    
            // 3,6,2,7,5,1,4

            // 1,2,3,4,5,6,7
            //1. 3 : 1,2,(3),4,5,6,7
            //2, 6 : 1,2,(3),4,5,(6),7  
            //3. 2 : 1,(2),(3),4,5,(6),7
            //4. 7 : 1,(2),(3),4,5,(6),(7)
            //5. 5 : 1,(2),(3),4,(5),(6),(7)
            //6. 1 : (1),(2),(3),4,(5),(6),(7)
            //7. 4

        }
    }
}
