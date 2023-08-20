#include<stdio.h>
void main()
{
	int i,num1=0,num2=1,add=num1+num2;-
	
	printf("%d,%d",num1,num2);
	for (i=3;i<=10;i++)
	{
		printf(",%d",add);
		num1=num2;
		num2=add;
		add=num1+num2;
	}
}

//Algorithm
//1)start0
//2)declare num,num1=0,num2=1,add=num1+num2
//3)print num1,num2
//4)for i=1;i<=num;i++
//7)print add
//8)num1=num2
//9)num2=add
//10)add=num1+num2
//11)stop
