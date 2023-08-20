#include<stdio.h>
void addition()
{
	int n1,n2,result=n1+n2;
	printf("Addition of 2 numbers=%d",result);
}
void main()
{
	char ch='y';
	do
	{
		int num1,num2;
		printf("Enter 2 numbers:");
		scanf("%d%d",&num1,&num2);
		addition(num1,num2);
		printf("\nDo you want to continue,press y");
		fflush(stdin);
		scanf("%c",&ch);
	}
	while(ch=='y');
}

//Algorithm:
//1)start
//2)define the function addition
//2.1)declare n1,n2,result=n1+n2
//2.2)print addition of 2 numbers
//3)go to main function
//4)declare ch=y
//5)print Enter 2 numbers
//6)accept num1,num2
//7)call function addition
//8)print do you want to continue press y
//9)accept ch
//10)stop
