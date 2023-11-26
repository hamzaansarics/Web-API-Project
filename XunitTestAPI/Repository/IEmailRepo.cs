namespace XunitTestAPI.Repository
{
    public interface IEmailRepo
    {
        void RecievedEmail();
        bool SendEmail();
    }
}