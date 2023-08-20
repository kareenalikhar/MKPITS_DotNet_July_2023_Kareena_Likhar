#include<stdio.h>
void main()
{
	int n1,n2;
	printf("Enter number:");
	scanf("%d",&n1);
	printf("Enter number:");
	scanf("%d",&n2);
	if(n1<n2)
	{
		printf("%d is smaller",n1);
	}
	else
	{
		printf("%d is smaller",n2);
	}
}
