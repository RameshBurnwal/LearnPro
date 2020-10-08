using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;

namespace CQRS.Mappers
{
    public static class MapperExtensions
    {
        /*
        public static async Task<List<TDestination>> ProjectToListAsync<TDestination>(this IQueryable queryable)
        {
            return await queryable.ProjectTo<TDestination>().DecompileAsync().ToListAsync();
        }

        public static IQueryable<TDestination> ProjectToQueryable<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().Decompile();
        }

        public static IPagedList<TDestination> ProjectToPagedList<TDestination>(this IQueryable queryable, int pageNumber, int pageSize)
        {
            return queryable.ProjectTo<TDestination>().Decompile().ToPagedList(pageNumber, pageSize);
        }

        public static async Task<TDestination> ProjectToSingleOrDefaultAsync<TDestination>(this IQueryable queryable)
        {
            return await queryable.ProjectTo<TDestination>().DecompileAsync().SingleOrDefaultAsync();
        }
        */
    }
}
