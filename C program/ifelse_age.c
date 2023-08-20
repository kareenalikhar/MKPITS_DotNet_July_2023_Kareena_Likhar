#include<stdio.h>
void main()
{
	int i;
	printf("Enter number:");
	scanf("%d",&i);
	if(i>75)
	{
		printf("%d is old",i);
	}
	else
	{
		printf("%d is adult",i);
	}
}
