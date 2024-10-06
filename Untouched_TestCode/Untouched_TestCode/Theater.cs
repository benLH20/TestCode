using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

public class Theater
{
    private int[] codes;
    private int[] counters;
    public void delUnPopularShow()
    {
        int lowest = 0;
        for (int i = 0; i < counters.Length; i++)
        {
            if (counters[i] > 0)
            {
                lowest = counters[i];
                break;
            }
        }
        for (int i = 0; i < counters.Length; i++)
        {
            if (counters[i] > 0 && counters[i] < lowest)
            {
                lowest = counters[i];
            }
        }
        for (int i = 0; i < codes.Length; i++)
        {
            if (counters[i] == lowest)
            {
                counters[i] = 0;
                codes[i] = 0;
            }
        }
    }
    public bool addShow(int code)
    {
        for (int i = 0; i < codes.Length; i++)
        {
            if (codes[i] == 0)
            {
                codes[i] = code;
                counters[i] = 1;
                return true;
            }
        }
        return false;
    }
}
