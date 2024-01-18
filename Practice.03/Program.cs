namespace Practice._03
{
    internal class Program
    {
        public class CheatKey
        {
            private Dictionary<string, Action> cheatDic;

            public CheatKey()
            {
                cheatDic = new Dictionary<string, Action>();

                cheatDic.Add("show me the money", ShowMeTheMoney);
                cheatDic.Add("there is no cow level", ThereIsNoCowLevel);
            }
            public void Run(string cheatKey)
            {
                cheatDic.TryGetValue(cheatKey, out Action action);
                action?.Invoke(); // 이게 뭐야....
            }

            public void ShowMeTheMoney()
            {
                Console.WriteLine("골드 추가");
            }

            public void ThereIsNoCowLevel()
            {
                Console.WriteLine("바로 승리");
            }
        }
        
        static void Main(string[] args)
        {
            CheatKey cheat = new CheatKey();

           
        }
    }
}
