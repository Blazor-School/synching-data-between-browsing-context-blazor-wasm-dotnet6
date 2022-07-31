using Microsoft.JSInterop;

namespace SynchingDataBetweenBrowsingContext.Utils;

public class BlazorSchoolBroadcaster : BlazorSchoolBroadcasterBase
{
    public override string ChannelName { get; } = "BlazorSchoolPrimitive";

    public BlazorSchoolBroadcaster(IJSRuntime jsRuntime) : base(jsRuntime)
    {
    }
}
