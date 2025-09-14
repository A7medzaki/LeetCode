public class Solution {
    public bool IsPalindrome(int n) {
        int rev = 0, x = n;
        while(x > 0){
            int digit = x % 10;
            rev = rev * 10 + digit;
            x = x / 10;
        }
        if(n == rev)
            return true;
        else
            return false;
    }
}