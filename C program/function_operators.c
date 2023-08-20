#include<stdio.h>
void calculate(int num1,int num2,char op)
{
	int result=0;
	switch(op)
	{
		case '+':
		result=num1+num2;
		break;
		case '-':
		result=num1-num2;
		break;
		case '*':
		result=num1*num2;
		break;
		case '/':
		result=num1/num2;
		break;
		}
		printf("result=%d\n",result);
}

void main()
{
		int num1,num2,result=0;
		char op;
		char ch='y';
	do
	{
		printf("Enter 2 numbers:");
		scanf("%d%d",&num1,&num2);
		printf("enter (+,-,*,/)");
		fflush(stdin);
		scanf("%c",&op);
		calculate(num1,num2,op);
		printf("\nDo you want to continue,press y");
		fflush(stdin);
		scanf("%c",&ch);
	}
	while(ch=='y');
}

//Algorithm:
//1)start
//2)define a function
//3)declare num1,num2,op,result=0
//3.1if operator is + then result= num1+num2
//3.2)if operator is - then result= num1-num2
//3.3)if operator is * then result= num1*num2
//3.4)if operator is / then result= num1/num2
//4)print result
//5)go to main function
//6)accept 2 numbers 
//7)accept +,-,*,/
//8)call function calculate
//9)print do you want to continue press y
//10)accept ch
//11)ch==y
//12)stop 
