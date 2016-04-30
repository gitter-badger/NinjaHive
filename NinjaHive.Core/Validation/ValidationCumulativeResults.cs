﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace NinjaHive.Core.Validation
{
    public class ValidationCumulativeResults : ValidationResult
    {
        private readonly ICollection<ValidationResult> resultsCollection;

        public ValidationCumulativeResults(string errorMessage)
            : base(errorMessage)
        {
            resultsCollection = new Collection<ValidationResult>();
        }

        public ValidationCumulativeResults(string errorMessage, IEnumerable<ValidationResult> results)
            : base(errorMessage)
        {
            resultsCollection = new Collection<ValidationResult>();
            AddResults(results);
            ErrorMessage = CreateErrorMessage(errorMessage);
        }

        public ValidationCumulativeResults(string errorMessage, IEnumerable<string> memberNames) :base(errorMessage, memberNames)
        {
            resultsCollection = new Collection<ValidationResult>();
        }

        public ValidationCumulativeResults(string errorMessage, IEnumerable<string> memberNames, IEnumerable<ValidationResult> results)
            : base(errorMessage, memberNames)
        {
            resultsCollection = new Collection<ValidationResult>();
            AddResults(results);
        }

        public ValidationCumulativeResults(ValidationResult result): base(result)
        {
            resultsCollection = new Collection<ValidationResult>();
        }

        public void AddResult(ValidationResult result)
        {
            if (result == null)
            {
                throw new ArgumentNullException("result");
            }

            resultsCollection.Add(result);
        }

        public void AddResults(IEnumerable<ValidationResult> results)
        {
            if (results == null)
                throw new ArgumentNullException("results");

            foreach (var result in results)
            {
                resultsCollection.Add(result);
            }
        }

        public IEnumerable<ValidationResult> ResultsCollection
        {
            get
            {
                return resultsCollection;
            }
        }

        private string CreateErrorMessage(string topLevelMessage)
        {
            return string.Format("{0} Inner-Exceptions:{{\n\t-{1}}}",
                topLevelMessage,
                string.Join("\n\t-", resultsCollection));
        }
    }
}
