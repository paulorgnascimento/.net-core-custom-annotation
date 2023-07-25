namespace api_entidade
{
    public class EventoPersonalizadoAttribute : Attribute
    {
        public string Message { get; }

        public EventoPersonalizadoAttribute(string message)
        {
            Message = message;
        }
    }
}
