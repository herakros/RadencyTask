using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Radency.Contracts.Queries
{
    public class QuerySecretKey
    {
        [BindRequired]
        public string Key { get; set; }
    }
}
