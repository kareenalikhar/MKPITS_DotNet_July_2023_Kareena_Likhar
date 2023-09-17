#include<stdio.h>
int main()
{
	int num, a=0,b=1,i,c;
	printf("enter num:");
	scanf("%d",&num);
	for(i=1;i<=num;i++)
	{
		printf("%d ",a);
		c=a+b;
		a=b;
		b=c;
	}
}
