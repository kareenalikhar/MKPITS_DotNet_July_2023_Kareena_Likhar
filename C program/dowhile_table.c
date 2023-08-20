#include<stdio.h>
void main()
{
	int num;
	int counter=1;
	int result;
	printf("Enter a number:");
	scanf("%d",&num);
	do
	{
	result=num*counter;
	counter=counter+1;
	printf("%d\n",result);
	}
	while(counter<=10);
}


//Algorithm:
//1)start
//2)declare num,counter=1,result
//3)accept num
//4)result=num*counter
//4.1)counter=counter+1
//5)print result
//6)check counter is smaller than equal to 10
//6)stop
