using FluentValidation;
using SchoolManagmentSystem_DevFayaz.MODELS;
using SchoolManagmentSystem_DevFayaz.MODELS.Dashboardmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystem_DevFayaz.Validations
{
    public class StudentModelValidations:AbstractValidator<StudentsModel>
    {
        public StudentModelValidations()
        {
            RuleFor(x=>x.Student_Name).NotEmpty().WithMessage("Student name is required")
                .MinimumLength(3).MaximumLength(25).Matches("^[a-zA-Z ]+$")
                .WithMessage("Only alphabets allowed");
            RuleFor(x=>x.Father_Name).NotEmpty().WithMessage("Father name is required")
                .MinimumLength(3).MaximumLength(25).Matches("^[a-zA-Z ]+$")
                .WithMessage("Only alphabets allowed");
            RuleFor(x => x.Roll_Number).NotEmpty().WithMessage("Roll number is required");
            RuleFor(x => x.DomicileFront).NotEmpty().WithMessage("Upload Domicile front image ");
            RuleFor(x=>x.DomicileBack).NotEmpty().WithMessage("Upload Domicile back image ");
            RuleFor(x => x.StudentFormBImage).NotEmpty().WithMessage("Upload formb image");
        }
    }
}
