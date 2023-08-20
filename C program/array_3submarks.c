#include<stdio.h>
void main()
{
	int i,sum=0,marks[3];
	marks[0]=99;
	marks[1]=88;
	marks[2]=77;
	for(i=0;i<3;i++)
	{
		printf("Marks=%d\n",marks[i]);
		sum=sum+marks[i];
	}
	printf("\nTotal marks=%d",sum);
}

//Algorithm:
//1)start
//2)declare i,sum=0,marks[3]
//3)take marks[0]=99
//marks[1]=88
//marks[2]=77
//4)for i=0;i<3;i++
//5)print marks
//6)sum=sum+marks
//7)print total marks
//8)stop
