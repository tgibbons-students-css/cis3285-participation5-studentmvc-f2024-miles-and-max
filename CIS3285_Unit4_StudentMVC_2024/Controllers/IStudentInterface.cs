namespace CIS3285_Unit4_StudentMVC_2024.Models
{
    public interface IStudentInterface
    {
        int Id { get; set; }
        string Name { get; set; }
        int Credits { get; set; }
    }
}