﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using NinjaHive.Core.Helpers;
using NinjaHive.Core.Validation.Attributes;

namespace NinjaHive.Contract.Models
{
    public class MainCategoryModel : IModel, IValidatable
    {
        public MainCategoryModel()
        {
            this.ValidationResults = new Collection<ValidationResult>();
        }

        public Guid Id { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "{0}, minimum: {2}, maximum: {1}")]
        [RegularExpression(RegEx.AlphaNumUnderscoreSpace, ErrorMessage = "a-z 0-9 spaces underscores")]
        [RequiredForValidation]
        public string Name { get; set; }

        [RequiredForValidation]
        public IEnumerable<SubCategoryModel> SubCategories { get; set; }

        public ICollection<ValidationResult> ValidationResults { get; }
    }
}
