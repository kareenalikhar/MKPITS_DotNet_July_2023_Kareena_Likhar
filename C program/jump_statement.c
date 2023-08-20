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
//3)i=1;i<=10;i++
//4)print i
//5)if i%2==0
//6)break
//7)print bye
//8)stop
