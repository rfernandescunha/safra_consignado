using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Safra.Application.ViewModels
{
    public class BaseViewModels
    {
        public bool Valid { get; set; }
        public bool Invalid => !Valid;
        public ValidationResult ValidationResult { get; set; }
    }
}
