using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Radency.Contracts.Queries
{
    public class QueryOrderBooks
    {
        [BindRequired]
        public string Order { get; set; }
    }
}
