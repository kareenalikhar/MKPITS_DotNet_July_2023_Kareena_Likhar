#include<stdio.h>
void main()
{
	int num,i=1;
	printf("Enter a number:");
	scanf("%d",&num);
	table:
		printf("%d*%d=%d\n",num,i,num*i);
		i++;
		if(i<=10)
		{
			goto table;
		}
}

//Algorithm:
//1)start
//2)declare num,i=1;
//3)accept num
//4)table
//5)print num,i,num*i
//6)i++
//7)if i<=10
//8)goto table
//9)stop

