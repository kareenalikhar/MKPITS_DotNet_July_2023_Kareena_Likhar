#include<stdio.h>
void main()
{
	int i;
	printf("Enter number:");
	scanf("%d",&i);
	if(i%2==0)
	{
		printf("%d is even",i);
	}
	else
	{
		printf("%d is odd",i);
	}
}
