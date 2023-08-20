#include<stdio.h>
void main()
{
	char name[10];
	char *ptr;
	printf("enter name:");
	gets(name);
	ptr=name;
	while(*ptr!='\0')
	{
		printf("%c",*ptr);
		ptr++;

	}

}

//Algorithm:
//1)start
//2)declare name ,*ptr
//3)accept name
//4)ptr=name
//5)take condition as *ptr!='\0'
//6)print ptr
//7)ptr++
//8)stop
