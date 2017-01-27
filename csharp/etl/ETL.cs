using System.Collections.Generic;
public static class ETL 
{
    public static Dictionary<string, int> Transform(Dictionary<int, IList<string>> input)
    {
        Dictionary<string, int> transformed = new Dictionary<string, int>();

        foreach (var kv in input)
        {
            var k = kv.Key;
            foreach (var v in kv.Value)
            {
                transformed.Add(v.ToLower(), k);
            }
        }

        return transformed;
    }
}