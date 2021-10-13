namespace FBS.Shared.Response
{
    public class GenericResponse
    {
        public GenericResponse()
        {

        }

        public GenericResponse(string message, bool success, object data)
        {
            this.Message = message;
            this.Success = success;
            this.Data = data;
        }

        public string Message { get; set; }
        public bool Success { get; set; }
        public object Data { get; set; }
    }
}