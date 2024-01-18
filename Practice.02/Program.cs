namespace Practice._02
{
    internal class Program
    {   
        public class Memo
        {
            public string site;
            public string password;

            public Memo(string site, string password)
            {
                this.site = site;
                this.password = password;
            }
        }

        static void Main(string[] args)
        {

            Memo memo1 = new Memo("noj.am", "IU");
            Memo memo2 = new Memo("startlink.io", "THEKINGOD");
            Memo memo3 = new Memo("acmicpc.net", "UAENA");

            Dictionary<string,string> dictionary = new Dictionary<string,string>();

            dictionary.Add(memo1.site, memo1.password);
            dictionary.Add(memo2.site, memo2.password);
            dictionary.Add(memo3.site, memo3.password);

            string answer = "acmicpc.net";

            dictionary.TryGetValue(answer, out string password);
            Console.WriteLine(password);
        }
    }
}
