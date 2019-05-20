
namespace ERA.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Position { get; set; }
    }

    public class EmployeeInfo
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthPlace { get; set; }
        public string BirthDate { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string Religion { get; set; }
        public string CivilStatus { get; set; }
        public string ProvAddress { get; set; }
        public string CityAddress { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNum { get; set; }
        public EmergencyContact EmergencyContact { get; set; }
        public EmploymentInfo EmploymentInfo { get; set; }
        public DependentsInformation DependentsInformation { get; set; }
    }

    public class EmergencyContact
    {
        public string Name { get; set; }
        public string Relationship { get; set; }
        public string Address { get; set; }
        public string ContactNum { get; set; }
    }

    public class EmploymentInfo
    {
        public string Department { get; set; }
        public string Position { get; set; }
        public string EmploymentStartDate { get; set; }
        public string EmploymentEndDate { get; set; }
        public int IDNumber { get; set; }
        public int Salary { get; set; }
        public int TIN { get; set; }
        public int Pagibig { get; set; }
        public int PhilHealth { get; set; }
        public int SSS { get; set; }
    }

    public class DependentsInformation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public int Age { get; set; }
        public string Relationship { get; set; }
        public string Gender { get; set; }
        public string ProvAddress { get; set; }
        public string CityAddress { get; set; }
    }
}
