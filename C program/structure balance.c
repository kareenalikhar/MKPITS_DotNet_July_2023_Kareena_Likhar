#include<stdio.h>
#include<string.h>
struct balance
{
	char name[20];
	int acc_no,balance;
};
void main()
{
	struct balance b1[5];
	int counter;
	for(counter=0;counter<5;counter++)
	{
		printf("Name,account no and balance:");
		scanf("%s%d%d",b1[counter].name,&b1[counter].acc_no,&b1[counter].balance);
		
}		printf("Account with balance less than 100;");
		for(counter=0;counter<5;counter++)
		{
	if(b1[counter].balance<100)
	{
	printf("\nname=%s and account no=%d",b1[counter].name,b1[counter].acc_no);
	}
	}
}

//Algorithm:
//1)start
//2)define structure balance
//3)declare name,acc_no,balance,counter
//4)create an array of structure balance b1 with size 5
//5)loop from counter=0;counter<2;counter++
//6)accept account no and balance
//7)print account with balance less than 100
//7)for counter=0;counter<5;counter++
//8)if b1[counter].balance<100
//9)print name and account
//10)stop
