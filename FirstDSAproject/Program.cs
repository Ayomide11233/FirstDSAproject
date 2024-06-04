
int[] Nums = { 4, 2,-6, 1,3,2,3,0,-3,9};

//Linear Search
//int minVal = Nums[0];
//for (int i = 1; i < Nums.Length; i++)
//{
//    if (Nums[i]< minVal ) 
//    {
//        minVal = Nums[i]; 
//            }


//}

//Console.WriteLine($"The Min Value is {minVal}");

//---------------------------------------------------------------
////Bubble Sort
for (int k = 0; k < Nums.Length; k++)
{
	for (int i = k + 1; i < Nums.Length - 1; i++)
	{
		if (Nums[k] > Nums[i + 1])
		{
			int temp = Nums[i + 1];
			Nums[i + 1] = Nums[k];
			Nums[k] = temp;
		}
	}

}
	Console.WriteLine(string.Join(",", Nums));

//----------------------------------------------------------------
//BinarySearch
int l=0, r=Nums.Length,target=9;

while (l < r)
{
	int mid=(l+r)/2;
	if (Nums[mid] ==target)
	{
		Console.WriteLine(mid);
		break;
    }
	if (Nums[mid] < target)
	{
		l=mid;

	}else
	{
		r=mid;
	}
}

