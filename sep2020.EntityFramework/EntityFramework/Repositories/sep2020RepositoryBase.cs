using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace sep2020.EntityFramework.Repositories
{
    public abstract class sep2020RepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<sep2020DbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected sep2020RepositoryBase(IDbContextProvider<sep2020DbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class sep2020RepositoryBase<TEntity> : sep2020RepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected sep2020RepositoryBase(IDbContextProvider<sep2020DbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
