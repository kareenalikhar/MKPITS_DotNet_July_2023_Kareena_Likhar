#include<stdio.h>
void main()
{
	int num;
	int factorial=1;
	printf("Enter a number:");
	scanf("%d",&num);
	while(num>0)
	{
		factorial=factorial*num;
		num=num-1;
	}
	printf("Factorial=%d",factorial);
}

//Algorithm
//1)start
//2)accept num,factorial=1
//3)check num is greater than 0 then
//3.1) factorial=factorial*num
//3.2)num=num-1
//4)print factorial
//5)stop
