namespace LinkedList_Basic
{
    internal class Program
    {   // 1. 사용자의 입력으로 숫자를 입력받기 (음수도 허용)
        // 2. 음수는 앞에 추가, 양수는 뒤에 추가하여 음수와 양수를 반으로 나누는 연결리스트를 구현
        // 3. 입력받을 때마다 처음부터 끝까지 출력 진행
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            while (true) 
            {
                Console.Write("숫자를 입력해 주세요 : ");
                int num = int.Parse(Console.ReadLine());

                if (num > 0)
                {
                    list.AddLast(num);
                }
                else if (num < 0)
                {
                    list.AddFirst(num);
                }
                else if (num == 0)
                {
                    Console.WriteLine("0은 입력할 수 없습니다.");
                }

                Console.Write("Linked List 요소 출력 : ");
                foreach (int value in list)
                {
                    Console.Write($"{value} ");
                }
                Console.WriteLine();
            }                       
        }
    }
}
