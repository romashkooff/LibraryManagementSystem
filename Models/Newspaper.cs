using Spectre.Console;

namespace LibraryManagementSystem.Models;

internal class Newspaper : LibraryItem
{
    internal string Publisher { get; set; }
    internal DateTime PublishDate { get; set; }

    internal Newspaper(int id, string name, string publisher, DateTime publishDate, string location)
        : base(id, name, location)
    {
        Publisher = publisher;
        PublishDate = publishDate;
    }

    internal override void DisplayDetails()
    {
        var panel = new Panel(new Markup(
            $"[bold]Newspaper:[/] [cyan]{Name}[/] published by [cyan]{Publisher}[/]")
            + $"\n[bold]Publish Date:[/] {PublishDate:yyyy-MM-dd}"
            + $"\n[bold]Location:[/] [blue]{Location}[/]")
        {
            Border = BoxBorder.Rounded
        };

        AnsiConsole.Write(panel);
    }
}