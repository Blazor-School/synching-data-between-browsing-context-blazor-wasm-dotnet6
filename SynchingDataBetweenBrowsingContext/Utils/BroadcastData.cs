using System.Text.Json;

namespace SynchingDataBetweenBrowsingContext.Utils;

public record BroadcastData<T>(JsonElement Data)
{
    public T? GetData()
    {
        try
        {
            return Data.Deserialize<T>(new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        catch (JsonException)
        {
            throw new BlazorSchoolBroadcasterException($"The data is not {typeof(T).FullName} or reached maximum depth");
        }
    }
}