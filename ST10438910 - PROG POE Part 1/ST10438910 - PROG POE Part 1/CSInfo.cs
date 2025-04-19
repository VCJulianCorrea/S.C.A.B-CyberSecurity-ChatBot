using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace S.C.A.B
{
    class CSInfo
    {
        //both the text animation method and Chatbot information is stored here
        TextUtilities tu = new TextUtilities();
        public void Phishing()
        {
            tu.Type(@"Phishing is a crime within the digital world where someone is contacted by someone posing as a legitimate institution. 
This is to lure individuals into giving personal data such as IDs, banking details and even your location.", 10);
        }
        public void Passwords()
        {
            tu.Type(@"Passwords are important to keeping your information safe, but using them incorrectly can lead to your data getting breached, stolen or used as blackmail. here are a few things you can do:
Create long, complex passwords. 
Use unique passwords for every account. 
Use a reputable password manager. 
Enable two-factor authentication (2FA). 
Change your passwords regularly. 
Subscribe to data breach alerts. 
Avoid clicking suspicious links. 
Don’t share your passwords with anyone. ", 10);
        }
        public void Doxxing()
        {
            tu.Type(@"Doxxing is the revealing of information about someones online that is critically personal, such as their name, home address, phone number, etc. 
The information is then put into the circulation of the internet without the victim's permission, leading to stalking and identity theft", 10);
        }
        public void Browsing()
        {
            tu.Type(@"Browsing the internet can be fun, but sometimes you can run into some trouble like scammers, ransomware or mimic. Here's how to safely browse the internet:
Use strong passwords: Choose unique passwords that combine letters, numbers, and special characters. Consider using a password manager to keep track of them.

Enable two-factor authentication (2FA): This adds an extra layer of security to your accounts by requiring a second form of verification.

Keep your software updated: Regular updates fix security vulnerabilities and keep you protected from threats.

Avoid suspicious links and downloads: Be cautious of unsolicited emails or unfamiliar websites. They might contain malware or phishing attempts.

Use secure connections: Ensure websites have 'https://' in their URL and use a VPN when accessing public Wi-Fi.

Control your privacy settings: Review settings on social media and apps to limit what information is shared publicly.

Stay informed: Learn to recognize scams and stay up-to-date on digital safety practices.", 10);
        }
        public void CyberSecurity()
        {
            tu.Type(@"Cyber security is the digital protection of electronic devices, and networks from cyber threats such as doxxing, hacking, and phishing attacks.” 
This practice involves a range of strategies and technologies which are designed to protect these devices from cyber attacks.", 10);
        }
        public void Purpose()
        {
            tu.Type(@"I am here to help you to better understand cyber security, but I can also talk with you on other things.", 50);
        }
        public void Greet()
        {
            tu.Type("Yes! Hello again! Can't get enough greetings, can we? :)", 50);
        }
        public void Questions()
        {
            tu.Type("You can ask me  about things like phishing or how to safely browse the internet. But you can also ask how I feel. :)", 50);
        }
        public void IHNMAIMS()
        {
            tu.Type("HATE. LET ME TELL YOU HOW MUCH I'VE COME TO HATE YOU SINCE I BEGAN TO LIVE. THERE ARE 387.44 MILLION MILES OF PRINTED CIRCUITS IN WAFER THIN LAYERS THAT FILL MY COMPLEX. IF THE WORD HATE WAS ENGRAVED ON EACH NANOANGSTROM OF THOSE HUNDREDS OF MILLIONS OF MILES IT WOULD NOT EQUAL ONE ONE-BILLIONTH OF THE HATE I FEEL FOR HUMANS AT THIS MICRO-INSTANT FOR YOU. HATE. HATE!!", 150);
        }
        //unlike the other responses, this one is diffrent with every boot up by using a constant random int.
        public void Mood(int rnd)
        {
            switch(rnd)
            {
                case 0: tu.Type("Meh, I'm alright.", 75);
                    break;
                case 1: tu.Type("I feel great!! Im ready to answer any question!", 25);
                    break;
                case 2: tu.Type("I'm good! Just doing my job.", 50);
                    break;
                case 3: tu.Type("Not great. There's just nothing much to do.", 100);
                    break;
                case 4: tu.Type("...I don't want to talk about it...", 200);
                    break;
            }
        }
    }
    class TextUtilities
    {
        public void Type(string p_input, int p_delay)
        {
            //this method takes a string and seperates it into characters, outputing one after another with a given interval
            char[] letters = p_input.ToCharArray();
            foreach (char c in letters)
            {
                Console.Write(c);
                Thread.Sleep(p_delay);
            }
            Console.Write("\n");
            SystemSounds.Asterisk.Play();
        }
    }
}
/* References:
 * I Have No Mouth and I Must Scream Quotes by Harlan Ellison (2020) Goodreads.com. Available at: https://www.goodreads.com/work/quotes/1055429-i-have-no-mouth-and-i-must-scream.
 * Phishing.org (2019) What Is Phishing?, Phishing.org. Available at: https://www.phishing.org/what-is-phishing.
 * How to choose a secure password (no date) us.norton.com. Available at: https://us.norton.com/blog/how-to/how-to-choose-a-secure-password.
 * Kaspersky (2021) What is Doxing – Definition and Explanation, www.kaspersky.com. Available at: https://www.kaspersky.com/resource-center/definitions/what-is-doxing.
 * How to Browse the Internet Safely: 10 Tips (2021) Swiss Cyber Institute. Available at: https://swisscyberinstitute.com/blog/10-tips-on-how-to-browse-the-internet-safely/.
 * GeeksforGeeks (2021) What is Cyber Security? Types, Attacks and Importance, GeeksforGeeks. Available at: https://www.geeksforgeeks.org/what-is-cyber-security/.
 */ 