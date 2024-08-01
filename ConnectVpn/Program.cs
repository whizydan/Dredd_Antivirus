// clientId should be generated for each client
using VpnHood.Client.Device.WinDivert;
using VpnHood.Client;
using VpnHood.Common;
using VpnHood.Client.Exceptions;

var clientId = Guid.Parse("7BD6C156-EEA3-43D5-90AF-B118FE47ED0A");

// accessKey must obtain from the server
var accessKey = "vh://eyJuYW1lIjoiUHVibGljIiwidiI6MSwic2lkIjoxMDAwLCJ0aWQiOiI3MWU1NmJmNS04OGU5LTRjNzQtYmY2NS05NTkxNzZiNDQ5Y2UiLCJzZWMiOiI2R3l6cHlydDlQU0JtQ3pUYW5XaVJ3PT0iLCJpc3YiOmZhbHNlLCJobmFtZSI6ImJ1LmRha2F6aGlyb2hpLmNvbSIsImhwb3J0IjowLCJjaCI6InJ5anowOERLenEzRTZWWlFRNjJONkpqekJDQT0iLCJwYiI6dHJ1ZSwidXJsIjpudWxsLCJlcCI6WyI0MS45MC42NC4yMzA6NDQzIl19";
var token = Token.FromAccessKey(accessKey);

var packetCapture = new WinDivertPacketCapture();
var vpnHoodClient = new VpnHoodClient(packetCapture, clientId, token, new ClientOptions() { });

Console.WriteLine("Attempting to connect.");
connect();

while (vpnHoodClient.State == ClientState.Connected)
{
    File.WriteAllText(@"C:\Temp\csc.txt", "0");
}


while (vpnHoodClient.State == ClientState.Disposed)
{
    
    Thread.Sleep(1000);
}
    
void connect()
{
    try
    {
        vpnHoodClient.Connect().Wait();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error : {ex}");
    }

    if(vpnHoodClient.State == ClientState.Disposed || vpnHoodClient.State == ClientState.None || vpnHoodClient.State == ClientState.Disconnecting)
    {
        Console.WriteLine("Attempting to reconnect.....");
        connect();
    }
    else if (vpnHoodClient.State == ClientState.Connected)
    {
        File.WriteAllText(@"C:\Temp\csc.txt", "0");
        Console.WriteLine("Connected....");
        Console.WriteLine("Open your browser and browse the Internet!");
    }
}