#include<stdio.h>
#include<string.h>
struct student
{
	int rollno;
	char name[20];
	struct date
	{
		int date;
		int month;
		int year;
	}
	bithdate,addate;
};
void main()
{
	struct student stud[3];
	int counter,r;
	for(counter=0;counter<3;counter++)
	{
		printf("Enter Rollno,Name:");
		scanf("%d%s",&stud[counter].bithdate.date,&stud[counter].name);
		printf("Enter Birthday:");
		scanf("%d-%d-%d",&stud[counter].bithdate.date,&stud[counter].bithdate.month,&stud[counter].bithdate.year);
		printf("Addmission date:");
		scanf("%d-%d-%d",&stud[counter].addate.date,&stud[counter].addate.month,&stud[counter].addate.year);
	}
	for(counter=0;counter<3;counter++)
	{
		r=stud[counter].addate.year-stud[counter].bithdate.year;
		printf("\nAge of student at the time of addmission:");
		printf("\t%d years",r);
	}
}
