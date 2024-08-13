public class Student
{
    public int Id { get; set; } // Auto-incrementing primary key
    public string? IndexNumber { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Course { get; set; }
    
    public DateTime CreatedAt { get; set; } // Timestamp for when the entity is created
    public DateTime UpdatedAt { get; set; } // Timestamp for when the entity is last updated
}
