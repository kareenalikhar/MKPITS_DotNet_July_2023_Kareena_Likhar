//function without parameter having no returning value
#include<stdio.h>
void check()
{
	int num,result;
	printf("Enter a number:");
	scanf("%d",&num);
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
	check(num,result);	
}

//Algorithm:
//1)start
//2)declare a function check
//3)declare num,result
//4)accept num
//5)if num%2==0 print number is even
//6)else print number is odd
//7)declare main function
//8)declare num,result
//9)call function check
//10)stop
