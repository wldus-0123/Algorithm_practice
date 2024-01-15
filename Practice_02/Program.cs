namespace Practice_02
{
    internal class Program
    {
        // < 작업 프로세스 : 큐 >
        public const int WorkTime = 8;
        int[] ProcessJob(int[] jonList)
        {
            Queue<int>queue = new Queue<int>();
            int remainTime = 8; // 남은 시간
            int day = 1;        // 날짜
            List<int> days = new List<int>();

            for(int i = 0; i < jonList.Length; i++)
            {
                queue.Enqueue(jonList[i]);
            }

            while (queue.Count > 0)  // 큐에 아무것도 안남을 때까지 반복
            {
                int currentWorkTime = queue.Dequeue();
                while (true)
                {
                    if (currentWorkTime <= remainTime)
                    {
                        remainTime -= currentWorkTime;
                        //작업완료
                        days.Add(day);
                        break;
                    }
                    else
                    {
                        currentWorkTime -= remainTime;
                        // 다음날로 넘어감
                        day++;
                        remainTime = 8;
                    }
                }               
            }
            return days.ToArray();
        }
        static void Main(string[] args)
        {
            
        }
    }
}
