using FluentValidation;
using SchoolManagmentSystem_DevFayaz.MODELS.Dashboardmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystem_DevFayaz.Validations
{
    public class ClassModelValidations:AbstractValidator<ClassModel>
    {
        public ClassModelValidations()
        {
            RuleFor(x=>x.ClassName).NotEmpty().WithMessage("Class name is required");
            RuleFor(x => x.Section).NotEmpty().WithMessage("Section is Required");    
        }
    }
}
