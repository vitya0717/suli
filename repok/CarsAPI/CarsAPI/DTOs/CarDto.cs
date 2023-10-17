namespace CarsAPI.DTOs
{
    public record CarDto(Guid id, string name, string desription, string color, DateTime generatedTime);

    public record CreateCarDto(string name, string desription, string color);
    public record UpdateCarDto(string name, string desription, string color);

    public record ResponseDto(object result, bool isSuccess = true, string message = "")
    {
       
    }
}
