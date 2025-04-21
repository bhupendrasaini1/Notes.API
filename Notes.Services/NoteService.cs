using Notes.Interface;
using Notes.ViewModel;

namespace Notes.Services
{
    public class NoteService : INoteService
    {
        private readonly List<NoteViewModel> _notes = new();

        public Task<List<NoteViewModel>> GetAllNotesAsync() => Task.FromResult(_notes);

        public Task<NoteViewModel> GetNoteByIdAsync(int id) => Task.FromResult(_notes.FirstOrDefault(n => n.Id == id));

        public Task<NoteViewModel> CreateNoteAsync(NoteViewModel note)
        {
            note.Id = _notes.Count + 1;
            _notes.Add(note);
            return Task.FromResult(note);
        }

        public Task<NoteViewModel> UpdateNoteAsync(int id, NoteViewModel note)
        {
            var existingNote = _notes.FirstOrDefault(n => n.Id == id);
            if (existingNote != null)
            {
                existingNote.Title = note.Title;
                existingNote.Description = note.Description;
            }
            return Task.FromResult(existingNote);
        }

        public Task DeleteNoteAsync(int id)
        {
            var note = _notes.FirstOrDefault(n => n.Id == id);
            if (note != null)
            {
                _notes.Remove(note);
            }
            return Task.CompletedTask;
        }
    }
}
