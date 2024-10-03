namespace CIS3285_Unit4_StudentMVC_2024.Models
{
    public class StudentRepository : IStudentCRUDInterface
    {
        // Use IStudentInterface for the list (Max Lasitsa)
        static List<IStudentInterface> myStudents = new List<IStudentInterface>();

        public StudentRepository()
        {
            if (myStudents.Count == 0)
            {
                // Initialize the list with StudentModel instances (constructors remain unchanged) (Max Lasitsa)
                myStudents.Add(new StudentModel(1001, "Tom", 16));
                myStudents.Add(new StudentModel(1002, "Jen", 8));
                myStudents.Add(new StudentModel(1003, "Sabah", 16));
            }
        }

        // Return the list of IStudentInterface instead of StudentModel (Max Lasitsa)
        public List<IStudentInterface> getAllStudent()
        {
            return myStudents;
        }

        // Return IStudentInterface instead of StudentModel (Max Lasitsa)
        public IStudentInterface getStudentById(int id)
        {
            foreach (IStudentInterface student in myStudents)
            {
                if (student.Id == id)
                {
                    return student;
                }
            }
            return nullStudent();
        }

        // Return IStudentInterface instead of StudentModel (Max Lasitsa)
        public IStudentInterface getOneStudent(int index)
        {
            return myStudents[index];
        }

        // Create a null student using StudentModel constructor (Max Lasitsa)
        private IStudentInterface nullStudent()
        {
            return new StudentModel(-1, "Null Student", -999);
        }

        // Add an IStudentInterface to the list (Max Lasitsa)
        public void AddStudent(IStudentInterface newStudent)
        {
            myStudents.Add(newStudent);
        }

        // Delete a student by ID (Max Lasitsa)
        public void DeleteStudent(int studentId)
        {
            int index = myStudents.FindIndex(student => student.Id == studentId);
            myStudents.RemoveAt(index);
        }

        // Update a student by ID (Max Lasitsa)
        public void UpdateStudent(int studentId, IStudentInterface updatedStudent)
        {
            int index = myStudents.FindIndex(student => student.Id == studentId);
            myStudents[index] = updatedStudent;
        }
    }
}
