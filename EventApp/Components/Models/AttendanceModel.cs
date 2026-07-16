public class Attendance
{
    public int Id { get; set; }

    public int EventId { get; set; }

    public string UserName { get; set; } = "";

    public bool Attended { get; set; }
}