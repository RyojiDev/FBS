namespace FBS.Shared.Response
{
    public class GenericResponse where T : <T>
    {
        public GenericResponse(string message, bool success, T data)
        {
            this.Message = message;
            this.Success = success;
            this.Data = data;
        }

        public string Message { get; set; }
        public bool Success { get; set; }
        public T Data { get; set; }
    }
}