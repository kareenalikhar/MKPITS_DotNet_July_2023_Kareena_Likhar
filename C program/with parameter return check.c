//function with parameter having returning value
#include<stdio.h>
int check(int num,int result)
{
	if(num%2==0)
	{
		printf("Number is even");
	}
	else
	{
		printf("Number is odd");
	}
	return result;
}
void main()
{
	int num,result;
	printf("Enter a number:");
	scanf("%d",&num);
	result=check(num,result);
}

//Algorithm:
//1)start
//2)declare a function check
//2.1)declare num,result
//3)if num%2==0 print number is even
//4)else print number is odd
//5)declare main function
//6)declare num,result
//7)accept num
//8)call function check
//9)stop
