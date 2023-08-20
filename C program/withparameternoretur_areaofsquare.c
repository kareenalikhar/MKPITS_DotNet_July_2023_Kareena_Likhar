//function with parameter having no returning value
#include<stdio.h>
void area(int side)
{
	int result=side*side;
	printf("Area of square=%d",result);
}
void main()
{
	int side,result;
	printf("Enter side:");
	scanf("%d",&side);
	area(side);
}

//Algorithm:
//1)Start
//2)declare function area
//2.1)declare side
//3)result=side*side
//4)print result
//5)declare main function
//6)declare side,result
//7)accept side
//8)call function area
//9)stop
