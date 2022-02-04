namespace CMenu
{
    internal class Menu
    {
        private int _selectedIndex;
        private readonly List<string> _options;

        public Menu(List<string> options)
        {
            _options = options;
            _selectedIndex = 0;
        }

        public void DrawMenu()
        {
            while (true)
            {
                Console.WriteLine("*** MENU ***");
                for (var i = 0; i < _options.Count; i++)
                {
                    var index = i + 1;
                    if (i == _selectedIndex)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }

                    Console.WriteLine($"{index}. {_options[i]}");
                    if (i == _selectedIndex)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                var input = Console.ReadKey();
                if (input.Key is ConsoleKey.DownArrow)
                {
                    if (_selectedIndex < _options.Count - 1) _selectedIndex++;
                }
                if (input.Key is ConsoleKey.UpArrow)
                {
                    if (_selectedIndex > 0) _selectedIndex--;
                }

                Console.Clear();
            }
        }

    }
}
