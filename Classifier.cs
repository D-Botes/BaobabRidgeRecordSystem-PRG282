namespace BaobabRidgeRecordSystem
{
    // Static class since it does not store any data, it just calculates
    static class Classifier
    {
        // Strings for statuses, const to ensure it doesnt change
        public const string Critical = "Critical";
        public const string Serious = "Serious";
        public const string Stable = "Stable";
        public const string Recovering = "Recovering";
        public const string ReleaseReady = "Release-Ready";

        // String for housing units
        public const string ICU = "Intensive Care Unit";
        public const string HDW = "High-Dependency Ward";
        public const string RecoveryWard = "Recovery Ward";
        public const string OutdoorEnclosure = "Outdoor Enclosure";
        public const string PreReleaseCamp = "Pre-Release Camp";

        // This is a Tuple method, which takes the recoveryScore as a parameter and then it returns two values, the status and the housingunit
        public static (string Status, string HousingUnit) Classify(int recoveryScore)
        {
            // This part simply checks for a out of range value
            if (recoveryScore < 0 || recoveryScore > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(recoveryScore));
            }

            // Here we check the value and return the corresponding status and housing units
            else if (recoveryScore >= 80)
            {
                return (ReleaseReady, PreReleaseCamp);
            }
            else if (recoveryScore >= 60)
            {
                return (Recovering, OutdoorEnclosure);
            }
            else if (recoveryScore >= 40)
            {
                return (Stable, RecoveryWard);
            }
            else if (recoveryScore >= 20)
            {
                return (Serious, HDW);
            }
            else
            {
                return (Critical, ICU);
            }

        }
    }
}
