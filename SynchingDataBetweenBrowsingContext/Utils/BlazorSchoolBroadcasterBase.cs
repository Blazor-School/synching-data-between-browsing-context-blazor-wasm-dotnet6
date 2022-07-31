using Microsoft.JSInterop;
using System.Text.Json;

namespace SynchingDataBetweenBrowsingContext.Utils;

public abstract class BlazorSchoolBroadcasterBase : IAsyncDisposable
{
    private readonly IJSRuntime _jsRuntime;
    private Lazy<IJSObjectReference> _blazorSchoolBroadcastJsRef = new();

    public abstract string ChannelName { get; }
    public event EventHandler<BroadcastData> OnMessageReceived = (sender, args) => { };

    public BlazorSchoolBroadcasterBase(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async Task SendMessageAsync<T>(T message)
    {
        await WaitForReference();
        await _blazorSchoolBroadcastJsRef.Value.InvokeVoidAsync("postMessage", ChannelName, message);
    }

    public async Task ListenChannelAsync()
    {
        await WaitForReference();
        var wrappedInstance = DotNetObjectReference.Create(this);
        await _blazorSchoolBroadcastJsRef.Value.InvokeVoidAsync("listenChannel", ChannelName, wrappedInstance);
    }

    [JSInvokable]
    public void Notify(JsonElement jsonData)
    {
        OnMessageReceived?.Invoke(this, new(jsonData));
    }

    protected async Task WaitForReference()
    {
        if (_blazorSchoolBroadcastJsRef.IsValueCreated is false)
        {
            _blazorSchoolBroadcastJsRef = new(await _jsRuntime.InvokeAsync<IJSObjectReference>("import", "/js/BlazorSchoolBroadcast.js"));
        }
    }

    public async ValueTask DisposeAsync()
    {
        if (_blazorSchoolBroadcastJsRef.IsValueCreated)
        {
            await _blazorSchoolBroadcastJsRef.Value.DisposeAsync();
        }
    }
}
