#include<stdio.h>
void main()
{
	int n1=5,n2=7,*p1=&n1,*p2=&n2;
	printf("Before swap *p1=%d,*p2=%d\n",*p1,*p2);
	*p1=*p1+*p2;
	*p2=*p1-*p2;
	*p1=*p1-*p2;
	printf("After swap *p1=%d,*p2=%d",*p1,*p2);
}

//Algorithm:
//1)start
//2)declare n1=5,n2=7,*p1=&n1,*p2=&n2
//3)print before swap value of *p1,*p2
//4)take *p1=*p1+*p2
//	*p2=*p1-*p2
//	*p1=*p1-*p2
//5)print after swap value of *p1,*p2
//6)stop
