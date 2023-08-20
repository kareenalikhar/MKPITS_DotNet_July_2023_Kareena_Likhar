#include<stdio.h>
#include<string.h>
struct employee
{
	int empid,salary;
	char name[20],desig[20],dep[20];
};
void main()
{
	struct employee emp[5];
	int counter;
	for(counter=0;counter<5;counter++)
	{
		printf("Enter emp id,name,designation,department,salary:");
		scanf("%d%s%s%s%d",&emp[counter].empid,&emp[counter].name,&emp[counter].desig,&emp[counter].dep,&emp[counter].salary);
	}
	printf("Enter employee details:\n");
	for(counter=0;counter<5;counter++)
	{
		printf("\nEnter employee id=%d\t",emp[counter].empid);
		printf("Enter employee name=%s\t",emp[counter].name);
		printf("Enter employee designation=%s\t",emp[counter].desig);
		printf("Enter employee department=%s\t",emp[counter].dep);
		printf("Enter employee salary=%d",emp[counter].salary);
	}
}

//Algorithm:
//1)start
//2)define structure employee
//3)declare empid,salary,name,desig,dep,counter
//4)create an array of structure employee emp with size 5
//5)loop from counter=0;counter<2;counter++
//6)accept emp id,name,designation,department,salary
//7)print employee detail
//8)for counter=0;counter<5;counter++
//9)print employee id,name,designation,departement,salary
//10)stop
