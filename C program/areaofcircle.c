#include<stdio.h>
void main()
{
	float radius,area,circum;
	printf("Enter radius:");
	scanf("%f",&radius);
	area=3.14f*radius*radius;
	circum=2*3.14f*radius;
	printf("area=%f\n",area);
	printf("circum=%f",circum);
}
