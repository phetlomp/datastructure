using System;
namespace datastructure
{
class datastructure
{
public static void Main(String[] args)
{
    int [] dataset = {45,87,30,20,97,63,75,34,88,65,30,27,45,30,48,99};
    int totaldata = dataset.Length;
    int i=0;
    quick_sort(dataset, 0, totaldata);

    for(i=0; i<totaldata;i++)
        Console.WriteLine(dataset [i]);
}

public static void quick_sort (int []ds, int left, int right)
{
    int pivot = 0;
if (left<right)
    {
        pivot = partition(ds,left,right);
    if (pivot>1)
    quick_sort(ds,pivot+1,right);
    if(pivot+1>right)
    quick_sort(ds,left,pivot-1);
    }

}
public static int partition (int[] ds, int left, int right)
{
    int pivot=ds[left];
    while(true)
    {
while(ds[left] < pivot)
left++;
while(ds[right]< pivot)
right--;
if(left<right)
{

if(ds[left]==ds[right])
return right;
int temp = ds[left];
ds[left] = ds[right];
ds[right] = temp;

}
    else
        return right;
    }
}

}





}


