#include<stdio.h>
void main()
{
	char n1[10];
	char n2[10];
	char *ptr1;
	char *ptr2;
	printf("Enter name1:");
	gets(n1);
	ptr1=n1;
	printf("Enter name2:");
	gets(n2);
	ptr2=n2;
	while(*ptr1!='\0' || *ptr2!='\0')
	{
		if(*ptr1==*ptr2)
		{
			printf("string is equal:");
			break;
		}
		else
		{
			printf("string is not equal:");
			break;
		}
	}
	
}

//Algorithm:
//1)start
//2)declare n1,n2,ptr1,ptr2
//3)accept name1 and name2
//4)ptr1=name1,ptr2=name2
//5)while *ptr1 != '\0' and *ptr2!='\0'
//	if *ptr1==*ptr2
//6)print string is equal
//7)else print string is not equal
//8)stop
