using System.Threading.Tasks;
using TestandoRepositoryPattern.Model;

namespace TestandoRepositoryPattern.Repository.Interface
{
    public interface ICarRepository
    {
        Task AddCar(Car entity);
        Task DeleteCar(Car entity);
    }
}