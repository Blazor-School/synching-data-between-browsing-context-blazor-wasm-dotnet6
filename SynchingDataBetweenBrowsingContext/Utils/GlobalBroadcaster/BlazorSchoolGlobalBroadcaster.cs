using Microsoft.JSInterop;
using SynchingDataBetweenBrowsingContext.Models;

namespace SynchingDataBetweenBrowsingContext.Utils.GlobalBroadcaster;

public class BlazorSchoolGlobalBroadcaster : BlazorSchoolBroadcasterBase<ExampleClass>
{
    public override string ChannelName { get; } = "BlazorSchoolGlobalBroadcaster";

    public BlazorSchoolGlobalBroadcaster(IJSRuntime jsRuntime) : base(jsRuntime)
    {
    }
}