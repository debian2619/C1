int[] array = {15,26,37,48,56,66,77,66,97};
int n = array.Length;
int find = 66;
int index= 0;
while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
       
    }
    index++;  
}


