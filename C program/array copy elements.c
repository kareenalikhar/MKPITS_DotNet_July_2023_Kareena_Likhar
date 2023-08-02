#include<stdio.h>
void main()
{
	int i,arr1[5],arr2[5];
	for(i=0;i<5;i++)
	{
		printf("Enter num:");
		scanf("%d",&arr1[i]);
	}
	for(i=0;i<5;i++)
	{
		arr2[i]=arr1[i];
	}
	printf("Element of arr1:");
	for(i=0;i<5;i++)
	{
		printf("%d",arr1[i]);
	}
	printf("\nElement of arr2=%d",arr2[i]);
	for(i=0;i<5;i++)
	{
		printf("%d",arr2[i]);
	}
}

//Algorithm:
//1)start
//2)declare i,arr1[5],arr2[5]
//3)for i=0;i<5;i++
//4)accept num
//5)for i=0;i<5;i++
//5.1)arr2[i]=arr1[i]
//6)print element of arr1
//7)for i=0;i<5;i++
//7.1)print arr1[i]
//8)print element of arr2
//9)for i=0;i<5;i++
//10)print arr2[i]
//11)stop
