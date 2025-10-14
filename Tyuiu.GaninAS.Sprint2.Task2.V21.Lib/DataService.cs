using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GaninAS.Sprint2.Task2.V21.Lib
{
    public class DataService : ISprint2Task2V21
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if (((x <= 3) && (x <= 12)) && (y >= 3) && (y <= 7))
            {
                res = true;
            }
            else if (((x <= 3) && (x <= 12)) && ((y >= 4) && (y <= 7)))
            {
                res = true;
            }
            else if (((x <= 3) && (x <= 6)) && (y >= 5) && (y <= 6))
            {
                res = true;
            }
            else if (((x >= 3) && (x <= 13)) && (y >= 6) && (y <= 7))
            {
                res = true;
            }
            else if ((x >= 3) && (x <= 13) && (y == 7))
            {
                res = true;
            }
            else if (((x >= 4) && (x <= 7) && (x >= 10)) && ((y >= 8) && (y <= 9)))
            {
                res = true;
            }
            else if (((x >= 4) && (x <= 7)) && (y == 9))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
}   }
    