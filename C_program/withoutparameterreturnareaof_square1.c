//function without parameter having returning value
#include<stdio.h>
int area()
{
	int side;
	printf("Enter side:");
	scanf("%d",&side);
	int result=side*side;
	return result;
}
void main()
{
	int result;
	result=area();
	printf("Area of square=%d",result);
}

//Algorithm:
//1)start
//2)declare function area
//3)accept side
//4)result=side*side
//5)declare main function
//6)declare result
//7)call function area
//8)stop
