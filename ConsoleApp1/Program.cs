using Microsoft.Win32.SafeHandles;

Console.WriteLine(" The path you are on splits in two. The path to the right leads to a magical forest with unicorns, gnomes and centaurs.");
Console.WriteLine("The path to the left leads to a haunted castle where it is always raining. Do you want to go left or right");

string choice = Console.ReadLine();
choice = choice.ToLower();

// if you chose to go Left to the haunted castel
if (choice == "left" || choice == "l")
{
    Console.WriteLine("You walk towards the haunted castel getting drenched in the process");
    Console.WriteLine("The door creeks open and you follow a hallway into a big room. there is a big fireplace,");
    Console.WriteLine("two plush armchairs and books lining the walls");
    Console.WriteLine("You look down and se a cirkle drawn in blood and latin characters written around it. ");
    Console.WriteLine("You happen to know latin and notise a misspeld word, do you correct it or keep exploring? ");


    string choice_castel = Console.ReadLine();
    choice_castel = choice_castel.ToLower();

    // what happens when you correctit
    if (choice_castel == "correct it")
    {
        Console.WriteLine("Taking out a knife, you slit your palm and, leting the blood drip, correct the word.");
        Console.WriteLine("Wind sweeps thruoght the room taking out the fireplace, you feel a powerful presence has apeard");
        Console.WriteLine("You hear a thump as your head hit the floor. you died");
    }

    else if (choice_castel == "keep exploring")
    {
        Console.WriteLine("Even though you chose the boring option do not think your safe");
        Console.WriteLine("you walk back through the hallway and find stairs going up the second floor.");
        Console.WriteLine("you hear crying from inside a room to your right so you open the door only to see a ghost");
        Console.WriteLine("The ghost looks up furious and apears before you, sticking it's hand into your chest");
        Console.WriteLine("Everything goes dark. You died");

    }

}

// if you chose to go right to the magical forest


// if you chose to go right to the magical forest
else if (choice == "right" || choice == "r")
{
    Console.WriteLine("You walk into the magical forest. You see a delicious mushroom which is blue with purple dots. ");
    Console.WriteLine("Do you take a bite or keep walking?");

    string choise_forest = Console.ReadLine();
    choise_forest = choise_forest.ToLower();

    if (choise_forest == "take a bite")
    {
        Console.WriteLine("you take a bite and realise you were right, it is delicious");
        Console.WriteLine("after finishing eating, you lay down for a nap.");
        Console.WriteLine("You don't wake up again, you died.");
    }

    if (choise_forest == "keep walking")
    {
        Console.WriteLine("you keep walking until you see a unicorn in a clearing.");
        Console.WriteLine("It looks so cute so you deside to go pet it. You step on a branch, scaring the unicorn.");
        Console.WriteLine("you end up very sad and miserable missing the one chance of happiness. The end.");
    }

}

else
{
    Console.WriteLine("try again");
}

Console.ReadLine();