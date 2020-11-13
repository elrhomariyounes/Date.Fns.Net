using System;
using System.Threading.Tasks;

namespace Date.Fns.Net.Services
{
    /// <summary>
    /// Date Service
    /// </summary>
    public interface IDateService
    {
        /// <summary>
        /// Calculate the distance between the two given dates. An optional parameter options <see cref="FormatDistanceOptions"/> can be passed.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="baseDate"></param>
        /// <param name="options"></param>
        /// <returns>Return the distance between the given dates in words.</returns>
        /// <exception cref="InvalidOptionException">Throw when a invalid value are set to an option</exception>
        Task<string> FormatDistance(DateTime date, DateTime baseDate, FormatDistanceOptions options = null);

        /// <summary>
        /// Calculate the distance between the given date and now. An optional parameter options <see cref="FormatDistanceOptions"/> can be passed. 
        /// </summary>
        /// <param name="date"></param>
        /// <param name="options"></param>
        /// <returns>Return the distance between the given date and now in words.</returns>
        /// <exception cref="InvalidOptionException">Throw when a invalid value are set to an option</exception>
        Task<string> FormatDistanceToNow(DateTime date, FormatDistanceOptions options = null);

        /// <summary>
        /// Calculate the distance between the two given dates. An optional parameter options <see cref="FormatDistanceStrictOptions"/> can be passed.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="baseDate"></param>
        /// <param name="options"></param>
        /// <returns>Return the distance between the given dates in words, using strict units. This is like <see cref="FormatDistance"/>, but does not use helpers like 'almost', 'over', 'less than' and the like.</returns>
        /// <exception cref="InvalidOptionException">Throw when a invalid value are set to an option</exception>
        Task<string> FormatDistanceStrict(DateTime date, DateTime baseDate, FormatDistanceStrictOptions options = null);

        /// <summary>
        /// Calculate the distance between the two given dates. An optional parameter options <see cref="FormatDistanceStrictOptions"/> can be passed.
        /// </summary>
        /// <param name="date"></param>
        /// <param name="options"></param>
        /// <returns>Return the distance between the given dates in words, using strict units. This is like <see cref="FormatDistanceToNow"/>, but does not use helpers like 'almost', 'over', 'less than' and the like.</returns>
        /// <exception cref="InvalidOptionException">Throw when a invalid value are set to an option</exception>
        Task<string> FormatDistanceToNowStrict(DateTime date, FormatDistanceStrictOptions options = null);

    }
}
