#include<stdio.h>
void main()
{
	int i,sum=0;
	int marks[3]={80,90,100};
	for(i=0;i<3;i++)
	{
		printf("Marks=%d\n",marks[i]);
		sum=sum+marks[i];
	}
	printf("Total marks=%d",sum);
}

//Algorithm:
//1)start
//2)declare i,sum=0,marks{80,90,100}
//3)for i=0;i<3;i++
//4)print marks
//5)sum=sum+marks
//6)print total marks
//7)stop
