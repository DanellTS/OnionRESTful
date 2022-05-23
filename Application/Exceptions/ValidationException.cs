﻿using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    internal class ValidationException : Exception 
    {
        public List<string> Errors { get;}

        public ValidationException() : base("One or more validation errors have occurred")
        {
            Errors = new List<string>();
            
        }

        public ValidationException(IEnumerable<ValidationFailure> failures) : this()
        {
            foreach (var failure in failures)
            {
                Errors.Add(failure.ErrorMessage);
            }
        }

    }
}
