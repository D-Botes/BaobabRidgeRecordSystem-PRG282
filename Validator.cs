using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;


namespace BaobabRidgeRecordSystem
{
    
    public static class Validator
    {
        
        // Validates an Animal ID, trims whitespace and converts it to uppercase
        // Checks that it matches WR- followed by exactly four digits.
       
        public static bool ValidateAnimalId(
            string input,
            out string cleanedValue,
            out string errorMessage)
        {
            cleanedValue = (input ?? string.Empty).Trim().ToUpperInvariant();
            errorMessage = string.Empty;

            // \A and \z force the WHOLE text to match (no extra characters before or after).
            // [0-9] is used instead of \d so only the digits 0-9 are accepted.
            if (!Regex.IsMatch(cleanedValue, @"\AWR-[0-9]{4}\z"))
            {
                errorMessage =
                    "Animal ID must start with WR- followed by exactly 4 digits.";
                return false;
            }

            return true;
        }

        
        // Validates a name by trimming whitespace and checking its length and ensuring that it does not contain the | delimiter.
        
        public static bool ValidateName(
            string input,
            out string cleanedValue,
            out string errorMessage)
        {
            cleanedValue = (input ?? string.Empty).Trim();
            errorMessage = string.Empty;

            if (cleanedValue.Length < 1 || cleanedValue.Length > 30)
            {
                errorMessage = "Name must contain between 1 and 30 characters.";
                return false;
            }

            if (cleanedValue.Contains("|"))
            {
                errorMessage = "Name must not contain the | character.";
                return false;
            }

            return true;
        }

        // Validates a species by trimming whitespace and checking its length
        // and ensuring that it does not contain the | delimiter.
        
        public static bool ValidateSpecies(
            string input,
            out string cleanedValue,
            out string errorMessage)
        {
            cleanedValue = (input ?? string.Empty).Trim();
            errorMessage = string.Empty;

            if (cleanedValue.Length < 1 || cleanedValue.Length > 30)
            {
                errorMessage = "Species must contain between 1 and 30 characters.";
                return false;
            }

            if (cleanedValue.Contains("|"))
            {
                errorMessage = "Species must not contain the | character.";
                return false;
            }

            return true;
        }

        
        // Validates that Age is a whole number between 0 and 100,
        // after trimming whitespace from the input

        public static bool ValidateAge(
            string input,
            out string cleanedValue,
            out string errorMessage)
        {
            cleanedValue = (input ?? string.Empty).Trim();
            errorMessage = string.Empty;

            int age;

            // NumberStyles.None accepts digits only 
            // InvariantCulture keeps the result the same on any regional setting.
            if (!int.TryParse(cleanedValue, NumberStyles.None,
                    CultureInfo.InvariantCulture, out age) ||
                age < 0 || age > 100)
            {
                errorMessage =
                    "Age must be a whole number between 0 and 100.";
                return false;
            }

            cleanedValue = age.ToString(CultureInfo.InvariantCulture);
            return true;
        }

      
        // Validates that Recovery Score is a whole number between 0 and 100 after trimming whitespace from the input.
        public static bool ValidateRecoveryScore(
            string input,
            out string cleanedValue,
            out string errorMessage)
        {
            cleanedValue = (input ?? string.Empty).Trim();
            errorMessage = string.Empty;

            int score;

            // Same digits-only parsing as Age.
            if (!int.TryParse(cleanedValue, NumberStyles.None,
                    CultureInfo.InvariantCulture, out score) ||
                score < 0 || score > 100)
            {
                errorMessage =
                    "Recovery Score must be a whole number between 0 and 100.";
                return false;
            }

            cleanedValue = score.ToString(CultureInfo.InvariantCulture);
            return true;
        }
    }
}

