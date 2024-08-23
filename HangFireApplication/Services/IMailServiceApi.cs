using Refit;
using Shared.Dtos.EMails;

namespace HangFireApplication.Services;

public interface IMailServiceApi
{
    // http://localhost:5020
    [Post("/api/Mails")]
    Task SendEmailAsync([Body] EmailBodyDto emailRequest);
}
