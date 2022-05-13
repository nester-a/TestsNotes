using MediatR;
using TestsNotes.Application.Common.Exceptions;
using TestsNotes.Application.Interfaces;
using TestsNotes.Domain;

namespace TestsNotes.Application.Notes.Commands.DeleteNote;
public class DeleteNoteCommandHandler : IRequestHandler<DeleteNoteCommand>
{
    private readonly INotesDbContext _dbContext;

    public DeleteNoteCommandHandler(INotesDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<Unit> Handle(DeleteNoteCommand request, CancellationToken cancellationToken)
    {
        var entity = await _dbContext.Notes.FindAsync(new object[] { request.Id }, cancellationToken);
        if (entity is null || entity.UserId != request.UserId)
        {
            throw new NotFoundException(nameof(Note), request.Id);
        }

        _dbContext.Notes.Remove(entity);
        await _dbContext.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}