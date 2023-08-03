#include<stdio.h>
void main()
{
	int arr[2][2]={{1,2},{3,4}},row,col;
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			printf("arr[%d][%d]=%d\n",row,col,arr[row][col]);
		}
	}
	
}
	
//Algorithm:
//1)start
//2)declare arr[2][2]={{1,2},{3,4}},row,col
//3)for row=0;row<2;row++
//4)for col=0;col<2;col++
//5)print row,col,arr[row][col]
//6)stop
