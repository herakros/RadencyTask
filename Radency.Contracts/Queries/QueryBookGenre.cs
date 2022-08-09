using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Radency.Contracts.Queries
{
    public class QueryBookGenre
    {
        [BindRequired]
        public string Genre { get; set; }
    }
}
