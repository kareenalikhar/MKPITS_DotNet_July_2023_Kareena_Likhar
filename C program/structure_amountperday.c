#include<stdio.h>
#include<string.h>
struct student
{
	char name[20];
	int fees;
};
void main()
{
	struct student s1[2];
	int counter,perday,total_month,month;
	for(counter=0;counter<2;counter++)
	{
	printf("Enter student name and fees:");
	scanf("%s%d",&s1[counter].name,&s1[counter].fees);
}
	for(counter=0;counter<2;counter++)
	{
	month=20;
	total_month=month*5;
	perday=s1[counter].fees/total_month;
	printf("total amount per day %d",perday);
}
}

//Algorithm:
//1)start
//2)define structure student
//3)declare name,fees,counter,perday,total_month,month
//4)create an array of structure student s1 with size 2
//5)loop from counter=0;counter<2;counter++
//6)accept team name,fees
//7)for counter=0;counter<5;counter++
//8)month=20
//9)total_month=month*5
//10)perday=s1[counter].fees/total_month
//11)print total run scored by team
//12)stop
