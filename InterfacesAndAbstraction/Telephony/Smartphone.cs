public class Smartphone : IBrowseable, ICallable
{
    public string Browsing(string site)
    {
        foreach (char c in site)
        {
            if (char.IsDigit(c))
            {
                return "Invalid URL!";
            }
        }
        return $"Browsing: {site}!";
    }

    public string Calling(string number)
    {
        foreach (char c in number)
        {
            if (!char.IsDigit(c))
            {
                return "Invalid number!";
            }
        }
        return $"Calling... {number}";
    }
}

