using System.Collections.Generic;
namespace Counting_Duplicates
{
    public class Kata
    {
        public static int DuplicateCount(string str)
        {
            int duplicateCount = 0;
            str = str.ToUpper();
            Dictionary<char, int> myDict = new();

            for (int i = 0; i < str.Length; i++)
            {
                if (!myDict.ContainsKey(str[i]))
                {
                    myDict.Add(str[i], 1);
                }
                else
                {
                    myDict[str[i]] = myDict[str[i]] + 1;
                    //myDict.Add(str[i], myDict[str[i]] + 1);
                }
            }

            foreach (KeyValuePair<char, int> kvp in myDict)
            {
                if (kvp.Value > 1)
                {
                    duplicateCount += 1;
                }

            }


            return duplicateCount;
        }

    }
}
