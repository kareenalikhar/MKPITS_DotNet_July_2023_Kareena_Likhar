#include<stdio.h>
void main()
{
	int counter=2;
	int rem=0;
	int num;
	printf("Enter a number:");
	scanf("%d",&num);
	while(counter<num)
	{
	rem=num%counter;
	if(rem==0)
	{
		printf("it is not a prime number:(");
		break;
	}
	counter=counter+1;
}
		if(num==counter)
		{
			printf("it is prime number:)");
		}
}

//Algorithm:
//1)start
//2)declare counter=2,rem=0,num
//3)accept num
//4)check counter is greater than num
//4.1) rem==0
//4.2)print it is not prime number
//5)counter=counter+1
//5.1)num==counter
//5.2)print it is prime number
//6)stop

