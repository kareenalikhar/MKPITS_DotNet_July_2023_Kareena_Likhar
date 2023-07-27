#include<stdio.h>
void main()
{
	int col,row;
	for(row=1;row<=5;row++)
	{
		for(col=1;col<=row;col++)
		{
			printf("*\t");
		}
		printf("\n");
	}
}

//Algorithm:
//1)Start
//2)declare col,row
//3)row=1;row<=3;row++
//4)col=1;col<=3;col++
//5)print *
//6)stop
