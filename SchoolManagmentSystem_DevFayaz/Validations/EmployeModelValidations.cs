using FluentValidation;
using SchoolManagmentSystem_DevFayaz.MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystem_DevFayaz.Validations
{
    public class EmployeModelValidations:AbstractValidator<EmployeModel>
    {
        public EmployeModelValidations()
        {
            RuleFor(x => x.Employe_Name).NotEmpty().WithMessage("Employe Name is Required")
                .Matches("^[a-zA-Z ]+$").MinimumLength(3).WithMessage("Min length is 3 characters")
                .MaximumLength(25).WithMessage("Max length is 25 characters");
            RuleFor(x => x.Employe_Cnic).NotEmpty().WithMessage("Cnic is required")
                .Matches("^[0-9]+$").WithMessage("Only Digits are allowed")
                .Length(13).WithMessage("Cnic must be 13 digits");
            RuleFor(x => x.Qualification).NotEmpty().WithMessage("Qualification is required");
            RuleFor(x => x.Designation).NotEmpty().WithMessage("Designation is Required");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required")
                .Matches(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
            .WithMessage("Invalid email format");
        }
    }
}
