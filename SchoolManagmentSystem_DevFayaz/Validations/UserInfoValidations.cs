using FluentValidation;
using SchoolManagmentSystem_DevFayaz.MODELS.Dashboardmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SchoolManagmentSystem_DevFayaz.Validations
{
    public class UserInfoValidations : AbstractValidator<UserinfoModel>
    {
        public UserInfoValidations()
        {
            RuleFor(x=>x.User_Name).NotEmpty().WithMessage("Username is required")
                .Matches("^[a-zA-Z]+$").WithMessage("Only Alphabets allowed")
                .MinimumLength(3).MaximumLength(25);

            RuleFor(x => x.User_Email).NotEmpty().WithMessage("Email is required")
                .Matches(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
            .WithMessage("Invalid email format");

            RuleFor(x => x.User_Role).NotEmpty().WithMessage("Role is required");

            RuleFor(x => x.User_Password).NotEmpty().WithMessage("Password is required")
                .MinimumLength(5).WithMessage("Minimum length is 5 characters")
                .MaximumLength(15).WithMessage("Maximum length is 15 characters");

            RuleFor(x => x.User_Image).NotEmpty().WithMessage("Upload image");

            RuleFor(x => x.User_Status).NotEmpty().WithMessage("UserStatus is required");
            
                




            //Important things for fluentValidation 

            //for email
            //  ^ [a - zA - Z0 - 9._ % +-] + → username part(letters, digits, dot, underscore, etc.)
            //   @ → mandatory @ symbol
            //   [a - zA - Z0 - 9.-] + → domain(e.g., gmail, yahoo)
            //   \.[a-zA - Z]{ 2,} → domain extension(.com, .org)

            //# | Purpose                                                   | Regex
            //1 | Only letters(no space)                                    | ^ [a - zA - Z] +$
            //2 | Letters + spaces                                          | ^ [a - zA - Z ] +$
            //3 | Letters + spaces + dots(.) allowed                        | ^ [a - zA - Z. ] +$
            //4 | Letters + numbers + spaces allowed                        | ^ [a - zA - Z0 - 9 ] +$
            //5 |  Letters + spaces + dash(-) allowed                       | ^ [a - zA - Z - ] +$
            //6 | Letters + numbers + spaces + dots + dash allowed          | ^ [a - zA - Z0 - 9. -] +$


            //            Shorthand Meaning Equivalent
            //                  \d Any digit(0–9)[0 - 9]
            //                  \w Any word character(a–z, A–Z, 0–9, _)	[a-zA - Z0 - 9_]
            //                  \s Any whitespace(space, tab)[ \t\r\n\f]
            //                  \D Anything not a digit[^0 - 9]
            //                  \W Anything not a word character[^a - zA - Z0 - 9_]
        }
    }
}
