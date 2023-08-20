#include<stdio.h>
void main()
{
	int sr,sc,arr[2][2],row,col;
	printf("Enter matrices:");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			scanf("%d",&arr[row][col]);
		}
	}
	for(row=0;row<2;row++)
	{
		sr=sc=0;
		for(col=0;col<2;col++)
		{
			sr=sr+arr[row][col];
			sc=sc+arr[col][row];
		}
		printf("Sum of rows=%d\n",sr);
		printf("Sum of columns=%d\n",sc);
	}
}

//Algorithm:
//1)start
//2)declare sr,sc,arr[2][2],row,col
//3)print enter matrices
//4)for row=0;row<2;row++
//5)for col=0;col<2;col++
//6)accept matrices
//7)for row=0;row<2;row++
//8)sr=sc=0
//9)for col=0;col<2;col++
//10)sr=sr+arr[row][col]
//	sc=sc+arr[col][row]
//11)print sum of rows and sum of columns
//12)stop
