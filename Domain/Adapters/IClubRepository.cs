using Domain.Entities;

namespace Domain.Adapters
{
    public interface IClubRepository
    {
        Task<IEnumerable<Club>> GetAll();
        Task Create(Club club);
    }
}
