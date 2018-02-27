using System.Collections.Generic;

public class StackOfStrings
{
    private List<string> data = new List<string>();


    public void Push(string item)
    {
        this.data.Add(item);
    }

    public string Peek()
    {
        int lastIndex = data.Count - 1;
        return data[lastIndex];
    }

    public string Pop()
    {
        int lastIndex = data.Count - 1;
        string result = data[lastIndex];
        data.RemoveAt(lastIndex);
        return result;
    }

    public bool IsEmpty()
    {
        if (data.Count > 0)
        {
            return false;
        }

        return true;
    }
}
