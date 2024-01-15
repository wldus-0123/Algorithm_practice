namespace Practice_01
{
    internal class Program
    {   
        // < 괄호검사기 구현하기 > : 스택
        // 괄호가 바르게 짝지어졌다는 것은 열렸으면 짝지어서 닫혀야 한다는 뜻
        // 텍스트를 입력으로 받아서 괄호가 유효한지 판단하는 함수
        // bool IsOk(string text) {}
        // 검사할 괄호 : [], {}, ()
        // 예시 : () 완성, (() 미완성, [) 미완성, [[(){}]] 완성

        static void Main(string[] args)
        {
            Console.Write("괄호와 문자열 입력 : ");
            string input = Console.ReadLine();
            if (IsOK(input) == true)
            {
                Console.WriteLine("괄호가 유효합니다");
            }
            else
            {
                Console.WriteLine("괄호가 유효하지 않습니다.");
            }
        }

        static bool IsOK(string text)
        {
            Stack<char> stack = new Stack<char>();
            char[] chars = text.ToCharArray(); // 문자열 문자 배열로 바꾸기

            for(int i = 0; i< chars.Length; i++) // 스택에 문자들 넣기
            {
                stack.Push(chars[i]);
            }

            int a = 1;
            int b = 1;
            int c = 1;

            foreach(char element in stack)
            {
                switch (element)
                {
                    case '[':
                        a = a + 1;
                        break;
                    case '{':
                        b = b + 1;
                        break;
                    case '(':
                        c= c + 1;
                        break;
                    case ')':
                        c= c - 1;
                        break;
                    case '}':
                        b = b - 1; 
                        break;
                    case ']':
                        c= c - 1;
                        break;

                    default:
                        break;
                }
            }
            if (a == 1 && b==0 && c==0) { return true; }
            else { return false; }
        }
    }
}
