namespace Practice._01
{
    internal class Program
    {
        public class CheatKey
        {
            private Dictionary<string, Action> cheatDic = new Dictionary<string, Action>();         
            
            public void Run(string cheatKey)
            {
                
                Action action1 = ShowMeTheMoney;
                Action action2 = ThereIsNoCowLevel;
                Action action3 = GameOverMan;
                Action action4 = WhatsMineIsMine;

                cheatDic.Add("ShowMeTheMoney", action1);
                cheatDic.Add("ThereIsNoCowLevel", action2);
                cheatDic.Add("GameOverMan", action3);
                cheatDic.Add("WhatsMineIsMine", action4);

                // 조건문 없이 바로 탐색하여 치트키 발동

                cheatDic.TryGetValue(cheatKey, out Action action);
                if(action != null) { action(); }
                else { Console.WriteLine("다시 입력 ㄱ"); }             
          
            }

            public void ShowMeTheMoney()
            {
                Console.WriteLine("골드를 늘려주는 치트키 발동");
            }

            public void ThereIsNoCowLevel()
            {
                Console.WriteLine("바로 승리합니다 치트키 발동");
            }

            public void GameOverMan()
            {
                Console.WriteLine("바로 패배합니다 치트키 발동");
            }

            public void WhatsMineIsMine()
            {
                Console.WriteLine("미네랄 500 획득");
            }
            
        }

        static void Main(string[] args)
        {
            CheatKey cheatKey = new CheatKey();
            string input = Console.ReadLine();
            cheatKey.Run(input);        
        }
    }    
}
