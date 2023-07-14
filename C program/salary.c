#include<stdio.h>
void main()
{
	float basic,hra,da,total_salary;
	printf("basic salary:");
	scanf("%f",&basic);
	hra=basic*0.35f;
	da=basic*0.45f;
	total_salary=basic+hra+da;
	printf("hra=%f\n",hra);
	printf("da=%f\n",da);
	printf("Total salary=%f",total_salary);
}*
