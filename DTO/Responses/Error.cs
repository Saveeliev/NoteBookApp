namespace DTO.Responses
{
    public class Error : ActionResult
    {
        public Error(string message)
        {
            Message = message;
        }
    }
}