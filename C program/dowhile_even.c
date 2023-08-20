#include<stdio.h>
void main()
{
	int counter=2;
		do
		{
		if(counter%2==0)
		{
			printf("%d\n",counter);
		}
		counter=counter+1;
	}
		while(counter<=10);
}

//Algorithm
//1)start
//2)declare counter=2
//3)if counter%2==0 then
//4)print counter
//5)counter=counter+1
//6)counter <=10 
//7)stop
