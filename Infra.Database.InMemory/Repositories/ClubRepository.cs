using Domain.Adapters;
using Domain.Entities;
using Infra.Database.InMemory.Context;
using Microsoft.EntityFrameworkCore;

namespace Infra.Database.InMemory.Repositories;

public class ClubRepository : IClubRepository
{
    private readonly InMemoryContext _context;

    public ClubRepository(InMemoryContext context)
    {
        _context = context;
    }

    public async Task Create(Club club)
    {
        _context.Set<Club>().Add(club);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Club>> GetAll()
        => await _context.Set<Club>().ToListAsync();
}
