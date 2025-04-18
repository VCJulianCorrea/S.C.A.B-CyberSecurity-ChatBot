using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography;
using System.Media;
using System.Threading;
namespace ST10438910___PROG_POE_Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            TextUtilities tu = new TextUtilities();
            CSInfo ci = new CSInfo();
            SoundPlayer player = new SoundPlayer(@"C:\Users\lab_services_student\Music\POE Voice Message.wav");
            string[] replyStart = { "So,", "You see,", "Well,", "Let's see,", "Ok, well", "As you can see," };
            Random rnd = new Random();
            int rand1 = rnd.Next(5);

            Console.WriteLine(@"                                     .':odxxxxxxxxxddddddddddddddddddddddddddool:.                            
                                    .lKNXOOOOOOOOOOOOO00000000000000000000000KKXNKo.                          
                                   .lNNkdxkkkkkkkkkkOOOOOOOOOO0OOOOOOOOOOOOOOOOkOXNo.                         
                                   .xWKdOXd:::::::::::::::::::;;;;;;;;;;;;;;;lK0d0Wk.                         
                                   .xWKx0K;             .''..'.              'O0oOWO'                         
                                   .xWKx0K;         .,;,cc....:;''..         '00oOWO'                         
                                   .xWKx0K,        ,c;  ddlccloo  ,,.        ,00oOWO'                         
                                   .xWKx00,        ;c.  o:;;;;:l  ,l;        '00oOWO'                         
                                   .xWKx00,        .cd  ,'looc.;  o:.        '00dOWO'                         
                                   .xWKd00,        ':,;dl,,;;,'ll',:.        '0Kd0Wk.                         
                                   .xWKd0K,         c..   ::cl   .;.         'OKd0Wk.                         
                                   .kW0oOK;          ,,;lc     ol'.          'OKd0Wk.                         
                                   .kW0oOK;             .,;;:cc'             'OKx0Wk.                         
                                   .kW0lOXl...............',,'...............,OKx0Wk.                         
                                   .kW0cdK0OkkOkkkkkkkkkkkkkkkkkkkkkkkkkkkkkxOK0d0Wk'                         
                                  .lXNk:oxxxkkkkkkkkkOOOOOOOOOOOOOOOOOOOOOOOOOOkokNXl.                        
                                 .lXNko0XkdoxOxookOdodOkooxOOxookOxodkkdodOkodxKKxkNXo.                       
                                .lXNkd0Xk:,,lo;';ol,';oc'';od:.':o:',co;',ll;';dXKdxXNd.                      
                               .oXNkxKNk:,;lo:,,coc;,co:,,:odc,,;oc,,:ol;,;ol;,:xNKddXNx.                     
                              .dNNkxXNx;'':o:'',ol,''lo,'';od:'',ol'''co;'';oc'';dNXddXNx.                    
                             .xNXxxXWN0kkxO0kxxk0Okxk00kxxk00Oxxk00kxxO0Okxk00kxk0NWXkxXNx.                   
                            .dNXo:dkkkkkkkkkOOOOO000000000000OOOkkkkkkkkkkkkkkkkOOOOOkldXNd.                  
                            .xWXl;looooooooodddddxxxxxxxxxxddddddoooooooooooooooooodddloKNd.");

            Console.WriteLine("\n                                       #####       #####         #        ######      \r\n                                      #     #     #     #       # #       #     #     \r\n                                      #           #            #   #      #     #     \r\n                                       #####      #           #     #     ######      \r\n                                            # ### #       ### ####### ### #     # ### \r\n                                      #     # ### #     # ### #     # ### #     # ### \r\n                                       #####  ###  #####  ### #     # ### ######  ### ");
            Console.WriteLine(@"                     __             _                                                    _       
                    (_    ._  _ ._ /   |_  _ .__ _  _   ._o_|_    /\  _ _o __|_ _..__|_ |_) __|_ 
                    __)|_||_)(/_|  \_\/|_)(/_|_>(/_(_|_|| | |_\/ /--\_>_>|_> |_(_|| ||_ |_)(_)|_ 
                          |          /                        /             ");
            player.PlaySync();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\n");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            tu.Type("Hey there fella! Might I ask what your name is? I'm just curious.", 100);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Gray;
            string name = "";
            name = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(100);
            if (name == null)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                do
                {
                    tu.Type("Uhhh... I didn't hear you. Could you please say it louder?", 200);
                    name = Console.ReadLine();
                } while (name == null);
            }
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            tu.Type("Why hello there " + name + "! It's a pleasure to meet you. " +
                "\nAs you might know from the voice recording, My name is S.C.A.B, the Super Cybersecurity Assistant Bot! " +
                "\nI help everyone with the use and understanding all around cybersecurity. Ask me any question you have on this topic! :)" +
                "\nYou can exit by simply saying 'goodbye'", 30);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Gray;
            string question = Console.ReadLine().ToUpper();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            do
            {
                tu.Type(replyStart[rnd.Next(6)], 100);
                Thread.Sleep(1500);
                if (question.Contains("PHISH"))
                {
                    ci.Phishing();
                } else if (question.Contains("PASSWORD"))
                {
                    ci.Passwords();
                } else
                if (question.Contains("BROWS"))
                {
                    ci.Browsing();
                } else
                if (question.Contains("DOX"))
                {
                    ci.Doxxing();
                } else
                if (question.Contains("CYBER SECURITY"))
                {
                    ci.CyberSecurity();
                } else
                if (question.Contains("HOW ARE YOU"))
                {
                    ci.Mood(rand1);
                } else
                if (question.Contains("DO YOU DO") || question.Contains("PURPOSE"))
                {
                    ci.Purpose();
                } else
                if (question.Contains("HI") || question.Contains("HELLO"))
                {
                    ci.Greet();
                } else
                if (question.Contains("ASK YOU") || question.Contains("QUESTION"))
                {
                    ci.Questions();
                } else
                if (question.Contains("AM"))
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.Black;
                    ci.IHNMAIMS();
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    tu.Type("It seems that I have no knowledge with regards to what you said.", 50);
                    tu.Type("Sooo... ", 500);
                    tu.Type("It basically flew over my head! ^U^'", 50);
                    tu.Type("Would you mind asking me something that I can potentially understand?", 75);
                }
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Gray;
                question = Console.ReadLine().ToUpper();
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
            } while (!question.Contains("GOODBYE"));
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Magenta;
            tu.Type("Bye, bye", 100);
            Thread.Sleep(3000);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Environment.Exit(0);
        }
    }
}
