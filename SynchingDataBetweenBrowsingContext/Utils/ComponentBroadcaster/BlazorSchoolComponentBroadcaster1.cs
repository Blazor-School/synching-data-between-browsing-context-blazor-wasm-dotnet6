﻿using Microsoft.JSInterop;

namespace SynchingDataBetweenBrowsingContext.Utils.ComponentBroadcaster;

public class BlazorSchoolComponentBroadcaster1 : BlazorSchoolBroadcasterBase<string>
{
    public BlazorSchoolComponentBroadcaster1(IJSRuntime jsRuntime) : base(jsRuntime)
    {
    }

    public override string ChannelName { get; } = "BlazorSchoolComponentBroadcaster1";
}
