#include<stdio.h>
void main()
{
	int col,row;
	for(row=3;row>=1;row--)
	{
	for(col=1;col<=row;col++)
	{
		printf("%d\t",col);
	}
	printf("\n");
	}
}

//Algorithm:
//1)Start
//2)declare col,row
//3)row=3;row>=1;row--
//4)col=1;col<=row;col++
//5)print col
//6)stop
