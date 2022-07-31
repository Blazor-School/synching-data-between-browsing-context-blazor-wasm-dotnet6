using Microsoft.JSInterop;

namespace SynchingDataBetweenBrowsingContext.Utils.ComponentBroadcaster;

public class BlazorSchoolComponentBroadcaster2 : BlazorSchoolBroadcasterBase
{
    public BlazorSchoolComponentBroadcaster2(IJSRuntime jsRuntime) : base(jsRuntime)
    {
    }

    public override string ChannelName { get; } = "BlazorSchoolComponentBroadcaster2";
}
