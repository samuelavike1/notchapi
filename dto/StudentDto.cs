public class StudentDto
{
    public int Id { get; set; }
    public string? IndexNumber { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Course { get; set; }
    public DateTime CreatedAt { get; set; } // Automatically set on creation
    public DateTime UpdatedAt { get; set; } // Automatically updated on modification
}
