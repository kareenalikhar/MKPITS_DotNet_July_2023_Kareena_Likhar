#include<stdio.h>
void main()
{
	int counter=2;
	int rem=0;
	int num;
	printf("Enter a number:");
	scanf("%d",&num);
	do
	{
	rem=num%counter;
	if(rem==0)
	{
		printf("it is not a prime number:(");
		break;
	}
	counter=counter+1;
}
		while(counter<num);
		if(num==counter)
		{
			printf("it is prime number:)");
		}

}

//Algorithm:
//1)start
//2)declare counter=2,rem=0,num
//3)accept num
//4) rem==0
//4.1)print it is not prime number
//5)counter=counter+1
//6)check counter is greater than num
//6)num==counter
//6.2)print it is prime number
//7)stop
