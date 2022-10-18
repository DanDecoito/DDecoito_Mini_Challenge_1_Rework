//Daniel Decoito    
//10-18-2022 3:46pm
//Mini challange 1 "What is your name?"
//This is a console prject that will ask a user thier name and return it on screen.
//peer reviewd. Reviwed by Manuel L. Everything looks really good:)
// Peer review of 0; Marcel R. worked well and looped :)

Console.Clear();
string userName = "";
string terminatGame =".";


static string NameGreeting(string userInput)
{
    return $"Hello {userInput} how are you doing?";
}

while (terminatGame != "")
{
     Console.WriteLine("Hello, what is your name?");
   Console.WriteLine(NameGreeting(Console.ReadLine()));
 
 Console.WriteLine("enter any key to play again or just press enter to end program.");
 terminatGame = Console.ReadLine();
 }
 
 Console.WriteLine("Thanks for Playing");
 

