//function with parameter having returning value
#include<stdio.h>
int area(int side)
{
	int result=side*side;
	return result;
}
void main()
{
	int side,result;
	printf("Enter side:");
	scanf("%d",&side);
	result=area(side);
	printf("Area of square=%d",result);
}

//Algorithm:
//1)start
//2)declare function area
//2.1)declare side
//3)result=side*side
//4)declare main function
//5)declare side,result
//6)accept side
//7)call function area
//8)print result
//9)stop
