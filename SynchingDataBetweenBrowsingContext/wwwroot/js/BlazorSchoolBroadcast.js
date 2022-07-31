export function postMessage(channelName, message)
{
    let channel = new BroadcastChannel(channelName);
    channel.postMessage(JSON.stringify(message));
}

export function listenChannel(channelName, csharpBroadcaster)
{
    let channel = new BroadcastChannel(channelName);
    channel.onmessage = (event) =>
    {
        csharpBroadcaster.invokeMethodAsync("Notify", JSON.parse(event.data));
    }
}