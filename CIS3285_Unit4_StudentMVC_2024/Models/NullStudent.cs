namespace CIS3285_Unit4_StudentMVC_2024.Models
{
    public class NullStudent : IStudentInterface
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }

        public NullStudent()
        {
            Id = -1;
            Name = "none";
            Credits = -1;
        }
    }


}
