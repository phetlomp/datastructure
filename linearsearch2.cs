class less
{

    public static void Main2 (string[] args)
    {
        int [] element = {25,52,45,36,87,99,101,124,48};
        int item = 101;
        int noe = element.Length;
        int flag = -1;

        for (int i=0;i<noe;i++)
    {
        if(element[i]==item)
        {
        Console.WriteLine(" The item " + item + " is found in position " + (i+1));
               flag = -1;
               break;
        }
        else
        flag = 10;
    }
    if (flag==10)
        Console.WriteLine("The item" + "is NOT found.");
        }
    }