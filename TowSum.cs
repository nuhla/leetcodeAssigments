
public class Solutions
{
    public int TowSum(int[] numes, in target)
    {

        Dictionary<int, int> idexes = new Dictionary<int, int>();
        for (int i = 0; i < numes.length; i++)
        {
            int isComplementry = target - numes[i];
            if (idexes.ContainsKey(isComplementry))
            {
                return new int[] { i, idexes[isComplementry] };
            }
            idexes[nums[i]] = i;
        }

        return new int[0];
    }
}