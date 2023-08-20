#include<stdio.h>
void main()
{
	int i,max,min,arr[5];
	for(i=0;i<5;i++)
	{
		printf("Enter number:");
		scanf("%d",&arr[i]);
	}
	max=arr[0];
	for(i=0;i<5;i++)
	{
		if(arr[i]>max)
		{
			max=arr[i];
		}
	}
		printf("\nMaximun value:%d",max);

	min=arr[0];
	for(i=0;i<5;i++)
	{
		if(arr[i]<min)
		{
			min=arr[i];
		}
	}
	printf("\nMinimum value:%d",min);
}

//Algorithm:
//1)start
//2)declare i,max,min,arr[5]
//3)for i=0;i<5;i++
//4)accept num
//5)max=arr[0]
//6)for i=0;i<5;i++
//7)if arr[i]>max
//8)max=arr[i]
//9)print max
//10)min=arr[0]
//11)for i=0;i<5;i++
//12)if arr[i]<min
//13)min=arr[i]
//14)print min
//15)stop

