using System;
namespace DSA_PRACTICE.ArrayWork
{
	public class ArrayClass
	{
		public void RotateArr(int[] arr, int d)
		{
			//with predefine function
			int n = arr.Length;
			d = d % n;

			int[] rotated = new int[n];
			Array.Copy(arr, d, rotated, 0, n - d);
			Array.Copy(arr, 0, rotated, n - d, d);

            //with custom reverse function with while loop

            // Step 1: Reverse the entire array
            Reverse(arr, 0, n - 1);

            // Step 2: Reverse the first part (0 to n-d-1)
            Reverse(arr, 0, n - d - 1);

            // Step 3: Reverse the second part (n-d to n-1)
            Reverse(arr, n - d, n - 1);






            // without any predefine function
            int[] newarr = new int[n];
			int nCount = 0;
			for(int i = d; i < arr.Length; i++)
			{
				newarr[nCount] = arr[i];
                nCount++;
            }
			for(int i = 0; i < d; i++)
			{
				newarr[nCount] = arr[i];
				nCount++;
            }
		}

        private void Reverse(int[] arr, int start, int end)
        {
            while (start < end)
            {
                // Swap elements
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                // Move indices closer
                start++;
                end--;
            }
        }


    }
}

