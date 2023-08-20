#include<stdio.h>
void main()
{
	char name1[10];
	char name2[10];
	char *ptr1=name1;
	char *ptr2=name2;
	printf("Enter name 1:");
	gets(name1);
	printf("Enter name2:");
	gets(name2);
	while(*ptr1 !='\0')
	{
		ptr1++;
	}
	while(*ptr2 !='\0')
	{
		*ptr1=*ptr2;
		ptr1++;
		ptr2++;
	}
	*ptr1='\0';
	printf("concetenate string=%s",name1);
}

//Algorithm:
//1)start
//2)declare name1,name2,ptr1,ptr2
//3)accept name
//4)ptr1=name1,ptr2=name2
//5)while *ptr1 != '\0' then
//	ptr1++
//6)//5)while *ptr1 != '\0' then
//*ptr1=*ptr2;
//		ptr1++;
//		ptr2++
//7)*ptr2='\0'
//8)print name1
//9)stop
