#include<stdio.h>
void main()
{
	int counter=1;
	int sum=0;
	while(counter<=5)
	{
		sum=sum+counter;
		counter=counter+1;
	}
	printf("sum=%d",sum);
}

//Algorithm
//1)start
//2)declare counter=1,sum=0
//3)if counter <=5 then 
//4)sum=sum+counter
//5)counter=counter+1
//6)print sum
//7)stop
