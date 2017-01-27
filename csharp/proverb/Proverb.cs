using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Proverb
{

    static Dictionary<int, string> _body = new Dictionary<int, string>() 
    {
        {1, "For want of a nail the shoe was lost." },
        {2, "For want of a shoe the horse was lost."},
        {3, "For want of a horse the rider was lost."},
        {4, "For want of a rider the message was lost."},
        {5, "For want of a message the battle was lost."},
        {6, "For want of a battle the kingdom was lost."},
        {7, "And all for the want of a horseshoe nail."}
    };

    public static string Line(int number)
    {
        return _body[number];
    }

    public static string AllLines()
    {
        var lines = new StringBuilder();
        var sortedKeys = _body.Keys.OrderBy(x => x);
        foreach (var key in sortedKeys)
        {
            lines.AppendLine(_body[key]);
        }

        // No leading space, so Trim == TrimEnd();
        return lines.ToString().Trim();
    }
}