#include<stdio.h>
void main()
{
	int num,i,cube;
	printf("Enter a number:");
	scanf("%d",&num);
	for(i=1;i<=num;i++)
	{
		cube=i*i*i;
		printf("\n%d cube is %d",i,cube);
	}
}

//Algorithm
//1)start
//2)declare num,i,cube
//3)accept num
//5)for i=1;i<=num;i++
//6)cube=i*i*i
//7)print cube
//8)stop
