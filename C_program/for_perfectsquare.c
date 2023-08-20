#include<stdio.h>
void main()
{
	int num,i,sum=0;
	printf("Enter a number:");
	scanf("%d",&num);
	printf("excluding of %d are: \n",num);

	for(i=1;i<num;i++)
	{
		if(num%i==0)
		{
			printf("%d\n",i);
			sum=sum+i;
		}
	}
	if(sum==num)
		printf("%d is a perfect number:\n",num);
	else
		printf("%d is not a perfect number:\n",num);
}

//Algorithm
//1)start
//2)declare num,sum=0,i
//3)accept num
//4)print num
//5)for i=1;i<=num;i++
//6)if num%i==0
//7)print i
//8)sum=sum+i
//9)if sum==num
//10)print num is perfect number
//11) else print num is not perfect
//12)stop
