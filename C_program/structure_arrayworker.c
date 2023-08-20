#include<stdio.h>
#include<string.h>
struct workers{
	char name[20];
	int wage,workday,salary;
};
void main()
{
	struct workers work[2];
	int counter;
	for(counter=0;counter<2;counter++)
	{
		printf("Enter workers name,daily wage and working days:");
		scanf("%s%d%d",&work[counter].name,&work[counter].wage,&work[counter].workday);
	}
	printf("\nEnter Worker's details:");
	for(counter=0;counter<2;counter++)
	{
		work[counter].salary=work[counter].wage*work[counter].workday;
	}
	for(counter=0;counter<2;counter++)
	{
		printf("\nTotal salary=%d",work[counter].salary);
	}
}

//Algorithm:
//1)start
//2)define structure worker
//3)declare name,wage,worker,salary,counter
//4)create an array of structure worker work with size 2
//5)loop from counter=0;counter<2;counter++
//6)accept worker name,daily wage,working days
//7)print worker detail
//8)for counter=0;counter<5;counter++
//9)work[counter].salary=work[counter].wage*work[counter].workday
//10)for counter=0;counter<5;counter++
//11)print total salary
//12)stop
