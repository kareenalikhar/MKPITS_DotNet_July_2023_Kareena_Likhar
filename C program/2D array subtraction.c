#include<stdio.h>
void main()
{
	int row,col,arr1[2][2],arr2[2][2],arr3[2][2];
	printf("Enter 1st matrices number:");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			scanf("%d",&arr1[row][col]);
		}
	}
	printf("Enter 2nd matrices number:");
			for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			scanf("%d",&arr2[row][col]);
		}
	}
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			arr3[row][col]=arr1[row][col]-arr2[row][col];
		}
	}
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			printf("%d\t",arr3[row][col]);
		}
		printf("\n");
	}
}

//Algorithm:
//1)start
//2)declare row,col,arr1[2][2],arr2[2][2],arr3[2][2]
//3)for row=0;row<2;row++
//for col=0;col<2;col++
//4)accept 1st matrices numbers
//5)for row=0;row<2;row++
//for col=0;col<2;col++
//6)accept 2st matrices numbers
//7)for row=0;row<2;row++
//for col=0;col<2;col++
//8)arr3[row][col]=arr1[row][col]-arr2[row][col]
//9)for row=0;row<2;row++
//for col=0;col<2;col++
//10)print arr3[row][col]
//11)stop

