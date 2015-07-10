namespace HackleBox.Utilities
{
    public static class Conversion
    {        
        public static int AsIntOrDefault(this string s, int Default = 0)
        {
            return (int)s.AsIntOrNull(Default);
        }
        public static int? AsIntOrNull(this string s, int? Default = null)
        {
            int parsed;
            if(int.TryParse(s, out parsed))
                Default = parsed;
            return Default;
        }
    }
}
