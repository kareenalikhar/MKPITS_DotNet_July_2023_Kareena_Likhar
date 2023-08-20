#include<stdio.h>
void main()
{
	int i;.
	for(i=1;i<=10;i++)
	{
		if(i%2==0)
		{
			continue;
		}
		printf("num=%d\n",i);
	}
	printf("\nbye");
	
}

//Algorithm:
//1)start
//2)declare i;
//3)i=1;i<=10;i++
//4)if i%2==0
//5)continue
//6)print i
//7)print bye
//8)stop
