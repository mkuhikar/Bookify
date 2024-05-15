using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Domain.Shared
{
    public record Currency
    {
        public static readonly Currency Usd = new("USD");
        public static readonly Currency Eur = new("EUR");
        public static readonly Currency None = new("");
        public string Code { get; init; }
        private Currency(string code) => Code = code;

        public static Currency FromCode(string code)
        {
            return All.FirstOrDefault(c => c.Code == code) ??
                throw new ApplicationException("The currency code is invalid");
        }

        public static readonly IReadOnlyCollection<Currency> All = new[]
        {
            Usd, Eur
        };

    }
}
