#include<stdio.h>w
void main()
{
	int num,sum=0,i,square;
	printf("Enter a number:");
	scanf("%d",&num);
	printf("square number from 1 to %d are:\n",num);
	{
	for(i=1;i<=num;i++)
	{
		square=i*i;
		printf("\n%d square is %d",i,square);
		sum=sum+square;
	}
	printf("\nSum of square natural number %d is %d\n",num,sum);
}

}

//Algorithm
//1)start
//2)declare num,sum=0,i,square
//3)accept num
//4)print num
//5)for i=1;i<=num;i++
//6)square=i*i
//7)print square
//8)sum=sum+square
//9)print num and sum
//10)stop
