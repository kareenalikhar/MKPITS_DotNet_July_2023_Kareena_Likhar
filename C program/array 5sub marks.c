#include<stdio.h>
void main()
{
	int i,sum=0,marks[5];
	for(i=0;i<5;i++)
	{
	printf("Enter marks:");
	scanf("%d",&marks[i]);
}
for(i=0;i<5;i++)
{
	printf("\nmarks=%d",marks[i]);
	sum=sum+marks[i];
}
printf("\nTotal marks=%d",sum);
}

//Algorithm:
//1)start
//2)declare i, sum=0, marks[5]
//3)for i=0;i<5;i++
//4)accept marks
//5)for i=0;i<5;i++
//6)print marks
//7)sum=sum+marks
//8)print total marks
//9)stop

