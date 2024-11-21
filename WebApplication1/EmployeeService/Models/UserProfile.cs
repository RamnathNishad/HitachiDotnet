namespace EmployeeService.Models
{
    public class UserProfile
    {
        public int Id { get; set; }   //profile id as PK        
        public int UserId { get; set; }
        public string FullName { get; set; }

        public User User { get; set; }
    }
}
