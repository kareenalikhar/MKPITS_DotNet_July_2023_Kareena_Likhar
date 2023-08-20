#include<stdio.h>
#include<string.h>
struct student
{
	int rno;
	char name[20];
};
void main()
{
	struct student stud[5];
	int counter;
	for(counter=0;counter<5;counter++)
	{
		printf("Enter rno and name of student:");
		scanf("%d%s",&stud[counter].rno,&stud[counter].name);
	}
	printf("Student details:");
	for(counter=0;counter<5;counter++)
	{
		printf("\nroll no=%d\t",stud[counter].rno);
		printf("Student name=%s",stud[counter].name);
	}
}

//Algorithm:
//1)start
//2)define structure student
//3)declare rno,name,counter
//4)create an array of structure student stud with size 5
//5)loop from counter=0;counter<2;counter++
//6)accept rno,name of student
//7)print student detail
//8)for counter=0;counter<5;counter++
//9)print roll no and student name
//10)stop
