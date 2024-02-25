namespace IdentityBhrDev.Repository.Interface
{
    public interface IEmailSender
    {
        Task<bool> EmailSendAsync(string email,string Subject , string message);
    }
}
