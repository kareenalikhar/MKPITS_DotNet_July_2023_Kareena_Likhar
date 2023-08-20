#include<stdio.h>
void deposite(int amt,int bal);
void withdrawl(int amt,int bal);
void main()
{
	int amt,bal;
	printf("Enter amount:");
	scanf("%d",&amt);
	printf("Enter balance:");
	scanf("%d",&bal);
	deposite(amt,bal);
	withdrawl(amt,bal);
}
void deposite(int amt,int bal)
{
	bal=bal+amt;
	printf("amount deposite,bal=%d\n",bal);
}
void withdrawl(int amt,int bal)
{
	bal=bal-amt;
	printf("amount withdrawl,bal=%d\n",bal);
}

//Algorithm:
//1)start
//2)declare amt,bal
//3)accept amt,bal
//4)call funtion deposite
//5)call function withdrwal
//6)declare a function deposite
//7)bal=bal+amt
//8)print amount deposite,bal
//9)declare function withdrawl
//10)bal=bal-amt
//11)print amount withdwal, bal
//12)stop
