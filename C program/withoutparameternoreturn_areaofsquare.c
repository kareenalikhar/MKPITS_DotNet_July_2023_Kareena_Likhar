//function without parameter having no returning value
#include<stdio.h>
void area()
{
	int side,result;
	printf("Enter side:");
	scanf("%d",&side);
	result=side*side;
	printf("Area of square:=%d",result);
	
}
void main()
{
	int result,side;
	area(side,result);	
	
	
}

//Algorithm:
//1)start
//2)declare function area
//3)declare side,result
//4)accept side
//5)result=side*side
//6)print result
//7)declare main function
//8)call area function
//9)stop
