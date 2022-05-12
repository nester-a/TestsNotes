using Microsoft.EntityFrameworkCore;
using TestsNotes.Domain;

namespace TestsNotes.Application.Interfaces;

public interface INotesDbContext
{
    DbSet<Note> Notes { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
