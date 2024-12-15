using System.Text.RegularExpressions;

namespace TechbodiaQuiz;

public class Notification
{
    public static List<string> ParseNotificationChannels(string title)
    {
        // Define a dictionary of valid tags and their corresponding channels
        var channelMap = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "BE", "Backend" },
            { "FE", "Frontend" },
            { "QA", "Quality Assurance" },
            { "Urgent", "Urgent" }
        };

        // Use a regex to extract tags from the title
        var tagPattern = new Regex(@"\[(.*?)\]");
        var matches = tagPattern.Matches(title);

        var channels = new HashSet<string>();

        foreach (Match match in matches)
        {
            var tag = match.Groups[1].Value.Trim();

            if (channelMap.TryGetValue(tag, out var channel))
            {
                channels.Add(channel);
            }
        }

        return [.. channels];
    }
}
