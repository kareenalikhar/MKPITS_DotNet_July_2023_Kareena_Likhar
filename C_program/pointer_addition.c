#include<stdio.h>
void addition(int n1,int n2,int *result)
{
	*result=n1+n2;
}
void main()
{
	int num1,num2,result;
	printf("Enter 2 number");
	scanf("%d%d",&num1,&num2);
	addition(num1,num2,&result);
	printf("Addition=%d",result);
}

//Algorithm:
//1)start
//2)declare function addition
//2.1)declare n1,n2,result
//3)*result=n1+n2
//4)declare main function
//5)declare num1,num2,result
//6)accept num1,num2
//7)call function addition
//8)print result
//9)stop


