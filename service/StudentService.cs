public interface IStudentService
{
    Task<IEnumerable<StudentDto>> GetAllStudentsAsync();
    Task<StudentDto?> GetStudentByIdAsync(int id);
    Task<StudentDto> CreateStudentAsync(StudentDto studentDto);
    Task<bool> UpdateStudentAsync(int id, StudentDto studentDto);
    Task<bool> DeleteStudentAsync(int id);
}