#include<stdio.h>
int addition(int n1,int n2)
{
int result=n1+n2;
return result;
}
void main()
{
	char ch='y';
		while(ch=='y')
	{
		int num1,num2,result;
		printf("Enter 2 numbers:");
		scanf("%d%d",&num1,&num2);
		result=addition(num1,num2);
		printf("result=%d",result);
		printf("\ndo you want to continue,press y");
		fflush(stdin);
		scanf("%c",&ch);
	}
}

//Algorithm
//1)start
//2)declare a function addition
//2.1)declare function as addition
//3)result=n1+n2
//4)return result
//5)declare main function
//6)char is y
//7)while ch==y
//8)declare num1,num2,result
//9)accept num1,num2
//10)call function addition
//11)print result
//12)stop
