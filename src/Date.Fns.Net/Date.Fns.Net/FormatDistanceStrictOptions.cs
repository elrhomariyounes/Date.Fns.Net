using Date.Fns.Net.Services;
using System.Linq;

namespace Date.Fns.Net
{
    /// <summary>
    /// This value type represent the options for the methods : <see cref="IDateService.FormatDistanceStrict"/> and <seealso cref="IDateService.FormatDistanceToNowStrict"/>
    /// </summary>
    public class FormatDistanceStrictOptions
    {
        /// <summary>
        /// Constructs a FormatDistanceStrictOptions with default values. Set <see cref="FormatDistanceStrictOptions.RoundingMethod"/> to "round" and <see cref="FormatDistanceOptions.AddSuffix"/> to false
        /// </summary>
        public FormatDistanceStrictOptions()
        {
            AddSuffix = false;
            RoundingMethod = "round";
        }

        /// <summary>
        /// Result indicates if the second date is earlier or later than the first
        /// </summary>
        public bool AddSuffix { get; set; }

        private string unit;

        /// <summary>
        /// If specified, will force a unit. Accepted values : "second" | "minute" | "hour" | "day" | "month" | "year"
        /// </summary>
        public string Unit
        {
            get
            {
                return this.unit;
            }
            set
            {
                var acceptedValues = new string[] { "second", "minute", "hour", "day", "month", "year" };

                if (!acceptedValues.Contains(value))
                    throw new InvalidOptionException(nameof(Unit), value);
                else this.unit = value;
            }
        }

        private string roundingMethod;

        /// <summary>
        /// Which way to round partial units. Accepted values : "floor" | "ceil" | "round"
        /// </summary>
        public string RoundingMethod 
        {
            get
            {
                return this.roundingMethod;
            }

            set
            {
                var acceptedValues = new string[] { "floor", "ceil", "round"};
                if (!acceptedValues.Contains(value))
                    throw new InvalidOptionException(nameof(RoundingMethod), value);
                else this.roundingMethod = value;
            }
        }
    }
}
