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

namespace GameTest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You realized that you couldn't go home without uncovering the killer's identity, especially since you were the prime suspect in the case. " +
                "Determined to clear your name, you decided to take action. It was now 10:00 AM, and everyone was dispersing in the theater to carry out various tasks and " +
                "enjoy some free time.However, you chose to investigate to prove your innocence.");
            Console.ReadLine();
            int room = 1;
            int midgame = 1;

            while (midgame == 1)
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
                        else if (LobbyChoice =="b") //I forgot to add Earl and Victor in the SCENE T-T so I added a new choice so that the player can inquire them
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
                            Console.WriteLine("Inspect the room for clues dialogue");
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
                            Console.WriteLine("\nInspecting the room for clues");
                        }
                        else if (GeneralDirectorOfficeChoice == "b")
                        {
                            Console.WriteLine("\nInquiringPeople");
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
                            Console.WriteLine("Inspecting the room for clues");
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
    }
}
