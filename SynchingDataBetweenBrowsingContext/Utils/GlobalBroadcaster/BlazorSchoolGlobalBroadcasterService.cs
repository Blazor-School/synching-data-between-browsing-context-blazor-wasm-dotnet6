using Microsoft.JSInterop;
using System.Text.Json;

namespace SynchingDataBetweenBrowsingContext.Utils.GlobalBroadcaster;

public class BlazorSchoolGlobalBroadcasterService : BlazorSchoolBroadcasterBase, IAsyncDisposable
{
    public override string ChannelName { get; } = "BlazorSchoolGlobalBroadcaster";

    public BlazorSchoolGlobalBroadcasterService(IJSRuntime jsRuntime) : base(jsRuntime)
    {
    }

    [JSInvokable]
    public override void Notify(JsonElement jsonData) => base.Notify(jsonData);
}