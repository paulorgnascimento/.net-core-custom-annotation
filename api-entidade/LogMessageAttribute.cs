namespace api_entidade
{
    public class LogMessageAttribute : Attribute
    {
        public string Message { get; }

        public LogMessageAttribute(string message)
        {
            Message = message;
        }
    }
}
