namespace Practice01
{
    internal class Program

    {
        static void Main(string[] args)
        {
            // {17,9,33,5,13,1,26.29.89}가 든 이진탐색트리 만들기
            SortedSet<int> practice = new SortedSet<int>();

            practice.Add(17);
            practice.Add(9);
            practice.Add(33);
            practice.Add(5);
            practice.Add(13);
            practice.Add(1);
            practice.Add(26);
            practice.Add(29);
            practice.Add(89);


            // {11} 추가
            practice.Add(11);

            // {1} 삭제
            practice.Remove(1);

            // {5} 삭제
            practice.Remove(5);

            // {17} 삭제
            practice.Remove(17);

            foreach(int i in practice)
            {
                Console.WriteLine(i);
            }
        }
    }
}
