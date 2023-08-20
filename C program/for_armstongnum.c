#include <stdio.h>
void main()
{
    int num,rem,sum=0,i;

    printf("Enter  a number: ");
    scanf("%d",&num);

    for(i=num;num!=0;num=num/10)
	{
         rem=num % 10;
         sum=sum+(rem*rem*rem);
    }
    if(sum==i)
         printf("%d is an Armstrong number.\n",i);
    else
         printf("%d is not an Armstrong number.\n",i);

}

//Algorithm
//1)start
//2)declare num,sum=0,i,rem
//3)accept num
//4)print num
//5)for i=num;num!=0;num/10
//6)rem=num%10
//6.1)sum=sum+(rem*rem*rem)
//7)if sum==i
//8)print num is armstong 
//9)else print num is not armstong
//10)stop
