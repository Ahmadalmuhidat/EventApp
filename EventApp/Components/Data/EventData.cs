using EventApp;

namespace EventApp;

public static class EventData
{
    public static List<EventModel> Events = new()
    {
        new EventModel
        {
            Id = 1,
            Name = "Tech Conference 2026",
            Date = new DateTime(2026,5,10),
            Location = "Amman",
            Description = "A conference about modern technology."
        },

        new EventModel
        {
            Id = 2,
            Name = "Corporate Dinner",
            Date = new DateTime(2026,6,15),
            Location = "Dead Sea",
            Description = "Annual company celebration."
        },

        new EventModel
        {
            Id = 3,
            Name = "Startup Meetup",
            Date = new DateTime(2026,7,20),
            Location = "Irbid",
            Description = "Networking event for startups."
        }
    };
}