class MarcsCakewalk
{

    //https://www.hackerrank.com/challenges/marcs-cakewalk/problem

    public static double marcsCakewalk(List<int> calorieList)
    {
        calorieList.Sort();
        calorieList.Reverse();
        double result = 0;
        for (int i = 0; i < calorieList.Count; i++)
        {
            result += Math.Pow(2, i) * calorieList[i];
        }
        return result;
    }
}
