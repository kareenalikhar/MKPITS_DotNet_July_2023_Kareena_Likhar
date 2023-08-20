#include<stdio.h>
void main()
{
	int i,arr[5],cnt=0,j;
	for(i=0;i<5;i++)
	{
		printf("Enter number:");
		scanf("%d",&arr[i]);
	}
	for(i=0;i<5;i++)
	{
		for(j=i+1;j<5;j++)
		{
			if(arr[i]==arr[j])
			{
				cnt++;
				break;
			}
		}
	}
	printf("\nNo of duplicate element=%d",cnt);
}

//Algorithm:
//1)start
//2)declare i,arr[5],cnt=0,j
//3)accept num
//4)for i=0;i<5;i++
//5)for j=i+1;j<5;j++
//6)if arr[i]==arr[j]
//7)cnt++
//8)print cnt
//9)stop
