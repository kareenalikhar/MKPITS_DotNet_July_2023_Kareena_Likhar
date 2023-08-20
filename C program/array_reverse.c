#include<stdio.h>
void main()
{
	int i,n,nums[100];
	printf("Enter n:");
	scanf("%d",&n);
	//accepting values
	for(i=0;i<n;i++)
	{
		printf("Enter numbers:");
		scanf("%d",&nums[i]);
	}
	for(i=n-1;i>=0;i--)
	{
		printf("%d",nums[i]);
	}
}

//Algorithm:
//1)start
//2)declare i,n,nums[100]
//3)accept number
//4)for i=0;i<n;i++
//5)accept nums
//6)for i=n-1;i>=n;i--
//7)print nums
//8)stop
