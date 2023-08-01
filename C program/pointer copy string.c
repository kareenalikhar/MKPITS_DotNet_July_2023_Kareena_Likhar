#include<stdio.h>
void main()
{
	char name1[10];
	char name2[10];
	char *ptr1,*ptr2;
	printf("Enter name:");
	gets(name1);
	ptr1=name1;
	ptr2=name2;
	while(*ptr1 != '\0')
	{
		*ptr2=*ptr1;
		ptr1++;
		ptr2++;
	}
	*ptr2='\0';
	printf("copy name=%s",name2);
}

//Algorithm:
//1)start
//2)declare name1,name2,ptr1,ptr2
//3)accept name
//4)ptr1=name1,ptr2=name2
//5)while *ptr1 != '\0' then
//5.1)*ptr2=*ptr1
//	ptr1++
//	ptr2++
//6)*ptr2='\0'
//7)print name2
//8)stop
