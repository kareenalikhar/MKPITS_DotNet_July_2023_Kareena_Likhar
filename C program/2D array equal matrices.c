#include<stdio.h>
void main()
{
	int row,col,arr1[2][2],arr2[2][2],i;
	printf("Enter 1st matrices number:");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			scanf("%d",&arr1[row][col]);
		}
	}
	printf("Enter 2st matrices number:");
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			scanf("%d",&arr2[row][col]);
		}
	}
	i=1;
	for(row=0;row<2;row++)
	{
		for(col=0;col<2;col++)
		{
			if(arr1[row][col]!=arr2[row][col])
			i=0;
			break;
		}
	}
	if(i==1)
	{
		printf("it is equal");
	}
	else
	{
		printf("it is not equal");
	}
}

//Algorithm:
//1)start
//2)declare row,col,arr1[2][2],arr2[2][2],i
//3)for row=0;row<2;row++
//for col=0;col<2;col++
//4)accept 1st matrices numbers
//5)for row=0;row<2;row++
//for col=0;col<2;col++
//6)accept 2st matrices numbers
//7)i=1
//7)for row=0;row<2;row++
//for col=0;col<2;col++
//8)if(arr1[row][col]!=arr2[row][col])
//  i=0
//9)if i==1
//9.1)print it is equal
//10)else print it is not equal
//11)stop

