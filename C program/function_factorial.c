#include<stdio.h>
void factorial(int num,int fact)
{
	while(num>0)
	{
	fact=fact*num;
	num=num-1;
}
	printf("fact=%d",fact);
}
void main()
{
int num,fact=1;
printf("Enter a numbers:");
scanf("%d",&num);
factorial(num,fact);
}

//Algorithm:
//1)start
//2)define the function factorial
//2.1)declare num,fact
//2.2)while num>0
//2.3)fact=fact*num
//2.4)num=num+1
//3)print fact
//4)go to main function
//5)accept num
//6)call function factorial
//7)stop
