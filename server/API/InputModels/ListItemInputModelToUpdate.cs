namespace API.InputModels
{
    public class ListItemInputModelToUpdate
    {
        public int ListItemId { get; set; }
        public int ListId { get; set; }
        public string Title { get; set; }
        public string Information { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
