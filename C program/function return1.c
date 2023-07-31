#include<stdio.h>
int addition()
{
	int n1,n2;
	printf("Enter 2 numbers:");
	scanf("%d%d",&n1,&n2);
	int result=n1+n2;
	return result;
}
void main()
{
	char ch='y';
	while(ch=='y')
	{
	int result;
	result=addition();
	printf("result=%d\n",result);
	printf("do you want to continue,press y");
	fflush(stdin);
	scanf("%c",&ch);
}
}

//Algorithm:
//1)Start
//2)declare function addition
//3)declare n1,n2
//4)accpet n1,n2
//5)result=n1+n2
//6)declare main function
//7)declare result
//8)call function addition
//9)print result
//10)stop 
