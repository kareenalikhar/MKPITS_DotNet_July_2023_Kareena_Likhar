#include<iostream>
using namespace std;
class bank
{
	public:
		int accno,balance,amt;
	bank(int balance,int amt)
	{
		this->balance=balance;
		this->amt=amt;
	}
	int getdeposite()
	{
		int amt;
	 	cout<<"Enter deposite amt:";
	 	cin>>amt;
	 	balance=balance+amt;
	 	cout<<"Total Amount :"<<balance<<endl;
	 	return 0;
	}
	int getwithdrawl()
	{
		int amt;
		cout<<"Enter withdrawl amt:";
		cin>>amt;
		balance=balance-amt;
		cout<<"Amount withdrawl:"<<balance<<endl;
		return 0;
	}
};
int main()
{
	int balance,amt;
	bank b1(balance,amt);
	cout<<"Enter accout no and balance:";
	cin>>b1.accno>>b1.balance;
	b1.getdeposite();
	b1.getwithdrawl();
	return 0;
}
