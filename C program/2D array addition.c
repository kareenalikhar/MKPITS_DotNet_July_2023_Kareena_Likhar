#include<stdio.h>
void main()
{
	int arr1[2][2]={{1,2},{3,4}};
	int arr2[2][2]={{5,6},{7,8}};
	int arr3[2][2],row,col;
	{
		for(row=0;row<2;row++)
		{
			for(col=0;col<2;col++)
			{
				arr3[row][col]=arr1[row][col]+arr2[row][col];
			}
		}
		for (row=0;row<2;row++)
		{
			for(col=0;col<2;col++)
			{
				printf("%d\t",arr3[row][col]);
			}
			printf("\n");
		}
	}
}

//Algorithm:
//1)start
//2)declare arr1[2][2]={{1,2},{3,4}}
//	arr2[2][2]={{5,6},{7,8}}
//	arr3[2][2],row,col
//3)for row=0;row<2;row++
//4)for col=0;col<2;col++
//5)arr3[row][col]=arr1[row][col]+arr2[row][col]
//6)for row=0;row<2;row++
//7)for col=0;col<2;col++
//8)print row and col of arr3
//9)stop
