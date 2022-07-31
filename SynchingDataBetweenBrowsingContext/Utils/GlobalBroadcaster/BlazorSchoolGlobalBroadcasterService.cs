using Microsoft.JSInterop;
using SynchingDataBetweenBrowsingContext.Models;

namespace SynchingDataBetweenBrowsingContext.Utils.GlobalBroadcaster;

public class BlazorSchoolGlobalBroadcasterService : BlazorSchoolBroadcasterBase<ExampleClass>
{
    public override string ChannelName { get; } = "BlazorSchoolGlobalBroadcaster";

    public BlazorSchoolGlobalBroadcasterService(IJSRuntime jsRuntime) : base(jsRuntime)
    {
    }
}