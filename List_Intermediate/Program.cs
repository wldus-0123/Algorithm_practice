namespace List_Intermediate
{
    internal class Program
    {   // 사용자의 입력을 받아서 없는 데이터면 추가하고, 있던 데이터면 삭제하는 보관함을 만든다
        // ex. 1, 6, 7, 8, 3 들고 있던 상황일 경우
        // 2를 입력할 경우 : 리스트에 없으므로 1, 6, 7, 8, 3, 2 출력
        // 7을 입력할 경우 : 리스트에 있으므로 1, 6, 8, 3 출력

        static public void ListElement<T>(List<T> list)
        {
            foreach (T element in list)
            {
                Console.Write(element);
            }
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            while (list.Count >= 0)
            {
                Console.Write("\n숫자를 입력해 주세요 : ");
                int user = int.Parse(Console.ReadLine());
                int index = list.IndexOf(user);
                if (index == -1)
                {
                    list.Add(user);
                }
                else
                {
                    list.Remove(user);
                }
                ListElement(list);
            }
        }
    }
}
