using ClassLibrary;

string startMenu = "Use any of the following parameters: \n" +
        "-lists \n" +
        "-new <list name> <language 1> <language 2> .. <langauge n> \n" +
        "-add <list name> \n" +
        "-remove <list name> <language> <word 1> <word 2> .. <word n> \n" +
        "-words <listname> <sortByLanguage> \n" +
        "-count <listname> \n" +
        "-practice <listname> \n";

if (args.Length > 0)
{
    menuChoices();
}
else
{
    Console.WriteLine(startMenu);
}

void menuChoices()
{
    switch (args[0])
    {
        case "-lists":
            getLists();
            break;

        case "-new":
            createNewList(args);
            break;

        case "-add":
            addNewWord(args);
            break;

        case "-remove":
            removeWord(args);
            break;

        case "-words":
            sortedWordList(args);
            break;

        case "-count":
            countWords(args);
            break;

        case "-practice":
            practiceWithWords(args);
            break;

        default:
            Console.Clear();
            Console.WriteLine("There's been a mistake! Please, start over.");
            Console.WriteLine(startMenu);
            break;
    }
}

void getLists()
{
    foreach (string list in WordList.GetLists())
    {
        Console.WriteLine(list);
    }
}

void createNewList(string[] args)
{
    List<string> givenLangs = new List<string>();
    if (args.Length <= 3)
    {
        Console.WriteLine("You have either not given a listname or haven't typed at least two languages after listname!");
        return;
    }
    else if (args.Length >= 4)
    {
        for (int i = 2; i < args.Length; i++)
        {
            givenLangs.Add(args[i]);
        }
        string[] languages = givenLangs.ToArray();
        WordList wordList = new WordList(args[1], languages);
        wordList.Save();
        addNewWord(args);
    }
    else
    {
        Console.WriteLine(startMenu);
    }
}

void addNewWord(string[] args)
{
    if (args.Length <= 1)
    {
        Console.WriteLine("Enter a listname, please!");
        return;
    }
    else if (args.Length == 2)
    {
        WordList wordList = WordList.LoadList(args[1]);
        if (wordList is null)
        {
            Console.WriteLine("There is not a file with that name!");
        }
        //List<string> words = new List<string>();
        bool go = true;
        while (go)
        {
            var words = new string[wordList.Languages.Length];
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine($"Enter a word in {wordList.Languages[i]}!");
                string userInput = Console.ReadLine();
                words[i] = userInput.ToLower();

                if (String.IsNullOrEmpty(userInput))
                {
                    go = false;
                    break;
                }
                else
                {
                    words[i] = userInput;
                }
            }
            if (go) wordList.Add(words);
        }
        wordList.Save();
        Console.WriteLine("New words have been added!");
    }
}

void removeWord(string[] args)
{
    if (args.Length <= 1)
    {
        Console.WriteLine("Please, enter a listname!");
        return;
    }
    else if (args.Length == 2)
    {
        Console.WriteLine("Please, enter a language!");
        return;
    }
    else if (args.Length == 3)
    {
        Console.WriteLine("Please, enter a word to be removed!");
        return;
    }
    else if (args.Length > 3)
    {
        string language = args[2];
        WordList wordList = WordList.LoadList(args[1]);
        if (wordList is null)
        {
            Console.WriteLine($"No file with the name {args[1]}.dat could be found!");
            return;
        }
        for (int i = 3; i < args.Length; i++)
        {
            bool looking = wordList.Remove(LanguageIndex(wordList), args[i].ToLower());
            if (looking)
            {
                Console.WriteLine($"{args[i]} has been removed from the list!");
            }
            else
            {
                Console.WriteLine("The given word was not found in the list!");
            }
        }
        wordList.Save();
    }
}

int LanguageIndex(WordList wordList)
{
    int index = 0;

    if (args.Length > 2)
    {
        for (int i = 0; i < wordList.Languages.Length; i++)
        {
            if (wordList.Languages[i].ToLower() == args[2].ToLower())
            {
                index = i;
                return index;
            }
        }
    }
    return -1;
}

void sortedWordList(string[] args)
{
    if (args.Length == 2)
    {
        WordList wordList = WordList.LoadList(args[1]);
        foreach (var item in wordList.Languages)
        {
            Console.Write(item.PadRight(20).ToUpper());
        }
        Console.WriteLine();
        wordList.List(0, ShowTranslations);

    }
    else if (args.Length == 3)
    {
        WordList wordList = WordList.LoadList(args[1]);
        int langIndex = 0;
        string chosenLanguage = args[2];
        for (int i = 0; i < wordList.Languages.Length; i++)
        {
            if (chosenLanguage == wordList.Languages[i])
            {
                langIndex = i;
            }
        }
        foreach (var item in wordList.Languages)
        {
            Console.Write(item.PadRight(20).ToUpper());
        }
        Console.WriteLine();
        wordList.List(langIndex, ShowTranslations);
    }
    else
    {
        Console.WriteLine($"No file with the name {args[1]}.dat could be found!");
    }
}

void ShowTranslations(string[] args)
{
    foreach (var item in args)
    {
        Console.WriteLine(item.PadRight(20));
    }
    Console.WriteLine();
}

void countWords(string[] args)
{
    WordList wordList = WordList.LoadList(args[1]);
    if (args.Length == 2)
    {
        Console.WriteLine($"{wordList.Name} contains {wordList.Count()} words.");
    }
    else
    {
        Console.WriteLine("Something has went wrong!");
    }
}

void practiceWithWords(string[] args)
{
    WordList wordList = WordList.LoadList(args[1]);
    int answers = 0;
    int tries = 0;
    bool go = true;

    if (wordList is null)
    {
        Console.WriteLine($"No file with the name {args[1]}.dat could be found!");
        return;
    }

    while (go)
    {
        Word practice = wordList.GetWordToPractice();
        string fromLanguage = wordList.Languages[practice.FromLanguage];
        string toLanguage = wordList.Languages[practice.ToLanguage];
        string fromTranslation = practice.Translations[practice.FromLanguage];
        string toTranslation = practice.Translations[practice.ToLanguage];

        Console.WriteLine($"Translate '{fromTranslation}' from {fromLanguage} to {toLanguage}: ");
        string userInput = Console.ReadLine();

        if (string.IsNullOrEmpty(userInput))
        {
            go = false;
            float correctPercentage = ((float)answers / (float)tries) * 100;
            Console.WriteLine($"You were correct {answers} times out of {tries} times.");
            Console.WriteLine($"{correctPercentage}% of your tries were correct!");
            break;
        }
        else if (!string.IsNullOrEmpty(userInput))
        {
            if (userInput.ToUpper() == toTranslation.ToUpper())
            {
                Console.WriteLine("Correct!");
                answers++;
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }
        }
        tries++;
    }
}