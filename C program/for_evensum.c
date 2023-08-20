#include<stdio.h>
void main()
{
	int num,i,sum=0;
	printf("Enter a number:");
	scanf("%d",&num);
	printf("odd number from 1 to %d are:\n",num);
	for(i=1;i<=num;i++)
	{
		if(i%2==0)
		{
		printf("%d\n",i);
		sum=sum+i;
		}
	}	
		printf("sum of odd natural number %d is %d\n",num,sum);
	}
	
//Algorithm
//1)start
//2)declare num,sum=0,i
//3)accept num
//4)print num
//5)for i=1;i<=num;i++
//6)if i%2==0
//7)print i
//8)sum=sum+i
//9)print num and sum
//10)stop
