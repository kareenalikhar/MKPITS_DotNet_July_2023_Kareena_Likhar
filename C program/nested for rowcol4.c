#include<stdio.h>
void main()
{
	int row,col,k,spc;
	spc=row+3-1;
	for(row=1;row<=3;row++)
	{
		for(k=spc;k>=1;k--)
		{
			printf("  ");
		}
		for(col=1;col<=row;col++)
		{
			printf("%d  ",row);
		}
		spc--;
		printf("\n");
	}
	}
	
//Algorithm:
//1)Start
//2)declare col,row,k,spc
//3)spc=row+3-1
//4)k=spc,k>=1;k--
//5)col=1;col<=row;col++
//6)print row
//7)spc--
//8)stop
