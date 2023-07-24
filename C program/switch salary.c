+#include<stdio.h>
int main()
{
	char name[20];
	char designation;
	int salary;
	printf("Employee name:");
	scanf("%s",&name);
	printf("enter designation (m,c,p)");
	fflush(stdin);
	scanf("%c",&designation);	
	switch(designation)
	{
		case 'm':
			salary=50000;
			break;
			case 'c':
				salary=20000;
				break;
				case 'p':
					salary=10000;
					break;
	}
	printf("employee name=%s",name);
	printf("\nsalary=%d",salary);
}

//Algorithm
//1-start
//2-accept name,designation,salary
//3-if designation is m then salary=50000
//4-if designation is c then salary=20000
//5-if designation is p then salary=10000
//6-stop
