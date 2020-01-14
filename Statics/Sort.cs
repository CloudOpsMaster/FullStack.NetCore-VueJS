
public static class Sort
    {
        static int[] masArray = { 54, 5, 3, 0, -3, 54, 98, 11 };
        static public void SortArray()
        {
            bool UpTop = true;
            int s ;
            if(UpTop)
            {
             s = 1;
            } else 
            {
               s = -1;
            }
           
            int temp;
            for (int i = 0; i < masArray.Length - 1; i++)
            {

                if (masArray[i] * s > masArray[i + 1] * s)
                {
                    temp = masArray[i];
                    masArray[i] = masArray[i + 1];
                    masArray[i + 1] = temp;
                    
                }
                
            }
           
        }
    }