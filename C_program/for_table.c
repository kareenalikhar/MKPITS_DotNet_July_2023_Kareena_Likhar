#include<stdio.h>
void main()
{
	int num;
	int counter;
	int result=0;
	printf("Enter a number:");
	scanf("%d",&num);
	for(counter=1;counter<=10;counter++)
	{
		result=num*counter;
		printf("%dx%d=%d\n",num,counter,result);
	}
}

//Algorithm
//1)start
//2)declare num,counter, result=0
//3)accept num
//4)print num
//5)for counter=1;counter<=10;counter++
//6)result=num*counter
//7)print num*counter=result
//8)stop
