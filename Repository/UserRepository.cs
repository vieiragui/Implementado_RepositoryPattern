using TestandoRepositoryPattern.Context;
using TestandoRepositoryPattern.Model;
using TestandoRepositoryPattern.Repository.Base;
using TestandoRepositoryPattern.Repository.Interface;

namespace TestandoRepositoryPattern.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}