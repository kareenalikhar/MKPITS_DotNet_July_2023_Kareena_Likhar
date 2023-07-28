#include<stdio.h>
void addition(int n1,int n2)
{
	int result=n1+n2;
	printf("addition of 2 numbers=%d",result);
}
void main()
{
int num1,num2;
printf("Enter 2 numbers:");
scanf("%d%d",&num1,&num2);
addition(num1,num2);
printf("\nbye");
}

//Algorithm:
//1)start
//2)define the function addition
//2.1)declare n1,n2,result=n1+n2
//2.2)print addition of 2 numbers
//3)go to main function
//4)print Enter 2 numbers
//5)accept num1,num2
//6)call function addition
//7)print bye
//8)stop
