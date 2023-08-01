#include<stdio.h>
void main()
{
	int cnt=0;
	char name[10];
	char *ptr;
	printf("Enter name:");
	gets(name);
	ptr=name;
	while(*ptr!='\0')
	{
		{
		cnt=cnt+1;
	}
	ptr++;
}
	printf("No of letter in string=%d",cnt);
}

//Algorithm:
//1)start
//2)declare cnt=0,name,*ptr
//3)accept name
//4)take condition as *ptr!='\0'
//5)cnt=cnt+1
//6)ptr++
//7)print cnt
//8)stop
