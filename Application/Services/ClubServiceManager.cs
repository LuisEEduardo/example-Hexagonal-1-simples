using Domain.Adapters;
using Domain.Entities;
using Domain.Services;

namespace Application.Services
{
    public class ClubServiceManager : IClubService
    {        
        private readonly IClubRepository _clubRepository;

        public ClubServiceManager(IClubRepository clubRepository)
        {
            _clubRepository = clubRepository;
        }

        public async Task<IEnumerable<Club>> GetAllClubs()
            => await _clubRepository.GetAll();

        public async Task<Club> RegisterClub(Club club)
        {
            await _clubRepository.Create(club);

            // send email

            return club;
        }
    }
}
