#include<stdio.h>
void prime(int num,int counter,int rem)
{
	while(counter<num)
	{
	rem=num%counter;
	if(rem==0)
	{
		printf("not a prime no");
	break;
	}
	counter=counter+1;
}
if(num==counter)
{
	printf("it is a prime no");
}
}

void main()
{
int num,counter=2,rem=0;
printf("Enter a numbers:");
scanf("%d",&num);
prime(num,counter,rem);
}

//Algorithm
//1)start
//2)define the function prime
//3)declare num,counter,rem
//4)while counter<num
//4.1)rem=num%counter
//4.2)if rem==0
//4.3)print not a prime no
//5)counter=counter+1
//6)if num==counter
//6.1)print it is a prime no
//7) go to main function
//8)accept num
//9)call function prime
//10)stop
