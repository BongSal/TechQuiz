using TechbodiaQuiz;

Console.WriteLine("Enter the notification title:");
string notificationTitle = Console.ReadLine() ?? "";

// Parse the title and get the channels
var channels = Notification.ParseNotificationChannels(notificationTitle);

if (channels.Count > 0)
{
    Console.WriteLine("Receive channels:");
    foreach (var channel in channels)
    {
        Console.WriteLine(channel);
    }
}
else
{
    Console.WriteLine("No relevant notification channels found.");
}