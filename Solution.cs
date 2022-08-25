using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoexperttasks
{
    public class Solution
    {
        public bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            bool continueLoop = true;
            int arrIndx = 0;
            int seqIndx = 0;

            while (continueLoop)
            {
                if (arrIndx < array.Count && seqIndx < sequence.Count)
                {
                    if (array[arrIndx] == sequence[seqIndx])
                    {
                        seqIndx++;
                        arrIndx++;
                        if (seqIndx >= sequence.Count)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        arrIndx++;
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;

        }
    }

}
