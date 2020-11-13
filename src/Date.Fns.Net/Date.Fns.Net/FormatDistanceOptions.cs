using Date.Fns.Net.Services;
namespace Date.Fns.Net
{
    /// <summary>
    /// This value type represent the options for the methods : <see cref="IDateService.FormatDistance"/> and <seealso cref="Date.Fns.Net.Services.IDateService.FormatDistanceToNow"/>
    /// </summary>
    public class FormatDistanceOptions
    {
        /// <summary>
        /// Constructs a FormatDistanceOptions with default values. Set <see cref="FormatDistanceOptions.IncludeSeconds"/> to false and <see cref="FormatDistanceOptions.AddSuffix"/> to false
        /// </summary>
        public FormatDistanceOptions()
        {
            IncludeSeconds = false;
            AddSuffix = false;
        }

        /// <summary>
        /// Set to true if distances less than a minute to be more detailed
        /// </summary>
        public bool IncludeSeconds { get; set; }

        /// <summary>
        /// Result indicates if the second date is earlier or later than the first
        /// </summary>
        public bool AddSuffix { get; set; }

    }
}
