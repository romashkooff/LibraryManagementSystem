using LibraryManagementSystem.Controllers;
using Spectre.Console;
using static LibraryManagementSystem.Enums;

namespace LibraryManagementSystem;
internal class UserInterface
{
    private readonly BooksController _booksController = new BooksController();
    private readonly MagazineController _magazinesController = new MagazineController();
    private readonly NewspaperController _newspapersController = new NewspaperController();

    internal void MainMenu()
    {
        while (true)
        {
            Console.Clear();

            var choice = AnsiConsole.Prompt(
                new SelectionPrompt<MenuAction>()
                .Title("What do you want to do next?")
                .AddChoices(Enum.GetValues<MenuAction>()));

            if (choice == MenuAction.Exit)
            {
                return;
            }

            var itemTypeChoice = AnsiConsole.Prompt(
                new SelectionPrompt<ItemType>()
                .Title("Select the type of item:")
                .AddChoices(Enum.GetValues<ItemType>()));

            switch (choice)
            {
                case MenuAction.ViewItem:
                    ViewItems(itemTypeChoice);
                    break;
                case MenuAction.AddItem:
                    AddItem(itemTypeChoice);
                    break;
                case MenuAction.DeleteItem:
                    DeleteItem(itemTypeChoice);
                    break;
                case MenuAction.Exit:
                    break;
            }
        }
    }

    private void ViewItems(ItemType itemType)
    {
        switch (itemType)
        {
            case ItemType.Book:
                _booksController.ViewItems();
                break;
            case ItemType.Magazine:
                _magazinesController.ViewItems();
                break;
            case ItemType.Newspaper:
                _newspapersController.ViewItems();
                break;
        }
    }

    private void AddItem(ItemType itemType)
    {
        switch (itemType)
        {
            case ItemType.Book:
                _booksController.AddItem();
                break;
            case ItemType.Magazine:
                _magazinesController.AddItem();
                break;
            case ItemType.Newspaper:
                _newspapersController.AddItem();
                break;
        }
    }

    private void DeleteItem(ItemType itemType)
    {
        switch (itemType)
        {
            case ItemType.Book:
                _booksController.DeleteItem();
                break;
            case ItemType.Magazine:
                _magazinesController.DeleteItem();
                break;
            case ItemType.Newspaper:
                _newspapersController.DeleteItem();
                break;
        }
    }
}
