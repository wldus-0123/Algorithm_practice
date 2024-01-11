namespace Algorithm_practice
{
    internal class Program
    {
        // 사용자에게 숫자를 입력받아서 0 부터 숫자까지 가지는 리스트 만들기
        // 0 요소를 제거하고, 리스트가 가지는 모든 요소들을 출력해주는 반복문 작성
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력해 주세요 : ");
            int user = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < user + 1; i++)
            {
                list.Add(i);
            }
            list.RemoveAt(0);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
            }
        }
    }
}
