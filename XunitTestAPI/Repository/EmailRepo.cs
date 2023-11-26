namespace XunitTestAPI.Repository
{
    public class EmailRepo : IEmailRepo
    {
        public bool SendEmail()
        {
            Console.WriteLine("Email sent successfuly");
            return true;
        }
        public void RecievedEmail()
        {
            Console.WriteLine("Email recieved successfuly");
        }
    }
}
