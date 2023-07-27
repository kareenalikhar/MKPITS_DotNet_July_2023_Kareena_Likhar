#include<stdio.h>
void main()
{
	int col,row,k=1;
	for(row=1;row<=3;row++)
	{
		for(col=1;col<=row;col++)
		{
			printf("%d\t",k++);
		}
		printf("\n");
	}
}

//Algorithm:
//1)Start
//2)declare col,row
//3)row=1;row<=3;row++
//4)col=1;col<=row;col++
//5)print k++
//6)stop
