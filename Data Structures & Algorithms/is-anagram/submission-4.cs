public class Solution
{
    public bool IsAnagram(string s, string t)
    { 
        if (s.Length != t.Length) return false;
        char[] schar = s.ToCharArray();
        char[] tchar = t.ToCharArray();
        Array.Sort(schar); Array.Sort(tchar);
        if (schar.SequenceEqual(tchar)) return true;
        return false;

    }
}