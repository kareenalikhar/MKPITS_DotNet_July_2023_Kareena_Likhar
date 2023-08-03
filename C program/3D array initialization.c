#include<stdio.h>
void main()
{
	int row,col,arr[3][3];
	printf("Enter number:");
	for(row=0;row<3;row++)
	{
		for(col=0;col<3;col++)
		{
			scanf("%d",&arr[row][col]);
		}
	}
	for(row=0;row<3;row++)
	{
		for(col=0;col<3;col++)
		{
			printf("%d\t",arr[row][col]);
		}
		printf("\n");
}
}

//Algorithm:
//1)start
//2)declare row,col,arr[3][3]
//3)for row=0;row<3;row++
//4)for col=0;col<3;col++
//5)accept numbers
//6)for row=0;row<3;row++
//7)for col=0;col<3;col++
//8)print row,col,arr[row][col]
//9)stop
