using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace Date.Fns.Net.Services
{

    /// <inheritdoc cref="IDateService"/>
    public class DateService : IDateService
    {
        private readonly IJSRuntime _jsRuntime;

        public DateService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task<string> FormatDistance(DateTime date, DateTime baseDate, FormatDistanceOptions options = null)
        {
            var opts = options ?? new FormatDistanceOptions();
            return await _jsRuntime.InvokeAsync<string>("MyLib.FormatDistance", date, baseDate, opts);
        }

        public async Task<string> FormatDistanceStrict(DateTime date, DateTime baseDate, FormatDistanceStrictOptions options = null)
        {
            var opts = options ?? new FormatDistanceStrictOptions();
            return await _jsRuntime.InvokeAsync<string>("MyLib.FormatDistanceStrict", date, baseDate, opts);
        }

        public async Task<string> FormatDistanceToNow(DateTime date, FormatDistanceOptions options = null)
        {
            var opts = options ?? new FormatDistanceOptions();
            return await _jsRuntime.InvokeAsync<string>("MyLib.FormatDistanceToNow", date, opts);
        }

        public async Task<string> FormatDistanceToNowStrict(DateTime date, FormatDistanceStrictOptions options = null)
        {
            var opts = options ?? new FormatDistanceStrictOptions();
            return await _jsRuntime.InvokeAsync<string>("MyLib.FormatDistanceToNowStrict", date, opts);
        }
    }
}
