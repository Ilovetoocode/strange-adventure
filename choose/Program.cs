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
            fulltext="You are Gertrude A knight who is....",
            choice1="going to Die right now",
            choice2="Going to a party!",
            choice3="Summoning the allmighty Bob",
            r1=4,
            r2=1,
            r3=17,
        },
        new view()
        {
            fulltext="You are at the party, what would you like to do here?",
            choice1="Drink poison",
            choice2="Eat cake",
            choice3="Dance",
            r1=5,
            r2=2,
            r3=3,
        },
          new view()
        {
            fulltext="YUMMY CAKE! You want more? Or you wanna drink poison, or dance?",
            choice1="POISON, POISON!!!!!!",
            choice2="Eat more cake!",
            choice3="DANCE",
            r1=6,
            r2=8,
            r3=3,
        },
           new view()
        {
            fulltext="You wanna do some sweet dance moves, what song do you play?",
            choice1="Rickroll",
            choice2="Generic dance music",
            choice3="Demon summoning music",
            r1=10,
            r2=11,
            r3=13,
        },
            new view()
        {
            fulltext="I, I guess that works? Uhh....Gertrude Was eaten by a grue, or something... herhis life was great, and definitly worth being in history",
            choice1="",
            choice2="",
            choice3="",
            r1=-1,
            r2=-2,
            r3=-3,
        },
            new view()
        {
            fulltext="You drink poison and die. The real Gertrude is not impressed",
            choice1="",
            choice2="",
            choice3="",
            r1=-1,
            r2=-2,
            r3=-3,
        },
            new view()
        {
            fulltext="The cake has somehow made the poison not kill you, but it does make you feel woozy, so you leave and come home.",
            choice1="Go back to the party!",
            choice2="Sleep",
            choice3="",
            r1=1,
            r2=7,
            r3=-3,
        },
            new view()
        {
            fulltext="You sleep for the rest of the day. Goodnight!",
            choice1="",
            choice2="",
            choice3="",
            r1=-1,
            r2=-2,
            r3=-3,
        },
            new view()
        {
            fulltext="You eat more cake, your belly starts growing out. Maybe you want to stop eating the cake?",
            choice1="Eat more!",
            choice2="Leave the party",
            choice3="Dance off the cake",
            r1=9,
            r2=12,
            r3=3,
        },
            new view()
        {
            fulltext="You ate the whole cake. You end up turning into basically a big round fat ball, unable to move. Since you can't go home, you soon get eaten by a grue, due to destroying the house you went to by accident.",
            choice1="",
            choice2="",
            choice3="",
            r1=-1,
            r2=-2,
            r3=-3,
        },
            new view()
        {
            fulltext="We're no strangers to love\r\nYou know the rules and so do I (do I)\r\nA full commitment's what I'm thinking of\r\nYou wouldn't get this from any other guy\r\nI just wanna tell you how I'm feeling\r\nGotta make you understand\r\nNever gonna give you up\r\nNever gonna let you down\r\nNever gonna run around and desert you\r\nNever gonna make you cry\r\nNever gonna say goodbye\r\nNever gonna tell a lie and hurt you\r\nWe've known each other for so long\r\nYour heart's been aching, but you're too shy to say it (say it)\r\nInside, we both know what's been going on (going on)\r\nWe know the game and we're gonna play it\r\nAnd if you ask me how I'm feeling\r\nDon't tell me you're too blind to see\r\nNever gonna give you up\r\nNever gonna let you down\r\nNever gonna run around and desert you\r\nNever gonna make you cry\r\nNever gonna say goodbye\r\nNever gonna tell a lie and hurt you\r\nNever gonna give you up\r\nNever gonna let you down\r\nNever gonna run around and desert you\r\nNever gonna make you cry\r\nNever gonna say goodbye\r\nNever gonna tell a lie and hurt you\r\nWe've known each other for so long\r\nYour heart's been aching, but you're too shy to say it (to say it)\r\nInside, we both know what's been going on (going on)\r\nWe know the game and we're gonna play it\r\nI just wanna tell you how I'm feeling\r\nGotta make you understand\r\nNever gonna give you up\r\nNever gonna let you down\r\nNever gonna run around and desert you\r\nNever gonna make you cry\r\nNever gonna say goodbye\r\nNever gonna tell a lie and hurt you\r\nNever gonna give you up\r\nNever gonna let you down\r\nNever gonna run around and desert you\r\nNever gonna make you cry\r\nNever gonna say goodbye\r\nNever gonna tell a lie and hurt you\r\nNever gonna give you up\r\nNever gonna let you down\r\nNever gonna run around and desert you\r\nNever gonna make you cry\r\nNever gonna say goodbye\r\nNever gonna tell a lie and hurt you" +
                "(officer's report: this was the song that played when Gertrude mysteriously dissapeared while dancing. herhis freinds tell us that when they dissapeared, there was a mysterious figure behind them." +
                "It is said that this song has been cursed ever since, LET NOONE PLAY IT.",
            choice1="",
            choice2="",
            choice3="",
            r1=-1,
            r2=-2,
            r3=-3,
        },
             new view()
        {
            fulltext="OH YEAH! DANCE, BABY, DANCE!!!!",
            choice1="Eat cake",
            choice2="Drink poison",
            choice3="Leave",
            r1=2,
            r2=5,
            r3=12,
        },
              new view()
        {
            fulltext="You leave the party and come home.",
            choice1="Go back to the party!",
            choice2="Sleep",
            choice3="Just die lol",
            r1=1,
            r2=7,
            r3=4,
        },
               new view()
        {
            fulltext="You dance to the demon music, and oh no! The devil is here!",
            choice1="KILL HIM",
            choice2="Sell your soul",
            choice3="Dance with him",
            r1=14,
            r2=15,
            r3=16,
        },
                new view()
        {
            fulltext="You Kill Satan himself, and now everyone is happy! You did it! You, are a hero I guess?",
            choice1="",
            choice2="",
            choice3="",
            r1=-1,
            r2=-2,
            r3=-3,
        },
                 new view()
        {
            fulltext="You have sold your soul to the devil, you get nothing in return. You yourself are forced to be a cat maid for him, ha ha",
            choice1="",
            choice2="",
            choice3="",
            r1=-1,
            r2=-2,
            r3=-3,
        },
                  new view()
        {
            fulltext="You and the devil dance...." +
                      "Years later, you two are in love, and run a successful dance school. How interesting and bizzare",
            choice1="",
            choice2="",
            choice3="",
            r1=-1,
            r2=-2,
            r3=-3,
        },
                   new view()
        {
            fulltext="|\\   __  \\|\\   __  \\|\\   __  \\    \r\n\\ \\  \\|\\ /\\ \\  \\|\\  \\ \\  \\|\\ /_   \r\n \\ \\   __  \\ \\  \\\\\\  \\ \\   __  \\  \r\n  \\ \\  \\|\\  \\ \\  \\\\\\  \\ \\  \\|\\  \\ \r\n   \\ \\_______\\ \\_______\\ \\_______\\\r\n    \\|_______|\\|_______|\\|_______| Reveals the secrets of the universe to you. 'Gertrude, none of this is real....' \r\n|\\   __  \\|\\   __  \\|\\   __  \\    \r\n\\ \\  \\|\\ /\\ \\  \\|\\  \\ \\  \\|\\ /_   \r\n \\ \\   __  \\ \\  \\\\\\  \\ \\   __  \\  \r\n  \\ \\  \\|\\  \\ \\  \\\\\\  \\ \\  \\|\\  \\ \r\n   \\ \\_______\\ \\_______\\ \\_______\\\r\n    \\|_______|\\|_______|\\|_______| then opens a strange portal of some kind,'Gertrude, once you go in here, you can't come back, but you will have my power, in the real world!' You step in, and.... You are now a powerful god like no other, you and \r\n|\\   __  \\|\\   __  \\|\\   __  \\    \r\n\\ \\  \\|\\ /\\ \\  \\|\\  \\ \\  \\|\\ /_   \r\n \\ \\   __  \\ \\  \\\\\\  \\ \\   __  \\  \r\n  \\ \\  \\|\\  \\ \\  \\\\\\  \\ \\  \\|\\  \\ \r\n   \\ \\_______\\ \\_______\\ \\_______\\\r\n    \\|_______|\\|_______|\\|_______| create worlds for people to live in, only for them to die. You two end up falling in love, this is happy end.",
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


    static string idk(string s)
    {
        s= s.Replace("Gertrude", name);
        s= s.Replace("herhis", gender);
        return s;
    }
    static void pageview()
    {
        
        Console.Clear();

        Console.WriteLine(idk(viewer[current].fulltext) + Environment.NewLine + Environment.NewLine + Environment.NewLine);;
        Console.WriteLine("Do something");
        if (viewer[current].choice1 != "")
        {
            Console.WriteLine(idk(viewer[current].choice1));
        }
        if (viewer[current].choice2 != "")
        {
            Console.WriteLine(idk(viewer[current].choice2));
        }
        if (viewer[current].choice3 != "")
        {
            Console.WriteLine(idk(viewer[current].choice3));
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
        name = Console.ReadLine();
        Console.WriteLine("Pronouns?");
        gender = Console.ReadLine();
        while (true)
        {
            pageview();
        }
        
    }
}