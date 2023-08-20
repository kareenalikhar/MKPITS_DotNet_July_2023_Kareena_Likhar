i#include<stdio.h>
void main()
{
	int i,j,arr[5],temp;
	for(i=0;i<5;i++)
	{
		printf("Enter number:");
		scanf("%d",&arr[i]);
	}
	for(i=0;i<5;i++)
	{
		for(j=i+1;j<5;j++)
		{
			if(arr[i]<=arr[j])
			{
				temp=arr[i];
				arr[i]=arr[j];
				arr[j]=temp;
			}
		}
	}
	printf("Descending order:");
	for(i=0;i<5;i++)
	{
		printf("%d",arr[i]);
	}
}

//Algorithm:
//1)start
//2)declare i,j,arr[5],temp
//3)for i=0;i<5;i++
//4)accept num
//5)for i=0;i<5;i++
//6)for j=i+1;j<5;j++
//7)if arr[i]<=arr[j]
//8)temp=arr[i]
//	arr[i]=arr[j]
//	arr[j]=temp
//9)print descending order
//10)for i=0;i<5;i++
//11)print arr[i]
//12)stop
