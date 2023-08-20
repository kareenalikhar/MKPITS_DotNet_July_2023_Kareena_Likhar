#include<stdio.h>
void main()
{
	int num;
	int factorial=1;
	printf("Enter a number:");
	scanf("%d",&num);
	do
	{
		factorial=factorial*num;
		num=num-1;
	}
			while(num>0);
	printf("Factorial=%d",factorial);

}

//Algorithm
//1)start
//2)accept num,factorial=1
//3) factorial=factorial*num
//3.1)num=num-1
//4)check num is greater than 0 then
//5)print factorial
//6)stop
