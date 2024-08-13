using Microsoft.EntityFrameworkCore;

public class StudentService : IStudentService
{
    private readonly ApplicationDbContext _context;

    public StudentService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<StudentDto>> GetAllStudentsAsync()
    {
        var students = await _context.Students.ToListAsync();
        return students.Select(student => new StudentDto
        {
            Id = student.Id,
            IndexNumber = student.IndexNumber,
            FirstName = student.FirstName,
            LastName = student.LastName,
            Course = student.Course,
            CreatedAt = student.CreatedAt,
            UpdatedAt = student.UpdatedAt
        }).ToList();
    }

    public async Task<StudentDto?> GetStudentByIdAsync(int id)
    {
        var student = await _context.Students.FindAsync(id);
        if (student == null) return null;

        return new StudentDto
        {
            Id = student.Id,
            IndexNumber = student.IndexNumber,
            FirstName = student.FirstName,
            LastName = student.LastName,
            Course = student.Course,
            CreatedAt = student.CreatedAt,
            UpdatedAt = student.UpdatedAt
        };
    }

    public async Task<StudentDto> CreateStudentAsync(StudentDto studentDto)
    {
        var student = new Student
        {
            IndexNumber = studentDto.IndexNumber,
            FirstName = studentDto.FirstName,
            LastName = studentDto.LastName,
            Course = studentDto.Course,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow
        };

        _context.Students.Add(student);
        await _context.SaveChangesAsync();

        studentDto.Id = student.Id;
        studentDto.CreatedAt = student.CreatedAt;
        studentDto.UpdatedAt = student.UpdatedAt;

        return studentDto;
    }

    public async Task<bool> UpdateStudentAsync(int id, StudentDto studentDto)
    {
        var student = await _context.Students.FindAsync(id);
        if (student == null) return false;

        student.IndexNumber = studentDto.IndexNumber;
        student.FirstName = studentDto.FirstName;
        student.LastName = studentDto.LastName;
        student.Course = studentDto.Course;
        student.UpdatedAt = DateTime.UtcNow;

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteStudentAsync(int id)
    {
        var student = await _context.Students.FindAsync(id);
        if (student == null) return false;

        _context.Students.Remove(student);
        await _context.SaveChangesAsync();
        return true;
    }
}
