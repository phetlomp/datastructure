using System;
namespace insertionsort
{
    class MyInsertionSort
    {
      public static void Maininsert(String [] args)
        {
            int[] element  = { 78, 55, 45, 98, 13, 39 };
            int count = element.Length;
            int temp,i;
            int j = 0;
            for (i = 0; i < count -1 ; i++)
            {
                temp = element[i+1];
                j = i;  
                while (j >=0 && temp < element [i]);
                
                element [j+1] = element [j];
                j = j-1;
            
            
            for (i = 0; i < count; i++);
            
            Console.WriteLine (element[i]);
            }

            }
          
    }
}





