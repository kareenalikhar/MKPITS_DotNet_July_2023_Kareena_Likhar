#include<iostream>
using namespace std;
class bank
{
	public:
		int accno,balance,amt;
	bank()
	{
		balance=0;
		amt=0;
	}
	int getdeposite()
	{
		int amt;
	 	cout<<"Enter deposite amt:";
	 	cin>>amt;
	 	balance=balance+amt;
	 	cout<<"Amount deposite:"<<balance<<endl;
	 	return 0;
	}
	int getwithdrawl()
	{
		int amt;
		cout<<"Enter withdrawl amt:";
		cin>>amt;
		balance=balance-amt;
		cout<<"Total Amount :"<<balance<<endl;
		return 0;
	}
};
int main()
{
	bank b1;
	cout<<"Enter accout no and balance:";
	cin>>b1.accno>>b1.balance;
	b1.getdeposite();
	b1.getwithdrawl();
	return 0;
}
