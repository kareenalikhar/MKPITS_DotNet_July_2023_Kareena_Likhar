#include<stdio.h>
void main()
{
	int i,rem=0,arr[5];
	for(i=0;i<5;i++)
	{
		printf("Enter number:");
		scanf("%d",&arr[i]);
	}
	for(i=0;i<5;i++)
		{
			if(arr[i]%2==0)
			{
	printf("\nNumber is even=%d",arr[i]);
}
		else
		{
			printf("\nnumber is odd=%d",arr[i]);
		}
	}
	}
	
//Algorithm:
//1)start
//2)decare i,rem=0,arr[5]
//3)for i=0;i<5;i++
//4)accept num
//5)for i=0;i<5;i++
//6)if arr[i]%2==0
//7)print number is even
//8)else print number is odd
//9)stop
	

