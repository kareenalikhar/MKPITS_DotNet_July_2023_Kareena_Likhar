#include<stdio.h>
void main()
{
	int i;
	for(i=1;i<=10;i++)
	{
		printf("num=%d\n",i);
		if(i%2==0)
		{
			break;
		}
	}
	printf("\nbye");
	
}

//Algorithm:
//1)start
//2)declare i;
//3)print i
//4)if i%2==0
//5)break
//6)print bye
//7)stop
