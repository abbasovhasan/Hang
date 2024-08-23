namespace Shared.Dtos.EMails;

public class EmailBodyDto
{
    public string To { get; set; } = null!;
    public string From { get; set; } = null!;
    public string? Bcc { get; set; } //gizli tanik (olarak eklenir karsi taraf gorunmez)
    public string? Cc { get; set; } //gizsiz tanik
    public string Subject { get; set; } = null!;
    public string? Body { get; set; }
    public string? DisplayName { get; set; }
    public bool SendNow { get; set; }
    public DateTime? ScheduleTime { get; set; }
    public ICollection<AttachmentDto> Attachments { get; set; } = new List<AttachmentDto>();

}
