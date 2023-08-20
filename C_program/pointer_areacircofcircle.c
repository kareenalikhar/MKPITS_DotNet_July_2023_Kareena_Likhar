#include<stdio.h>
void calculate(int r,float *a,float *c)
{
	*a=3.14f*r*r;
	*c=2*3.14f*r;
}
void main()
{
	int radius;
	float area,circ;
	printf("Enter radius:");
	scanf("%d",&radius);
	calculate(radius,&area,&circ);
	printf("Area of circle=%f\n",area);
	printf("Circ=%f",circ);
}

//Algorithm:
//1)start
//2)declare a function as calculate 
//3)take *a=3.14f*r*r
//	*c=2*3.14f*r
//4)declare main function 
//5)declare radius, area, cicr
//6)accept radius
//7)call function calculate
//8)print area of circle and circ
//9)stop
