#include<stdio.h>
void table(int num,int i)
{
	for(i=1;i<=10;i++)
	{
		printf("%d*%d=%d\n",num,i,num*i);
	}
}

void main()
{
int num,i=1;
printf("Enter a numbers:");
scanf("%d",&num);
table(num,i);
}

//Algorithm:
//1)start
//2)define the function table
//3)declare num,i
//4)i=1;i<=10;i++
//4.1)print num,i=num*i
//5)go to main function
//6)accept num
//7)call function table
//8)stop
