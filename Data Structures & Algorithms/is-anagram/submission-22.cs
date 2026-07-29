public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length !=t.Length) return false;
int[] temp = new int[26];
for(int i =0;i<s.Length;i++){
temp[s[i] - 'a']++;
temp[t[i] - 'a']--;
}
foreach(var e in temp){
    if (e != 0) return false;
}
return true;
    }
}
