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
        // Validates the Animal ID and converts it to uppercase and the ID must start with WR- followed by exactly four digits.
        public static bool ValidateAnimalId(
            string input,
            out string cleanedValue,
            out string error)
        { 
             //stops a crash if the input is ever null
            cleanedValue = (input ?? string.Empty).Trim().ToUpperInvariant();
            error = string.Empty;

            //force the whole text to match, and only accept [0-9]
            if (!Regex.IsMatch(cleanedValue, @"\AWR-[0-9]{4}\z"))
            {
                error = "Animal ID must start with WR- followed by exactly four digits (e.g. WR-0001).";
                return false;
            }

            return true;
        }

        // Validates the animal's name.
        public static bool ValidateName(
            string input,
            out string cleanedValue,
            out string error)
        {
            cleanedValue = (input ?? string.Empty).Trim();
            error = string.Empty;

            if (cleanedValue.Length < 1 || cleanedValue.Length > 30)
            {
                error = "Name must contain between 1 and 30 characters.";
                return false;
            }

            if (cleanedValue.Contains("|"))
            {
                error = "Name cannot contain the | character.";
                return false;
            }

            return true;
        }

        // Validates the animal's species.
        public static bool ValidateSpecies(
            string input,
            out string cleanedValue,
            out string error)
        {
            cleanedValue = (input ?? string.Empty).Trim();
            error = string.Empty;

            if (cleanedValue.Length < 1 || cleanedValue.Length > 30)
            {
                error = "Species must contain between 1 and 30 characters.";
                return false;
            }

            if (cleanedValue.Contains("|"))
            {
                error = "Species cannot contain the | character.";
                return false;
            }

            return true;
        }

        // Validates the animal's age.
        public static bool ValidateAge(
            string input,
            out string cleanedValue,
            out string error)
        {
            cleanedValue = (input ?? string.Empty).Trim();
            error = string.Empty;

            // NumberStyles.None accepts digits only
            if (!int.TryParse(
                cleanedValue,
                NumberStyles.None,
                CultureInfo.InvariantCulture,
                out int age))
            {
                error = "Age must be a whole number containing digits only.";
                return false;
            }

            if (age < 0 || age > 100)
            {
                error = "Age must be between 0 and 100.";
                return false;
            }

            // Rewrite the number in clean form so "007" becomes "7"
            cleanedValue = age.ToString(CultureInfo.InvariantCulture);
            return true;
        }

        // Validates the animal's recovery score.
        public static bool ValidateRecoveryScore(
            string input,
            out string cleanedValue,
            out string error)
        {
            cleanedValue = (input ?? string.Empty).Trim();
            error = string.Empty;

            // Same digits-only parsing as Age
            if (!int.TryParse(
                cleanedValue,
                NumberStyles.None,
                CultureInfo.InvariantCulture,
                out int score))
            {
                error = "Recovery Score must be a whole number containing digits only.";
                return false;
            }

            if (score < 0 || score > 100)
            {
                error = "Recovery Score must be between 0 and 100.";
                return false;
            }

            // Rewrite the number in clean form
            cleanedValue = score.ToString(CultureInfo.InvariantCulture);
            return true;
        }
    }
}
