using Spectre.Console;

namespace LibraryManagementSystem.Models;

internal class Magazine : LibraryItem
{
    internal string Publisher { get; set; }
    internal DateTime PublishDate { get; set; }
    internal int IssueNumber { get; set; }

    internal Magazine(int id, string name, string publisher, DateTime publishDate, string location, int issueNumber)
        : base(id, name, location)
    {
        Publisher = publisher;
        PublishDate = publishDate;
        IssueNumber = issueNumber;
    }

    internal override void DisplayDetails()
    {
        var panel = new Panel(new Markup(
            $"[bold]Magazine:[/] [cyan]{Name}[/] published by [cyan]{Publisher}[/]")
            + $"\n[bold]Publish Date:[/] {PublishDate:yyyy-MM-dd}"
            + $"\n[bold]Issue Number:[/] {IssueNumber}"
            + $"\n[bold]Location:[/] [blue]{Location}[/]")
        {
            Border = BoxBorder.Rounded
        };

        AnsiConsole.Write(panel);
    }
}