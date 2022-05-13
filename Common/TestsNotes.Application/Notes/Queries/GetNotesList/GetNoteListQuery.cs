using MediatR;

namespace TestsNotes.Application.Notes.Queries.GetNotesList;
public class GetNoteListQuery : IRequest<NoteListVm>
{
    public Guid UserId { get; set; }
}