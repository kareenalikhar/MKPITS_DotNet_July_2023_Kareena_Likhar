#include<stdio.h>
void main()
{
	int i,j,arr[5],cnt=0;
	for(i=0;i<5;i++)
	{
		printf("Enter numbers:");
		scanf("%d",&arr[i]);
	}
	for(i=0;i<5;i++)
	{
		cnt=0;
		for(j=0;j<5;j++)
		{
			if(i!=j)
			{
			if(arr[i]==arr[j])
			{
				cnt++;
				break;
			}
	}
}
if(cnt==0)
{
			printf("\nunique elements:%d",arr[i]);
		}
}

}

//Algorithm:
//1)start
//2)declare i,j,arr[5],cnt=0
//3)for i=0;i<5;i++
//4)accept num
//5)for i=0;i<5;i++
//6)cnt=0
//7)for j=0;j<5;j++
//8)if i!=j
//9)if arr[i]==arr[j]
//10)cnt++
//11)if cnt==0
//12)print arr[i]
//13)stop

