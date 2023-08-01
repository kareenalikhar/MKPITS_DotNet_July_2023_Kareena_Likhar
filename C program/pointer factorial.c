#include<stdio.h>
void factorial(int num,int *fact)
{
	while(num>0)
	{
	*fact=*fact * num;
	num=num-1;
}
}
void main()
{
	int num,fact;
	printf("Enter a number");
	scanf("%d",&num);
	factorial(num,&fact);
	printf("factorial=%d",fact);
}

//Algorithm:
//1)start
//2)declare function factorial
//2.1)declare num,*fact
//3)take condition as num>0
//4)*fact=*fact * num
//	num=num-1
//5)declare main function
//6)accept num
//7)call function factorial
//8)print fact
//9)stop
