#include<stdio.h>
void main()
{
	char name[10];
	int salary,bonus=0;
	printf("enter name:");
	scanf("%s",name);
	printf("salary:");
	scanf("%d",&salary);
	
	if(salary>=10000)
	{
		bonus=5000;
	}
	else if(salary<10000 && salary>=5000)
	{
		bonus=2000;
	}
	else
	{
		bonus=1000;
	}
	printf("employee_name:=%s",name);
	printf("\nbasic_salary:=%d",salary);
	printf("\nbonus=%d",bonus);

}

//Algorithm
//step1- start
//step2- accept name,salary,bonus
//step3- if salary is greater than 10000 then bonus=5000
//step4- if salary is less than 10000 and greater than equal to 5000 then bonus=2000
//step5- else bonus=1000
//step6- stop
