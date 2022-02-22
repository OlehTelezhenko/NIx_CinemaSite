namespace lesson22._2._22.Models
{
    public class Shedule
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public List<Lesson> Lessons { get; set; }
    }
}
