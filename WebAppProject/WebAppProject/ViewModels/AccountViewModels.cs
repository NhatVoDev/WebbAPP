namespace WebAppProject.ViewModels
{
    public class AccountViewModels
    {
        public int? Id { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }

        public string? Err { get; set; }
    }
}
