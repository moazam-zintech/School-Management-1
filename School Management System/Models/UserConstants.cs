namespace School_Management_System.Models
{
    public class UserConstants
    {
        public static List<Register> Users = new List<Register>()
        {
            new Register() { Username = "Admin", Email = "admin@example.com", Password =
                "MyPass_w0rd", ConfirmPassword = "MyPass_w0rd",PhoneNumber="0322-1111111" ,Address = "UK",Role="Administrator"},

            new Register() { Username = "Test", Email = "test@example.com", Password =
                "MyPass_w0rd", ConfirmPassword = "MyPass_w0rd",PhoneNumber="0322-1111111", Address = "UK",Role="Teacher"},
        };
    }
}
