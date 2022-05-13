using AutoMapper;
using TestsNotes.Application.Common.Mappings;
using TestsNotes.Domain;

namespace TestsNotes.Application.Notes.Queries.GetNotesList;
public class NoteLookupDto : IMapWith<Note>
{
    public Guid Id { get; set; }
    public string Title { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Note, NoteLookupDto>()
            .ForMember(dto => dto.Id,
                opt => opt.MapFrom(n => n.Id))
            .ForMember(dto => dto.Title,
                opt => opt.MapFrom(n => n.Title));
    }
}