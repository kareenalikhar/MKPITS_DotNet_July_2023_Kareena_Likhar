#include<stdio.h>
void main()
{
	int row,col;
	int arr1[2][2];
	int arr2[2][2];
	printf("Enter matrices:");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
		scanf("%d",&arr1[row][col]);
		}
	}
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
		arr2[row][col]=arr1[col][row];
		}
	}
	printf("Transpose of matrices:\n");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
 			printf("%d\t",arr2[row][col]);

		}
		printf("\n");
	}
	
}

//Algorithm:
//1)start
//2)declare row,col,arr1[2][2],arr2[2][2]
//3)for row=0;row<2;row++
//for col=0;col<2;col++
//4)accept 1st matrices numbers
//5)for row=0;row<2;row++
//for col=0;col<2;col++
//6)accept 2st matrices numbers
//7)print transpose of matrices
//8)for row=0;row<2;row++
//9)for col=0;col<2;col++
//10)print arr2[row][col]
//11)stop

