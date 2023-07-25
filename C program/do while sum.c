#include<stdio.h>
void main()
{
	int counter=1;
	int sum=0;
	do
	{
		sum=sum+counter;
		counter=counter+1;
		printf("sum=%d",sum);
	}
	while(counter<=5);
}

//Algorithm
//1)start
//2)declare counter=1,sum=0 
//3)sum=sum+counter
//4)counter=counter+1
//5)print sum
//6)if counter <=5 then
//7)stop
