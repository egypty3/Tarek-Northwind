using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System.Web;

namespace NorthwindWeb.ViewModels
{
    /// <summary>
    /// Index view.
    /// </summary>
    public class IndexViewModel
    {
        /// <summary>
        /// Has a password.
        /// </summary>
        public bool HasPassword { get; set; }

        /// <summary>
        /// Logins.
        /// </summary>
        public IList<UserLoginInfo> Logins { get; set; }

        /// <summary>
        /// Phone number.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Two factor log-in.
        /// </summary>
        public bool TwoFactor { get; set; }

        /// <summary>
        /// Browser remember.
        /// </summary>
        public bool BrowserRemembered { get; set; }
    }

    /// <summary>
    /// Manage logins.
    /// </summary>
    public class ManageLoginsViewModel
    {
        /// <summary>
        /// Current login.
        /// </summary>
        public IList<UserLoginInfo> CurrentLogins { get; set; }

        /// <summary>
        /// Others login.
        /// </summary>
        public IList<AuthenticationDescription> OtherLogins { get; set; }
    }

    /// <summary>
    /// Factor view model.
    /// </summary>
    public class FactorViewModel
    {
        /// <summary>
        /// Purpose.
        /// </summary>
        public string Purpose { get; set; }
    }

    /// <summary>
    /// Set password view.
    /// </summary>
    public class SetPasswordViewModel
    {
        /// <summary>
        /// New password.
        /// </summary>
        [Required]
        [StringLength(100, ErrorMessage = "{0} must contain at least {2} characters.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        /// <summary>
        /// Confirm password.
        /// </summary>
        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }

    /// <summary>
    /// Change password view.
    /// </summary>
    public class ChangePasswordViewModel
    {
        /// <summary>
        /// Old.
        /// </summary>
        [Required(ErrorMessage = "The current password is required")]
        [DataType(DataType.Password)]
        [Display(Name = "Current Password")]
        public string OldPassword { get; set; }

        /// <summary>
        /// New.
        /// </summary>
        [Required(ErrorMessage = "The new password is required")]
        [StringLength(100, ErrorMessage = "{0} must contain at least {2} characters.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        /// <summary>
        /// Confirmed password.
        /// </summary>
        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
    /// <summary>
    /// Change Email view.
    /// </summary>
    public class ChangeEmailViewModel
    {
        /// <summary>
        /// Password
        /// </summary>
        [Required(ErrorMessage = "This field '{0}' is required!")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        /// <summary>
        /// Email.
        /// </summary>
        [Required(ErrorMessage = "This field '{0}' is required!")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
    }
    /// <summary>
    /// Change Email view.
    /// </summary>
    public class ChangeProfileViewModel
    {
        /// <summary>
        /// Password
        /// </summary>
        [Required(ErrorMessage = "This field '{0}' is required!")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        /// <summary>
        /// The image user.
        /// </summary>
        [Display(Name = "Profile photo")]
        public HttpPostedFileBase UserImage { get; set; }
    }

    /// <summary>
    /// Add phone number.
    /// </summary>
    public class AddPhoneNumberViewModel
    {
        /// <summary>
        /// Phone number.
        /// </summary>
        [Required]
        [Phone]
        [Display(Name = "Phone")]
        public string Number { get; set; }
    }

    /// <summary>
    /// Verify phone view.
    /// </summary>
    public class VerifyPhoneNumberViewModel
    {
        /// <summary>
        /// Code.
        /// </summary>
        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }

        /// <summary>
        /// Number of phone.
        /// </summary>
        [Required]
        [Phone]
        [Display(Name = "Phone")]
        public string PhoneNumber { get; set; }
    }

    /// <summary>
    /// Configure TwoFactor View.
    /// </summary>
    public class ConfigureTwoFactorViewModel
    {
        /// <summary>
        /// Provider.
        /// </summary>
        public string SelectedProvider { get; set; }

        /// <summary>
        /// Providers collection.
        /// </summary>
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
    }
}