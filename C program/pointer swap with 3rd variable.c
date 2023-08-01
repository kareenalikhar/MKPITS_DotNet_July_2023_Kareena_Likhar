#include<stdio.h>
void main()
{
	int n1=10;
	int n2=20;
	int temp;
	int *p1=&n1;
	int *p2=&n2;
	printf("Before swap *p1=%d,*p2=%d",*p1,*p2);
	temp=*p1;
	*p1=*p2;
	*p2=temp;
	printf("\nAfter swap *p1=%d,*p2=%d",*p1,*p2);
}

//Algorithm:
//1)start
//2)declare n1=10,n2=20,temp
//3)declare *p1 is equal to address of n1 
//and *p2 is equal to address of n2
//4)print before swap value of *p1,*p2
//5)take temp=*p1
//	*p1=*p2
//	*p2=temp
//6)print after swap value of *p1,*p2
//7)stop	
