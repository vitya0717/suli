namespace CarsAPI.DTOs
{
    public class ResponseResult
    {
        public Object Result { get; set; } = null;

        public bool Success { get; set; } = false;

        public string Message { get; set; }
    }
}
