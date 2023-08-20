#include<iostream>
using namespace std;
class bankaccount
{
	public:
	int accno,balance;
	int getdeposite()
	{
		int amt;
		cout<<"Enter deposite amt:";
		cin>>amt;
		balance=balance+amt;
		cout<<"Amout deposited:"<<balance<<endl;
		return amt;
	}
	int getwithdrawl()
	{
		int amt;
		cout<<"Enter withdrwal amt:";
		cin>>amt;
		balance=balance-amt;
		cout<<"Amount withdrwal:"<<balance<<endl;
		return amt;	
	}	
};
int main()
{
	bankaccount b1;
	cout<<"Enter account no and balance:";
	cin>>b1.accno>>b1.balance;
	b1.getdeposite();
	b1.getwithdrawl();
	return 0;
}
