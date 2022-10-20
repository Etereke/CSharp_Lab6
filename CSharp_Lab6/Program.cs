// 1. feladat
List<int> intList = new List<int>() { 8, 37, 11, 98, 95, 43, 11, 98, 8, 8, 37 };

// 2. feladat
List<string> stringList = new List<string>() { "ss", "sss", "ssas", "fa", "kép", "daru", "fa", "alma", "doboz", "kép", "doboz", "fa" };

// 3. feladat
foreach (int i in intList)
{
    if (i > 20) Console.WriteLine(i);
}

// 4. feladat
Dictionary<int, int> counter =
    new Dictionary<int, int>();
foreach (int i in intList)
{
    if (counter.ContainsKey(i)) counter[i]++;
    else counter[i] = 1;
}
foreach (KeyValuePair<int, int> entry in counter)
{
    Console.WriteLine(entry.Key + " : " + entry.Value);
}

// 5. feladat
Dictionary<char, int> initials =
    new Dictionary<char, int>();
foreach (string str in stringList)
{
    if (initials.ContainsKey(str[0])) initials[str[0]]++;
    else initials[str[0]] = 1;
}
int max = 0;
foreach (KeyValuePair<char, int> entry in initials)
{
    if(entry.Value > max) max = entry.Value;
}
List<char> starterChars = new List<char>();
foreach (KeyValuePair<char, int> entry in initials)
{
    if (entry.Value == max) starterChars.Add(entry.Key);
}
foreach(string str in stringList.ToList())
{
    if (starterChars.Contains(str[0])) stringList.Remove(str);
}
foreach (string str in stringList)
{
    Console.WriteLine(str);
}

// 6. feladat
int sum = 0, count = 0;
foreach (int i in intList)
{
    sum += i;
    count++;
}
float avg = (float)sum / count;
foreach (int i in intList)
{
    if (i < avg) Console.WriteLine(i);
}

// 7. feladat -- ez nem jó!
int numOfMaxS = 0;
List<string> maxSStrings = new List<string>();
foreach (string str in stringList)
{
    int numOfS = str.Split('s').Length - 1;
    if (numOfS > numOfMaxS)
    {
        numOfMaxS = numOfS;
        maxSStrings.Add(str);
    }
}
if(maxSStrings.Count == 0)
    Console.WriteLine("No such string found in stringList");
else
{
    foreach(string str in maxSStrings)
    {
        Console.WriteLine(str);
    }
}