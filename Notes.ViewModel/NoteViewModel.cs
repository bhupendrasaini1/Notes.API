namespace Notes.ViewModel
{
    public record NoteViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
