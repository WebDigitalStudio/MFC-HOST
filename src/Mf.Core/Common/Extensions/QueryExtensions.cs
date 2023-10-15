using System.Linq;
using Abp.ObjectMapping;

namespace Mf.Common.Extensions;

public static class QueryExtensions
{
    // AutoMapper Extensions
    public static IQueryable<TOut> ProjectTo<TOut>(this IQueryable query, IObjectMapper mapper)
    {
        return mapper.ProjectTo<TOut>(query);
    }
}