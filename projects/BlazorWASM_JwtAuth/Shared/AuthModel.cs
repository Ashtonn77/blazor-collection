using System.ComponentModel.DataAnnotations;

namespace BlazorWASM_JwtAuth.Shared
{
    public class LoginResult
    {
        public string Message { get; set; }

        public string Email { get; set; }

        public string JwtBearer { get; set; }

        public bool Success { get; set; }

    }

    public class LoginModel
    {

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Email is invalid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }

    public class RegisterModel : LoginModel
    {
        [Required(ErrorMessage = "Confirm Password is required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords don't match")]
        public string ConfirmPassword { get; set; }
    }

}