namespace WebApplication1.DAL.Entitites;

public class Message
{
    public int MessageId { get; set; }
    public string NameSurname { get; set; }
    public string Subject { get; set; }
    public string Email { get; set; }
    public string MessageDdetail { get; set; }
    public DateTime SendDate { get; set; }
    public bool IsRead { get; set; }
}