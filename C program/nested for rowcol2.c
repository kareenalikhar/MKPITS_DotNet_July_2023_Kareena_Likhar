#include<stdio.h>
void main()
{
	int row,col;
	for(row=1;row<=3;row++)
	{
		for(col=1;col<=row;col++)
		{
			printf("%d\t",row);
		}
		printf("\n");
	}
}

//Algorithm:
//1)Start
//2)declare col,row
//3)row=1;row<=3;row++
//4)col=1;col<=row;col++
//5)print row
//6)stop
