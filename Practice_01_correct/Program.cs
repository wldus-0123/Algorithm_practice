namespace Practice_01_correct
{
    internal class Program
    {   // <괄호검사기 : 스택>

        public static bool IsOk(string text)
        {
            Stack<char>stack = new Stack<char>(); // 괄호의 종류 담을 스택 만들기

            foreach(char c in text)
            {
                if(c == '(')
                {
                    stack.Push(c);
                }
                else if(c == '{')
                {
                    stack.Push(c);
                }
                else if (c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    if (stack.Count == 0)
                        return false;
                    char bracket = stack.Pop();
                    if(bracket == '(')
                    {
                        //괜찮은 상황
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (c == '}')
                {
                    char bracket = stack.Pop();
                    if (bracket == '{')
                    {
                        //괜찮은 상황
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (c == ']')
                {
                    char bracket = stack.Pop();
                    if (bracket == '[')
                    {
                        //괜찮은 상황
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            if (stack.Count > 0)
            {
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            IsOk("(())");
            IsOk("{}{}(()){()}");
        }
    }
}
