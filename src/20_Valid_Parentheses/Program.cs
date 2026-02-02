bool IsValid(string s)
{
    if (s.Length % 2 != 0) return false;
    Stack<char> chars = new Stack<char>();

    foreach (char c in s)
    {
        if (c == '(' || c == '{' || c == '[')
        {
            chars.Push(c);
        }
        else
        {
            if (chars.Count() == 0) return false;
            var top = chars.Peek();
            if ((c == ')' && top != '(') ||
                (c == '}' && top != '{') ||
                (c == ']' && top != '['))
            {
                return false;
            }

            chars.Pop();
        }
    }

    return chars.Count() == 0;
}

string s = "[()()]{}";
Console.WriteLine((IsValid(s)));