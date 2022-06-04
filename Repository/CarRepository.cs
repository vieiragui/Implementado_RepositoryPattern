using System.Threading.Tasks;
using TestandoRepositoryPattern.Model;
using TestandoRepositoryPattern.Repository.Interface;

namespace TestandoRepositoryPattern.Repository
{
    public class CarRepository : ICarRepository
    {
        private readonly IRepositoryBase<Car> _carRepository;

        public CarRepository(IRepositoryBase<Car> carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task AddCar(Car entity) =>        
            await _carRepository.AddAsync(entity);

        public async Task DeleteCar(Car entity) =>
            await _carRepository.Delete(entity);
        
    }
}