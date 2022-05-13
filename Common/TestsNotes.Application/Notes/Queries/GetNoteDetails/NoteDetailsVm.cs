using AutoMapper;
using TestsNotes.Application.Common.Mappings;
using TestsNotes.Domain;

namespace TestsNotes.Application.Notes.Queries.GetNoteDetails;
public class NoteDetailsVm : IMapWith<Note>
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Details { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime? EditDate { get; set; }


    public void Mapping(Profile profile)
    {
        profile.CreateMap<Note, NoteDetailsVm>()
            .ForMember(vm => vm.Title,
                opt => opt.MapFrom(n => n.Title))
            .ForMember(vm => vm.Details,
                opt => opt.MapFrom(n => n.Details))
            .ForMember(vm => vm.CreationDate,
                opt => opt.MapFrom(n => n.CreationDate))
            .ForMember(vm => vm.EditDate,
                opt => opt.MapFrom(n => n.EditDate));
    }
}
