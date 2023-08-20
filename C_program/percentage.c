#include<stdio.h>
void main()
{
	float sub1,sub2,sub3,total;
	float per;
	printf("Enter 3sub marks:");
	scanf("%f,%f,%f",&sub1,sub2,sub3);
	total=sub1+sub2+sub3;
	per=(total/300.0f)*100.0f;
	printf("total=%f\n",total);
	printf("per=%f",per);
}
