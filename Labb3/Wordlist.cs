namespace ClassLibrary
{
    public class WordList : Word
    {

        private List<Word> words = new List<Word>();
        public string Name { get; }
        public string[] Languages { get; }

        public WordList(string name, params string[] languages)
        {
            this.Name = name;
            this.Languages = languages;
        }

        public static string[] GetLists()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string pathFile = Path.Combine(path, "Labb3");
            if (!Directory.Exists(pathFile))
            {
                return null;
            }
            string[] files = Directory.GetFiles(pathFile, "*.dat");
            string[] lists = files.Select(file => Path.GetFileNameWithoutExtension(file)).ToArray();

            return lists;
        }

        public static WordList LoadList(string name)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string pathFile = Path.Combine(path, "Labb3", name + ".dat");
            try
            {
                using (StreamReader reader = new StreamReader(pathFile))
                {
                    string[] languages = reader.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                    WordList thisList = new WordList(name, languages);
                    while (!reader.EndOfStream)
                    {
                        var input = reader.ReadLine();
                        if (!string.IsNullOrWhiteSpace(input))
                        {
                            string[] words = input.Split(';', StringSplitOptions.RemoveEmptyEntries);
                            thisList.Add(words);
                        }
                    }
                    return thisList;
                }
            }
            catch (Exception)
            {
                throw new ArgumentException("Couldn't find the selected file!");
            }
        }

        public void Save()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string pathFile = Path.Combine(path, "Labb3", Name + ".dat");
            DirectoryInfo directoryInfo = new DirectoryInfo(pathFile); 
            /*if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }*/
            using (TextWriter writer = new StreamWriter(pathFile))
            {
                writer.WriteLine(String.Join(';', Languages));
                foreach (Word thisWord in words)
                {
                    writer.WriteLine(String.Join(';', thisWord.Translations));
                }
                writer.Close();
            }
        }

        public void Add(params string[] translations)
        {
            words.Add(new Word(translations));
        }

        public bool Remove(int translation, string word)
        {
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Translations.Contains(word))
                {
                    words.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public int Count()
        {
            return words.Count;
        }

        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            List<Word> sortedWordlist = words.OrderBy(w => w.Translations[sortByTranslation]).ToList();
            foreach (Word word in sortedWordlist)
            {
                showTranslations(word.Translations);
            }
        }

        public Word GetWordToPractice()
        {
            Random rnd = new Random();

            int rndFrom = rnd.Next(0, Languages.Length);
            int rndTo = rnd.Next(0, Languages.Length);

            while (rndFrom == rndTo)
            {
                rndFrom = rnd.Next(Languages.Length);
            }

            int rndWord = rnd.Next(words.Count);
            Word wordForPractice = words[rndWord];
            wordForPractice = new Word(rndFrom, rndTo, wordForPractice.Translations);

            return wordForPractice;

        }


    }
}
