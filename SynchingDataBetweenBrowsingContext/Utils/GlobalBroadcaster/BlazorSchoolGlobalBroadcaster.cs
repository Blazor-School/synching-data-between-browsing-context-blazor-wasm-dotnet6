using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using SynchingDataBetweenBrowsingContext.Models;

namespace SynchingDataBetweenBrowsingContext.Utils.GlobalBroadcaster;

public class BlazorSchoolGlobalBroadcaster : ComponentBase
{
    [CascadingParameter(Name = "BlazorSchoolCascadingGlobalBroadcastData")]
    public BroadcastData<ExampleClass> CurrentData { get; set; } = default!;

    [Parameter]
    public RenderFragment<BroadcastData<ExampleClass>>? ChildContent { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder) => builder.AddContent(0, ChildContent?.Invoke(CurrentData));
}
