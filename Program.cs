#region task1


//int num = 0;

//sum(1, 2, 3, 4);

//void sum(params int[] nums)
//{
//    for (int i = 0; i < nums.Length; i++)
//    {
//        if (nums[i] == num)
//        {
//            Console.WriteLine("there is");

//        }
//    } 
//}



#endregion


#region task2

int sum(params int[] values)
{
    int largest = values[0];
    for (int i = 0; i < values.Length; i++)
    {
        if (values[i] > largest)
            largest = values[i];
    }
    return largest;
}
Console.WriteLine(sum(1,3,5,2,6,8,7));

#endregion