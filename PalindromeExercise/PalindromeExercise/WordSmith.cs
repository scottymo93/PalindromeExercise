namespace PalindromeExercise;

public class WordSmith
{
    public bool IsPalindrome(string word)
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] != word[word.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}