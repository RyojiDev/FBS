namespace FBS.Shared.Response
{
    public class GenericResponse<T>
        where T : class
    {
        public GenericResponse()
        {

        }

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