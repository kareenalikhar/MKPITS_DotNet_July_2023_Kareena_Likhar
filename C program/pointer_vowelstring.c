#include<stdio.h>
void main()
{
	int cnt=0;
	char name[20];
	char *ptr;
	printf("Enter name:");
	gets(name);
	ptr=name;
	while(*ptr != '\0')
	{
		if(*ptr=='a' || *ptr=='e' || *ptr=='i' || *ptr=='o' || *ptr=='u')
		{
			cnt=cnt+1;
		}
		ptr++;
	}
	printf("no of vowel in string=%d",cnt);
	
}

//Algorithm:
//1)start
//2)declare cnt=0,name,*ptr
//3)accept name
//4)ptr=name
//5)take condition as *ptr!='\0'
//6)if *ptr=='a' || *ptr=='e' || *ptr=='i' || *ptr=='o' || *ptr=='u'
//7)cnt=cnt+1
//8)ptr++
//9)print cnt
//10)stop
