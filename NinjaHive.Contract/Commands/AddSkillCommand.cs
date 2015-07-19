﻿using System.ComponentModel.DataAnnotations;
using NinjaHive.Contract.DTOs;
using NinjaHive.Core.Validations;

namespace NinjaHive.Contract.Commands
{
    public class AddSkillCommand
    {
        [Required]
        [ValidateObject]
        public Skill Skill { get; set; }
    }
}
