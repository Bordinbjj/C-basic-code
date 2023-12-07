public class Show
{
    public string Title { get; set; }
    public DateTime Time { get; set; }
    public int AvailableSeats { get; set; }
}

public class ReservationSystem
{
    private List<Show> shows = new List<Show>();

    public void AddShow(string title, DateTime time, int availableSeats)
    {
        shows.Add(new Show { Title = title, Time = time, AvailableSeats = availableSeats });
    }

    public bool MakeReservation(string title, int numberOfSeats)
    {
        var show = shows.Find(s => s.Title == title && s.AvailableSeats >= numberOfSeats);

        if (show != null)
        {
            show.AvailableSeats -= numberOfSeats;
            return true;
        }

        return false;
    }
}
