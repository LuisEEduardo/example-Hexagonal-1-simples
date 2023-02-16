using Domain.Entities;

namespace Domain.Services
{
    public interface IClubService
    {
        Task<IEnumerable<Club>> GetAllClubs();
        Task<Club> RegisterClub(Club club);
    }
}
