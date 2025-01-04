namespace LibraryManagementSystem.Models;

internal abstract class LibraryItem
{
    internal int Id { get; set; }
    internal string Name { get; set; }
    internal string Location { get; set; }

    protected LibraryItem(int id, string name, string location)
    {
        Id = id;
        Name = name;
        Location = location;
    }

    internal abstract void DisplayDetails();
}

