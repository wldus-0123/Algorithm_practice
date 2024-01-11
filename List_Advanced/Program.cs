namespace List_Advanced
{
    internal class Program
    {
        // 인벤토리 구현 ( 아이템 수집, 아이템 버리기 )
        enum SKILL { Collect, Throw }
        static SKILL PlayerInput()
        {
            SKILL player = SKILL.Collect;
            Console.WriteLine("1번 : 아이템 수집 / 2번: 아이템 버리기");

            ConsoleKeyInfo info = Console.ReadKey();
            switch (info.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    player = SKILL.Collect;
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    player = SKILL.Throw;
                    break;
            }
            return player;
        }
        static void CollectItem(List<string> list)
        {
            Console.Write("\n\n아이템 수집 : ");
            string itemname = Console.ReadLine();
            list.Add(itemname);
        }

        static void ThrowItem(List<string> list)
        {
            Console.Write("\n\n아이템 버리기 : ");
            string itemname = Console.ReadLine();
            int index = list.IndexOf(itemname);
            if (index == -1)
            {
                Console.WriteLine("해당 아이템을 찾을 수 없습니다.");
            }
            else
            {
                list.Remove(itemname);
            }
        }
        static void ItemList(List<string> list)
        {
            Console.Write("소지한 아이템 목록 : ");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }
            Console.WriteLine("\n");
        }


        static void Main(string[] args)
        {
            List<string> myInven = new List<string>();


            Console.WriteLine("*** 사용자의 인벤토리 ***\n");

            while (myInven.Count >= 0)
            {
                SKILL player = PlayerInput();

                if (player == SKILL.Collect)
                {
                    CollectItem(myInven);
                }

                else if (player == SKILL.Throw)
                {
                    ThrowItem(myInven);
                }
                ItemList(myInven);
            }
        }
    }
}
