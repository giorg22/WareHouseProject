﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Service.AccountentTrees.Commands
{
    public class CreateAccountentTreeCommand
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public string FullCode;
    }
    public class CreateAccountTreeCommandValidator : AbstractValidator<CreateAccountentTreeCommand>
    {
        public CreateAccountTreeCommandValidator()
        {

        }
    }

}
