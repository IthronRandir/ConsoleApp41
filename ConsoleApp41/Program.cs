int[] nums = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,15 };
int target = 9;
int k = -1;
do
{
    k++;
}
while (nums[k] < target);
Console.WriteLine(k);