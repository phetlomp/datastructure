using System;
class plus
{
    public static void Main(String[] args)
    {
        int[] element = {45,87,30,20,97,63,75,34,88};
        int item = 750;
        int noe = element.Length;

        linearsearch (element, noe, item);
    }

    static void linearsearch(int[] element, int noe, int item)
     {
        bool flag = false;    
        for(int i=0;i<noe;i++)
        {
            if(element[i]==item)
            {
                Console.WriteLine("The item " + item + " is found in position " + (i+1) );
                flag = true;
                break;
            }
            else
              flag = false;
        }   

        if(flag == false)
            Console.WriteLine("The item " + item + " is NOT found.");
     }   
}

