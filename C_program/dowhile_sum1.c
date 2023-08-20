#include<stdio.h>
void main()
{
	int counter=10;
	int sum=0;
	do
	{
		sum=sum+counter;
		counter=counter+1;
		printf("sum=%d",sum);
	}
	while(counter<=20);
}

//Algorithm
//1)start
//2)declare counter=10,sum=0
//3)sum=sum+counter
//4)counter=counter+1
//5)print sum
//6)if counter <=20 then 
//7)stop
