#include<stdio.h>
void main()
{
	int num=5;
	int *ptr=&num;
	printf("Address=%x\n",ptr);
	printf("value at address=%d",*ptr);
}

//Algorithm:
//1)start
//2)declare num is equal
//3)declare ptr is equal to address of num
//4)print address of ptr
//5)print value at ptr
//6)stop

