//Marcel Rodriguez
//10-18-22 4pm
//Mini Challenge 5 - mad lib
//This program will ask the user 10 inputs in the form of nouns,
//adjectives, verbs etc. and output them in a story
//Peer Review - 

Console.Clear();

string end = "yes";
while(end == "yes")
{
    string stringValue = "";

    Console.WriteLine("Please enter a name: ");
    string nameOne = Console.ReadLine();
    Validate(nameOne, out stringValue);
    nameOne = stringValue;

    Console.WriteLine("Please enter a noun: ");
    string nounOne = Console.ReadLine();
    Validate(nounOne, out stringValue);
    nounOne = stringValue;

    Console.WriteLine("Please enter a verb: ");
    string verbOne = Console.ReadLine();
    Validate(verbOne, out stringValue);
    verbOne = stringValue; 

    Console.WriteLine("Please enter an adjective: ");
    string adjectiveOne = Console.ReadLine();
    Validate(adjectiveOne, out stringValue);
    adjectiveOne = stringValue; 

    Console.WriteLine("Please enter another noun: ");
    string nounTwo = Console.ReadLine();
    Validate(nounTwo, out stringValue);
    nounTwo = stringValue;

    Console.WriteLine("Please enter another verb: ");
    string verbTwo = Console.ReadLine();
    Validate(verbTwo, out stringValue);
    verbTwo = stringValue;

    
    Console.WriteLine("Please enter another adjective: ");
    string adjectiveTwo = Console.ReadLine();
    Validate(adjectiveTwo, out stringValue);
    adjectiveTwo = stringValue; 

    Console.WriteLine("Please enter a third adjective: ");
    string adjectiveThree = Console.ReadLine();
    Validate(adjectiveThree, out stringValue);
    adjectiveThree = stringValue;

    Console.WriteLine("Please enter a third verb: ");
    string verbThree = Console.ReadLine();
    Validate(verbThree, out stringValue);
    verbThree = stringValue;

    Console.WriteLine("Please enter a forth verb: ");
    string verbFour = Console.ReadLine();   
    Validate(verbFour, out stringValue);
    verbFour = stringValue;

    Console.WriteLine("Please enter a fifth verb: ");
    string verbFive = Console.ReadLine();
    Validate(verbFive, out stringValue);
    verbFive = stringValue;

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("There once was a person named " +nameOne+ " who loved " +nounOne+ " a lot.");
    Console.WriteLine("They loved " +nounOne+ " so much that they always had to " +verbOne+ " with it.");
    Console.WriteLine("It had a " +adjectiveOne+ " look to it, and that made " +nameOne+ " want to " +verbTwo+ " when they were apart.");
    Console.WriteLine("There was another thing that they had, which was a " +nounTwo);
    Console.WriteLine("The " +nounTwo+ " was " +adjectiveTwo+ " and " +adjectiveThree+ ".");
    Console.WriteLine(nameOne+ " dropped the " +nounTwo+ " off a cliff, which caused " +nameOne+ " to ");
    Console.WriteLine(verbThree+ ", " +verbFour+ ", and " +verbFive+ " off the cliff as well.");
    Console.WriteLine(nounOne+ " watched from the top and laughed. The End :D");
    Console.WriteLine("");
    Console.WriteLine("");


    Console.WriteLine("\nDo you want to try again? Yes/No");
    end = Console.ReadLine().ToLower();
    Console.WriteLine();
}

static string Validate(string validateString, out string validatedString)
{
    bool isContainer = false;
    int validNum = 0;
    Console.WriteLine();

    while(isContainer == false)
    {   
        if (!Int32.TryParse(validateString, out validNum))
        {
            isContainer = true;
            validatedString = validateString;
            return validateString;
        }
        else
        {
            Console.WriteLine("Please enter a word, not a number");
            validateString = Console.ReadLine();
            Console.WriteLine();

        }
    }
    validatedString = validateString;
    return validateString;
}
