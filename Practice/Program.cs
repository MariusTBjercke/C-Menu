using CMenu;

List<string> options = new List<string>
{
    "First",
    "Second",
    "Third",
    "Fourth",
    "Fifth",
    "Sixth",
};

var menu = new Menu(options);
menu.DrawMenu();