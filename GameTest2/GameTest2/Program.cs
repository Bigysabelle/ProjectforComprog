using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GameTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maingame = 0;
            while (maingame == 0)
            {
                Console.WriteLine("a) Start\nb) Exit");
                Console.Write("Action: ");
                string starter = Console.ReadLine();
                if (starter == "a")
                {
                    Console.WriteLine("\nWould you like to skip the introduction?(It's recommended to not skip it if it's your first time playing)\na) Yes\nb) No");
                    string skipping = Console.ReadLine();
                    if (skipping == "a")
                    {
                        Midgame();
                    }
                    else if (skipping == "b")
                    {
                        Introduction();
                        Midgame();
                    }
                }
                else if (starter == "b") 
                {
                    Console.WriteLine("Exiting the game...");
                    Console.WriteLine("Thank you for trying out the game!");
                    break;
                }
                else
                {
                    Console.WriteLine("Kidly put either a or b");
                }
            }
        }
        static void Introduction()
        {
            Console.WriteLine("You come from a wealthy family and have recently been promoted to chief officer, working abroad. It\'s been a long time since you last visited home, as you\'ve been " +
                "busy with early projects. However, an opportunity has arisen: your close friend Leon, who is now the general director of the Citadel Opera House and a person you\'ve known since " +
                "childhood, has given you a letter.\n");
            Console.WriteLine(" _________________________________________________________________________________ \n" +
                              "|                                                                                 |\n" +
                              "|                                                                                 |\n" +
                              "|                                                                                 |\n" +
                              "|  It has been years since we last met in person. I have heard from the merchants |\n" +
                              "|  that you are doing well and contributing significantly to our country.         |\n" +
                              "|  Therefore, I invite you to be one of our special guests at the Citadel Opera   |\n" +
                              "|  House for our 30th anniversary celebration. You have always been a supportive  |\n" +
                              "|  friend, and I hope you can attend. This would also be an excellent opportunity |\n" +
                              "|  to relax and enjoy yourself.                                                   |\n" +
                              "|                                                     ██████                      |\n" +
                              "|                                                   ░░  ░░  ██                    |\n" +
                              "|                                                 ░░░░  ██  ░░██                  |\n" +
                              "|  Sincerely from your dear friend,               ░░  ░░████  ██                  |\n" +
                              "|  Leon Grandet                                   ░░  ░░░░██  ██                  |\n" +
                              "|                                                   ░░      ██                    |\n" +
                              "|                                                     ░░░░██                      |\n" +
                              "|_________________________________________________________________________________|\n");
            Console.ReadLine();
            Console.WriteLine("Without any doubt, you wrote a letter back, agreeing to join in watching the performance of the Citadel's finest entertainers. As you sealed the letter, you couldn't " +
                "help but feel excitement and nostalgia for your hometown. You finalize the letter with your name below.\n");
            Console.Write("What's your name? ");
            string playername = Console.ReadLine();
            Console.WriteLine("\nYou finally arrived in your hometown in the following days and noticed how much it had improved. The streets were bustling and more crowded than usual. Suddenly, you " +
                "spotted a familiar face waving at you. Leon Grandet stood in the crowd, smiling and greeting you. He was wearing a top hat and one of the finest suits. A cane accompanied him, and " +
                "he was walking towards you. You hurried over to your friend and began catching up on things. Leon took you to the front of the Citadel Opera House, now packed with excited " +
                "audiences eagerly waiting for the performance.\n");
            Console.ReadLine();
            //brushes hehe Gray = ░░ white = ██
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗\n"+
                              "║░░      ░░░░                ██      ██████████      ██                      ░░░░      ░░░░                                                ║\n" +
                              "║  ░░  ░░  ░░            ████████████      ░░░░████████████                  ░░  ░░  ░░  ░░                                                ║\n" +
                              "║    ░░    ░░██████████████          ██████████░░░░░░░░░░██████████████████  ░░    ░░    ░░                                ██████          ║\n" +
                              "║  ░░  ░░████████          ██████████░░      ░░██████████░░░░░░░░░░░░░░░░████████░░  ░░  ░░              ░░    ░░░░      ████░░████      ░░║\n" +
                              "║░░  ██████      ██████████        ░░  ░░  ░░  ░░        ████████████████░░░░░░██████  ░░░░              ░░  ░░    ░░  ██    ██░░████  ░░  ║\n" +
                              "║  ████  ████████          ░░░░░░  ░░░░  ░░  ░░░░  ░░░░░░                ██████░░░░████  ░░                ░░      ████  ████  ██░░████    ║\n" +
                              "║████  ██                    ░░░░  ░░  ░░  ░░  ░░  ░░░░░░░░░░░░░░░░░░░░░░      ████  ████                      ████    ██    ░░  ████░░░░██║\n" +
                              "║██████████████████████████████████████████████████████████████████████████████████████████████████████████████    ████    ░░  ░░    ████░░║\n" +
                              "║░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ████  ████          ░░    ░░    ██║\n" +
                              "║  ░░  ░░██████████████████░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░██████  ██            ░░  ░░  ░░░░░░  ║\n" +
                              "║██████████      ░░░░░░░░██████████████████████████████████████████████████████████████████████████████████████████████████████████████████║\n" +
                              "║    ██  ████████████████░░████                                                                            ██    ██░░                ░░██  ║\n" +
                              "║  ████  ██              ████░░██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░████    ██  ░░░░░░░░░░░░░░░░  ██  ║\n" +
                              "║████  ██        ░░░░░░░░  ██░░████        ░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██    ██                    ██  ║\n" +
                              "║██  ██            ░░░░░░░░  ██░░██                                                                        ██    ██░░░░░░░░░░░░░░░░░░░░██  ║\n" +
                              "║██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████║\n" +
                              "║░░░░██░░░░░░░░░░░░░░░░░░░░░░██░░░░██░░    ██  ██    ░░██      ██        ░░░░  ░░░░      ░░░░  ░░░░        ██    ██░░  ░░        ░░  ░░██  ║\n" +
                              "║██████      ░░░░░░░░░░      ████████  ░░██      ██░░  ██████████      ░░░░  ░░░░          ░░░░  ░░░░      ██    ██  ░░░░        ░░░░  ██  ║\n" +
                              "║  ░░██████████████████████████    ██████  ██████  ██████      ██      ░░    ██              ██    ░░      ██    ██    ░░        ░░    ██  ║\n" +
                              "║  ░░██    ██    ██    ██    ██░░  ██    ██      ██    ██      ██    ░░░░  ██                  ██  ░░░░    ██    ██    ░░        ░░    ██  ║\n" +
                              "║  ░░██    ██    ██    ██    ██░░  ██  ██  ░░░░░░  ██  ██      ██    ░░    ██                  ██    ░░    ██    ██    ░░        ░░    ██  ║\n" +
                              "║  ░░██    ██    ██    ██    ██░░  ██  ██  ░░░░░░  ██  ██      ██    ░░  ████                  ████  ░░    ██    ██  ░░░░  ░░░░  ░░░░  ██  ║\n" +
                              "║  ░░██████████████████████████░░  ██  ██  ░░░░░░  ██  ██      ██    ██  ██                      ██  ██    ██    ██░░  ░░░░    ░░░░  ░░██  ║\n" +
                              "║  ░░██  ██░░██      ██░░██  ██░░  ██  ██  ░░░░░░  ██  ██      ██    ██  ██                      ██  ██    ██    ██    ░░░░    ░░░░    ██  ║\n" +
                              "║  ░░██  ██░░██      ██░░██  ██░░  ██  ██  ░░░░░░  ██  ██      ██    ██  ██                      ██  ██    ██    ██    ░░        ░░    ██  ║\n" +
                              "║  ░░██  ██░░██      ██░░██  ██░░  ██████████████████████████████    ░░  ██                      ██  ░░    ██    ██    ░░        ░░    ██  ║\n" +
                              "║  ░░██  ██░░██      ██░░██  ██░░  ██                  ██      ██    ░░  ██                      ██  ░░    ██    ██    ░░        ░░    ██  ║\n" +
                              "║  ░░██  ██░░██      ██░░██  ██░░  ██                  ██      ██    ░░  ░░                      ░░  ░░    ██    ██    ░░        ░░    ██  ║\n" +
                              "║  ░░██  ██░░██      ██░░██  ██░░  ██████████████████████      ██    ░░  ░░                      ░░  ░░    ██    ██    ░░        ░░    ██  ║\n" +
                              "║    ██  ██░░██      ██░░██  ██    ██░░  ░░  ░░  ░░  ░░██      ██    ░░  ░░                      ░░  ░░    ██    ██    ░░        ░░    ██  ║\n" +
                              "║    ██  ██░░██      ██░░██  ██    ██  ░░  ░░  ░░  ░░  ██      ██    ░░  ░░                      ░░  ░░    ██    ██    ░░        ░░    ██  ║\n" +
                              "╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝\n");
            Console.WriteLine("{0}: I remember when this opera house was built; it has never had such a large audience. It was still a tiny performance crew with just a few supporters. " +
                "How time has passed, huh?\n",playername);
            Console.ReadLine();

            LeonGrandetProfile();
            Console.WriteLine(" _________________________________________________________________________________________________________________________________________\n" +
                              "/                                                                                                                                         \\\n" +
                              "|  Leon Grandet: Indeed, without your support during that time, I wouldn\'t have been able to continue building this growing community. I   |\n" +
                              "|                was just an ordinary person with ambitions to share talent. Yet, you still gave me numerous opportunities, even when the  |\n" +
                              "|                Citadel faced difficult times.                                                                                            |\n" +
                              "\\_________________________________________________________________________________________________________________________________________/\n");
            Console.ReadLine();
            Console.WriteLine(" ___________________________________________________________________________________________________________________________________________\n" +
                              "|                                                                                                                                           |\n" +
                              "|  You and Leon entered the lobby, waiting for the performance to start. As you sat in the nearby chairs, two people approached you. One    |\n" +
                              "|  was dressed elegantly in a refined dress adorned with pearls, with a fan dangling from her waist. The other person wore a green suit and |\n" +
                              "|  glasses and carried a cane, signifying his status as one of the aristocrats.                                                             |\n" +
                              "|___________________________________________________________________________________________________________________________________________|\n");
            Console.ReadLine();
            Console.WriteLine(" _________________________________________________________________________________________________________________________________________\n" +
                             "/                                                                                                                                         \\\n" +
                             "|  Leon Grandet: Oh, Silvio and Merida, meeting you two was a pleasure. Are you guys not going to perform at the event?                    |\n" +
                             "\\_________________________________________________________________________________________________________________________________________/\n");
            Console.ReadLine();
            MeridaLakesProfile();
            Console.SetCursorPosition(76, 2);
            SilvioAddamsProfile();
            Console.WriteLine(" _________________________________________________________________________________________________________________________________________\n" +
                             "/                                                                                                                                         \\\n" +
                             "|  Merida Lakes: Well, we are, but we will perform at the Act II event, which is in the afternoon. Plus, we are cheering on Julio\'s first |\n" +
                             "|                performance; he has been quite anxious about whether or not he will fail.                                                 |\n" +
                             "\\_________________________________________________________________________________________________________________________________________/\n");
            Console.ReadLine();
            Console.WriteLine(" _________________________________________________________________________________________________________________________________________\n" +
                             "/                                                                                                                                         \\\n" +
                             "|  Silvio Addams: I talked to him before he went backstage, and I could tell he was a nervous wreck. I comforted him by telling him it     |\n" +
                             "|                 would be alright and that he should enjoy the moment, as we had agreed.                                                  |\n" +
                             "\\_________________________________________________________________________________________________________________________________________/\n");
            Console.ReadLine();
            Console.WriteLine(" _________________________________________________________________________________________________________________________________________\n" +
                             "/                                                                                                                                         \\\n" +
                             "|  Merida Lakes: That's true; we can't help but feel proud of him. He has been working hard to improve his performance this past month.    |\n" +
                             "\\_________________________________________________________________________________________________________________________________________/\n");
            Console.ReadLine();
            Console.WriteLine(" _________________________________________________________________________________________________________________________________________\n" +
                             "/                                                                                                                                         \\\n" +
                             "|  Silvio Addams: His hard work will be paid off indeed. Every performer in the Citadel is a one-of-a-kind, as they say, right, Merida?    |\n" +
                             "\\_________________________________________________________________________________________________________________________________________/\n");
            Console.ReadLine();
            Console.WriteLine(" _________________________________________________________________________________________________________________________________________\n" +
                              "/                                                                                                                                         \\\n" +
                              "|  Merida Lakes: Haha, indeed. Oh, by the way, I'm sorry to ask, but who is…?                                                              |\n" +
                              "\\_________________________________________________________________________________________________________________________________________/\n");
            Console.ReadLine();
            Console.WriteLine(" ___________________________________________________________________________________________________________________________________________\n" +
                              "|                                                                                                                                           |\n" +
                              "|                                        Merida Lakes looked at you beamingly, followed by Silvio Addams.                                   |\n" +
                              "|___________________________________________________________________________________________________________________________________________|\n");
            Console.ReadLine();
            Console.WriteLine(" _________________________________________________________________________________________________________________________________________\n" +
                             "/                                                                                                                                         \\\n" +
                             "|  Leon Grandet: Oh, this is one of my friends from overseas, (Player Name). He helped me establish this Citadel in the first place, and we|\n" +
                             "|                were childhood friends, too.                                                                                              |\n" +
                             "\\_________________________________________________________________________________________________________________________________________/\n");
            Console.ReadLine();
            Console.WriteLine("{0}: It's an honor to meet you all.\n",playername);
            Console.ReadLine();

            Console.WriteLine(" ___________________________________________________________________________________________________________________________________________\n" +
                              "|                                                                                                                                           |\n" +
                              "|                             You shook their hands as a sign of greeting, and both replied with you as a smile.                            |\n" +
                              "|___________________________________________________________________________________________________________________________________________|\n");
            Console.ReadLine();
            Console.WriteLine(" _________________________________________________________________________________________________________________________________________\n" +
                              "/                                                                                                                                         \\\n" +
                              "|  Merida Lakes: It's a pleasure to meet you, too. I'm delighted that you can attend the performance.                                      |\n" +
                              "\\_________________________________________________________________________________________________________________________________________/\n");
            Console.ReadLine();
            Console.WriteLine(" _________________________________________________________________________________________________________________________________________\n" +
                              "/                                                                                                                                         \\\n" +
                              "|  Silvio Addams: I heard you from Leon Grandet before. He has been very excited about your arrival at the opera house.                    |\n" +
                              "\\_________________________________________________________________________________________________________________________________________/\n");
            Console.ReadLine();

            Console.WriteLine("{0}: I have also heard about you from Leon. You were one of the first aristocrats here to perform and are known as a talented musician.\n", playername);
            Console.ReadLine();

            Console.WriteLine(" _________________________________________________________________________________________________________________________________________\n" +
                              "/                                                                                                                                         \\\n" +
                              "|  Silvio Addams: I was grateful that Leon recognized my talent and allowed me to showcase it at the Opera House. After a few years, Merida|\n" +
                              "|                 joined the crew, and our performances have continued to entertain the audience.                                          |\n" +
                              "\\_________________________________________________________________________________________________________________________________________/\n");
            Console.ReadLine();

            Console.WriteLine(" _________________________________________________________________________________________________________________________________________\n" +
                              "/                                                                                                                                         \\\n" +
                              "|  Merida: We would make a great team if you asked me.                                                                                     |\n" +
                              "\\_________________________________________________________________________________________________________________________________________/\n");
            Console.ReadLine();
            Console.WriteLine(" ___________________________________________________________________________________________________________________________________________\n" +
                              "|                                                                                                                                           |\n" +
                              "|           Both laughed; they seemed to have been very close friends. Then, you suddenly notice a strange presence in the lobby.           |\n" +
                              "|___________________________________________________________________________________________________________________________________________|\n");
            Console.ReadLine();
            Console.WriteLine("{0}: Is it just me, or is that Earl Victor in the corner?\n", playername);
            Console.ReadLine();
            EarlVictorProfile();
            Console.WriteLine(" ___________________________________________________________________________________________________________________________________________\n" +
                              "|                                                                                                                                           |\n" +
                              "|  You pointed out Victor, a handsome young man standing in the lobby. Many people were glaring at him, which concerned you because he is   |\n" +
                              "|  one of the wealthiest noblemen in the country. Yet, you felt an agitated atmosphere.                                                     |\n" +
                              "|___________________________________________________________________________________________________________________________________________|\n");
            Console.ReadLine();
            Console.WriteLine(" _________________________________________________________________________________________________________________________________________\n" +
                              "/                                                                                                                                         \\\n" +
                              "|  Leon Grandet: Well, aren't you observant? Yes, I invited him to join since he is also one of the main sponsors for the Citadel Opera    |\n" +
                              "|                House, even though he had a controversy with Christine. He is still Julio's great friend.                                 |\n" +
                              "\\_________________________________________________________________________________________________________________________________________/\n");
            Console.ReadLine();
            Console.WriteLine("{0}: Christine?\n", playername);
            Console.ReadLine();
            Console.WriteLine(" _________________________________________________________________________________________________________________________________________\n" +
                              "/                                                                                                                                         \\\n" +
                              "|  Merida Lakes: Yes, Christine Williams. She is a very kind-hearted noblewoman who has significantly contributed to the city's education. |\n" +
                              "|                We have been great friends for two years, and she has also been invited to the event. Ah, right. I forgot that she        |\n" +
                              "|                mentioned that she would be late for the event because she had to take care of some official tasks at their residence.    |\n" +
                              "\\_________________________________________________________________________________________________________________________________________/\n");
            Console.ReadLine();
            Console.WriteLine(" ___________________________________________________________________________________________________________________________________________\n" +
                              "|                                                                                                                                           |\n" +
                              "|                               Suddenly, a young man was running towards the group, breathing heavily.                                     |\n" +
                              "|___________________________________________________________________________________________________________________________________________|\n");
            Console.ReadLine();
            JulioLopezProfile();
            Console.WriteLine(" _________________________________________________________________________________________________________________________________________\n" +
                              "/                                                                                                                                         \\\n" +
                              "|  ???: Have… (pant) you guys… (pant) seen Victor?                                                                                         |\n" +
                              "\\_________________________________________________________________________________________________________________________________________/\n");
            Console.ReadLine();
            Console.WriteLine(" _________________________________________________________________________________________________________________________________________\n" +
                              "/                                                                                                                                         \\\n" +
                              "|  Merida Lakes: Julio? What are you doing here? Shouldn’t you be preparing for the performance?                                           |\n" +
                              "\\_________________________________________________________________________________________________________________________________________/\n");
            Console.ReadLine();
            Console.WriteLine(" ___________________________________________________________________________________________________________________________________________\n" +
                              "|                                                                                                                                           |\n" +
                              "|  Julio was still trying to catch his breath after running. He was a distinguished young man who appeared to be a foreigner. He was well-  |\n" +
                              "|  dressed and adorned with gold accessories and unique charms with a particular scent.                                                     |\n" +
                              "|___________________________________________________________________________________________________________________________________________|\n");
            Console.ReadLine();
            Console.WriteLine(" _________________________________________________________________________________________________________________________________________\n" +
                              "/                                                                                                                                         \\\n" +
                              "|  Julio Lopez: I remembered telling Victor to bring me the imported props for the performance, so I rushed out.                           |\n" +
                              "\\_________________________________________________________________________________________________________________________________________/\n");
            Console.ReadLine();
            Console.WriteLine(" _________________________________________________________________________________________________________________________________________\n" +
                              "/                                                                                                                                         \\\n" +
                              "|  Merida Lakes: You can tell the stage manager to get the props for you.                                                                  |\n" +
                              "\\_________________________________________________________________________________________________________________________________________/\n");
            Console.ReadLine();
            Console.WriteLine(" _________________________________________________________________________________________________________________________________________\n" +
                              "/                                                                                                                                         \\\n" +
                              "|  Julio Lopez: You’re right. I’ll tell Victor to leave it in the lobby for someone to pick it up.                                         |\n" +
                              "\\_________________________________________________________________________________________________________________________________________/\n");
            Console.ReadLine();
            Console.WriteLine(" ___________________________________________________________________________________________________________________________________________\n" +
                              "|                                                                                                                                           |\n" +
                              "|                                               Julio then hurriedly went to Victor’s side.                                                 |\n" +
                              "|___________________________________________________________________________________________________________________________________________|\n");
            Console.ReadLine();
            Console.WriteLine("{0}: Is he a foreigner? He doesn’t seem to be dressed like us.\n", playername);
            Console.ReadLine();
            Console.WriteLine(" _________________________________________________________________________________________________________________________________________\n" +
                              "/                                                                                                                                         \\\n" +
                              "|  Silvio Addams: Yes, he is one of our latest overseas recruits. He is known for performing unique magic tricks that catch people's       |\n" +
                              "|                 attention.                                                                                                               |\n" +
                              "\\_________________________________________________________________________________________________________________________________________/\n");
            Console.ReadLine();
            Console.WriteLine(" _________________________________________________________________________________________________________________________________________\n" +
                              "/                                                                                                                                         \\\n" +
                              "|  Leon Grandet: He became one of the rising stars in our community. He joined a month ago and captured people's attention with his        |\n" +
                              "|                performance, which gained him many supporters.                                                                            |\n" +
                              "\\_________________________________________________________________________________________________________________________________________/\n");
            Console.ReadLine();
            Console.WriteLine(" ___________________________________________________________________________________________________________________________________________\n" +
                              "|                                                                                                                                           |\n" +
                              "|                                     Suddenly, a bell rang, indicating the performance was to start.                                       |\n" +
                              "|___________________________________________________________________________________________________________________________________________|\n");
            Console.ReadLine();
            Console.WriteLine(" _________________________________________________________________________________________________________________________________________\n" +
                              "/                                                                                                                                         \\\n" +
                              "|  Leon Grandet: Well, enough of chit-chat. We have to get there already, then, my friend. The show is about to start.                     |\n" +
                              "\\_________________________________________________________________________________________________________________________________________/\n");
            Console.ReadLine();
            Console.WriteLine(" _________________________________________________________________________________________________________________________________________\n" +
                              "/                                                                                                                                         \\\n" +
                              "|  Merida Lakes: I’ll return to the practice room to practice my skills and prepare for the performance. I wish I could watch Julio’s      |\n" +
                              "|                performance, though.                                                                                                      |\n" +
                              "\\_________________________________________________________________________________________________________________________________________/\n");
            Console.ReadLine();
            Console.WriteLine(" _________________________________________________________________________________________________________________________________________\n" +
                              "/                                                                                                                                         \\\n" +
                              "|  Julio Lopez: You’re right. I’ll tell Victor to leave it in the lobby for someone to pick it up.                                         |\n" +
                              "\\_________________________________________________________________________________________________________________________________________/\n");
            Console.ReadLine();
            Console.WriteLine(" _________________________________________________________________________________________________________________________________________\n" +
                              "/                                                                                                                                         \\\n" +
                              "|  Silvio Addams: I’ll watch Julio's performance for you, so you don’t need to worry.                                                      |\n" +
                              "\\_________________________________________________________________________________________________________________________________________/\n");
            Console.ReadLine();
            Console.WriteLine(" _________________________________________________________________________________________________________________________________________\n" +
                              "/                                                                                                                                         \\\n" +
                              "| Merida Lakes: That's reassuring, thank you.                                                                                              |\n" +
                              "\\_________________________________________________________________________________________________________________________________________/\n");
            Console.ReadLine();
            Console.WriteLine(" ___________________________________________________________________________________________________________________________________________\n" +
                              "|                                                                                                                                           |\n" +
                              "|   Both Merida and Silvio went on their way. At the same time, Leon led me to a seat inside the auditorium where I could see the entire    |\n" +
                              "|   performance. He took the vacant chair beside me. The hall quickly filled with excited chatter as everyone settled in. There were no     |\n" +
                              "|   empty seats; the auditorium was packed with people, including some familiar faces from the city's elite.                                |\n" +
                              "|___________________________________________________________________________________________________________________________________________|\n");
            Console.ReadLine();

            Console.WriteLine("Inserting Pixel art of auditorium(still in progress)");
            Console.WriteLine(" ___________________________________________________________________________________________________________________________________________\n" +
                              "|                                                                                                                                           |\n" +
                              "|   As the curtains began to rise, two musicians appeared on stage and started playing their instruments. Their music's melody was beautiful|\n" +
                              "|   and enchanting, casting a spell over the audience and making them feel engaged and relaxed. The notes danced in the air, weaving a      |\n" +
                              "|   tapestry of sound around the audience, soothing their nerves. After the performance, the musicians bowed, and the audience responded by |\n" +
                              "|   throwing roses onto the stage in appreciation, their faces lit up with joy and admiration.                                              |\n" +
                              "|___________________________________________________________________________________________________________________________________________|\n");
            Console.ReadLine();

            Console.WriteLine("Inserting Black out pixel art(Still in progress)");
            Console.WriteLine(" ___________________________________________________________________________________________________________________________________________\n" +
                              "|                                                                                                                                           |\n" +
                              "|   Then, the lights suddenly went out, and two distinct sounds resembling gunshots set off a wave of panic in the theater. Engulfed in     |\n" +
                              "|   darkness, everyone's shouts merged into a cacophony of fear and confusion. Leon Grandet, beside me, tried to restore order, but his     |\n" +
                              "|   voice was lost in the chaos. You felt the urgency to help him, so you requested to leave the auditorium. Leon agreed, cautioning you    |\n" +
                              "|   about the darkness. You navigated through the panicking crowd, your heart pounding, and headed to the exit.                             |\n" +
                              "|___________________________________________________________________________________________________________________________________________|\n");
            Console.ReadLine();
            Console.WriteLine(" ___________________________________________________________________________________________________________________________________________\n" +
                              "|                                                                                                                                           |\n" +
                              "|   While everyone is quivering in fear and panic inside the auditorium, you manage to go to the lobby. You tried to walk to the entrance   |\n"+
                              "|   hall but suddenly felt a lump on your feet. It was not an object; instead, it was something unusual yet heavy.                          |\n"+
                              "|___________________________________________________________________________________________________________________________________________|\n");
            Console.ReadLine();

            Console.WriteLine("Inserting Lobby with ded body pixel art(Still in progress)");
            Console.WriteLine(" ___________________________________________________________________________________________________________________________________________\n" +
                              "|                                                                                                                                           |\n" +
                              "|   Suddenly, the chaos came to an end. The lights turned on, revealing Earl standing in the lobby, his face a mask of shock. Following his |\n" +
                              "|   gaze, you looked down and saw a sight that would haunt you forever: a pale woman's lifeless body, lying still—a stark contrast to the   |\n"+
                              "|   previously bustling theater. You struggled to process what had just happened when, without warning, the auditorium doors opened.        |\n" +
                              "|   Everyone turned to look at you near the body, and the air was filled with screams and surprise gasps. Horror and sorrow permeated your  |\n"+
                              "|   heart and mind, not knowing what to do.                                                                                                 |\n" +
                              "|___________________________________________________________________________________________________________________________________________|\n");
            Console.ReadLine();
            Console.WriteLine(" ___________________________________________________________________________________________________________________________________________\n" +
                              "|                                                                                                                                           |\n" +
                              "|   There was a small blood pool oozing out of her heart. Merida Lakes rushed towards the body and began to cry once she saw the body lying |\n" +
                              "|   in a mess there. With Merida grieving there, you realize that the body belonged to Christine Williams, the friend of Merida she         |\n" +
                              "|   mentioned before who was going to be late attending the party. Leon Grandet finally took action and called the closest police station by|\n" +
                              "|   telephone to investigate the case.                                                                                                      |\n" +
                              "|___________________________________________________________________________________________________________________________________________|\n");
            Console.ReadLine();
            Console.WriteLine(" ___________________________________________________________________________________________________________________________________________\n" +
                              "|                                                                                                                                           |\n" +
                              "|   The detective in charge of the case called several individuals into the lobby, including you: Merida Lakes, Silvio Addams, Julio Lopez, |\n" +
                              "|   Earl Victor, and Leon Grandet. All of you were waiting for further instructions. The detectives informed you that you could not leave   |\n" +
                              "|   the theater for the interrogation of the murder of Christine Williams.                                                                  |\n" +
                              "|___________________________________________________________________________________________________________________________________________|\n");
            Console.ReadLine();
            Console.WriteLine(" ___________________________________________________________________________________________________________________________________________\n" +
                              "|                                                                                                                                           |\n" +
                              "|   The detective's assistant urgently summoned him again, prompting the detective to rush out in apparent concern, leaving everyone behind |\n" +
                              "|   in the theater. The entrance door was heavily guarded, and tension rose as suspicions grew among the group. Silvio Addams appeared      |\n"+
                              "|   worried about Merida while Merida Lakes stared intently at the table. Victor maintained an expressionless demeanor as he listened to    |\n" +
                              "|   Julio's anxious pleas, and Leon stood nearby, deep in thought.                                                                          |\n" +
                              "|___________________________________________________________________________________________________________________________________________|\n");
            Console.ReadLine();

        }
        static void Midgame()
        {
            Console.WriteLine("You realized that you couldn't go home without uncovering the killer's identity, especially since you were the prime suspect in the case. " +
                        "Determined to clear your name, you decided to take action. It was now 10:00 AM, and everyone was dispersing in the theater to carry out various tasks and " +
                        "enjoy some free time.However, you chose to investigate to prove your innocence.");
            Console.ReadLine();
            int room = 1;
            int gamephase = 1;

            while (gamephase == 1)
            {
                if (room == 1) //Code of the room variable: (1=lobby, 2=Auditorium, 3=Hallway, 4=GeneralDirectorOffice, 5=PracticeRoom, 6=Generator, 7=Backstage)
                {//This is the code for lobby
                    while (room == 1)
                    {
                        Console.WriteLine("\nYou find yourself in the dimly lit lobby, where the air is thick with intrigue and tension. The distant murmur of your colleagues " +
                            "echoes from various rooms, each one a potential source of vital information. You spot Julio and Earl in the lobby, still engaged in conversation. " +
                            "Although the police have already attended to the body, the crime scene remains rich with opportunities for investigation. The chance to uncover " +
                            "crucial clues is too significant to ignore. With determination in your heart, what will you do first?");
                        Console.WriteLine("\na) Inspect the room for clues\nb) Interrogate people\nc) Enter a different room\nd) Check Inventory");
                        Console.Write("\nAction: ");
                        string LobbyChoice = Console.ReadLine();

                        if (LobbyChoice == "a")
                        {
                            Console.WriteLine("\nIn the dimly lit lobby, the atmosphere is thick with intrigue as a table and plush sofas are carefully positioned near the entrance to the " +
                                "grand auditorium. The table is strewn with scattered files, resembling a trail of breadcrumbs that beckons you to uncover the mystery hidden within their" +
                                "pages.To the far left, nestled against the hallway, stands a haphazard collection of boxes and colorful props, all gathered near the wide staircase leading " +
                                "up to the second balcony, hinting at stories waiting to be told. Dominating the lobby's center, the crime scene is marked by an air of urgency and suspense," +
                                " a complex puzzle that requires keen eyes to piece together the clues.");
                            while (LobbyChoice == "a")
                            {
                                Console.WriteLine("\nWhere will your curiosity lead you?");
                                Console.WriteLine("a) Table and Plush Sofas\nb) Collection of Boxes and Props\nc) Inspect the Crime Scene\nd) Back");
                                Console.Write("\nAction:");
                                string LobbyRoom = Console.ReadLine(); //if its <location>Room variable, it indicates the player is exploring a specific room/spot inside the location

                                if (LobbyRoom == "a")
                                {
                                    //brushes hehe Gray = ░░ white = ██
                                    Console.WriteLine("╔══════════════════════════════════════════════════════════════════════╗\n" +
                                                      "║                                  ██        ░░░░░░██░░░░░░██░░██      ║\n" +
                                                      "║    ██████                        ██          ░░░░░░████░░██░░██      ║\n" +
                                                      "║      ████░░                      ██              ░░░░██░░░░░░██      ║\n" +
                                                      "║      ░░░░░░                  ██  ██                ░░░░░░░░░░██  ██  ║\n" +
                                                      "║    ░░░░                      ████  ██████████████████████████  ████  ║\n" +
                                                      "║  ░░                              ██                          ██      ║\n" +
                                                      "║████                              ████                      ████      ║\n" +
                                                      "║██                                                                    ║\n" +
                                                      "║██      ████                                                          ║\n" +
                                                      "║██    ░░████      ████████████████  ████████████████                  ║\n" +
                                                      "║██░░░░░░░░██    ██      ░░░░░░░░░░██░░░░░░░░░░░░░░░░██                ║\n" +
                                                      "║████    ░░██    ██      ██░░░░░░░░██    ░░░░██░░░░░░██                ║\n" +
                                                      "║░░              ██        ██░░░░░░██      ██░░░░░░░░██                ║\n" +
                                                      "║░░              ██          ░░░░░░██          ░░░░░░██                ║\n" +
                                                      "║░░              ██          ░░░░░░██            ░░░░██                ║\n" +
                                                      "║░░              ██            ░░░░██              ░░██                ║\n" +
                                                      "║████        ██████████████████████████████████████████████            ║\n" +
                                                      "║████████  ██░░░░██                ░░░░░░░░░░░░░░░░░░██░░░░██          ║\n" +
                                                      "║░░░░████  ██  ░░██                      ░░░░░░░░░░░░██  ░░██          ║\n" +
                                                      "║░░░░██    ██    ██████████████████████████████████████  ░░██          ║\n" +
                                                      "║░░████    ██    ██                          ░░░░░░░░██    ██          ║\n" +
                                                      "║░░██      ██    ██                                ░░██    ██          ║\n" +
                                                      "║░░██      ██████████████████████████████████████████████████          ║\n" +
                                                      "║  ████                    ██████████████████                          ║\n" +
                                                      "║  ████░░██░░██░░  ████████    ░░░░░░░░░░░░░░████████  ██░░██░░██░░██  ║\n" +
                                                      "║      ██░░  ░░  ██              ░░░░░░░░░░░░░░░░░░░░██░░  ░░  ░░      ║\n" +
                                                      "║      ████░░  ██                      ░░░░░░░░░░░░░░░░██░░  ░░██░░██  ║\n" +
                                                      "║    ████░░  ░░██                            ░░░░░░░░░░██  ░░  ░░      ║\n" +
                                                      "║██████░░██░░  ░░██                            ░░░░░░██░░░░  ░░██░░██  ║\n" +
                                                      "║        ░░  ░░  ░░██████████              ██████████░░░░  ░░  ░░      ║\n" +
                                                      "║    ██░░██░░  ░░  ░░░░░░░░░░██████████████░░░░░░░░░░░░░░░░  ░░██░░██  ║\n" +
                                                      "║        ░░  ░░  ░░  ░░    ████          ████  ░░  ░░  ░░  ░░  ░░      ║\n" +
                                                      "╚══════════════════════════════════════════════════════════════════════╝");

                                    Console.SetCursorPosition(75, 1);
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐");
                                    Console.SetCursorPosition(75, 2);
                                    Console.WriteLine("|As you approached the table, your eyes were drawn to the plush sofas  |");
                                    Console.SetCursorPosition(75, 3);
                                    Console.WriteLine("|where Merida and Silvio sat. Unexpectedly, a file lay abandoned on the|");
                                    Console.SetCursorPosition(75, 4);
                                    Console.WriteLine("|table, piquing your curiosity. You couldn't resist picking it up.     |");
                                    Console.SetCursorPosition(75, 5);
                                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────┘");
                                    Console.SetCursorPosition(75, 6);
                                    Console.ReadLine();

                                    Console.SetCursorPosition(75, 7);
                                    Console.WriteLine("                             ___________________________________________");
                                    Console.SetCursorPosition(75, 8);
                                    Console.WriteLine("                            | A detective file?                         |");
                                    Console.SetCursorPosition(75, 9);
                                    Console.WriteLine("                             ----------------------------------------\\/-");
                                    Console.SetCursorPosition(75, 10);
                                    Console.ReadLine();

                                    Console.SetCursorPosition(75, 11);
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐");
                                    Console.SetCursorPosition(75, 12);
                                    Console.WriteLine("|You flipped open the cover to reveal a draft report meticulously      |");
                                    Console.SetCursorPosition(75, 13);
                                    Console.WriteLine("|detailing the investigation into Christine's mysterious death. Though |");
                                    Console.SetCursorPosition(75, 14);
                                    Console.WriteLine("|still a work in progress, the report brimmed with the detective's     |");
                                    Console.SetCursorPosition(75, 15);
                                    Console.WriteLine("|insights and observations that promised to be a valuable reference in |");
                                    Console.SetCursorPosition(75, 16);
                                    Console.WriteLine("|the future.                                                           |");
                                    Console.SetCursorPosition(75, 17);
                                    Console.WriteLine("└──────────────────────────────────────────────────────────────────────┘");
                                    Console.SetCursorPosition(75, 18);
                                    Console.ReadLine();

                                    Console.SetCursorPosition(75, 19);
                                    Console.WriteLine("           You found \"Detective's File Case Report.\"");
                                    Console.SetCursorPosition(75, 20);
                                    Console.ReadLine();
                                    Console.SetCursorPosition(75, 34);
                                }
                                else if (LobbyRoom == "b")
                                {
                                    Console.WriteLine("Player: What are these?");
                                    Console.WriteLine("Your curiosity piqued, and you approached the collection of peculiarly ordered boxes. Each one was stamped on the corner, a detail that " +
                                        "only added to the mystery.");
                                    Console.WriteLine("Player:  Imported from Portugal.");
                                    Console.WriteLine("As you examined the boxes, you noticed one was slightly ajar. Inside were a deck of cards, a handful of handkerchiefs tied in a peculiar " +
                                        "manner, metal hoops, and colorful cups neatly arranged. Above the chests, a cage of doves added to the enigma. But your keen eye caught a metal glint hidden " +
                                        "by a potted plant. You reached for it and discovered a small, unnoticed object.");
                                    Console.WriteLine("Player: Wait, isn't this a bullet of some kind?");
                                    Console.WriteLine("Understanding this, you took the bullet as part of your evidence. You kept the bullet as proof.");
                                    Console.WriteLine("You found a \"Bullet.\"");
                                }
                                else if (LobbyRoom == "c")
                                {
                                    Console.WriteLine("You approached the crime scene again, where Christine lay lifeless before you, trying to organize your thoughts. You noticed a significant " +
                                        "amount of blood at the scene, but among it, you spotted a white piece of paper stained with red. Despite the gruesome sight, you carefully picked up the " +
                                        "paper. Upon closer inspection, it appeared to be a stamped letter.");
                                    Console.WriteLine("Player: This letter seems to be of great significance, as Christine must have kept it personally.");
                                    Console.WriteLine("The front of the letter bore a seal with a hawk crest logo, a majestic bird with its wings spread wide, and on the back, there was a handwritten " +
                                        "text addressed to the recipient: \"To Christine.\"");
                                    Console.WriteLine("You carefully tucked the letter into your inventory, fully aware that it might contain crucial information.");
                                    Console.WriteLine("You have obtained a \"Blood-stained letter.\"");
                                }
                                else if (LobbyRoom == "d")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\nKindly input either of the choices");
                                }
                            }
                        }
                        else if (LobbyChoice == "b") //I forgot to add Earl and Victor in the SCENE T-T so I added a new choice so that the player can inquire them
                        {
                            Console.WriteLine("Interrogating People");
                        }
                        else if (LobbyChoice == "c") //enables players to switch room . Name of Variable used in this code is <Name of the current location>SwitchRoom
                        {
                            while (LobbyChoice == "c")
                            {
                                Console.WriteLine("\nWhere would you like to go?");
                                Console.WriteLine("a) Lobby\nb) Auditorium\nc) Hallway");
                                Console.Write("\nAction: ");
                                string LobbySwitchRoom = Console.ReadLine();
                                if (LobbySwitchRoom == "a")
                                {
                                    Console.WriteLine("\nStaying at Lobby...");
                                    room = 1;
                                    break;

                                }
                                else if (LobbySwitchRoom == "b")
                                {
                                    Console.WriteLine("\nHeading to Auditorium...");
                                    room = 2;
                                    break;
                                }
                                else if (LobbySwitchRoom == "c")
                                {
                                    Console.WriteLine("\nHeading to Hallway...");
                                    room = 3;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\nKindly input the letter that indicates the choices.");
                                }
                            }
                        }
                        else if (LobbyChoice == "d")
                        {
                            Console.WriteLine("Here is your inventory");
                        }
                        else
                        {
                            Console.WriteLine("Kindly input the letter that indicates the choices above.");
                        }
                    }
                }
                else if (room == 2)
                {//this is the code for auditorium
                    while (room == 2)
                    {
                        Console.WriteLine("\nThe auditorium stretches out before you, an expansive space filled with silence, stripped of the vibrant laughter and spirited performances that once animated " +
                            "its walls. As you tread softly along the velvet carpet lining the aisle, your gaze sweeps over the scattered remnants of a past event—forgotten programs, half-empty " +
                            "cups, and crumpled ticket stubs strewn carelessly across the floor, echoes of the audience that once filled these seats with life. At the front of the auditorium, basking in " +
                            "the soft glow of the overhead lights, you notice two figures standing near the stage. What would you like to do?");
                        Console.WriteLine("\na) Inquire People\nb) Enter a different room\nc) Check Inventory");
                        Console.Write("\nAction: ");
                        string AuditoriumChoice = Console.ReadLine();
                        if (AuditoriumChoice == "a")
                        {
                            Console.WriteLine("\nInquiring people");
                        }
                        else if (AuditoriumChoice == "b")
                        {
                            while (AuditoriumChoice == "b")
                            {
                                Console.WriteLine("\nWhere would you like to go?");
                                Console.WriteLine("a) Auditorium\nb) Lobby");
                                Console.Write("\nAction: ");
                                string AuditoriumSwitchRoom = Console.ReadLine();

                                if (AuditoriumSwitchRoom == "a")
                                {
                                    Console.WriteLine("\nStaying at Auditorium...");
                                    break;
                                }
                                else if (AuditoriumSwitchRoom == "b")
                                {
                                    Console.WriteLine("\nHeading to Lobby...");
                                    room = 1;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\nKindly input only the available choices.");
                                }
                            }
                        }
                        else if (AuditoriumChoice == "c")
                        {
                            Console.WriteLine("Here is your inventory");
                        }
                        else
                        {
                            Console.WriteLine("Kindly input the letter that indicates the choices above.");
                        }
                    }
                }
                else if (room == 3)
                {//code for hallway
                    while (room == 3)
                    {
                        Console.WriteLine("\nYou find yourself in a long corridor adorned with various wall paintings. The brown flooring and unique textiles enhance the " +
                            "hallway's ambiance. Several doors lead to other rooms, each with its distinct design. The left door exudes an air of elegance, featuring an " +
                            "exquisite display and a sign that reads \"General Director's Office.\" Nearby, you can hear the sound of a piano playing from another room. At the " +
                            "far left end of the hallway is a heavily guarded metallic door, while a plain wooden door stands directly across from it. What would you like to do?");
                        Console.WriteLine("\na) Inspect the room for clues\nb) Enter a different room\nc) Check Inventory");
                        Console.Write("\nAction: ");
                        string HallwayChoice = Console.ReadLine();

                        if (HallwayChoice == "a")
                        {
                            while (HallwayChoice == "a") //still in progress.
                            {
                                Console.WriteLine("You continued searching for clues as you took in the hallway's disarray. Exquisite paintings adorned the right wall, their ornate frames showcasing " +
                                    "various scenes. The green carpet beneath you looked messy and crinkled, evidence of heavy foot traffic. Small boxes of props were scattered in the corner; some were " +
                                    "left open and revealing intriguing items. With so much to explore,");
                                Console.WriteLine("Where would you like to begin?");
                                Console.WriteLine("\na) Exquisite Paintings\nb) Look into the Carpets\nc) Explore the disarrayed boxes\nd) Return Back");
                                Console.Write("\nAction: ");
                                string HallwayRoom = Console.ReadLine();

                                if (HallwayRoom == "a")
                                {
                                    Console.WriteLine("You decided to look at the paintings, which are a history of the Citadel Opera House and Three paintings were involved.");
                                    Console.WriteLine("Player: December 20, 1903... This painting must be age-old.");
                                    Console.WriteLine("The first contained three prominent families, and below the corner of the painting, it said the letters G, A, and V.");
                                    Console.WriteLine("Player: I wondered what it means. Does it involve the people in the painting?");
                                    Console.WriteLine("The second painting contains the first crew performers, and you recognize Leon in the middle of the painting. He was surrounded by people who " +
                                        "were familiar to you. There was Merida together, who seemed to be with Christine, Silvio was next to Leon, and Earl was on the far corner. Nobles also " +
                                        "surrounded them and dressed elegantly.");
                                    Console.WriteLine("The third painting is recent and involves all the performers of the past month. Merida and Silvio were playing their instruments together with " +
                                        "other musicians. There were also acrobats, clowns, and an animal trainer in the middle, which seemed to be the newest addition to the performances; however, " +
                                        "you recognized a young individual's face. It seemed to be Julio, and he was holding out what appeared to be a deck of cards.");
                                    Console.WriteLine("Player: If I remember correctly, the Citadel's first performers were only musicians. However, as he mentioned in our past discussions, Leon " +
                                        "expanded and explored new talents overseas.");
                                    Console.WriteLine("Player: If I remember correctly, the Citadel's first performers were only musicians. However, as he mentioned in our past discussions, Leon " +
                                        "expanded and explored new talents overseas.");
                                    Console.WriteLine("You found \"Historical Paintings.\"");
                                }
                                else if (HallwayRoom == "b")
                                {
                                    Console.WriteLine("Look into the carpets Dialogue");
                                }
                                else if (HallwayRoom == "c")
                                {
                                    Console.WriteLine("Explore the disarrayed boxes Dialogue");
                                }
                                else if (HallwayRoom == "d")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\nKindly input the letters mentioned above.");
                                }
                            }
                        }
                        else if (HallwayChoice == "b")
                        {
                            while (HallwayChoice == "b")
                            {
                                Console.WriteLine("\nWhere would you like to go?");
                                Console.WriteLine("a) Hallway\nb) General Director Office\nc) Practice Room\nd) Generator\ne) Backstage\nf) Lobby");
                                Console.Write("\nAction: ");
                                string HallwaySwitchRoom = Console.ReadLine();

                                if (HallwaySwitchRoom == "a")
                                {
                                    Console.WriteLine("\nStaying at Hallway...");
                                    break;
                                }
                                else if (HallwaySwitchRoom == "b")
                                {
                                    Console.WriteLine("\nHeading to General Director Office...");
                                    room = 4;
                                    break;
                                }
                                else if (HallwaySwitchRoom == "c")
                                {
                                    Console.WriteLine("\nHeading to Practice Room...");
                                    room = 5;
                                    break;
                                }
                                else if (HallwaySwitchRoom == "d")
                                {
                                    Console.WriteLine("\nHeading to Generator...");
                                    room = 6;
                                    break;
                                }
                                else if (HallwaySwitchRoom == "e")
                                {
                                    Console.WriteLine("\nHeading to Backstage...");
                                    room = 7;
                                    break;
                                }
                                else if (HallwaySwitchRoom == "f")
                                {
                                    Console.WriteLine("\nHeading to Lobby...");
                                    room = 1;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\nKindly input either of the choices");
                                }
                            }
                        }
                        else if (HallwayChoice == "c")
                        {
                            Console.WriteLine("Here is your inventory");
                        }
                        else
                        {
                            Console.WriteLine("Kindly input either of the choices.");
                        }
                    }
                }
                else if (room == 4)
                {//code for general director office
                    while (room == 4)
                    {
                        Console.WriteLine("A sense of awe washed over you as you stepped through the grand door of an exquisitely arranged office. To your right stood a " +
                            "towering bookshelf, a testament to knowledge and elegance. In the heart of the room, your friend Leon Grandet, a figure of undeniable authority, " +
                            "was seated at his desk, exuding grace. Behind him, a vast window adorned with regal dark blue and gold accents framed a breathtaking view of the " +
                            "city. He was engrossed in writing, his focus unwavering. What would you like to do while you’re here?");
                        Console.WriteLine("\na) Inspect the room for clues\nb) Inquire People\nc) Enter a different room\nd) Check Inventory");
                        Console.Write("\nAction: ");
                        string GeneralDirectorOfficeChoice = Console.ReadLine();

                        if (GeneralDirectorOfficeChoice == "a")
                        {
                            while (GeneralDirectorOfficeChoice == "a")
                            {
                                Console.WriteLine("\nAfter seeking Leon's permission to investigate the room, he allowed you to explore leisurely. As you stepped further in, you were immediately drawn " +
                                    "to a peculiar chest resting atop his desk, its ornate carvings and unique design hinting at secrets. Surrounding you were several keys meticulously displayed on the " +
                                    "walls, each seemingly carrying its own story. A towering bookshelf stood to your right, its shelves lined with books and documents that promised a wealth of valuable" +
                                    " knowledge.");
                                Console.WriteLine("\nWhere would you like to delve into?");
                                Console.WriteLine("\na) The office desk of Leon\nb) The keys hanging on the wall\nc) Large Bookshelves\nd) Return Back");
                                Console.Write("\nAction: ");
                                string GeneralDirectorOfficeRoom = Console.ReadLine();

                                if (GeneralDirectorOfficeRoom == "a")
                                {
                                    Console.WriteLine("\nDesk office dialogue");
                                }
                                else if (GeneralDirectorOfficeRoom == "b")
                                {
                                    Console.WriteLine("\nThe key hanging on the wall.");
                                }
                                else if (GeneralDirectorOfficeRoom == "c")
                                {
                                    Console.WriteLine("\nLarge Bookshelves");
                                }
                                else if (GeneralDirectorOfficeRoom == "d")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Kindly input the letters mentioned above.");
                                }
                            }
                        }
                        else if (GeneralDirectorOfficeChoice == "b")
                        {
                            Console.WriteLine("\nInquiring People");
                        }
                        else if (GeneralDirectorOfficeChoice == "c")
                        {
                            while (GeneralDirectorOfficeChoice == "c")
                            {
                                Console.WriteLine("\nWhere would you like to go?");
                                Console.WriteLine("a) General Director Office\nb) Hallway");
                                Console.Write("\nAction: ");
                                string GeneralDirectorOfficeSwitchRoom = Console.ReadLine();

                                if (GeneralDirectorOfficeSwitchRoom == "a")
                                {
                                    Console.WriteLine("\nStaying at General Director Office...");
                                    break;
                                }
                                else if (GeneralDirectorOfficeSwitchRoom == "b")
                                {
                                    Console.WriteLine("\nHeading to Hallway...");
                                    room = 3;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\nKindly input either of the choices mentioned above.");
                                }
                            }
                        }
                        else if (GeneralDirectorOfficeChoice == "d")
                        {
                            Console.WriteLine("Here is your inventory");
                        }
                        else
                        {
                            Console.WriteLine("Kindly input either of the choices");
                        }
                    }
                }
                else if (room == 5)
                {//code for Practice Room
                    while (room == 5)
                    {
                        Console.WriteLine("As you entered the room, a sweet melody wrapped around you like a warm embrace. Your gaze immediately landed on Merida, her " +
                            "fingers dancing gracefully across the grand piano, while Silvio stood beside her, his violin adding a rich layer to the enchanting symphony. " +
                            "The elegant room, with tall windows framed by rich red curtains, exuded warmth. Flickering lights glow softly, illuminating various instruments " +
                            "eager to join the melody. Shelves filled with sheet music whispered tales of past performances, inviting you to immerse yourself in this " +
                            "delightful world of sound and creativity. What would you like to do first?");
                        Console.WriteLine("\na) Inspect the room for clues\nb) Inquire People\nc) Enter a different room\nd) Check Inventory");
                        Console.Write("\nAction: ");
                        string PracticeRoomChoice = Console.ReadLine();

                        if (PracticeRoomChoice == "a")
                        {
                            while (PracticeRoomChoice == "a")
                            {
                                Console.WriteLine("\nStepping into the practice room, your gaze was drawn to the neatly organized shelves filled with books and labeled folders, each promising musical " +
                                    "insights. Beside them stood a striking black grand piano, its glossy surface gleaming in the warm light, inviting you to play. Conversely, a cozy resting area with " +
                                    "white armchairs beckoned you to relax. The vibrant atmosphere sparked your curiosity.");
                                Console.WriteLine("\nWhere would you like to begin your exploration?");
                                Console.WriteLine("\na) Stacked Shelves\nb) Grand Piano\nc) Resting Area\nd) Return Back");
                                Console.Write("\nAction: ");
                                string PracticeRoomRoom = Console.ReadLine();

                                if (PracticeRoomRoom == "a")
                                {
                                    Console.WriteLine("Stacked Shelves Dialogue");
                                }
                                else if (PracticeRoomRoom == "b")
                                {
                                    Console.WriteLine("Grand Piano Dialogue");
                                }
                                else if (PracticeRoomRoom == "c")
                                {
                                    Console.WriteLine("Resting Area Dialogue");
                                }
                                else if (PracticeRoomRoom == "d")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Kindly input the letters that indicates the choices above.");
                                }
                            }
                        }
                        else if (PracticeRoomChoice == "b")
                        {
                            Console.WriteLine("Inquiring People");
                        }
                        else if (PracticeRoomChoice == "c")
                        {
                            while (PracticeRoomChoice == "c")
                            {
                                Console.WriteLine("\nWhere would you like to go?");
                                Console.WriteLine("a) Practice Room\nb) Hallway");
                                Console.Write("\nAction: ");
                                string PracticeRoomSwitchRoom = Console.ReadLine();

                                if (PracticeRoomSwitchRoom == "a")
                                {
                                    Console.WriteLine("\nStaying at Practice Room...");
                                    break;
                                }
                                else if (PracticeRoomSwitchRoom == "b")
                                {
                                    Console.WriteLine("\nHeading at Hallway...");
                                    room = 3;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\nKindly input either of the choices.");
                                }
                            }
                        }
                        else if (PracticeRoomChoice == "d")
                        {
                            Console.WriteLine("Here is your inventory");
                        }
                        else
                        {
                            Console.WriteLine("Kindly choose either of the choices above.");
                        }

                    }
                }
                else if (room == 6)
                {//code for Generator
                    while (room == 6)
                    {
                        Console.WriteLine("\nA massive electrical generator stands in the center of the scene, its metallic surface gleaming under the small fading ceiling " +
                            "light. The generator is housed in a large, rusted steel enclosure, with thick cables snaking out and disappearing into nearby control panels. " +
                            "Its steady, mechanical hum vibrates through the air as it powers up, and the air is filled with a pungent smell of oil and metal, enveloping the" +
                            " scene in an unmistakable industrial atmosphere. What would you like to do?");
                        Console.WriteLine("\na) Inspect the room for clues\nb) Enter a different room\nc) Check Inventory");
                        Console.Write("\nAction: ");
                        string GeneratorChoice = Console.ReadLine();
                        if (GeneratorChoice == "a")
                        {
                            Console.WriteLine("Inspecting the room for clues");
                        }
                        else if (GeneratorChoice == "b")
                        {
                            while (GeneratorChoice == "b")
                            {
                                Console.WriteLine("\nWhere would you like to go?");
                                Console.WriteLine("a) Generator\nb) Hallway");
                                Console.Write("\nAction: ");
                                string GeneratorSwitchRoom = Console.ReadLine();

                                if (GeneratorSwitchRoom == "a")
                                {
                                    Console.WriteLine("\nStaying at Generator...");
                                    break;
                                }
                                else if (GeneratorSwitchRoom == "b")
                                {
                                    Console.WriteLine("\nHeading to Hallway...");
                                    room = 3;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\nKindly input the choices mentioned above");
                                }
                            }
                        }
                    }
                }
                else if (room == 7)
                {//Code for Backstage
                    while (room == 7)
                    {
                        Console.WriteLine("\nIn the half-dark backstage, a unique atmosphere of anticipation and tension fills the air. The faint glow of overhead lights cast " +
                            "long, distorted shadows across the worn wooden floor. The heavy curtains accompany the room's quietness. Stagehands tiptoe; their footsteps are " +
                            "barely audible as they rush to adjust props and set pieces. The half-lit space is cluttered with scattered costumes—some hanging loosely on racks, " +
                            "others tossed carelessly on the ground, their fabric glowing faintly in the dim light. This is a place like no other, with its own secrets and " +
                            "stories waiting to be discovered. What would you like to do?");
                        Console.WriteLine("\na) Inspect the room for clues\nb) Enter a different room\nc) Check Inventory");
                        Console.Write("\nAction: ");
                        string BackstageChoice = Console.ReadLine();

                        if (BackstageChoice == "a")
                        {
                            Console.WriteLine("Inspecting the room for clues");
                        }
                        else if (BackstageChoice == "b")
                        {
                            while (BackstageChoice == "b")
                            {
                                Console.WriteLine("\nWhere would you like to go?");
                                Console.WriteLine("a) Backstage\nb) Hallway\nc) Secret Passageway");
                                Console.Write("\nAction: ");
                                string BackstageSwitchRoom = Console.ReadLine();

                                if (BackstageSwitchRoom == "a")
                                {
                                    Console.WriteLine("\nStaying at Backstage...");
                                    break;
                                }
                                else if (BackstageSwitchRoom == "b")
                                {
                                    Console.WriteLine("\nHeading to Hallway...");
                                    room = 3;
                                    break;
                                }
                                else if (BackstageSwitchRoom == "c") //unlocks when the player finds another key and some pliers. This will also trigger a limited dialogue
                                {
                                    Console.WriteLine("\nGoing to a passageway...");
                                    room = 2;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\nKindly input the choices mentioned above");
                                }
                            }
                        }
                        else if (BackstageChoice == "c")
                        {
                            Console.WriteLine("Here is your inventory");
                        }
                        else
                        {
                            Console.WriteLine("\nKindly input the choics mentioned.");
                        }
                    }
                }
            }
        }
        static void LeonGrandetProfile()
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════╗\n" +
                   "║                  ██                                ██                ║\n" +
                   "║                  ████████████████████████████████████                ║\n" +
                   "║                  ██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██                ║\n" +
                   "║          ████████████████████████████████████████████████████        ║\n" +
                   "║                ████                ██████          ████              ║\n" +
                   "║              ██        ██████    ██░░░░░░████          ██            ║\n" +
                   "║              ██      ██░░░░░░██  ██░░░░░░░░░░██        ██            ║\n" +
                   "║              ██        ██░░░░░░██░░░░░░░░░░░░░░██  ██  ██            ║\n" +
                   "║                ████████░░░░░░░░░░░░░░░░░░░░████░░██████              ║\n" +
                   "║              ██░░██░░░░░░░░░░░░░░░░░░░░░░██░░░░██░░██░░██            ║\n" +
                   "║              ██░░██░░░░░░░░░░░░░░░░░░░░░░██░░░░██░░██░░██            ║\n" +
                   "║              ██░░██░░░░░░░░░░░░░░░░░░░░░░░░████░░░░██░░██            ║\n" +
                   "║                ████░░░░░░░░░░░░░░░░░░░░░░░░░░░░██░░████              ║\n" +
                   "║                  ███░░░░░░░░░░░░░░░░░░░░░░░░░░░░░████                ║\n" +
                   "║                     ██░░░░░░░░░░░░░░░░░░░░░░░░░░░██                  ║\n" +
                   "║                     ██░░░░░░░░░░░░░░░░░░░░░░░░░░░██                  ║\n" +
                   "║                       ██░░░░░              ░░░░░██                   ║\n" +
                   "║                        ██░░       ░░░░       ░██                     ║\n" +
                   "║                          ██░░░   ░░░░░░    ░░██                      ║\n" +
                   "║                          ████░░░░░░░░░░░░░░████                      ║\n" +
                   "║                          ██░░██░░░░░░░░░░██░░██                      ║\n" +
                   "║                          ██░░██████████████░░██                      ║\n" +
                   "║                          ██░░░░░░░░░░░░░░░░░░██                      ║\n" +
                   "║                          ██░░░░░░░░░░░░░░░░░░██                      ║\n" +
                   "║                          ██░░░░░░░░░░░░░░░░░░██                      ║\n" +
                   "║                          ██░░░░░░░░░░░░░░░░░░██                      ║\n" +
                   "║                          ██████████████████████                      ║\n" +
                   "║                          ██████████████████████                      ║\n" +
                   "║  ████████████████████████████    ██████    ████████████████████████  ║\n" +
                   "║██                      ████████          ████████                  ██║\n" +
                   "╚══════════════════════════════════════════════════════════════════════╝");

        }
        static void EarlVictorProfile()
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════╗\n" +
                  "║                                                                      ║\n" +
                  "║                ██  ██  ████    ██████  ███████    █████              ║\n" +
                  "║                ████░░██░░░░████░░░░░░██░░░░░██████░░░██              ║\n" +
                  "║                ██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██              ║\n" +
                  "║                ██░░░░░░████████████████████████░░░░░░██              ║\n" +
                  "║                ██░░░░██░░░░░░░░░░░░░░░░░░░░░░░░██░░░░██              ║\n" +
                  "║                ██░░██░░░░░░░░░░░░░░░░░░░░░░░░░░░░██░░██              ║\n" +
                  "║                ██░░██░░░░░░░░░░░░░░░░░░░░░░░░░░░░██░░██              ║\n" +
                  "║                ██████░░░░░░░░░░░░░░░░░░░░░░░░░░░░██████              ║\n" +
                  "║              ██░░██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██░░██            ║\n" +
                  "║              ██░░██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██░░██            ║\n" +
                  "║              ██░░██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██░░██            ║\n" +
                  "║                ████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░████              ║\n" +
                  "║                  ███░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██                ║\n" +
                  "║                     ██░░░░░░░░░░░░░░░░░░░░░░░░░░░██                  ║\n" +
                  "║                     ██░░░░░░░░░░░░░░░░░░░░░░░░░░░██                  ║\n" +
                  "║                       ██░░░░░░░░░░░░░░░░░░░░░░░██                    ║\n" +
                  "║                        ██░░░░░░░░░░░░░░░░░░░░░██                     ║\n" +
                  "║                          ██░░░░░░░░░░░░░░░░░░██                      ║\n" +
                  "║                          ████░░░░░░░░░░░░░░████                      ║\n" +
                  "║                          ██░░██░░░░░░░░░░██░░██                      ║\n" +
                  "║                          ██░░██████████████░░██                      ║\n" +
                  "║                          ██░░░░░░░░░░░░░░░░░░██                      ║\n" +
                  "║                          ██░░░░░░░░░░░░░░░░░░██                      ║\n" +
                  "║                          ██████████░░██████████                      ║\n" +
                  "║                          ██        ██        ██                      ║\n" +
                  "║                          ██        ██        ██                      ║\n" +
                  "║                          ██        ██        ██                      ║\n" +
                  "║████████████████████████████        ██        ████████████████████████║\n" +
                  "║                                    ██                                ║\n" +
                  "╚══════════════════════════════════════════════════════════════════════╝");
        }
        static void JulioLopezProfile()
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════╗\n" +
                  "║                          ███████████████████████                     ║\n" +
                  "║                    █████████████████████████████████████             ║\n" +
                  "║                ██████████████████████████████  ███████████           ║\n" +
                  "║              ██████  ████    ████████████████       ███████          ║\n" +
                  "║            ████████            ██                      ██████        ║\n" +
                  "║          ██████████                      ██              ███████     ║\n" +
                  "║          ██████                ██░░██  ██░░██             █████      ║\n" +
                  "║          ████          ██    ██░░░░░░██░░░░░░██  ██        ████      ║\n" +
                  "║          ██        ████░░████░░░░░░██░░░░░░░░░░████          ██      ║\n" +
                  "║            ██    ████░░░░░░░░░░░░░░░░░░░░░░░░░░░░████      ██        ║\n" +
                  "║              ██  ██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██  ████          ║\n" +
                  "║            ██    ██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██    ██          ║\n" +
                  "║          ██████  ██░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██      ██        ║\n" +
                  "║            ██    ███░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██    ██          ║\n" +
                  "║              ██     ██░░░░░░░░░░░░░░░░░░░░░░░░░░░██    ██            ║\n" +
                  "║              ██     ███░░░░░░░░░░░░░░░░░░░░░░░░░░██      ██          ║\n" +
                  "║                ████    ██░░░░░░░░░░░░░░░░░░░░░░██  ██████            ║\n" +
                  "║                    ██████░░░░░░░░░░░░░░░░░░░░░░██████                ║\n" +
                  "║                          ████░░░░░░░░░░░░░░████  ██                  ║\n" +
                  "║                            ████░░░░░░░░░░████                        ║\n" +
                  "║                            ██░░██████████░░██                        ║\n" +
                  "║                            ██░░░░░░░░░░░░░░██                        ║\n" +
                  "║                            ██░░░░░░░░░░░░░░██                        ║\n" +
                  "║                            ██░░░░░░░░░░░░░░██                        ║\n" +
                  "║                            ██░░░░░░░░░░░░░░██                        ║\n" +
                  "║                            ██░░░░░░░░░░░░░░██                        ║\n" +
                  "║                          ██████░░░░░░░░░░██████                      ║\n" +
                  "║                        ████  ████░░░░░░████  ████                    ║\n" +
                  "║                      ████  ██    ██░░██    ██  ████                  ║\n" +
                  "║    ██████████████████      ██      ██      ██      ██████████████    ║\n" +
                  "╚══════════════════════════════════════════════════════════════════════╝");

        }
        static void MeridaLakesProfile()
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════╗\n" +
                  "║            ██████                                                    ║\n" +
                  "║          ██      ████                                                ║\n" +
                  "║        ██            ████████████████████████                        ║\n" +
                  "║      ██            ████                      ████                    ║\n" +
                  "║      ██          ██                              ██                  ║\n" +
                  "║        ██        ██                                ████              ║\n" +
                  "║          ██    ██        ████                        ██              ║\n" +
                  "║            ████        ██░░░░██                        ████          ║\n" +
                  "║            ██     ██   ██░░░░░░███████████                 ██        ║\n" +
                  "║           ██    ████   ██░░░░░░░░░░░░░░░░░██        ████   ██        ║\n" +
                  "║           ██  ██░░█████░░░░░░░░░░░░░░░░░░░░████     ██░░██ ██        ║\n" +
                  "║           ██  ██░░██░░░░░░░░░░░░░░░░░░░░░░░░░░░░██  ██░░██ ██        ║\n" +
                  "║           ██  ██░░██░░░░░░░░░░░░░░░░░░░░░░░░░░░░██  ██░░██ ██        ║\n" +
                  "║             ██  ████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██████  ██         ║\n" +
                  "║               ██████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░███████          ║\n" +
                  "║               ██████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░███████          ║\n" +
                  "║               ████████░░░░░░░░░░░░░░░░░░░░░░░░░░░░██ ██████          ║\n" +
                  "║                 ████ ██░░░░░░░░░░░░░░░░░░░░░░░░░░██  ████            ║\n" +
                  "║                        ██░░░░░░░░░░░░░░░░░░░░░░██                    ║\n" +
                  "║                          ██░░░░░░░░░░░░░░░░░░██                      ║\n" +
                  "║                            ████░░░░░░░░░░████                        ║\n" +
                  "║                              ██████████████                          ║\n" +
                  "║                              ██░░░░░░░░░░██                          ║\n" +
                  "║                              ██░░░░░░░░░░██                          ║\n" +
                  "║                              ██░░░░░░░░░░██                          ║\n" +
                  "║                              ██░░░░░░░░░░██                          ║\n" +
                  "║                              ██░░░░░░░░░░██                          ║\n" +
                  "║                            ████░░░░░░░░░░████                        ║\n" +
                  "║                      ██████░░░░░░░░░░░░░░░░░░██████                  ║\n" +
                  "║        ██████████████░░░░██░░██░░██░░██░░██░░██░░░░██████████████    ║\n" +
                  "╚══════════════════════════════════════════════════════════════════════╝");

        }
        static void SilvioAddamsProfile()
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════╗\n" +
                  "║                                                                      ║\n" +
                  "║                           ██████      ██████                         ║\n" +
                  "║                  █████████      ██████      ██████████               ║\n" +
                  "║                ██                 ██                 ██              ║\n" +
                  "║                ██                 ██                 ██              ║\n" +
                  "║              ██            ████████████████            ██            ║\n" +
                  "║              ██      ██████░░░░░░░░░░░░░░░░██████      ██            ║\n" +
                  "║              ██    ██░░░░░░░░░░░░░░░░░░░░░░░░░░░░██    ██            ║\n" +
                  "║                ██  ██░░░░░░░░░░░░░░░░░░░░░░░░░░░░██  ██              ║\n" +
                  "║              ██░░████░░████████░░░░░░░░████████░░████░░██            ║\n" +
                  "║              ██░░██████░░░░░░░░████████░░░░░░░░██████░░██            ║\n" +
                  "║              ██░░██░░██░░░░░░░░██░░░░██░░░░░░░░██░░██░░██            ║\n" +
                  "║                ████░░░░████████░░░░░░░░████████░░░░████              ║\n" +
                  "║                  ███░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░██                ║\n" +
                  "║                     ██░░░░░░░░░░░░░░░░░░░░░░░░░░░██                  ║\n" +
                  "║                     ██░░░░░░░░░░░░░░░░░░░░░░░░░░░██                  ║\n" +
                  "║                       ██░░░░░░░░░░░░░░░░░░░░░░░██                    ║\n" +
                  "║                        ██░░░░░░░░░░░░░░░░░░░░░██                     ║\n" +
                  "║                          ████░░░░░░░░░░░░░░████                      ║\n" +
                  "║                            ████░░░░░░░░░░████                        ║\n" +
                  "║                            ██░░██████████░░██                        ║\n" +
                  "║                            ██░░░░░░░░░░░░░░██                        ║\n" +
                  "║                            ██░░░░░░░░░░░░░░██                        ║\n" +
                  "║                            ██░░░░░░░░░░░░░░██                        ║\n" +
                  "║                            ██░░░░░░░░░░░░░░██                        ║\n" +
                  "║                            ██░░░░░░░░░░░░░░██                        ║\n" +
                  "║                          ██████░░░░░░░░░░██████                      ║\n" +
                  "║                          ██  ████░░░░░░████  ██                      ║\n" +
                  "║                    ██████  ██    ██░░██    ██  ██████                ║\n" +
                  "║    ██████████████████      ██      ██      ██      ██████████████    ║\n" +
                  "╚══════════════════════════════════════════════════════════════════════╝");

        }
    }
}
