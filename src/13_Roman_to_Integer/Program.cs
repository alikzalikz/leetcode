int RomanToInt(string s)
{
    char[] sArrey = s.ToCharArray();
    int integer = 0;
    int res = 0;
    for (int i = 0; i < sArrey.Length; i++)
    {
        integer = 0;
        switch (sArrey[i])
        {
            case 'I':
                integer = 1;
                break;
            case 'V':
                integer = 5;
                break;
            case 'X':
                integer = 10;
                break;
            case 'L':
                integer = 50;
                break;
            case 'C':
                integer = 100;
                break;
            case 'D':
                integer = 500;
                break;
            case 'M':
                integer = 1000;
                break;
        }

        if (i + 1 < sArrey.Length)
        {
            if (sArrey[i] == 'I' && sArrey[i + 1] == 'V')
            {
                integer = 4;
                i++;
            }
        }

        if (i + 1 < sArrey.Length)
        {
            if (sArrey[i] == 'I' && sArrey[i + 1] == 'X')
            {
                integer = 9;
                i++;
            }
        }

        if (i + 1 < sArrey.Length)
        {
            if (sArrey[i] == 'X' && sArrey[i + 1] == 'L')
            {
                integer = 40;
                i++;
            }
        }

        if (i + 1 < sArrey.Length)
        {
            if (sArrey[i] == 'X' && sArrey[i + 1] == 'C')
            {
                integer = 90;
                i++;
            }
        }

        if (i + 1 < sArrey.Length)
        {
            if (sArrey[i] == 'C' && sArrey[i + 1] == 'D')
            {
                integer = 400;
                i++;
            }
        }

        if (i + 1 < sArrey.Length)
        {
            if (sArrey[i] == 'C' && sArrey[i + 1] == 'M')
            {
                integer = 900;
                i++;
            }
        }

        res += integer;
    }
    return res;
}

Console.WriteLine(RomanToInt("MCMXCIV"));