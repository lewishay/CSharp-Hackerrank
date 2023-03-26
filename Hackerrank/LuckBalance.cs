class LuckBalance
{
    //https://www.hackerrank.com/challenges/luck-balance/problem
    public static int luckBalance(int k, List<List<int>> contests)
    {
        int result = 0;
        contests.Sort((a,b) => -1 * a[0].CompareTo(b[0]));
        foreach (var contest in contests)
        {
            if (contest[1] == 0)
            {
                result += contest[0];
            }
            else if (k > 0)
            {
                result += contest[0];
                k--;
            }
            else
            {
                result -= contest[0];
            }
        }
        return result;
    }
}
