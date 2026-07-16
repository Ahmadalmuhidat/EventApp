namespace EventApp;

public class EventStateService
{
    public string? CurrentUser { get; set; }

    public List<int> RegisteredEvents { get; set; } = new();
}