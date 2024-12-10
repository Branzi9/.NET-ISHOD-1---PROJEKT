namespace Todoer.Models;

public class Todo{
    public int Id { get; set; }
    public string Naslov { get; set; }

    public bool IsCompleted { get; set; }

    public DateOnly dateOnly{ get; set; }
}