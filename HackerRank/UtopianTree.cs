namespace HackerRank
{
    public class UtopianTree
    {
        public static int CalcHeight(int cycles)
        {
            var height = 1;
            var i = 1;

            while (i <= cycles)
            {
                if (i % 2 == 0)
                    height += 1;
                else
                    height *= 2;

                i++;    
            }


            return height;
        }
    }
}