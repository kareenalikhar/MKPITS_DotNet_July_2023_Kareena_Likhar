//function with parameter having no returning value
#include<stdio.h>
void check(int num,int result)
{
	if(num%2==0)
	{
		printf("Number is even");
	}
	else 
	{
		printf("Number is odd");
	}
}
void main()
{
	int num,result;
	printf("Enter a number:");
	scanf("%d",&num);
	check(num,result);
}

//Algorithm:
//1)start
//2)declare a function check
//3)declare num,result
//4)if num%2==0 print number is even
//5)else print number is odd
//6)declare main function
//7)declare num,result
//8)accept num
//9)call function check
//10)stop
