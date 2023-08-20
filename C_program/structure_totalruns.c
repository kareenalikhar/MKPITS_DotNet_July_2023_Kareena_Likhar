#include<stdio.h>
#include<string.h>
struct cricket
{
	char name[20];
	int run;
};
void main()
{
	struct cricket c1[11];
	int counter,total=0;
	for(counter=0;counter<11;counter++)
	{
		printf("Enter team name and run scored:");
		scanf("%s%d",&c1[counter].name,&c1[counter].run);
	}
	for(counter=0;counter<11;counter++)
	{
	total=total+c1[counter].run;
}
	printf("total run scored by team=%d",total);
}

//Algorithm:
//1)start
//2)define structure cricket
//3)declare name,run,counter,total=0
//4)create an array of structure cricket c1 with size 11
//5)loop from counter=0;counter<2;counter++
//6)accept team name,run scored
//7)for counter=0;counter<5;counter++
//8)total=total+c1[counter].run
//9)print total run scored by team
//10)stop
