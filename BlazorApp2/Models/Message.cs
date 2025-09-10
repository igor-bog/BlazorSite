namespace BlazorApp2.Models
{
    public class Message
    {
        public int Id { get; set; } // автоинкрементный ключ
        public string Content { get; set; } = string.Empty; // текст сообщения
        public DateTime CreatedAt { get; set; } = DateTime.Now; // дата создания
    }
}
