using Notes.ViewModel;

namespace Notes.Interface
{
    public interface INoteService
    {
        Task<List<NoteViewModel>> GetAllNotesAsync();
        Task<NoteViewModel> GetNoteByIdAsync(int id);
        Task<NoteViewModel> CreateNoteAsync(NoteViewModel note);
        Task<NoteViewModel> UpdateNoteAsync(int id, NoteViewModel note);
        Task DeleteNoteAsync(int id);
    }
}
