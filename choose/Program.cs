using System.Security.Cryptography;
using System.Text;

    struct view
    {
        public string fulltext;
        public string choice1, choice2, choice3;
        //r in this case represents result
        public int r1, r2, r3;
    }

internal class Program

{
    static string name = "Gertude";
    static string gender = "herhis";

    static view[] viewer =
{
        new view()
        {
            fulltext="You are " +name+ " A knight who is....",
            choice1="going to Die right now",
            choice2="Going to a party!",
            choice3="",
            r1=4,
            r2=2,
            r3=-1,
        },
        new view()
        {
            fulltext="You are at the party, what would you like to do here?",
            choice1="start",
            choice2="next",
            choice3="second to last",
            r1=1,
            r2=2,
            r3=3,
        },
          new view()
        {
            fulltext="it",
            choice1="end",
            choice2="start",
            choice3="back 1",
            r1=1,
            r2=2,
            r3=3,
        },
           new view()
        {
            fulltext="working?",
            choice1="back1",
            choice2="end",
            choice3="reset",
            r1=1,
            r2=2,
            r3=3,
        },
            new view()
        {
            fulltext="I, I guess that works? Uhh...."+name+"Was eaten by a grue, or something...",
            choice1="",
            choice2="",
            choice3="",
            r1=-1,
            r2=-2,
            r3=-3,
        }
    };
    static int current = 0;
    static Random rand = new Random();
    static int maxstart = 1;
    static void pageview()
    {
        Console.Clear();
        if ((viewer[current].fulltext).Contains("Gertrude"))
        {
            string s = viewer[current].fulltext.Replace("gertrude", name);
        }
        Console.WriteLine(viewer[current].fulltext + Environment.NewLine + Environment.NewLine + Environment.NewLine);
        Console.WriteLine("Do something");
        if (viewer[current].choice1 != "")
        {
            Console.WriteLine(viewer[current].choice1);
        }
        if (viewer[current].choice2 != "")
        {
            Console.WriteLine(viewer[current].choice2);
        }
        if (viewer[current].choice3 != "")
        {
            Console.WriteLine(viewer[current].choice3);
        }
        char input = Console.ReadKey().KeyChar;
        if ((input == 'A' || input == 'a' || input== '1' )&& viewer[current].r1 >= 0)
        {
            current = viewer[current].r1;
        }
        if ((input == 'B' || input == 'b' || input == '2') && viewer[current].r2 >= 0)
        {
            current = viewer[current].r2;
        }
        if ((input == 'C' || input == 'c' || input == '3') && viewer[current].r3 >= 0)
        {
            current = viewer[current].r3;
        }
    }
    
    
    private static void Main(string[] args)
    {
        current = rand.Next(0, maxstart);
        
        Console.WriteLine("Name please!");
        Console.WriteLine("Pronouns?");
       
        while (true)
        {
            pageview();
        }
        
    }
}