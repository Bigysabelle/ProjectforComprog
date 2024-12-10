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
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗\n" +
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
                "How time has passed, huh?\n", playername);
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
            Console.WriteLine("{0}: It's an honor to meet you all.\n", playername);
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
            //brushes hehe Gray = ░░ white = ██
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗\n" +
                              "║██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████║\n" +
                              "║░░░░░░      ░░░░░░      ░░░░░░██  ░░  ░░░░      ░░  ██░░██░░██░░██░░██░░██░░██░░██░░██  ░░      ░░░░  ░░  ██░░░░░░      ░░░░░░      ░░░░░░║\n" +
                              "║░░░░░░      ░░░░░░  ████░░░░░░██░░  ░░░░      ░░░░  ██  ██  ██  ██  ██  ██  ██  ██  ██  ░░░░      ░░░░  ░░██░░░░░░████  ░░░░░░      ░░░░░░║\n" +
                              "║░░░░░░    ██████████    ██░░░░██░░  ░░    ░░░░░░    ██                              ██    ░░░░░░    ░░  ░░██░░░░██    ██████████    ░░░░░░║\n" +
                              "║░░░░░░████              ██░░░░██░░  ░░  ░░░░░░    ██                                  ██    ░░░░░░  ░░  ░░██░░░░██      ░░░░░░  ████░░░░░░║\n" +
                              "║░░░░██                  ██░░░░██    ░░  ░░    ████  ██████████████████████████████████  ████    ░░  ░░    ██░░░░██      ░░░░░░      ██░░░░║\n" +
                              "║░░░░██              ██████░░░░██  ░░  ░░░░  ██                                              ██  ░░░░  ░░  ██░░░░██████  ░░░░░░      ██░░░░║\n" +
                              "║░░░░██    ██████████  ██░░██░░██░░  ░░░░  ██                                                  ██  ░░░░  ░░██░░██░░██  ██████████    ██░░░░║\n" +
                              "║░░░░██████  ██░░██  ██████░░░░██░░░░    ██                                                      ██    ░░░░██░░░░██████  ██░░██  ██████░░░░║\n" +
                              "║░░██░░██  ██████████    ░░░░░░██████████                                            ████          ██████████░░░░░░    ██████████  ██░░██░░║\n" +
                              "║░░░░████████░░░░░░      ░░░░░░██░░░░██                                              ░░░░██          ██░░░░██░░░░░░      ░░░░░░  ██████░░░░║\n" +
                              "║░░░░░░      ░░░░░░      ░░░░░░██████                                            ██░░      ██          ██████░░░░░░      ░░░░░░      ░░░░░░║\n" +
                              "║░░░░░░      ░░░░░░      ░░░░░░██░░  ██                                      ████░░        ██        ██  ░░██░░░░░░      ░░░░░░      ░░░░░░║\n" +
                              "║░░░░░░      ░░░░░░      ░░░░░░██░░  ██                                    ██████████████████      ██    ░░██░░░░░░      ░░░░░░      ░░░░░░║\n" +
                              "║░░░░░░      ░░░░░░      ░░░░░░██  ░░  ██                                ██░░░░░░░░░░░░░░░░        ██  ░░  ██░░░░░░      ░░░░░░      ░░░░░░║\n" +
                              "║░░░░░░      ░░░░░░      ░░░░░░██  ░░  ██                          ████    ░░            ░░        ██  ░░  ██░░░░░░      ░░░░░░      ░░░░░░║\n" +
                              "║░░░░░░      ░░░░░░      ░░░░░░██  ░░  ██                          ░░░░    ██            ██        ██  ░░  ██░░░░░░      ░░░░░░      ░░░░░░║\n" +
                              "║██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████║\n" +
                              "║  ██  ██  ██  ██  ██  ██  ██  ██                                                                          ██  ██  ██  ██  ██  ██  ██  ██  ║\n" +
                              "║  ██  ██  ██  ██  ██  ██  ██  ██                                                                          ██  ██  ██  ██  ██  ██  ██  ██  ║\n" +
                              "║██████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████║\n" +
                              "║░░░░  ░░░░  ░░░░  ░░░░  ░░░░            ██░░  ░░    ██████  ████████  ██████  ████████    ░░  ░░██            ░░░░  ░░░░  ░░░░  ░░░░  ░░░░║\n" +
                              "║░░░░  ░░░░  ░░░░  ████  ░░░░░░██████████    ░░  ░░  ░░░░░░  ░░░░░░░░  ░░░░░░  ░░░░░░░░  ░░  ░░  ░░██████████░░░░░░  ████  ░░░░  ░░░░  ░░░░║\n" +
                              "║░░░░  ░░░░  ████  ░░░░░░  ██████  ░░  ░░  ░░                                                  ░░  ░░  ░░  ██████  ░░░░░░  ████  ░░░░  ░░░░║\n" +
                              "║░░░░  ████  ░░░░░░████████  ░░  ░░  ░░  ░░    ████████  ██████  ████████  ██████  ████████  ░░  ░░  ░░  ░░  ░░  ████████░░░░░░  ████  ░░░░║\n" +
                              "║████  ░░░░░░██████░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░░░░░░░  ░░░░░░  ░░░░░░░░  ░░░░░░  ░░░░░░░░    ░░  ░░  ░░  ░░  ░░  ░░  ░░██████░░░░░░  ████║\n" +
                              "║░░░░░░  ██████  ░░  ░░  ░░  ░░  ░░  ░░                                                                  ░░  ░░  ░░  ░░  ░░  ██████  ░░░░░░║\n" +
                              "║    ██████░░  ░░  ░░  ░░  ░░  ░░  ░░    ██████  ████████  ██████  ████████  ██████  ████████  ██████  ░░  ░░  ░░  ░░  ░░  ░░  ░░██████    ║\n" +
                              "║████░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░░░░░  ░░░░░░░░  ░░░░░░  ░░░░░░░░  ░░░░░░  ░░░░░░░░  ░░░░░░    ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░████║\n" +
                              "║  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░                                                                          ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ║\n" +
                              "║░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░    ████████  ██████  ████████  ██████  ████████  ██████  ████████  ██████    ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░║\n" +
                              "║  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░░░░░░░  ░░░░░░  ░░░░░░░░  ░░░░░░  ░░░░░░░░  ░░░░░░  ░░░░░░░░  ░░░░░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ░░  ║\n" +
                              "╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝\n");
            Console.WriteLine(" ___________________________________________________________________________________________________________________________________________\n" +
                              "|                                                                                                                                           |\n" +
                              "|   As the curtains began to rise, two musicians appeared on stage and started playing their instruments. Their music's melody was beautiful|\n" +
                              "|   and enchanting, casting a spell over the audience and making them feel engaged and relaxed. The notes danced in the air, weaving a      |\n" +
                              "|   tapestry of sound around the audience, soothing their nerves. After the performance, the musicians bowed, and the audience responded by |\n" +
                              "|   throwing roses onto the stage in appreciation, their faces lit up with joy and admiration.                                              |\n" +
                              "|___________________________________________________________________________________________________________________________________________|\n");
            Console.ReadLine();
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
                              "|   While everyone is quivering in fear and panic inside the auditorium, you manage to go to the lobby. You tried to walk to the entrance   |\n" +
                              "|   hall but suddenly felt a lump on your feet. It was not an object; instead, it was something unusual yet heavy.                          |\n" +
                              "|___________________________________________________________________________________________________________________________________________|\n");
            Console.ReadLine();
            //brushes hehe Gray = ░░ white = ██
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗\n" +
                              "║████                                    ████      ██                ████                ██      ████      ░░      ░░░░      ░░            ║\n" +
                              "║████                                    ██░░██    ██                ████                ██    ██░░██      ░░    ██░░░░██    ░░            ║\n" +
                              "║████                                    ██░░░░██  ██                                    ██  ██░░░░██      ██  ██  ░░░░  ██  ██            ║\n" +
                              "║                                        ██  ░░░░████        ██      ████      ██        ████░░░░  ██        ████  ████  ████            ░░║\n" +
                              "║████      ░░░░                          ██    ░░░░██      ░░░░      ░░░░      ░░░░      ██░░░░    ██            ██    ██                ██║\n" +
                              "║░░░░      ░░░░                          ██      ░░██      ░░░░    ██░░░░██    ░░░░      ██░░      ██              ████                  ██║\n" +
                              "║░░░░██    ░░░░                          ██        ██    ██  ██  ██  ░░░░  ██  ██  ██    ██        ██                                  ░░░░║\n" +
                              "║░░░░  ██  ██  ██                        ██        ██      ██  ████  ████  ████  ██      ██        ██                                  ████║\n" +
                              "║████  ████  ██                          ██        ██              ██    ██              ██        ██        ██            ██          ████║\n" +
                              "║    ██                ████████          ██        ██                ████                ██        ██        ░░            ░░        ░░░░░░║\n" +
                              "║████                ██      ████        ██        ██                                    ██        ██        ░░            ░░      ░░██████║\n" +
                              "║                              ░░        ██        ██                                    ██        ██        ██            ██      ████████║\n" +
                              "║                              ░░        ██        ██                                    ██        ██░░░░  ██  ░░░░░░░░░░░░  ██  ░░░░░░░░░░║\n" +
                              "║████████████                ░░░░        ██        ██                                    ██        ██░░░░  ██  ████████████  ██  ░░░░░░░░░░║\n" +
                              "║            ██              ██          ██        ██                                    ██        ██░░    ██  ████████████  ██    ░░░░░░░░║\n" +
                              "║  ░░  ░░    ██            ██████████    ██░░      ██                                    ██      ░░██░░  ██  ░░░░░░░░░░░░░░░░  ██  ░░░░░░░░║\n" +
                              "║    ░░      ██            ██      ░░    ██░░░░    ██                                    ██    ░░░░██░░  ██  ████████████████  ██  ░░░░░░░░║\n" +
                              "║      ░░    ██            ████      ░░  ████░░░░  ██                                    ██  ░░░░████░░  ██  ████████████████  ██    ░░░░░░║\n" +
                              "║            ██              ████    ░░  ██  ██░░░░██                                    ██░░░░██  ██  ██  ░░░░░░░░░░░░░░░░░░░░    ██  ░░░░║\n" +
                              "║████████████  ████            ██        ██    ██░░██                                    ██░░██    ██  ██  ████████████████████  ██    ░░░░║\n" +
                              "║            ██    ██  ████████████████  ██      ████                                    ████      ██  ██  ████████████████████  ██    ░░░░║\n" +
                              "║            ██    ██    ██        ██    ██        ██                                    ██        ████  ░░░░░░░░░░░░░░░░░░░░░░░░  ██    ░░║\n" +
                              "║            ██    ██    ██        ██    ██        ██                                    ██        ████  ████████████████████████  ██    ░░║\n" +
                              "║██████████████    ██    ██        ██    ████████████                                    ██████████████  ████████████████████████  ██    ░░║\n" +
                              "║            ██    ██      ████████    ██          ████████████████████████████████████████          ██                                    ║\n" +
                              "║██████████████████                      ██████████                                        ██████████    ░░                    ░░          ║\n" +
                              "║                                                                                                          ░░░░░░░░░░░░░░░░░░░░            ║\n" +
                              "║░░░░░░░░░░░░░░░░░░░░░░░░                                                                                  ░░                ░░            ║\n" +
                              "║                  ░░                                                                                      ░░  ░░░░░░░░░░░░  ░░            ║\n" +
                              "║░░░░░░░░░░░░░░░░░░░░░░░░                                                                                  ░░  ░░        ░░  ░░            ║\n" +
                              "║                  ░░                                                                                      ░░  ░░  ░░░░  ░░  ░░            ║\n" +
                              "╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝\n");
            Console.WriteLine(" ___________________________________________________________________________________________________________________________________________\n" +
                              "|                                                                                                                                           |\n" +
                              "|   Suddenly, the chaos came to an end. The lights turned on, revealing Earl standing in the lobby, his face a mask of shock. Following his |\n" +
                              "|   gaze, you looked down and saw a sight that would haunt you forever: a pale woman's lifeless body, lying still—a stark contrast to the   |\n" +
                              "|   previously bustling theater. You struggled to process what had just happened when, without warning, the auditorium doors opened.        |\n" +
                              "|   Everyone turned to look at you near the body, and the air was filled with screams and surprise gasps. Horror and sorrow permeated your  |\n" +
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
                              "|   in the theater. The entrance door was heavily guarded, and tension rose as suspicions grew among the group. Silvio Addams appeared      |\n" +
                              "|   worried about Merida while Merida Lakes stared intently at the table. Victor maintained an expressionless demeanor as he listened to    |\n" +
                              "|   Julio's anxious pleas, and Leon stood nearby, deep in thought.                                                                          |\n" +
                              "|___________________________________________________________________________________________________________________________________________|\n");
            Console.ReadLine();

        }
        static void Midgame()
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗\n" +
                              "║You realized that you couldn't go home without uncovering the killer's identity, especially since you were the prime suspect in the case. ║\n" +
                              "║Determined to clear your name, you decided to take action. It was now 10:00 AM, and everyone was dispersing in the theater to carry out   ║\n" +
                              "║various tasks and enjoy some free time.However, you chose to investigate to prove your innocence.                                         ║\n" +
                              "╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝\n");
            Console.ReadLine();
            int room = 1, hour=10,minutes=0;
            Random random = new Random();
            int gamephase = 1;
            string[] Inventory = new string [27];
            string LobbyChoice, LobbyRoom, LobbyInterrogation;
            string TimeReader = "AM",Minutereader="";
            
            while (gamephase == 1)
            {
                if (room == 1) //Code of the room variable: (1=lobby, 2=Auditorium, 3=Hallway, 4=GeneralDirectorOffice, 5=PracticeRoom, 6=Generator, 7=Backstage)
                {//This is the code for lobby
                    while (room == 1)
                    {
                        LobbyPicture();
                        Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗\n" +
                                          "║You find yourself in the dimly lit lobby, where the air is thick with intrigue and tension. The distant murmur of your colleagues echoes  ║\n"+
                                          "║from various rooms, each one a potential source of vital information. You spot Julio and Earl in the lobby, still engaged in conversation.║\n" +
                                          "║Although the police have already attended to the body, the crime scene remains rich with opportunities for investigation. The chance to   ║\n" +
                                          "║uncover crucial clues is too significant to ignore. With determination in your heart, what will you do first?                             ║\n" +
                                          "╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝\n");
                        Console.WriteLine("\n\ta) Inspect the room for clues\n\tb) Interrogate people\n\tc) Enter a different room\n\td) Check Inventory\n");
                        Console.Write("\nAction: ");
                        LobbyChoice = Console.ReadLine();

                        if (LobbyChoice == "a")
                        {
                            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐\n" +
                                              "|In the dimly lit lobby, the atmosphere is thick with intrigue as a table and plush sofas are carefully positioned near the entrance to the|\n" +
                                              "|grand auditorium. The table is strewn with scattered files, resembling a trail of breadcrumbs that beckons you to uncover the mystery     |\n" +
                                              "|hidden within their pages.To the far left, nestled against the hallway, stands a haphazard collection of boxes and colorful props, all    |\n" +
                                              "|gathered near the wide staircase leading up to the second balcony, hinting at stories waiting to be told. Dominating the lobby's center,  |\n" +
                                              "|the crime scene is marked by an air of urgency and suspense, a complex puzzle that requires keen eyes to piece together the clues.        |\n" +
                                              "└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘\n");
                            while (LobbyChoice == "a")
                            {
                                Console.WriteLine("Where will your curiosity lead you?");
                                Console.WriteLine("\n\ta) Table and Plush Sofas\n\tb) Collection of Boxes and Props\n\tc) Inspect the Crime Scene\n\td) Back\n");
                                Console.Write("Action:");
                                LobbyRoom = Console.ReadLine(); //if its <location>Room variable, it indicates the player is exploring a specific room/spot inside the location

                                if (LobbyRoom == "a")
                                {
                                    //brushes hehe Gray = ░░ white = ██
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|As you approached the table, your eyes were drawn to the plush sofas  |\n" +
                                                      "|where Merida and Silvio sat. Unexpectedly, a file lay abandoned on the|\n" +
                                                      "|table, piquing your curiosity. You couldn't resist picking it up.     |\n"+
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("                             ___________________________________________\n"+
                                                      "                            | A detective file?                         |\n"+
                                                      "                             ----------------------------------------v--");
                                    Console.ReadLine();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n"+
                                                      "|You flipped open the cover to reveal a draft report meticulously      |\n"+
                                                      "|detailing the investigation into Christine's mysterious death. Though |\n"+
                                                      "|still a work in progress, the report brimmed with the detective's     |\n"+
                                                      "|insights and observations that promised to be a valuable reference in |\n"+
                                                      "|the future.                                                           |\n"+
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("           You found \"Detective's File Case Report.\"");
                                    Console.ReadLine();

                                    Inventory[0] = "> (0204) Detective's File Case Report"; //Detective Case Report Clue

                                    minutes += random.Next(1, 3);
                                    if(minutes>=60)
                                    {
                                        hour += 1;
                                        minutes = minutes-60;
                                    }
                                    if(hour>12)
                                    {
                                        hour = hour-12;
                                        TimeReader = "PM";
                                    }
                                    if (minutes < 10)
                                    {
                                        Minutereader = "0" + minutes;
                                       
                                    }
                                    else
                                    {
                                        Minutereader = minutes.ToString();
                                    }
                                    Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);



                                }
                                else if (LobbyRoom == "b")
                                {
                                    Console.WriteLine("You: What are these?");
                                    Console.ReadLine();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|Your curiosity piqued, and you approached the collection of peculiarly|\n" +
                                                      "|ordered boxes. Each one was stamped on the corner, a detail that only |\n" +
                                                      "|added to the mystery.                                                 |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("                                       ________________________________\n" +
                                                      "                                      |Player:  Imported from Portugal.|\n" +
                                                      "                                       -----------------------------v--");
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|As you examined the boxes, you noticed one was slightly ajar. Inside  |\n" +
                                                      "|were a deck of cards, a handful of handkerchiefs tied in a peculiar   |\n" +
                                                      "|manner, metal hoops, and colorful cups neatly arranged. Above the     |\n" +
                                                      "|chests, a cage of doves added to the enigma. But your keen eye caught |\n" +
                                                      "|a metal glint hidden by a potted plant. You reached for it and        |\n" +
                                                      "|discovered a small, unnoticed object.                                 |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("                                _______________________________________\n" +
                                                      "                               |Wait, isn't this a bullet of some kind?|\n" +
                                                      "                                ------------------------------------v--");
                                    Console.ReadLine();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|Understanding this, you took the bullet as part of your evidence. You |\n" +
                                                      "|kept the bullet as proof.                                             |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("                         You found a \"Bullet.\""); //bullet clue
                                    Console.ReadLine();
                                    Inventory[1] = "> (7823) Bullet";
                                    minutes += random.Next(1, 3);
                                    if (minutes >= 60)
                                    {
                                        hour += 1;
                                        minutes = minutes - 60;
                                    }
                                    if (hour > 12)
                                    {
                                        hour = hour - 12;
                                        TimeReader = "PM";
                                    }
                                    if (minutes < 10)
                                    {
                                        Minutereader = "0" + minutes;

                                    }
                                    else
                                    {
                                        Minutereader = minutes.ToString();
                                    }
                                    Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
                                }
                                else if (LobbyRoom == "c")
                                {
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|You approached the crime scene again, where Christine lay lifeless    |\n" +
                                                      "|before you, trying to organize your thoughts. You noticed a           |\n" +
                                                      "|significant amount of blood at the scene, but among it, you spotted a |\n" +
                                                      "|white piece of paper stained with red. Despite the gruesome sight, you|\n" +
                                                      "|carefully picked up the paper. Upon closer inspection, it appeared to |\n" +
                                                      "|be a stamped letter.                                                  |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("           ____________________________________________________________\n" +
                                                      "          |This letter seems to be of great significance, as Christine |\n" +
                                                      "          |must have kept it personally.                               |\n" +
                                                      "           ---------------------------------------------------------v--");
                                    Console.ReadLine();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|The front of the letter bore a seal with a hawk crest logo, a majestic|\n" +
                                                      "|bird with its wings spread wide, and on the back, there was a         |\n" +
                                                      "|handwritten text addressed to the recipient: \"To Christine.\"        |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|You carefully tucked the letter into your inventory, fully aware that |\n" +
                                                      "|it might contain crucial information.                                 |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("            You have obtained a \"Blood-stained letter.\"");
                                    Console.ReadLine();
                                    Inventory[2] = "> (8203) Blood-stained letter";//Blood-Stained Letter Clue
                                    minutes += random.Next(1, 3);
                                    if (minutes >= 60)
                                    {
                                        hour += 1;
                                        minutes = minutes - 60;
                                    }
                                    if (hour > 12)
                                    {
                                        hour = hour - 12;
                                        TimeReader = "PM";
                                    }
                                    if (minutes < 10)
                                    {
                                        Minutereader = "0" + minutes;

                                    }
                                    else
                                    {
                                        Minutereader = minutes.ToString();
                                    }
                                    Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
                                }
                                else if (LobbyRoom == "d")
                                {
                                    Console.WriteLine("\nReturning Back...\n");
                                    Console.ReadLine();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\nKindly input either of the choices");
                                    Console.ReadLine();
                                }
                            }
                        }
                        else if (LobbyChoice == "b") //I forgot to add Earl and Victor in the SCENE T-T so I added a new choice so that the player can inquire them
                        {
                            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐\n" +
                                              "|As you entered the lobby, your gaze was drawn to Earl and Julio, who stood a few paces away, engaged in a hushed conversation. The        |\n" +
                                              "|atmosphere was thick with tension, contrasting sharply between the two. Julio's brow was furrowed, his body language tight and anxious, as|\n" +
                                              "|if wrestling with an inner conflict. In stark contrast, Earl maintained an emotionless facade, his expression blank and mysterious, giving|\n" +
                                              "|nothing away.                                                                                                                             |\n" +
                                              "└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                            Console.ReadLine();
                            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐\n" +
                                              "|It was clear that whatever was brewing between them held the potential for crucial information, and the uncertainty of their thoughts only|\n" +
                                              "|heightened your curiosity. Realizing the moment's importance, you steeled yourself and decided to approach them, ready to initiate a      |\n" +
                                              "|conversation.                                                                                                                             |\n" +
                                              "└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                            Console.ReadLine();
                            Console.WriteLine(" ______\n" +
                                              "|Hello.|\n" +
                                              " -v----");
                            Console.ReadLine();
                            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐\n" +
                                              "|Both men turned toward you, their interest piqued by your unexpected arrival. They greeted you with mild curiosity. Now, the choice lay   |\n" +
                                              "|before you:                                                                                                                               |\n" +
                                              "└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                            Console.ReadLine();
                            while (LobbyChoice == "b") //Interrogation on earl and victor
                            {
                                Console.WriteLine("Who would you like to engage with first?");
                                Console.WriteLine("\n\ta) Julio Lopez\n\tb) Earl Victor\n\tc) Nevermind");
                                LobbyInterrogation = Console.ReadLine();

                                if (LobbyInterrogation == "a")
                                {
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|You decided to talk to Julio first.                                   |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    while (LobbyInterrogation == "a")
                                    {
                                        Console.WriteLine(" ______________________________________________________________________\n" +
                                                          "/                                                                      \\\n" +
                                                          "| Julio: Oh, umm… so I'm sorry; it's just that I’ve felt very surprised|\n" +
                                                          "|        and grief-stricken about what happened… What would you like to|\n" +
                                                          "|        ask me?                                                       |\n" +
                                                          "\\______________________________________________________________________/\n");

                                        Console.WriteLine("\n\ta) Who are you?\n\tb)What is your relationship with everyone?\n\tc) Where were you during the brownout?\n\td) Nevermind\n");
                                        Console.Write("Action: ");
                                        string JulioChoice = Console.ReadLine();

                                        if (JulioChoice == "a")
                                        {
                                            Console.WriteLine(" ________________________________\n" +
                                                              "|Can you desribe yourself to me? |\n" +
                                                              " --v-----------------------------");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "/                                                                      \\\n" +
                                                              "| Julio: If you want to know about me, I'm just a recruit here. I just |\n" +
                                                              "|        moved here a few months ago, and thanks to Leon, I got a job  |\n" +
                                                              "|        as a performer at the Citadel. Now, I’m sharing my talents as |\n" +
                                                              "|        a magician. Sadly, due to the events that happened, my        |\n" +
                                                              "|        performance was delayed, but I didn't think that somebody     |\n" +
                                                              "|        die during the anniversary, especially Christine…             |\n" +
                                                              "\\______________________________________________________________________/\n");
                                            Console.ReadLine();
                                            Console.WriteLine(" ___________________________________\n" +
                                                             "|Have you met with Christine before? |\n" +
                                                             " --v---------------------------------");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "/                                                                      \\\n" +
                                                              "| Julio: Yes, Earl mentioned her to me many times. However I only met  |\n" +
                                                              "|        her a few times because of my performances. She was always    |\n" +
                                                              "|        cheery and everytime I made a magic trick even if I committed |\n" +
                                                              "|        a mistake in the process, she will be always be happy and     |\n" +
                                                              "|        pretend to be surprised. Sadly she passed away…               |\n" +
                                                              "\\______________________________________________________________________/\n");
                                            Console.ReadLine();
                                            minutes += random.Next(1, 3);
                                            if (minutes >= 60)
                                            {
                                                hour += 1;
                                                minutes = minutes - 60;
                                            }
                                            if (hour > 12)
                                            {
                                                hour = hour - 12;
                                                TimeReader = "PM";
                                            }
                                            if (minutes < 10)
                                            {
                                                Minutereader = "0" + minutes;

                                            }
                                            else
                                            {
                                                Minutereader = minutes.ToString();
                                            }
                                            Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
                                        }
                                        else if (JulioChoice == "b")
                                        {
                                            Console.WriteLine(" ________________________________________\n" +
                                                              "|How is your relationship with everyone? |\n" +
                                                              " --v-------------------------------------");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "/                                                                      \\\n" +
                                                              "| Julio: My relationship? Well… I'm really good friends with Earl,     |\n" +
                                                              "|        since he is a business man that was also interested in        |\n" +
                                                              "|        overseas trading, I met him coincidentally and now we became  |\n" +
                                                              "|        best of friends.                                              |\n" +
                                                              "\\______________________________________________________________________/\n");
                                            Console.ReadLine();
                                            Console.WriteLine(" _____________________________________________\n" +
                                                              "|Did you know about the controversy with Earl?|\n" +
                                                              " --v------------------------------------------");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "/                                                                      \\\n" +
                                                              "| Julio: Oh you mean the scandal of Earl regarding Christine? Well to  |\n" +
                                                              "|        be honest, all because of one public argument, I didnt think  |\n" +
                                                              "|        that the controversy will ruin his reputation slightly. I do  |\n" +
                                                              "|        know that both of them are victims of the controversy.        |\n" +
                                                              "|        Christine loved him a lot but Earl is already bethroted which |\n" +
                                                              "|        why earl is having a hard time to return his feelings with    |\n" +
                                                              "|        Christine.                                                    |\n" +
                                                              "\\______________________________________________________________________/\n");
                                            minutes += random.Next(1, 3);
                                            if (minutes >= 60)
                                            {
                                                hour += 1;
                                                minutes = minutes - 60;
                                            }
                                            if (hour > 12)
                                            {
                                                hour = hour - 12;
                                                TimeReader = "PM";
                                            }
                                            if (minutes < 10)
                                            {
                                                Minutereader = "0" + minutes;

                                            }
                                            else
                                            {
                                                Minutereader = minutes.ToString();
                                            }
                                            Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
                                        }
                                        else if (JulioChoice == "c")
                                        {
                                            Console.WriteLine(" ______________________________________________\n" +
                                                              "|Where were you before and during the brownout?|\n" +
                                                              " --v-------------------------------------------");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "/                                                                      \\\n" +
                                                              "| Julio: Since I was the next second performer, I waited at the        |\n" +
                                                              "|        backstage, then suddenly I heard a commotion near the hallway |\n" +
                                                              "|        and then suddenly the light went out. I panicked during there |\n" +
                                                              "|        because I dont know what to do. However after it brown out, I |\n" +
                                                              "|        heard very loud shouts coming from the same spot but its      |\n" +
                                                              "|        nearer by me.                                                 |\n" +
                                                              "\\______________________________________________________________________/\n");
                                            Console.ReadLine();
                                            Console.WriteLine(" _____________________________________\n" +
                                                              "|Did you heard anyone scream near you?|\n" +
                                                              " --v----------------------------------");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "/                                                                      \\\n" +
                                                              "| Julio: I was alone in the backstage and the others were waiting on   |\n" +
                                                              "|        standby for the cue for my performance so I don’t think no one|\n" +
                                                              "|        was there but me and also during the brownout, the screams in |\n" +
                                                              "|        the auditorium was also loud.                                 |\n" +
                                                              "\\______________________________________________________________________/\n");
                                            Console.ReadLine();
                                            Console.WriteLine(" _________________\n" +
                                                              "|Standby for what?|\n" +
                                                              " --v--------------");
                                            minutes += random.Next(1, 3);
                                            if (minutes >= 60)
                                            {
                                                hour += 1;
                                                minutes = minutes - 60;
                                            }
                                            if (hour > 12)
                                            {
                                                hour = hour - 12;
                                                TimeReader = "PM";
                                            }
                                            if (minutes < 10)
                                            {
                                                Minutereader = "0" + minutes;

                                            }
                                            else
                                            {
                                                Minutereader = minutes.ToString();
                                            }
                                            Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
                                            Console.ReadLine();
                                            while (JulioChoice == "c")
                                            {
                                                Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "/                                                                      \\\n" +
                                                              "| Julio: Well my finale magic performance, includes a lot of people so |\n" +
                                                              "|        I told them to go to the balcony holding the props that I     |\n" +
                                                              "|        asked. It’s basically a reflection magic trick. If you have   |\n" +
                                                              "|        two items related to the performance, I can probably give you |\n" +
                                                              "|        a glimpse of the magic trick.                                 |\n" +
                                                              "\\______________________________________________________________________/\n");

                                                Console.WriteLine("What would you like to say?");
                                                Console.WriteLine("\n\ta) I have the items you're looking for\n\t)b) I don't think I have it.");
                                                Console.Write("Action: ");
                                                string JulioPuzzleChoice = Console.ReadLine();

                                                if (JulioPuzzleChoice == "a")
                                                {
                                                    Console.WriteLine(" ___________________________________\n" +
                                                                      "|I have the items you're looking for|\n" +
                                                                      " --v--------------------------------");
                                                    Console.ReadLine();
                                                    if (Inventory[6] != "" && Inventory[20] != "")
                                                    {
                                                        Console.WriteLine(" ______________________________________________________________________\n" +
                                                                          "/                                                                      \\\n" +
                                                                          "| Julio: Oh, you have both of them. Here is the last mirror. You can do|\n" +
                                                                          "|        my magic trick easily now. Place them in the right place at   |\n" +
                                                                          "|        one of the areas in the Backstage and you can figure out how  |\n" +
                                                                          "|        final performance will go. Goodluck!                          |\n" +
                                                                          "\\______________________________________________________________________/\n");
                                                        Console.ReadLine();
                                                        Console.WriteLine("You obtained \"Mirror (III)\"");
                                                        Inventory[20] = "> (6569) Mirror(III)";
                                                        Console.ReadLine();

                                                        break;
                                                    }
                                                    else if (Inventory[6] != "" || Inventory[20] != "")
                                                    {
                                                        Console.WriteLine(" ______________________________________________________________________\n" +
                                                                          "/                                                                      \\\n" +
                                                                          "| Julio: You already have one item but I need one more of the same.    |\n" +
                                                                          "|        Come back if you have both of them.                           |\n" +
                                                                          "\\______________________________________________________________________/\n");
                                                        Console.ReadLine();
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine(" ______________________________________________________________________\n" +
                                                                          "/                                                                      \\\n" +
                                                                          "| Julio: I dont think you have it...                                   |\n" +
                                                                          "\\______________________________________________________________________/\n");
                                                        Console.ReadLine();
                                                    }
                                                }
                                                else if (JulioPuzzleChoice == "b")
                                                {
                                                    Console.WriteLine(" ______________________________________________________________________\n" +
                                                                      "/                                                                      \\\n" +
                                                                      "| Julio: You can talk to me again, if you have the items I'm looking   |\n" +
                                                                      "|        for.                                                          |\n" +
                                                                      "\\______________________________________________________________________/\n");
                                                    Console.ReadLine();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Choose either of the options.");
                                                    Console.ReadLine();
                                                }

                                            }
                                        }
                                        else if (JulioChoice == "d")
                                        {
                                            Console.WriteLine("You decided to stop your conversation.");
                                            Console.ReadLine();
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Kindly select the choices mentioned.");
                                        }
                                    }
                                }
                                else if (LobbyInterrogation == "b")
                                {
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|You decided to talk to Earl first.                                    |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    while (LobbyInterrogation == "b")
                                    {
                                        Console.WriteLine(" ______________________________________________________________________\n" +
                                                          "/                                                                      \\\n" +
                                                          "| Earl: Hurry up, I don’t have enough time for you. What do you        |" +
                                                          "|        want to ask?                                                  |\n" +
                                                          "\\______________________________________________________________________/\n");
                                        Console.WriteLine("\n\ta) Who are you?\n\tb)What is your relationship with everyone?\n\tc) Where were you during the brownout?\n\td) Nevermind\n");
                                        Console.Write("Action: ");
                                        string EarlChoice = Console.ReadLine();

                                        if(EarlChoice=="a")
                                        {
                                            Console.WriteLine(" ___________________________________\n" +
                                                              "|Can you describe yourself to me?   |\n" +
                                                              " --v--------------------------------");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "/                                                                      \\\n" +
                                                              "| Earl: You wasted my time for that question. Geez. I think you know me|\n" +
                                                              "|       already, Earl Victor, one of the Citadel’s sponsors. It was not|\n" +
                                                              "|       my choice, but supposedly, my family supported the Citadel's   |\n" +
                                                              "|       building firsthand, and our family became wealthier once many  |\n" +
                                                              "|       performers now here are known. They are expanding the selection|\n" +
                                                              "|       of performers abroad, and I don’t mind being invested in it.   |\n"+
                                                              "\\______________________________________________________________________/\n");
                                            Console.ReadLine();
                                            Console.WriteLine(" ________________________________________\n" +
                                                              "|What’s your relationship with Christine?|\n" +
                                                              " --v-------------------------------------");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "/                                                                      \\\n" +
                                                              "| Earl:  . . . Nothing, just friends.                                  |\n" +
                                                              "\\______________________________________________________________________/\n");
                                            Console.ReadLine();
                                            Console.WriteLine(" ___________________________________________________________________\n" +
                                                              "|Just friends, but the controversy about you and her says otherwise.|\n" +
                                                              " --v----------------------------------------------------------------");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "/                                                                      \\\n" +
                                                              "| Earl:  I didn’t think you were one of those gossip-bearing newts.    |\n" +
                                                              "|        Sadly, I don’t want any relationship with her other than with |\n" +
                                                              "|        friends, and I have already been betrothed. If I didn't have  |\n" +
                                                              "|        one in the first place, I would have picked her to marry me   |\n" +
                                                              "|        instead.                                                      |\n" +
                                                              "\\______________________________________________________________________/\n");
                                            Console.ReadLine();
                                            minutes += random.Next(1, 3);
                                            if (minutes >= 60)
                                            {
                                                hour += 1;
                                                minutes = minutes - 60;
                                            }
                                            if (hour > 12)
                                            {
                                                hour = hour - 12;
                                                TimeReader = "PM";
                                            }
                                            if (minutes < 10)
                                            {
                                                Minutereader = "0" + minutes;

                                            }
                                            else
                                            {
                                                Minutereader = minutes.ToString();
                                            }
                                            Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
                                        }
                                        else if (EarlChoice == "b")
                                        {
                                            Console.WriteLine(" _______________________________________\n" +
                                                              "|What’s your relationship with everyone?|\n" +
                                                              " --v------------------------------------");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "/                                                                      \\\n" +
                                                              "| Earl:  All of them are just normal, nothing new and nothing terrible.|\n" +
                                                              "\\______________________________________________________________________/\n");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________\n" +
                                                              "|Except with Christine?|\n" +
                                                              " --v-------------------");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "/                                                                      \\\n" +
                                                              "| Earl:  . . . Why do you keep bringing up Christine in this? We’re    |\n" +
                                                              "|        just friends, as I said, and I didn’t kill her.               |\n" +
                                                              "\\______________________________________________________________________/\n");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "|Well, sorry to inform you, but she is the victim, of course. I'm      |" +
                                                              "|bringing her up in this conversation. Anyway, do you think she has any|" +
                                                              "|recent terrible relationship with anyone?                             |\n" +
                                                              " --v-------------------------------------------------------------------");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "/                                                                      \\\n" +
                                                              "| Earl:  Probably with Merida. . .                                     |\n" +
                                                              "\\______________________________________________________________________/\n");
                                            Console.ReadLine();
                                            Console.WriteLine(" __________________________________________\n" +
                                                              "| But Merida is her dearest friend, right? |\n" +
                                                              " --v---------------------------------------");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "/                                                                      \\\n" +
                                                              "| Earl: Yes, but sadly, they fell out a few days ago. I don’t know what|\n" +
                                                              "|       happened between them, but I saw them feeling distant.         |\n" +
                                                              "\\______________________________________________________________________/\n");
                                            Console.ReadLine();
                                            Console.WriteLine(" _____________________________\n" +
                                                              "| How do you know about this? |\n" +
                                                              " --v--------------------------");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "/                                                                      \\\n" +
                                                              "| Earl: Merida mentioned this about me. She didn’t specify why they    |\n" +
                                                              "|       fell out, but she said they had an argument last few days ago  |\n" +
                                                              "|       and that she needed a breather from what happened.             |\n" +
                                                              "\\______________________________________________________________________/\n");
                                            Console.ReadLine();
                                            Console.WriteLine(" ___________________________________________________________________\n" +
                                                              "| What is your relationship with Merida then, you guys seems close? |\n" +
                                                              " --v----------------------------------------------------------------");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "/                                                                      \\\n" +
                                                              "| Earl: I met her through Silvio. Silvio introduced me to her, and we  |\n" +
                                                              "|       became friends. We became closer because she always asked me   |\n" +
                                                              "|       about my travels overseas.                                     |\n" +
                                                              "\\______________________________________________________________________/\n");
                                            Console.ReadLine();
                                            minutes += random.Next(1, 3);
                                            if (minutes >= 60)
                                            {
                                                hour += 1;
                                                minutes = minutes - 60;
                                            }
                                            if (hour > 12)
                                            {
                                                hour = hour - 12;
                                                TimeReader = "PM";
                                            }
                                            if (minutes < 10)
                                            {
                                                Minutereader = "0" + minutes;

                                            }
                                            else
                                            {
                                                Minutereader = minutes.ToString();
                                            }
                                            Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
                                        }
                                        else if (EarlChoice == "c")
                                        {
                                            Console.WriteLine(" __________________________________________\n" +
                                                              "| What were you doing during the brown-out |\n" +
                                                              " --v---------------------------------------");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "/                                                                      \\\n" +
                                                              "| Earl: I should be asking you that question since you were especially |\n" +
                                                              "|       next to the body when the lights turned on. I’m not spilling   |\n" +
                                                              "|       anything I have done; my conscience is clear.                  |\n" +
                                                              "\\______________________________________________________________________/\n");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "| However, you were also in the lobby when the lights turned on, so you|\n" +
                                                              "| are also a prime suspect in my case.                                 |\n" +
                                                              " --v-------------------------------------------------------------------");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "/                                                                      \\\n" +
                                                              "| Earl: Fine. During the performance, I got bored since I'm not really |\n" +
                                                              "|       a fan of the arts. I only wanted wealth, so I did what I always|\n" +
                                                              "|       do.                                                            |\n" +
                                                              "\\______________________________________________________________________/\n");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "| However, you were also in the lobby when the lights turned on, so you|\n" +
                                                              "| are also a prime suspect in my case.                                 |\n" +
                                                              " --v-------------------------------------------------------------------");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "/                                                                      \\\n" +
                                                              "| Earl: Smoke a cigar outside. Not only that, but I was also waiting   |\n" +
                                                              "|       for Theodore to come back.                                     |\n" +
                                                              "\\______________________________________________________________________/\n");
                                            Console.ReadLine();
                                            Console.WriteLine(" ____________________________________\n" +
                                                              "| Theodore? Wait, you know Theodore. |\n" +
                                                              " --v---------------------------------");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "/                                                                      \\\n" +
                                                              "| Earl: Of course I do. He is a beneficial errand boy, but you could   |\n" +
                                                              "|       use him better.                                                |\n" +
                                                              "\\______________________________________________________________________/\n");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "| Well, honestly, Theodore seems more stressed because of you, and I’m |\n" +
                                                              "| an excellent boss, unlike someone.                                   |\n" +
                                                              " --v-------------------------------------------------------------------");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "/                                                                      \\\n" +
                                                              "| Earl: Shut it, anyway. I went outside and waited for him, but        |\n" +
                                                              "|       Christine arrived. She was cheery as always, saying hello to   |\n" +
                                                              "|       me, but it was annoying. I told her to go inside as the        |\n" +
                                                              "|       performance was already starting. However, she gave me one of  |\n" +
                                                              "|       those cheesy love poems again. Honestly, that reminds me. I    |\n" +
                                                              "|       gave her a letter back, and she happily went back. I don’t like|\n" +
                                                              "|       it, to be honest.                                              |\n" +
                                                              "\\______________________________________________________________________/\n");
                                            Console.ReadLine();
                                            Console.WriteLine(" _____________________________________________\n" +
                                                              "| You know, Christine is love-stricken on you.|\n" +
                                                              " --v------------------------------------------");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "/                                                                      \\\n" +
                                                              "| Earl: I don’t feel sorry for her anyhow, since it’s becoming… quite  |\n" +
                                                              "|       annoying. Anyway, let's continue with what happened. After a   |\n" +
                                                              "|       minute or so, before Christine went inside, I heard a loud     |\n" +
                                                              "|       thud.                                                          |\n" +
                                                              "\\______________________________________________________________________/\n");
                                            Console.ReadLine();
                                            Console.WriteLine(" ________________\n" +
                                                             "| Like a gunshot? |\n" +
                                                             " --v--------------");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "/                                                                      \\\n" +
                                                              "| Earl: No, it doesn’t seem to look like it. It was rather loud, but   |\n" +
                                                              "|       not that. I came to check on what had happened and saw         |\n" +
                                                              "|       Christine dead there. I heard a commotion in the hallway, so I |\n" +
                                                              "|       tried to go there; however, suddenly, the lights went off.     |\n" +
                                                              "|       Because of the dark, I couldn’t clearly see after a minute or  |\n" +
                                                              "|       so, but once I had become accustomed to the dark, I tried to   |\n" +
                                                              "|       look in the hallway, and there were a lot of figures.          |\n" +
                                                              "\\______________________________________________________________________/\n");
                                            Console.ReadLine();
                                            Console.WriteLine(" __________\n" +
                                                             "| How many? |\n" +
                                                             " --v--------");
                                            Console.ReadLine();
                                            Console.WriteLine(" ______________________________________________________________________\n" +
                                                              "/                                                                      \\\n" +
                                                              "| Earl: About two passed by. I was scared to go in there without proper|\n" +
                                                              "|       vision, so I went back to Christine’s body to inspect what     |\n" +
                                                              "|       really happened. However, the lights finally came back on      |\n" +
                                                              "|       suddenly, and I found you were there next to the body.         |\n" +
                                                              "\\______________________________________________________________________/\n");
                                            Console.ReadLine();
                                            minutes += random.Next(1, 3);
                                            if (minutes >= 60)
                                            {
                                                hour += 1;
                                                minutes = minutes - 60;
                                            }
                                            if (hour > 12)
                                            {
                                                hour = hour - 12;
                                                TimeReader = "PM";
                                            }
                                            if (minutes < 10)
                                            {
                                                Minutereader = "0" + minutes;

                                            }
                                            else
                                            {
                                                Minutereader = minutes.ToString();
                                            }
                                            Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
                                        }
                                        else if (EarlChoice == "d")
                                        {
                                            Console.WriteLine("You said your goodbyes to Earl...");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Kindly input the choices mentioned.");
                                            Console.ReadLine();
                                        }
                                    }
                                }
                                else if (LobbyInterrogation == "c")
                                {
                                    Console.WriteLine("\nYou decided to forego the conversation and you said goodbye to them.\n");
                                    Console.ReadLine();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Kindly input the choices mentioned above.");
                                    Console.ReadLine();
                                }
                            }
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
                                    Console.ReadLine();                                    
                                    room = 1;
                                    break;

                                }
                                else if (LobbySwitchRoom == "b")
                                {
                                    Console.WriteLine("\nHeading to Auditorium...");
                                    minutes += random.Next(1, 3);
                                    if (minutes >= 60)
                                    {
                                        hour += 1;
                                        minutes = minutes - 60;
                                    }
                                    if (hour > 12)
                                    {
                                        hour = hour - 12;
                                        TimeReader = "PM";
                                    }
                                    if (minutes < 10)
                                    {
                                        Minutereader = "0" + minutes;

                                    }
                                    else
                                    {
                                        Minutereader = minutes.ToString();
                                    }
                                    Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
                                    room = 2;
                                    break;
                                }
                                else if (LobbySwitchRoom == "c")
                                {
                                    Console.WriteLine("\nHeading to Hallway...");
                                    minutes += random.Next(1, 3);
                                    if (minutes >= 60)
                                    {
                                        hour += 1;
                                        minutes = minutes - 60;
                                    }
                                    if (hour > 12)
                                    {
                                        hour = hour - 12;
                                        TimeReader = "PM";
                                    }
                                    if (minutes < 10)
                                    {
                                        Minutereader = "0" + minutes;

                                    }
                                    else
                                    {
                                        Minutereader = minutes.ToString();
                                    }
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
                            while (LobbyChoice == "d")
                            { 
                                Console.WriteLine("Here is your inventory:");
                                for (int z = 0; z < Inventory.Length; z++)
                                {
                                    if (Inventory[z] == "" && Inventory[z + 1] == "")
                                    {
                                        break;
                                    }
                                    if (Inventory[z] == "")
                                    {
                                        continue;
                                    }
                                    Console.WriteLine(Inventory[z]);

                                    
                                }

                                Console.WriteLine("Write the indicated number of the clue you want to view otherwise type \"Back\"");
                                Console.Write("Action: ");
                                string InventoryChoice = Console.ReadLine();
                                if (InventoryChoice == "0204" && Inventory[0]!="")
                                {
                                    Console.WriteLine("Detective File Case Report Summary Findings");
                                }
                                else if (InventoryChoice == "7823" && Inventory[1] != "")
                                {
                                    Console.WriteLine("Bullet Summary Findings");
                                }
                                else if (InventoryChoice == "8203" && Inventory[2] != "")
                                {
                                    Console.WriteLine("Blood-stained Letter Summary Findings");
                                }
                                else if (InventoryChoice == "5685" && Inventory[3] != "")
                                {
                                    Console.WriteLine("Schedule Summary Findings");
                                }
                                else if (InventoryChoice == "0370" && Inventory[4] != "")
                                {
                                    Console.WriteLine("Exquisite Paintings Summary Findings");
                                }
                                else if (InventoryChoice == "1488" && Inventory[5] != "")
                                {
                                    Console.WriteLine("Several Footprints Summary Findings");
                                }
                                else if (InventoryChoice == "6179" && Inventory[6] != "")
                                {
                                    Console.WriteLine("First Mirror Summary Findings");
                                }
                                else if (InventoryChoice == "4448" && Inventory[7] != "")
                                {
                                    Console.WriteLine("Sealing Wax Summary Findings");
                                }
                                else if (InventoryChoice == "2490" && Inventory[8] != "")
                                {
                                    Console.WriteLine("Spare Key Summary Findings");
                                }
                                else if (InventoryChoice == "3505" && Inventory[9] != "")
                                {
                                    Console.WriteLine("Old Letter Summary Findings");
                                }
                                else if (InventoryChoice == "0195" && Inventory[10] != "")
                                {
                                    Console.WriteLine("Torn Photograph Summary Findings");
                                }
                                else if (InventoryChoice == "2340" && Inventory[11] != "")
                                {
                                    Console.WriteLine("Journal Summary Findings");
                                }
                                else if (InventoryChoice == "8966" && Inventory[12] != "")
                                {
                                    Console.WriteLine("Eternal Bessotted Music Sheet Summary Findings");
                                }
                                else if (InventoryChoice == "1872" && Inventory[13] != "")
                                {
                                    Console.WriteLine("Set of Metronomes Summary Findings");
                                }
                                else if (InventoryChoice == "4006" && Inventory[14] != "")
                                {
                                    Console.WriteLine("The Cryptic Message of a Love Song Summary Findings");
                                }
                                else if (InventoryChoice == "3891" && Inventory[15] != "")
                                {
                                    Console.WriteLine("Vase of Roses Summary Findings");
                                }
                                else if (InventoryChoice == "0656" && Inventory[16] != "")
                                {
                                    Console.WriteLine("Typewriter with Weird Pamphlet Summary Findings");
                                }
                                else if (InventoryChoice == "1966" && Inventory[17] != "")
                                {
                                    Console.WriteLine("Thin Metal Stick Summary Findings");
                                }
                                else if (InventoryChoice == "6168" && Inventory[18] != "")
                                {
                                    Console.WriteLine("Pliers Summary Findings");
                                }
                                else if (InventoryChoice == "4176" && Inventory[19] != "")
                                {
                                    Console.WriteLine("Strange Bullet Summary Findings");
                                }
                                else if (InventoryChoice == "0657" && Inventory[20] != "")
                                {
                                    Console.WriteLine("Second Mirror Summary Findings");
                                }
                                else if (InventoryChoice == "0445" && Inventory[21] != "")
                                {
                                    Console.WriteLine("Blueprint of the Citadel Summary Findings");
                                }
                                else if (InventoryChoice == "1729" && Inventory[22] != "")
                                {
                                    Console.WriteLine("Dead Body of Quentin Summary Findings");
                                }
                                else if (InventoryChoice == "9485" && Inventory[23] != "")
                                {
                                    Console.WriteLine("Ferulle Summary Findings");
                                }
                                else if (InventoryChoice == "6695" && Inventory[24] != "")
                                {
                                    Console.WriteLine("Logo of Silvio Addams Summary Findings");
                                }
                                else if (InventoryChoice == "6569" && Inventory[25] != "")
                                {
                                    Console.WriteLine("Third Mirror Summary Findings");
                                }
                                else if (InventoryChoice == "3529" && Inventory[26] != "")
                                {
                                    Console.WriteLine("Scented Charm Letter Findings");
                                }
                                else if (InventoryChoice == "Back"||InventoryChoice=="back")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("It seems you wrote it wrong. Please try again.");
                                }
                            }
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
                        Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗\n" +
                                          "║The auditorium stretches out before you, an expansive space filled with silence, stripped of the vibrant laughter and spirited            ║\n" +
                                          "║performances that once animated its walls. As you tread softly along the velvet carpet lining the aisle, your gaze sweeps over the        ║\n" +
                                          "║scattered remnants of a past event—forgotten programs, half-empty cups, and crumpled ticket stubs strewn carelessly across the floor,     ║\n" +
                                          "║echoes of the audience that once filled these seats with life. At the front of the auditorium, basking in the soft glow of the overhead   ║\n" +
                                          "║lights, you notice two figures standing near the stage. What would you like to do?                                                        ║\n" +
                                          "╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                        Console.WriteLine("\n\ta) Inquire People\n\tb) Enter a different room\n\tc) Check Inventory");
                        Console.Write("\nAction: ");
                        string AuditoriumChoice = Console.ReadLine();
                        if (AuditoriumChoice == "a")
                        {
                            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐\n" +
                                              "|You caught sight of the two figures in the dimly lit room, their silhouettes reminiscent of the musicians who had captivated the audience |\n" +
                                              "|earlier in the evening. A rush of excitement coursed through you as you approached them, eager to engage in conversation, hoping they     |\n" +
                                              "|might share insights or stories.                                                                                                          |\n" +
                                              "└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                            Console.WriteLine(" ______\n" +
                                              "|Hello.|\n" +
                                              " -v----");
                            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐\n" +
                                              "|The musicians turned to you, their expressions a blend of surprise and guarded curiosity. They exchanged a glance as if silently assessing|\n" +
                                              "|the situation. Undeterred, you stepped closer and posed your question, feeling anticipation and hope however, one of the musicians replied|\n" +
                                              "|their tone warm yet cautious.                                                                                                             |\n" +
                                              "└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                            while (AuditoriumChoice == "a")
                            {
                                Console.WriteLine("What would you like to know?");
                                Console.WriteLine("\n\ta) Do you know any information?\n\tb) What do you think about... ?\n\tc) Nevermind");
                                Console.Write("Action: ");
                                string AuditoriumInterrogation = Console.ReadLine();

                                if(AuditoriumInterrogation == "a")
                                {
                                    Console.WriteLine(" _________________________________________________________________\n" +
                                                      "| Can I ask if you guys have any information regarding the event? |\n" +
                                                      " -v---------------------------------------------------------------");
                                    Console.ReadLine();
                                    Console.WriteLine(" ______________________________________________________________________\n" +
                                                      "/                                                                      \\\n" +
                                                      "| Musician: I dont know the whole story but I think this can help.     |\n" +
                                                      "\\______________________________________________________________________/\n");
                                    Console.ReadLine();
                                    Console.WriteLine(" _____________\n" +
                                                      "| A Schedule? |\n" +
                                                      " -v-----------");
                                    Console.ReadLine();
                                    Console.WriteLine(" ______________________________________________________________________\n" +
                                                      "/                                                                      \\\n" +
                                                      "| Musician: Yes, this is the flow of our program. I hope this helps I  |\n" +
                                                      "|           guess.                                                     |\n" +
                                                      "\\______________________________________________________________________/\n");
                                    Console.ReadLine();

                                    Console.WriteLine("                        You obtained \"Schedule\"");
                                    Inventory[3] = "> (5685) Schedule"; //Schedule Clue
                                    minutes += random.Next(1, 3);
                                    if (minutes >= 60)
                                    {
                                        hour += 1;
                                        minutes = minutes - 60;
                                    }
                                    if (hour > 12)
                                    {
                                        hour = hour - 12;
                                        TimeReader = "PM";
                                    }
                                    if (minutes < 10)
                                    {
                                        Minutereader = "0" + minutes;

                                    }
                                    else
                                    {
                                        Minutereader = minutes.ToString();
                                    }
                                    Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
                                }
                                else if (AuditoriumInterrogation=="b")
                                {
                                    Console.WriteLine(" _________________________________________________________________\n" +
                                                      "| What do you think about the people working in the Citadel?      |\n" +
                                                      " -v---------------------------------------------------------------");
                                    Console.ReadLine();
                                    Console.WriteLine(" ______________________________________________________________________\n" +
                                                     "/                                                                      \\\n" +
                                                     "| Musician 1: I think Leon is very kind-hearted and noble. He truly    |\n" +
                                                     "|             cares about the health and well-being of the performers  |\n" +
                                                     "|             and every guest who comes to the Citadel.                |\n" +
                                                     "\\______________________________________________________________________/\n");
                                    Console.ReadLine();

                                    Console.WriteLine(" ______________________________________________________________________\n" +
                                                     "/                                                                      \\\n" +
                                                     "| Musician 2: Merida is also very kind and loving. Not only is she one |\n" +
                                                     "|             of the first performers, but she also serves as a role   |\n" +
                                                     "|             model and an example in the field of musical arts.       |\n" +
                                                     "\\______________________________________________________________________/\n");
                                    Console.ReadLine();

                                    Console.WriteLine(" ______________________________________________________________________\n" +
                                                     "/                                                                      \\\n" +
                                                     "| Musician 1: When paired with Silvio, they make an incredible duo.    |\n" +
                                                     "|           Silvio may be a late bloomer back in the days, but he is a |\n" +
                                                     "|           talented individual.                                       |\n" +
                                                     "\\______________________________________________________________________/\n");
                                    Console.ReadLine();

                                    Console.WriteLine(" ______________________________________________________________________\n" +
                                                     "/                                                                      \\\n" +
                                                     "| Musician 1: Julio is a new recruit who tends to be quite anxious.    |\n" +
                                                     "|             However, he is an amazing magician who always brings     |\n" +
                                                     "|             surprises and joy to us                                  |\n" +
                                                     "\\______________________________________________________________________/\n");
                                    Console.ReadLine();
                                    minutes += random.Next(1, 3);
                                    if (minutes >= 60)
                                    {
                                        hour += 1;
                                        minutes = minutes - 60;
                                    }
                                    if (hour > 12)
                                    {
                                        hour = hour - 12;
                                        TimeReader = "PM";
                                    }
                                    if (minutes < 10)
                                    {
                                        Minutereader = "0" + minutes;

                                    }
                                    else
                                    {
                                        Minutereader = minutes.ToString();
                                    }
                                    Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
                                }
                                else if (AuditoriumInterrogation=="c")
                                {
                                    Console.WriteLine("You said your goodbyes to the musicians. . .");
                                    Console.ReadLine();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("\nKindly input the choices mentioned above.\n");
                                    Console.ReadLine();
                                }
                            }
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
                                    if (minutes >= 60)
                                    {
                                        hour += 1;
                                        minutes = minutes - 60;
                                    }
                                    if (hour > 12)
                                    {
                                        hour = hour - 12;
                                        TimeReader = "PM";
                                    }
                                    if (minutes < 10)
                                    {
                                        Minutereader = "0" + minutes;

                                    }
                                    else
                                    {
                                        Minutereader = minutes.ToString();
                                    }
                                    Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
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
                        Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗\n" +
                                          "║You find yourself in a long corridor adorned with various wall paintings. The brown flooring and unique textiles enhance the hallway's    ║\n" +
                                          "║ambiance. Several doors lead to other rooms, each with its distinct design. The left door exudes an air of elegance, featuring an         ║\n" +
                                          "║exquisite display and a sign that reads \"General Director's Office.\" Nearby, you can hear the sound of a piano playing from another     ║\n" +
                                          "║room. At the far left end of the hallway is a heavily guarded metallic door, while a plain wooden door stands directly across from it.    ║\n"+
                                          "╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine("\n\ta) Inspect the room for clues\n\tb) Enter a different room\n\tc) Check Inventory");
                        Console.Write("\nAction: ");
                        string HallwayChoice = Console.ReadLine();

                        if (HallwayChoice == "a")
                        {
                            while (HallwayChoice == "a") //still in progress.
                            {
                                Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐\n" +
                                                  "|You continued searching for clues as you took in the hallway's disarray. Exquisite paintings adorned the right wall, their ornate frames  |\n" +
                                                  "|showcasing various scenes. The green carpet beneath you looked messy and crinkled, evidence of heavy foot traffic. Small boxes of props   |\n" +
                                                  "|were scattered in the corner; some were left open and revealing intriguing items.                                                         |\n" +
                                                  "└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                                Console.WriteLine("Where would you like to begin?");
                                Console.WriteLine("\n\ta) Exquisite Paintings\n\tb) Look into the Carpets\n\tc) Explore the disarrayed boxes\n\td) Return Back");
                                Console.Write("\nAction: ");
                                string HallwayRoom = Console.ReadLine();

                                if (HallwayRoom == "a")
                                {
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|You decided to look at the paintings, which are a history of the      |\n" +
                                                      "|Citadel Opera House and Three paintings were involved.                |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();

                                    Console.WriteLine("                     ___________________________________________________\n" +
                                                      "                    |December 20, 1903... This painting must be age-old.|\n" +
                                                      "                     ------------------------------------------------v--");
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|The first contained three prominent families, and below the corner of |\n" +
                                                      "|the painting, it said the letters G, A, and V.                        |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("  _____________________________________________________________________\n" +
                                                      " |I wondered what it means. Does it involve the people in the painting?|\n" +
                                                      "  ------------------------------------------------------------------v--");
                                    Console.ReadLine();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|The second painting contains the first crew performers, and you       |\n" +
                                                      "|recognize Leon in the middle of the painting. He was surrounded by    |\n" +
                                                      "|people who were familiar to you. There was Merida together, who seemed|\n" +
                                                      "|to be with Christine, Silvio was next to Leon, and Earl was on the far|\n" +
                                                      "| corner. Nobles also surrounded them and dressed elegantly.           |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|The third painting is recent and involves all the performers of the   |\n" +
                                                      "|past month. Merida and Silvio were playing their instruments together |\n" +
                                                      "|with other musicians. There were also acrobats, clowns, and an animal |\n" +
                                                      "|trainer in the middle, which seemed to be the newest addition to the  |\n" +
                                                      "|performances; however, you recognized a young individual's face. It   |\n" +
                                                      "|seemed to be Julio, and he was holding out what appeared to be a deck |\n" +
                                                      "|of cards.                                                             |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("      _________________________________________________________________\n" +
                                                      "     |If I remember correctly, the Citadel's first performers were only|\n" +
                                                      "     |musicians. However, as he mentioned in our past discussions, Leon|\n" +
                                                      "     |                      expanded and explored new talents overseas.|\n" +
                                                      "      --------------------------------------------------------------v--");
                                    Console.ReadLine();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|You preserved this information in mind as it might be another helpful |\n" +
                                                      "|clue.                                                                 |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("                 You found \"Historical Paintings.\"");
                                    Console.ReadLine();
                                    Inventory[4] = "> (0370) Historical Paintings"; //Historical Paintings Clue
                                    minutes += random.Next(1, 3);
                                    if (minutes >= 60)
                                    {
                                        hour += 1;
                                        minutes = minutes - 60;
                                    }
                                    if (hour > 12)
                                    {
                                        hour = hour - 12;
                                        TimeReader = "PM";
                                    }
                                    if (minutes < 10)
                                    {
                                        Minutereader = "0" + minutes;

                                    }
                                    else
                                    {
                                        Minutereader = minutes.ToString();
                                    }
                                    Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);

                                }
                                else if (HallwayRoom == "b")
                                {
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|The carpet, once luxurious and meticulously arranged, now lay in      |\n" +
                                                      "|disarray, its fibers ruffled and stained. It was intended to exude an |\n" +
                                                      "|air of grandeur and cleanliness, but instead, it told a story of      |\n" +
                                                      "|neglect. Scattered across its surface were numerous footprints, each a|\n" +
                                                      "|silent witness to the chaos unfolding. The once-pristine rug had      |\n" +
                                                      "|become a patchwork of disturbances, hinting at a sudden commotion that|\n" +
                                                      "|had disrupted its intended elegance.                                  |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("    ___________________________________________________________________\n" +
                                                      "   |It seems that many people have passed this way during the brownout.|\n" +
                                                      "    ----------------------------------------------------------------v--");
                                    Console.ReadLine();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|You considered this, knowing it might be significant.                 |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("                 You found \"Several Footprints.\"");
                                    Console.ReadLine();
                                    Inventory[5] = "> (1488) Several Footprints";//Several Footprints Clue
                                    minutes += random.Next(1, 3);
                                    if (minutes >= 60)
                                    {
                                        hour += 1;
                                        minutes = minutes - 60;
                                    }
                                    if (hour > 12)
                                    {
                                        hour = hour - 12;
                                        TimeReader = "PM";
                                    }
                                    if (minutes < 10)
                                    {
                                        Minutereader = "0" + minutes;

                                    }
                                    else
                                    {
                                        Minutereader = minutes.ToString();
                                    }
                                    Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
                                }
                                else if (HallwayRoom == "c")
                                {
                                    Console.WriteLine("                                    ___________________________________\n" +
                                                      "                                   |Why does this box look so familiar?|\n" +
                                                      "                                    --------------------------------v--");
                                    Console.ReadLine();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|The box catches your eye with its resemblance to a small black chest, |\n" +
                                                      "|though notably more petite than a typical large chest you might have  |\n" +
                                                      "|seen before. Lifting the lid reveals an array of trinkets nestled     |\n" +
                                                      "|inside—the marked ropes, adorned silk scarves glistening softly, and a|\n" +
                                                      "|handful of coins that chime gently against one another. Several       |\n" +
                                                      "|mirrors are Scattered among these treasures, each featuring intricate |\n" +
                                                      "|designs hinting at artistry and craftsmanship. However, a few of these|\n" +
                                                      "| mirrors lie shattered on the floor, their delicate shards catching   |\n" +
                                                      "|the light dishearteningly.                                            |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("                           ____________________________________________\n" +
                                                      "                          |I'll take this one since it's in good shape.|\n" +
                                                      "                           -----------------------------------------v--");
                                    Console.ReadLine();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|You carefully select one of the unbroken mirrors, admiring its glossy |\n" +
                                                      "|surface and ornate frame. This item could prove valuable in your      |\n" +
                                                      "|upcoming investigation.                                               |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("                  You have obtained \"Mirror (I).\"");
                                    Console.ReadLine();
                                    Inventory[6] = "> (6179) Mirror (I)";//First Mirror Clue
                                    minutes += random.Next(1, 3);
                                    if (minutes >= 60)
                                    {
                                        hour += 1;
                                        minutes = minutes - 60;
                                    }
                                    if (hour > 12)
                                    {
                                        hour = hour - 12;
                                        TimeReader = "PM";
                                    }
                                    if (minutes < 10)
                                    {
                                        Minutereader = "0" + minutes;

                                    }
                                    else
                                    {
                                        Minutereader = minutes.ToString();
                                    }
                                    Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
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
                                    Console.WriteLine("\nStaying in the Hallway...");
                                    break;
                                }
                                else if (HallwaySwitchRoom == "b")
                                {
                                    Console.WriteLine("\nHeading to General Director Office...");
                                    minutes += random.Next(1, 3);
                                    if (minutes >= 60)
                                    {
                                        hour += 1;
                                        minutes = minutes - 60;
                                    }
                                    if (hour > 12)
                                    {
                                        hour = hour - 12;
                                        TimeReader = "PM";
                                    }
                                    if (minutes < 10)
                                    {
                                        Minutereader = "0" + minutes;

                                    }
                                    else
                                    {
                                        Minutereader = minutes.ToString();
                                    }
                                    Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
                                    room = 4;
                                    break;
                                }
                                else if (HallwaySwitchRoom == "c")
                                {
                                    Console.WriteLine("\nHeading to Practice Room...");
                                    minutes += random.Next(1, 3);
                                    if (minutes >= 60)
                                    {
                                        hour += 1;
                                        minutes = minutes - 60;
                                    }
                                    if (hour > 12)
                                    {
                                        hour = hour - 12;
                                        TimeReader = "PM";
                                    }
                                    if (minutes < 10)
                                    {
                                        Minutereader = "0" + minutes;

                                    }
                                    else
                                    {
                                        Minutereader = minutes.ToString();
                                    }
                                    Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
                                    room = 5;
                                    break;
                                }
                                else if (HallwaySwitchRoom == "d")
                                {
                                    Console.WriteLine("\nHeading to Generator...");
                                    minutes += random.Next(1, 3);
                                    if (minutes >= 60)
                                    {
                                        hour += 1;
                                        minutes = minutes - 60;
                                    }
                                    if (hour > 12)
                                    {
                                        hour = hour - 12;
                                        TimeReader = "PM";
                                    }
                                    if (minutes < 10)
                                    {
                                        Minutereader = "0" + minutes;

                                    }
                                    else
                                    {
                                        Minutereader = minutes.ToString();
                                    }
                                    Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
                                    room = 6;
                                    break;
                                }
                                else if (HallwaySwitchRoom == "e")
                                {
                                    Console.WriteLine("\nHeading to Backstage...");
                                    minutes += random.Next(1, 3);
                                    if (minutes >= 60)
                                    {
                                        hour += 1;
                                        minutes = minutes - 60;
                                    }
                                    if (hour > 12)
                                    {
                                        hour = hour - 12;
                                        TimeReader = "PM";
                                    }
                                    if (minutes < 10)
                                    {
                                        Minutereader = "0" + minutes;

                                    }
                                    else
                                    {
                                        Minutereader = minutes.ToString();
                                    }
                                    Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
                                    room = 7;
                                    break;
                                }
                                else if (HallwaySwitchRoom == "f")
                                {
                                    Console.WriteLine("\nHeading to Lobby...");
                                    minutes += random.Next(1, 3);
                                    if (minutes >= 60)
                                    {
                                        hour += 1;
                                        minutes = minutes - 60;
                                    }
                                    if (hour > 12)
                                    {
                                        hour = hour - 12;
                                        TimeReader = "PM";
                                    }
                                    if (minutes < 10)
                                    {
                                        Minutereader = "0" + minutes;

                                    }
                                    else
                                    {
                                        Minutereader = minutes.ToString();
                                    }
                                    Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
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
                        Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗\n" +
                                          "║A sense of awe washed over you as you stepped through the grand door of an exquisitely arranged office. To your right stood a towering    ║\n" +
                                          "║bookshelf, a testament to knowledge and elegance. In the heart of the room, your friend Leon Grandet, a figure of undeniable authority,   ║\n" +
                                          "║was seated at his desk, exuding grace. Behind him, a vast window adorned with regal dark blue and gold accents framed a breathtaking view ║\n" +
                                          "║of the city. He was engrossed in writing, his focus unwavering.                                                                           ║\n" +
                                          "╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                        Console.WriteLine("What would you like to do here?");
                        Console.WriteLine("\n\ta) Inspect the room for clues\n\tb) Inquire People\n\tc) Enter a different room\n\td) Check Inventory");
                        Console.Write("\nAction: ");
                        string GeneralDirectorOfficeChoice = Console.ReadLine();

                        if (GeneralDirectorOfficeChoice == "a")
                        {
                            while (GeneralDirectorOfficeChoice == "a")
                            {
                                Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┐\n" +
                                                  "|After seeking Leon's permission to investigate the room, he allowed you to explore leisurely. As you stepped further in, you were         |\n" +
                                                  "|immediately drawn to a peculiar chest resting atop his desk, its ornate carvings and unique design hinting at secrets. Surrounding you    |\n" +
                                                  "|were several keys meticulously displayed on the walls, each seemingly carrying its own story. A towering bookshelf stood to your right,   |\n" +
                                                  "|its shelves lined with books and documents that promised a wealth of valuable knowledge.                                                  |\n" +
                                                  "└──────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────┘");
                                Console.WriteLine("Where would you like to delve into?");
                                Console.WriteLine("\n\ta) The office desk of Leon\n\tb) The keys hanging on the wall\n\tc) Large Bookshelves\n\td) Return Back");
                                Console.Write("\nAction: ");
                                string GeneralDirectorOfficeRoom = Console.ReadLine();

                                if (GeneralDirectorOfficeRoom == "a")
                                {
                                    while (GeneralDirectorOfficeRoom == "a")
                                    {
                                        Console.WriteLine("\n Which one would you like to look first?");
                                        Console.WriteLine("\n\ta) Chest\n\tb) Desk Papers\n\tc) Back");
                                        Console.Write("Action: ");
                                        string GeneralDirectorOfficeRoomChoiceDetail = Console.ReadLine();

                                        if (GeneralDirectorOfficeRoomChoiceDetail == "a")
                                        {
                                            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                              "|You stumbled upon a small, intricately carved wooden box resting on   |\n" +
                                                              "|the desk beside a bottle of dark ink and a finely crafted quill. As   |\n" +
                                                              "|you lifted the box, its smooth surface felt warm against your palm,   |\n" +
                                                              "|perfectly contoured to fit comfortably. Carefully, you opened the lid,|\n" +
                                                              "| revealing a concealed treasure inside—a glinting stamp.              |\n" +
                                                              "└──────────────────────────────────────────────────────────────────────┘");
                                            Console.ReadLine();
                                            Console.WriteLine("                                                 ______________________\n" +
                                                              "                                                |Is that a sealing wax?|\n" +
                                                              "                                                 -------------------v--");
                                            Console.ReadLine();
                                            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                              "|Indeed, the sealing wax lay nestled within the box, intended for      |\n" +
                                                              "|impressing documents with authority. Its surface was adorned with an  |\n" +
                                                              "|elaborate Lion Crest, depicting strength and nobility. As you         |\n" +
                                                              "|carefully examined the crest, you couldn't help but think this detail |\n" +
                                                              "|could prove significant in your journey.                              |" +
                                                              "└──────────────────────────────────────────────────────────────────────┘\n");
                                            Console.ReadLine();
                                            Console.WriteLine("                   You have obtained \"Sealing Wax.\"");
                                            Console.ReadLine();
                                            Inventory[7] = "> (4448) Sealing Wax";//Sealing Wax Clue
                                            minutes += random.Next(1, 3);
                                            if (minutes >= 60)
                                            {
                                                hour += 1;
                                                minutes = minutes - 60;
                                            }
                                            if (hour > 12)
                                            {
                                                hour = hour - 12;
                                                TimeReader = "PM";
                                            }
                                            if (minutes < 10)
                                            {
                                                Minutereader = "0" + minutes;

                                            }
                                            else
                                            {
                                                Minutereader = minutes.ToString();
                                            }
                                            Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
                                        }
                                        else if (GeneralDirectorOfficeRoomChoiceDetail == "b")
                                        {
                                            while (GeneralDirectorOfficeRoomChoiceDetail == "b")
                                            {
                                                Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                                  "|You gazed upon an elegant chest that seems to locked. It seems you    |\n" +
                                                                  "|need a 4-letter passcode to unlock it. You tried to input the code    |\n" +
                                                                  "|below. (Input the code in uppercase; If you want to return type \"Back\"|\n" +
                                                                  "└──────────────────────────────────────────────────────────────────────┘");
                                                Console.Write("Code: ");
                                                string chestcode = Console.ReadLine();
                                                if (chestcode == "DWMP")
                                                {
                                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                                      "|A musty scent wafted into the air as you deftly opened the chest,     |\n" +
                                                                      "|revealing its hidden treasures. Nestled inside was an ancient         |\n" +
                                                                      "|document, its edges frayed and yellowed with age. A letter, the ink   |\n" +
                                                                      "|slightly faded, was addressed to Grandet. The wax stamp that once     |\n" +
                                                                      "|sealed it lay crumbled nearby, suggesting it had been read and        |\n" +
                                                                      "|treasured by someone long ago.                                        |\n" +
                                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                                    Console.ReadLine();
                                                    Console.WriteLine("      _________________________________________________________________\n" +
                                                                      "     |This might cross my dear friend's boundaries, but my curiosity is|\n" +
                                                                      "     |                                                      getting me.|\n" +
                                                                      "      --------------------------------------------------------------v--");
                                                    Console.ReadLine();
                                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                                      "|Carefully extracting the letter, you traced your fingertips over the  |\n" +
                                                                      "|fragile parchment, committing its elegant script to memory. After     |\n" +
                                                                      "|savoring the moment, you gently folded the letter and returned it to  |\n" +
                                                                      "|its resting place, locking the chest securely once more.              |\n" +
                                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                                    Console.ReadLine();

                                                    Console.WriteLine("                     You discovered an \"Old Letter\"");
                                                    Console.ReadLine();
                                                    Inventory[9] = "> (3505) Old Letter";//Old Letter clue
                                                    minutes += random.Next(1, 3);
                                                    if (minutes >= 60)
                                                    {
                                                        hour += 1;
                                                        minutes = minutes - 60;
                                                    }
                                                    if (hour > 12)
                                                    {
                                                        hour = hour - 12;
                                                        TimeReader = "PM";
                                                    }
                                                    if (minutes < 10)
                                                    {
                                                        Minutereader = "0" + minutes;

                                                    }
                                                    else
                                                    {
                                                        Minutereader = minutes.ToString();
                                                    }
                                                    Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
                                                }
                                                else if(chestcode == "Back")
                                                {
                                                    break;
                                                }
                                                else 
                                                {
                                                    Console.WriteLine("\n(!) The chest didn't open. (Hint: It seems you need to find a clue somewhere within the room related to this.)\n");
                                                    Console.ReadLine();
                                                }
                                            }
                                        }
                                        else if (GeneralDirectorOfficeRoomChoiceDetail == "c")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Kindly input the choices mentioned above.");
                                        }
                                    }
                                }
                                else if (GeneralDirectorOfficeRoom == "b")
                                {
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|As you drew closer to the wall, your eyes were immediately drawn to a |\n" +
                                                      "|fascinating assortment of keys suspended from it. Each key appeared   |\n" +
                                                      "|unique: some proudly displayed labels, while others were merely hooks |\n" +
                                                      "|left bare, absent of any metal companions. You recalled that each room|\n" +
                                                      "|held its specific spare key, yet their differences piqued your        |\n" +
                                                      "|interest.                                                             |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("       ________________________________________________________________\n" +
                                                      "      |This one is indeed a spare, but I can't help but wonder why its |\n" +
                                                      "      |                                           design is so unusual?|" +
                                                      "       -------------------------------------------------------------v--");
                                    Console.ReadLine();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|Amidst the collection, your gaze landed on a solitary key that bore no|\n" +
                                                      "|label atop its head. Intrigued by its enigmatic appearance, you       |\n" +
                                                      "|couldn't resist the urge to take it, convinced it might prove helpful |\n" +
                                                      "|in your exploration.                                                  |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("                   You obtained a \"Spare Key.\"");
                                    Console.ReadLine();
                                    Inventory[8] = "> (2490) Spare Key"; //Spare Key Clue
                                    minutes += random.Next(1, 3);
                                    if (minutes >= 60)
                                    {
                                        hour += 1;
                                        minutes = minutes - 60;
                                    }
                                    if (hour > 12)
                                    {
                                        hour = hour - 12;
                                        TimeReader = "PM";
                                    }
                                    if (minutes < 10)
                                    {
                                        Minutereader = "0" + minutes;

                                    }
                                    else
                                    {
                                        Minutereader = minutes.ToString();
                                    }
                                    Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
                                }
                                else if (GeneralDirectorOfficeRoom == "c")
                                {
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|As you approached the bookshelf, the neatly arranged books drew your  |\n" +
                                                      "|attention. One specific volume caught your eye, and a delicate piece  |\n" +
                                                      "|of paper slipped out as you lifted it.                                |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("                                                          _____________\n" +
                                                      "                                                         |A photograph?|\n" +
                                                      "                                                          ----------v--");
                                    Console.ReadLine();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|You knelt to pick it up and discovered it was a torn piece. Despite   |\n" +
                                                      "|its frayed edges, it captured two smiling children from a wealthy     |\n" +
                                                      "|family. Flipping it over revealed a series of strange symbols arranged|\n" +
                                                      "|in an intriguing pattern.                                             |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|Searching the spot where the photograph had fallen, you discovered a  |\n" +
                                                      "|journal filled with the same symbols on the picture.                  |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|Recognizing their potential significance, you carefully placed the    |\n" +
                                                      "|torn photograph and the journal into your inventory, ready to continue|\n" +
                                                      "|exploring.                                                            |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();

                                    Console.WriteLine("             You obtained \"Torn Photograph\" and \"Journal.”");
                                    Console.ReadLine();
                                    Inventory[10] = "> (0195) Torn Paragraph"; //Torn Photograph Clue
                                    Inventory[11] = "> (2340) Journal";//Journal cLUE
                                    Inventory[9] = "> (3505) Old Letter";//Old Letter clue
                                    minutes += random.Next(1, 3);
                                    if (minutes >= 60)
                                    {
                                        hour += 1;
                                        minutes = minutes - 60;
                                    }
                                    if (hour > 12)
                                    {
                                        hour = hour - 12;
                                        TimeReader = "PM";
                                    }
                                    if (minutes < 10)
                                    {
                                        Minutereader = "0" + minutes;

                                    }
                                    else
                                    {
                                        Minutereader = minutes.ToString();
                                    }
                                    Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
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
                            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                              "|As you entered the office, you noticed Leon seated at his cluttered   |\n" +
                                              "|desk, surrounded by a sea of official documents. The soft scratch of  |\n" +
                                              "|his pen on paper punctuated the otherwise quiet room as he focused on |\n" +
                                              "|signing a series of forms. A desire for information nudged at you, and|\n" +
                                              "|you approached him, hoping to engage in a friendly conversation. You  |\n" +
                                              "|stepped closer, your voice breaking the stillness.                    |\n" +
                                              "└──────────────────────────────────────────────────────────────────────┘");
                            Console.ReadLine();
                            Console.WriteLine(" __________\n" +
                                              "|Hey, Leon?|\n" +
                                              " --v-------");
                            Console.ReadLine();
                            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                              "|At the sound of your voice, Leon looked up from his work, a warm smile|\n" +
                                              "|spreading. He momentarily set his pen down, giving you his undivided  |\n" +
                                              "|attention.                                                            |\n" +
                                              "└──────────────────────────────────────────────────────────────────────┘");
                            Console.ReadLine();
                            while (GeneralDirectorOfficeChoice=="b")
                            Console.WriteLine(" ______________________________________________________________________\n" +
                                              "/                                                                      \\\n" +
                                              "| Julio: You want to ask me something? What would you like to know?    |\n" +
                                              "\\______________________________________________________________________/\n");

                            Console.WriteLine("\n\ta) Who are you?\n\tb) What is your relationship with everyone\n\tc)What were you doing during the brown-out\n\td) Nevermind");
                            Console.Write("Action: ");
                            string GeneralDirectorOfficeInterrogation = Console.ReadLine();

                            if(GeneralDirectorOfficeInterrogation== "a")
                            {
                                Console.WriteLine(" _____________\n" +
                                                  "| How are you |\n" +
                                                  " -v-----------");
                                Console.ReadLine();
                                Console.WriteLine(" ______________________________________________________________________\n" +
                                                  "/                                                                      \\\n" +
                                                  "| Leon: I’ve been doing well with my recent happenings, however. I     |\n" +
                                                  "|       didn’t think such a tragedy would strike on this good day.     |\n" +
                                                  "|       Christine has been one of the kindest people I have met, and   |\n" +
                                                  "|       she died at the hands of a person we don’t know.               |\n" +
                                                  "\\______________________________________________________________________/\n");
                                Console.ReadLine();
                                Console.WriteLine(" ______________________________________________\n" +
                                                  "| Can you tell me how you started the citadel? |\n" +
                                                  " -v--------------------------------------------");
                                Console.ReadLine();
                                Console.WriteLine(" ______________________________________________________________________\n" +
                                                  "/                                                                      \\\n" +
                                                  "| Leon: I built this citadel as an inheritance from my family. However,|\n" +
                                                  "|       I built it for inheritance and as a place where people feel at |\n" +
                                                  "|       home. I started in a relatively poor state. Our family wasn’t  |\n" +
                                                  "|       that wealthy, but since my dad is friends with Silvio’s family |\n" +
                                                  "|       and had connections with Earl’s family, we became prominent in |\n" +
                                                  "|       society later on and built this citadel thanks to them.        |\n" +
                                                  "\\______________________________________________________________________/\n");
                                Console.ReadLine();
                                minutes += random.Next(1, 3);
                                if (minutes >= 60)
                                {
                                    hour += 1;
                                    minutes = minutes - 60;
                                }
                                if (hour > 12)
                                {
                                    hour = hour - 12;
                                    TimeReader = "PM";
                                }
                                if (minutes < 10)
                                {
                                    Minutereader = "0" + minutes;

                                }
                                else
                                {
                                    Minutereader = minutes.ToString();
                                }
                                Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);

                            }
                            else if (GeneralDirectorOfficeInterrogation == "b")
                            {
                                Console.WriteLine(" __________________________________________\n" +
                                                  "| What is your relationship with everyone? |\n" +
                                                  " -v----------------------------------------");
                                Console.ReadLine();
                                Console.WriteLine(" ______________________________________________________________________\n" +
                                                  "/                                                                      \\\n" +
                                                  "| Leon: I feel like a father figure of the crew; not only am I the     |\n" +
                                                  "|       oldest, but I’m coming at the age where I’m almost going to    |\n" +
                                                  "|       retire.                                                        |\n" +
                                                  "\\______________________________________________________________________/\n");
                                Console.ReadLine();
                                Console.WriteLine(" ______________________________________________________________________\n" +
                                                  "| This might bec too personal but do you have any bad relationships    |\n" +
                                                  "| with anyone?                                                         |\n" +
                                                  " -v--------------------------------------------------------------------");
                                Console.ReadLine();
                                Console.WriteLine(" ______________________________________________________________________\n" +
                                                  "/                                                                      \\\n" +
                                                  "| Leon: Well, there is none I can think of. Everything is good with my |\n" +
                                                  "|       relationship with everyone. Earl, Silvio, and I are still      |\n" +
                                                  "|       friends as of today. If you want to know, we were childhood    |\n" +
                                                  "|       friends back then.                                             |\n" +
                                                  "\\______________________________________________________________________/\n");
                                Console.ReadLine();
                                Console.WriteLine(" ______________________________________________________\n" +
                                                  "| Have you seen anyone who is somewhat off than usual? |\n" +
                                                  " -v----------------------------------------------------");
                                Console.ReadLine();
                                Console.WriteLine(" ______________________________________________________________________\n" +
                                                 "/                                                                      \\\n" +
                                                 "| Leon: Before the anniversary, hmm… I did think that Earl was somewhat|\n" +
                                                 "|       off than usual; he was instead distracted. He was usually      |\n" +
                                                 "|       expressionless, but he was rather sad the other day. I don’t   |\n" +
                                                 "|       know what happened to him, but I think it’s probably because of|\n" +
                                                 "|       the controversy.                                               |\n" +
                                                 "\\______________________________________________________________________/\n");
                                Console.ReadLine();
                                minutes += random.Next(1, 3);
                                if (minutes >= 60)
                                {
                                    hour += 1;
                                    minutes = minutes - 60;
                                }
                                if (hour > 12)
                                {
                                    hour = hour - 12;
                                    TimeReader = "PM";
                                }
                                if (minutes < 10)
                                {
                                    Minutereader = "0" + minutes;

                                }
                                else
                                {
                                    Minutereader = minutes.ToString();
                                }
                                Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
                            }
                            else if (GeneralDirectorOfficeInterrogation == "c")
                            {
                                Console.WriteLine(" _____________________________________________\n" +
                                                  "| Where and when are you during the brownout? |\n" +
                                                  " -v-------------------------------------------");
                                Console.ReadLine();
                                Console.WriteLine(" ______________________________________________________________________\n" +
                                                 "/                                                                      \\\n" +
                                                 "| Leon: Well, of course, I was with you the whole time. However, when  |\n" +
                                                 "|       we separated, I saw Silvio in the auditorium, and he looked    |\n" +
                                                 "|       frantic, too. Because many people were pushing him, he dislikes|\n" +
                                                 "|       people screaming a lot.                                        |\n" +
                                                 "\\______________________________________________________________________/\n");
                                Console.ReadLine();
                                Console.WriteLine(" ____________________________________\n" +
                                                  "| Does he dislike loud noises a lot? |\n" +
                                                  " -v----------------------------------");
                                Console.ReadLine();
                                Console.WriteLine(" ______________________________________________________________________\n" +
                                                 "/                                                                      \\\n" +
                                                 "| Leon: Well, when we were young, he was an energetic man who loved to |\n" +
                                                 "|       create trouble. However, I guess as time passed, he became more|\n" +
                                                 "|       irritated by it.                                               |\n" +
                                                 "\\______________________________________________________________________/\n");
                                Console.ReadLine();
                                minutes += random.Next(1, 3);
                                if (minutes >= 60)
                                {
                                    hour += 1;
                                    minutes = minutes - 60;
                                }
                                if (hour > 12)
                                {
                                    hour = hour - 12;
                                    TimeReader = "PM";
                                }
                                if (minutes < 10)
                                {
                                    Minutereader = "0" + minutes;

                                }
                                else
                                {
                                    Minutereader = minutes.ToString();
                                }
                                Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
                            }
                            else if (GeneralDirectorOfficeInterrogation == "d")
                            {
                                Console.WriteLine("You said your goodbyes to Leon. . .");
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Kindly input the choices mentioned.");
                                    Console.ReadLine();
                            }
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
                                    Inventory[9] = "> (3505) Old Letter";//Old Letter clue
                                    minutes += random.Next(1, 3);
                                    if (minutes >= 60)
                                    {
                                        hour += 1;
                                        minutes = minutes - 60;
                                    }
                                    if (hour > 12)
                                    {
                                        hour = hour - 12;
                                        TimeReader = "PM";
                                    }
                                    if (minutes < 10)
                                    {
                                        Minutereader = "0" + minutes;

                                    }
                                    else
                                    {
                                        Minutereader = minutes.ToString();
                                    }
                                    Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
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
                        Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗\n" +
                                          "║As you entered the room, a sweet melody wrapped around you like a warm embrace. Your gaze immediately landed on Merida, her fingers       ║\n" +
                                          "║dancing gracefully across the grand piano, while Silvio stood beside her, his violin adding a rich layer to the enchanting symphony. The  ║\n" +
                                          "║elegant room, with tall windows framed by rich red curtains, exuded warmth. Flickering lights glow softly, illuminating various           ║\n" +
                                          "║instruments eager to join the melody. Shelves filled with sheet music whispered tales of past performances, inviting you to immerse       ║\n" +
                                          "║yourself in this delightful world of sound and creativity.                                                                                ║\n" +
                                          "╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                        Console.WriteLine("What would you like to do first?");
                        Console.WriteLine("\n\ta) Inspect the room for clues\n\tb) Inquire People\n\tc) Enter a different room\n\td) Check Inventory");
                        Console.Write("\nAction: ");
                        string PracticeRoomChoice = Console.ReadLine();

                        if (PracticeRoomChoice == "a")
                        {
                            while (PracticeRoomChoice == "a")
                            {
                                Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                  "|Stepping into the practice room, your gaze was drawn to the neatly    |\n" +
                                                  "|organized shelves filled with books and labeled folders, each         |\n" +
                                                  "|promising musical insights. Beside them stood a striking black grand  |\n" +
                                                  "|piano, its glossy surface gleaming in the warm light, inviting you to |\n" +
                                                  "|play. Conversely, a cozy resting area with white armchairs beckoned   |\n" +
                                                  "|you to relax. The vibrant atmosphere sparked your curiosity.          |\n" +
                                                  "└──────────────────────────────────────────────────────────────────────┘");
                                Console.WriteLine("\nWhere would you like to begin your exploration?");
                                Console.WriteLine("\n\ta) Stacked Shelves\n\tb) Grand Piano\n\tc) Resting Area\n\td) Return Back");
                                Console.Write("\nAction: ");
                                string PracticeRoomRoom = Console.ReadLine();

                                if (PracticeRoomRoom == "a")
                                {
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|As you stepped closer to the meticulously organized shelves, you were |\n" +
                                                      "|drawn to a prominently displayed book, its cover adorned with         |\n" +
                                                      "|intricate designs and titles that hinted at a treasure trove of       |\n" +
                                                      "|musical compositions. Nestled atop the shelf, a collection of polished|\n" +
                                                      "| metronomes stood like sentinels, their pendulums ready to keep       |\n" +
                                                      "|perfect time.                                                         |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|As you delved into the music sheets, your fingers fluttered through   |\n" +
                                                      "|the thick book, the scent of aged paper surrounding you. Suddenly,    |\n" +
                                                      "|something caught your eye, making you stop.                           |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("                                                    ___________________\n" +
                                                      "                                                   |What could this be?|\n" +
                                                      "                                                    ----------------v--");
                                    Console.ReadLine();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|You found a sheet titled \"Eternal Besotted,\" adorned with an        |\n" +
                                                      "|intricate seal of a hawk beneath it. Unlike the others, this one had  |\n" +
                                                      "|numbers beneath each note, hinting at a deeper meaning that piqued    |\n" +
                                                      "|your curiosity. You contemplated the situation carefully, diving      |\n" +
                                                      "|deeper into your investigation by scrutinizing the array of           |\n" +
                                                      "|metronomes. Each metronome bore a striking resemblance to the others, |\n" +
                                                      "|crafted in a uniform style, yet their pendulums hung motionless,      |\n" +
                                                      "|frozen in time like statues in a museum.                              |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("                                                       ________________" +
                                                      "                                                      |Are they broken?|" +
                                                      "                                                       -------------v--");
                                    Console.ReadLine();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|At first, you were convinced they were malfunctioning, especially as  |\n" +
                                                      "|you leaned in to inspect one closely. But as your fingers brushed     |\n" +
                                                      "|against its cool surface, you noticed intricate symbols etched beneath|\n" +
                                                      "|it—mysterious glyphs that left you puzzled and curious.               |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|Both the music sheet and the symbols on the metronome might be helpful|\n" +
                                                      "| in your investigation, so you decided to take the music sheet and    |\n" +
                                                      "|commit the metronome's symbols to memory, as they could aid your      |\n" +
                                                      "|progress.                                                             |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("You discovered \"Eternal Bessotted Music Sheet\" and \"Set of Metronomes.\"");
                                    Console.ReadLine();
                                    Inventory[12] = "> (8966) Eternal Bessotted Music Sheet";
                                    Inventory[13] = "> (1872) Set of Metronomes";
                                    minutes += random.Next(1, 3);
                                    if (minutes >= 60)
                                    {
                                        hour += 1;
                                        minutes = minutes - 60;
                                    }
                                    if (hour > 12)
                                    {
                                        hour = hour - 12;
                                        TimeReader = "PM";
                                    }
                                    if (minutes < 10)
                                    {
                                        Minutereader = "0" + minutes;

                                    }
                                    else
                                    {
                                        Minutereader = minutes.ToString();
                                    }
                                    Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);

                                }
                                else if (PracticeRoomRoom == "b") //Music Sheet puzzle
                                {
                                        Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                          "|Approaching the grand piano, you notice its polished surface gleaming |\n" +
                                                          "|under the soft light. A spot on the music stand beckons for a sheet of|\n" +
                                                          "|music. Checking your inventory, you consider which piece to place     |\n" +
                                                          "|before this elegant instrument. What will you choose?                 |\n" +
                                                          "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    while (PracticeRoomRoom == "b")
                                    {
                                        Console.WriteLine("Here is your inventory:");
                                        for (int z = 0; z < Inventory.Length; z++)
                                        {
                                            if (Inventory[z] == "")
                                            {
                                                continue;
                                            }
                                            Console.WriteLine(Inventory[z]);

                                            if (Inventory[z] == "" && Inventory[z + 1] == "")
                                            {
                                                break;
                                            }
                                        }
                                        Console.WriteLine("Pick the item you want to interact with the piano (If you would like to return type \"Back\"");
                                        Console.Write("Action: ");
                                        string MusicSheetPuzzleAction = Console.ReadLine();

                                        if (MusicSheetPuzzleAction == "8966" && Inventory[12] != "")
                                        {
                                            
                                                Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                                  "|The melody unfolded into a sweet love song as you played, filling the |\n" +
                                                                  "|room with warmth. Yet, beneath the enchanting notes, the numbers      |\n" +
                                                                  "|scribbled below piqued your curiosity, suggesting a deeper meaning.   |\n" +
                                                                  "└──────────────────────────────────────────────────────────────────────┘");
                                            Console.ReadLine();
                                            Console.WriteLine("                                      _____________________________________\n" +
                                                              "                                     |There must be something more to this.|\n" +
                                                              "                                      ----------------------------------v--");
                                            Console.ReadLine();
                                            while (MusicSheetPuzzleAction == "8966" && Inventory[12] != "")
                                            {
                                                Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                                  "|You leaned closer, eyes scanning the mysterious notations, eager to   |\n" +
                                                                  "|decipher their secrets. (Input the right message and ensure it's      |\n" +
                                                                  "|lowercase with only spaces without special characters; otherwise, type|\n" +
                                                                  "|\"Back\" to explore other rooms.)                                     |\n" +
                                                                  "└──────────────────────────────────────────────────────────────────────┘");

                                                Console.Write("Code: ");
                                                string CrypticMessage= Console.ReadLine();

                                                if (CrypticMessage == "if you do not love me back i will kill you") //Cryptic Message of A love song Clue
                                                {
                                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                                      "|Eventually, you uncovered a hidden message that seemed to loom        |\n" +
                                                                      "|ominously—beneath the love song lurked a threatening undertone. Who   |\n" +
                                                                      "|could have written this? Despite the eerie discovery, you decided to  |\n" +
                                                                      "|continue your investigation.                                          |\n" +
                                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                                    Console.ReadLine();
                                                    Console.WriteLine("           You discovered \"Cryptic Message of a Love Song\"");
                                                    Console.ReadLine();
                                                    Inventory[14] = "> (4006) Cryptic Message of A Love Song";
                                                    minutes += random.Next(1, 3);
                                                    if (minutes >= 60)
                                                    {
                                                        hour += 1;
                                                        minutes = minutes - 60;
                                                    }
                                                    if (hour > 12)
                                                    {
                                                        hour = hour - 12;
                                                        TimeReader = "PM";
                                                    }
                                                    if (minutes < 10)
                                                    {
                                                        Minutereader = "0" + minutes;

                                                    }
                                                    else
                                                    {
                                                        Minutereader = minutes.ToString();
                                                    }
                                                    Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
                                                }
                                                else if (CrypticMessage=="Back"||CrypticMessage=="back")
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("That seems to be the wrong code. Maybe the numbers in the music sheet is related to another clue.");
                                                }
                                            }
                                        }
                                        else if (MusicSheetPuzzleAction =="Back"||MusicSheetPuzzleAction=="back")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("It seems you cant interact with this or its not part of the choices. Please try again.");
                                        }
                                        
                                    }
                                }
                                else if (PracticeRoomRoom == "c") //Vase of Roses and Weird Pamphlet CLue
                                {
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|As you made your way to the tranquil resting area, a sweet and        |\n" +
                                                      "|intoxicating fragrance wafted through the air, drawing you closer. You|\n" +
                                                      "|soon spotted a delicate vase adorned with vibrant roses that seemed to|\n" +
                                                      "|bloom with life. Nestled beneath the vase, a small note tag lay       |\n" +
                                                      "|partially slipped out, its elegant script revealing a touching        |\n" +
                                                      "|message: \"From your dear fiancé.\"                                   |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("                                            ___________________________\n" +
                                                      "                                           |Who do the roses belong to?|\n" +
                                                      "                                            ------------------------v--");
                                    Console.ReadLine();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|As you mused over the meaning behind the roses, your gaze fell upon a |\n" +
                                                      "|vintage typewriter sitting silently beside the vase. Its polished keys|\n" +
                                                      "|glimmered in the soft light, and curious numbers were etched along its|\n" +
                                                      "|sides, hinting at secrets waiting to be unraveled. Next to the        |\n" +
                                                      "|typewriter, a pamphlet caught your attention, its surface intricately |\n" +
                                                      "|covered in mysterious symbols that danced before your eyes.           |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("                                         ______________________________\n" +
                                                      "                                        |Both of these might be useful.|\n" +
                                                      "                                         ---------------------------v--");
                                    Console.ReadLine();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|You carefully lifted the pamphlet and ignited in your mind as you     |\n" +
                                                      "|recalled the unique layout of the typewriter. Combining both items    |\n" +
                                                      "|hinted at discovering something significant, urging you to proceed    |\n" +
                                                      "|with your investigation.                                              |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("  You obtained \"Vase of Roses\" and \"Typewriter and Weird Pamphlet\"");
                                    Console.ReadLine();
                                    Inventory[15] = "> (3891) Vase of Roses";
                                    Inventory[16] = "> (0656) Typewriter with Weird Pamphlet";
                                    minutes += random.Next(1, 3);
                                    if (minutes >= 60)
                                    {
                                        hour += 1;
                                        minutes = minutes - 60;
                                    }
                                    if (hour > 12)
                                    {
                                        hour = hour - 12;
                                        TimeReader = "PM";
                                    }
                                    if (minutes < 10)
                                    {
                                        Minutereader = "0" + minutes;

                                    }
                                    else
                                    {
                                        Minutereader = minutes.ToString();
                                    }
                                    Console.WriteLine("Current Time: " + hour + ":" + Minutereader + TimeReader);
                                }
                                else if (PracticeRoomRoom == "d")
                                {
                                    Console.WriteLine("Returning. . .");
                                    Console.ReadLine();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Kindly input the letters that indicates the choices above.");
                                    Console.ReadLine();
                                }
                            }
                        }
                        else if (PracticeRoomChoice == "b")
                        {
                            Console.WriteLine("Dialgoue");
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
                            while (GeneratorChoice == "a")
                            {
                                Console.WriteLine("As you scanned the dim room for clues, the generator's hum filled your ears, and its switches flickered ominously. You pondered the brown-out's cause, then " +
                                    "noticed a toolbox beneath the switch box, its lid carelessly left open as if someone had hurriedly rummaged through it. Strange scuff marks on the wall caught your eye, " +
                                    "suggesting an unusual struggle or secret activity. What would you like to investigate first?"); //Going to revise this paragraph
                                Console.WriteLine("a) Switchbox\nb) Toolbox\nc) Strange marks\nd) Back\n");
                                Console.Write("Action: ");
                                string GeneratorRoom = Console.ReadLine();
                                if (GeneratorRoom == "a")
                                {
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|You began your investigation by examining the switch box, which stood |\n" +
                                                      "|in an unassuming corner, its surface smooth and unblemished.          |\n" +
                                                      "|Everything was in perfect order: the circuits were intact, the buttons|\n" +
                                                      "|responsive, and the entire device operated seamlessly. Yet, amidst the|\n" +
                                                      "|neatly arranged components, your gaze fell upon a slender metallic    |\n" +
                                                      "|stick, its surface glinting under the light.                          |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("Player: This may appear to be an odd find, but it could be quite useful.");
                                    Console.ReadLine();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|Unsure of its intended use, you decided to take the peculiar object   |\n" +
                                                      "|with you, convinced that it might be essential for whatever lay ahead.|\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("You obtained a \"Thin Metallic Stick\""); //Thin Metallic Stick Clue
                                    Console.ReadLine();
                                    Inventory[17] = "> (1966) Thin Metallic Stick";
                                }
                                else if (GeneratorRoom == "b")
                                {
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|Beneath the switch box, your eyes are drawn to a toolbox that hangs   |\n" +
                                                      "|ajar, its contents partially revealed. As you peer inside, you search |\n" +
                                                      "|for tools to assist your investigation. Among the scattered wrenches  |\n" +
                                                      "|and screws, a pair of gleaming pliers catches your attention. You     |\n" +
                                                      "|reach for the sturdy tool, feeling its weight in your hand, confident |\n" +
                                                      "|that it will prove valuable in the tasks ahead.                       |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("You obtained \"Pliers\"");
                                    Console.ReadLine();
                                    Inventory[18] = "> (6168) Pliers";
                                }
                                else if(GeneratorRoom=="c")
                                {
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|As you leaned in closer to the wall, your eyes caught sight of        |\n" +
                                                      "|peculiar scuffed marks.                                               |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("Player: Wait, isn't this...?");
                                    Console.ReadLine();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|With renewed focus, you examined the surface, and your heartbeat      |\n" +
                                                      "|quickened as you spotted something shimmering faintly amidst the      |\n" +
                                                      "|patterns—an object with a golden glint nestled within the worn texture|\n" +
                                                      "|of the wall. This discovery, seemingly insignificant at first, became |\n" +
                                                      "|a significant find. Curiosity got the better of you, and you reached  |\n" +
                                                      "|out, gently prying at the edges. It finally came loose after a few    |\n" +
                                                      "|determined pulls, revealing itself as a bullet—a striking find that   |\n" +
                                                      "|left you pondering its origin and significance.                       |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("You obtained “Strange Bullet”");
                                    Console.ReadLine();
                                    Inventory[19] = "> (4176) Strange Bullet";
                                }
                                else if (GeneratorChoice == "d")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Kindly input things the choices indicated above.");
                                }
                            }                        
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
                        else if(GeneratorChoice=="c")
                        {

                        }
                        else
                        {
                            Console.WriteLine("Kindly input the choices mentioned above");
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
                            while (BackstageChoice == "a")
                            {
                                Console.WriteLine("A unique atmosphere of anticipation and tension fills the air in the half-dark backstage. The faint glow of overhead lights cast long, distorted shadows across " +
                                    "the worn wooden floor. The heavy curtains accompany the room's quietness. Stagehands tiptoe; their footsteps are barely audible as they rush to adjust props and set pieces. " +
                                    "The half-lit space is cluttered with scattered costumes—some hanging loosely on racks, others tossed carelessly on the ground, their fabric glowing faintly in the dim light. " +
                                    "This is a place with its secrets and stories waiting to be discovered. What would you like to do?");
                                Console.WriteLine("a)Another set of Boxes\nb)Investigate the Ladder\nc)Explore the dressing room\nd)Back\n");
                                Console.Write("Action: ");
                                string BackstageRoom = Console.ReadLine();
                                if (BackstageRoom == "a")
                                {
                                    while (BackstageRoom == "a") 
                                    {
                                        Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                          "|Your eyes are drawn to a collection of small and large black chests,  |\n" +
                                                          "|each exuding an air of mystery. One chest catches your attention with |\n" +
                                                          "|its intricate carvings. At the same time, another features a tattered |\n" +
                                                          "|blueprint of the citadel, which you carefully store in your inventory.|\n" +
                                                          "└──────────────────────────────────────────────────────────────────────┘");
                                        Console.ReadLine();
                                        Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                          "|You then notice a chest adorned with a gleaming golden lock, its      |\n" +
                                                          "|four-digit code challenge sparking your curiosity.                    |\n" +
                                                          "└──────────────────────────────────────────────────────────────────────┘");
                                        Console.ReadLine();
                                        Console.WriteLine("What would you like to do first?");
                                        Console.WriteLine("\na) Continue exploring the surroundings.\nb) Attempt to unlock the chest.\n");
                                        Console.Write("\nAction: ");
                                        string BackstageRoomChest = Console.ReadLine();

                                        if (BackstageRoomChest == "a")
                                        {
                                            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                              "|You decided to return rather than look at the chest.                  |\n" +
                                                              "└──────────────────────────────────────────────────────────────────────┘");
                                            Console.ReadLine();
                                            Console.WriteLine("You obtained \"Blueprint of the Citadel\"");
                                            Console.ReadLine();
                                            Inventory[21] = "> (0445) Blueprint of the Citadel"; //Blueprint of Citadel Clue
                                        }
                                        else if (BackstageRoomChest == "b")
                                        {
                                            while (BackstageRoomChest == "b")
                                            {
                                                Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                                  "|You attempted to unlock the chest. (Input the right code; If you would|\n" +
                                                                  "|like to return, type \"Back\"                                         |\n" +
                                                                  "└──────────────────────────────────────────────────────────────────────┘"); //Chest Puzzle regarding metronome
                                                Console.Write("Code: ");
                                                string BackstageRoomUnlockingChest = Console.ReadLine();
                                                if (BackstageRoomUnlockingChest == "3824")
                                                {
                                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                                      "|After a long, arduous journey to unlocking the padlock, you finally   |\n" +
                                                                      "|unlocked the intricately designed chest. A soft, golden light spilled |\n" +
                                                                      "|out as the lid creaked open, revealing an exquisite mirror within the |\n" +
                                                                      "|velvet-lined interior. This mirror was unlike any you had encountered |\n" +
                                                                      "|before; its frame was adorned with delicate, swirling patterns that   |\n" +
                                                                      "|seemed to shimmer in the light. Intrigued, you gently lifted the      |\n" +
                                                                      "|mirror and, sensing its unique aura, carefully placed it in your      |\n" +
                                                                      "|inventory, feeling a subtle warmth radiate from it as you did so.     |\n" +
                                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                                    Console.ReadLine();
                                                    Console.WriteLine("You obtained \"Mirror (II).\""); //Mirror II Clue
                                                    Console.ReadLine();
                                                    Inventory[20] = "> (0657) Mirror (II)";
                                                }
                                                else if (BackstageRoomUnlockingChest == "Back"||BackstageRoomUnlockingChest=="back")
                                                {
                                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                                      "|You decided to return and check it later                              |\n" +
                                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                                    Console.ReadLine();
                                                    break;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("It seems thats the wrong code...(Hint: You might need to check the metronomes once again.");
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Kindly choose between the choices mentioned");
                                        }
                                    }
                                }
                                else if (BackstageRoom == "b")
                                {
                                    Console.WriteLine("Investigate the Ladder Dialogue");
                                   Inventory[24] = "> (6695) A Tiger Crest";
                                }
                                else if (BackstageRoom=="c")
                                {
                                        Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                          "|Upon entering the dressing room, a strong, unpleasant odor envelops   |\n" +
                                                          "|you, blending with the chaotic atmosphere. Clothes are scattered      |\n" +
                                                          "|across the floor, creating a vibrant patchwork of colors that dance in|\n" +
                                                          "|the dim lighting, stimulating your visual senses.                     |\n" +
                                                          "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                      "|You approach the vanities, where makeup products are left in          |\n" +
                                                      "|disarray—lipsticks, eyeshadows, and brushes hint at a rushed          |\n" +
                                                      "|preparation. Amidst the clutter, you spot half-eaten food containers, |\n" +
                                                      "|suggesting the presence of spoiled items.                             |\n" +
                                                      "└──────────────────────────────────────────────────────────────────────┘");
                                    Console.ReadLine();
                                    Console.WriteLine("Player: There must be spoiled food somewhere, and that's what's causing the stench.");
                                    Console.ReadLine();
                                    while (BackstageRoom == "c")
                                    {
                                        Console.WriteLine("┌──────────────────────────────────────────────────────────────────────┐\n" +
                                                          "|Pushing past the smell, you notice a locked cabinet against the wall. |\n" +
                                                          "|It is secured by a peculiar silver lock with a thin, circular hole,   |\n" +
                                                          "|hinting at a unique key hidden within. You checked your inventory to  |\n" +
                                                          "|see if there was a valuable key to use.                               |\n" +
                                                          "└──────────────────────────────────────────────────────────────────────┘");
                                        Console.ReadLine();
                                        for (int z = 0; z < Inventory.Length; z++)
                                        {
                                            if (Inventory[z] == "")
                                            {
                                                continue;
                                            }
                                            Console.WriteLine(Inventory[z]);

                                            if (Inventory[z] == "" && Inventory[z + 1] == "")
                                            {
                                                break;
                                            }
                                        }
                                        Console.WriteLine("Select the right item that can be interacted (Write \"Back\" if you would like to return");
                                        Console.Write("Action: ");
                                        string CabinetInteraction = Console.ReadLine();
                                        if (CabinetInteraction == "1966" && Inventory[17] != "")
                                        {
                                            Console.WriteLine("You discovered \"Quentin\'s Dead Body\" and \"Ferulle\"");
                                            Inventory[22] = "> (1729) Quentin's Dead Body";
                                            Inventory[23] = "> (9485) Ferulle";
                                        }
                                       else if (CabinetInteraction =="Back"||CabinetInteraction=="back")
                                        {
                                            Console.WriteLine("Returning back...");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("It seems that item won't work... (Or you probably input the wrong number so try double checking)");
                                        }
                                    }
                                }
                                else if (BackstageRoom == "d")
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Kindly input a choice mentioned above.");
                                }
                            }
                        }
                        else if (BackstageChoice == "b")
                        {
                            while (BackstageChoice == "b")
                            {
                                Console.WriteLine("\nWhere would you like to go?");
                                Console.WriteLine("a) Backstage\nb) Hallway");
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
        static void Empty()
        {
            Console.WriteLine("                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            " +
                              "                                                                                                                                            ");
        }               
        static void LobbyPicture()
        {
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗\n" +
                              "║████                                    ████      ██                ████                ██      ████      ░░      ░░░░      ░░            ║\n" +
                              "║████                                    ██░░██    ██                ████                ██    ██░░██      ░░    ██░░░░██    ░░            ║\n" +
                              "║████                                    ██░░░░██  ██                                    ██  ██░░░░██      ██  ██  ░░░░  ██  ██            ║\n" +
                              "║                                        ██  ░░░░████        ██      ████      ██        ████░░░░  ██        ████  ████  ████            ░░║\n" +
                              "║████      ░░░░                          ██    ░░░░██      ░░░░      ░░░░      ░░░░      ██░░░░    ██            ██    ██                ██║\n" +
                              "║░░░░      ░░░░                          ██      ░░██      ░░░░    ██░░░░██    ░░░░      ██░░      ██              ████                  ██║\n" +
                              "║░░░░██    ░░░░                          ██        ██    ██  ██  ██  ░░░░  ██  ██  ██    ██        ██                                  ░░░░║\n" +
                              "║░░░░  ██  ██  ██                        ██        ██      ██  ████  ████  ████  ██      ██        ██                                  ████║\n" +
                              "║████  ████  ██                          ██        ██              ██    ██              ██        ██        ██            ██          ████║\n" +
                              "║    ██                ████████          ██        ██                ████                ██        ██        ░░            ░░        ░░░░░░║\n" +
                              "║████                ██      ████        ██        ██                                    ██        ██        ░░            ░░      ░░██████║\n" +
                              "║                              ░░        ██        ██                                    ██        ██        ██            ██      ████████║\n" +
                              "║                              ░░        ██        ██                                    ██        ██░░░░  ██  ░░░░░░░░░░░░  ██  ░░░░░░░░░░║\n" +
                              "║████████████                ░░░░        ██        ██                                    ██        ██░░░░  ██  ████████████  ██  ░░░░░░░░░░║\n" +
                              "║            ██              ██          ██        ██                                    ██        ██░░    ██  ████████████  ██    ░░░░░░░░║\n" +
                              "║  ░░  ░░    ██            ██████████    ██░░      ██                                    ██      ░░██░░  ██  ░░░░░░░░░░░░░░░░  ██  ░░░░░░░░║\n" +
                              "║    ░░      ██            ██      ░░    ██░░░░    ██                                    ██    ░░░░██░░  ██  ████████████████  ██  ░░░░░░░░║\n" +
                              "║      ░░    ██            ████      ░░  ████░░░░  ██                                    ██  ░░░░████░░  ██  ████████████████  ██    ░░░░░░║\n" +
                              "║            ██              ████    ░░  ██  ██░░░░██                                    ██░░░░██  ██  ██  ░░░░░░░░░░░░░░░░░░░░    ██  ░░░░║\n" +
                              "║████████████  ████            ██        ██    ██░░██                                    ██░░██    ██  ██  ████████████████████  ██    ░░░░║\n" +
                              "║            ██    ██  ████████████████  ██      ████                                    ████      ██  ██  ████████████████████  ██    ░░░░║\n" +
                              "║            ██    ██    ██        ██    ██        ██                                    ██        ████  ░░░░░░░░░░░░░░░░░░░░░░░░  ██    ░░║\n" +
                              "║            ██    ██    ██        ██    ██        ██                                    ██        ████  ████████████████████████  ██    ░░║\n" +
                              "║██████████████    ██    ██        ██    ████████████                                    ██████████████  ████████████████████████  ██    ░░║\n" +
                              "║            ██    ██      ████████    ██          ████████████████████████████████████████          ██                                    ║\n" +
                              "║██████████████████                      ██████████                                        ██████████    ░░                    ░░          ║\n" +
                              "║                                                                                                          ░░░░░░░░░░░░░░░░░░░░            ║\n" +
                              "║░░░░░░░░░░░░░░░░░░░░░░░░                                                                                  ░░                ░░            ║\n" +
                              "║                  ░░                                                                                      ░░  ░░░░░░░░░░░░  ░░            ║\n" +
                              "║░░░░░░░░░░░░░░░░░░░░░░░░                                                                                  ░░  ░░        ░░  ░░            ║\n" +
                              "║                  ░░                                                                                      ░░  ░░  ░░░░  ░░  ░░            ║\n" +
                              "╚══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝\n");
        }
        
    }
}
