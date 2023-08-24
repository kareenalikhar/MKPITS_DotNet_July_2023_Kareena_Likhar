#include<iostream>
using namespace std;
class Account
{
	public:
		int actno;
		int bal;
		virtual void deposite(int amt)
		{
			cout<<"hello from account deposite:"<<endl;
		}
};
class Saving:public Account
{
	public:
		void deposite(int amt)
		{
			int interest=500;
			bal=bal+amt+interest;
			cout<<"balance with interst:"<<bal<<endl;
		}
};
class Current:public Account
{
	public:
		void deposite(int amt)
		{
			bal=bal+amt;
			cout<<"balance without interest:"<<bal<<endl;
		}
};
int main()
{
	int amt;
	Account *A;
	Account a1;
	Saving s;
	Current c;
	A=&a1;
	A->deposite(amt);
	A=&s;
	A->actno=123;
	A->bal=500;
	A->deposite(1000);
	A=&c;
	A->actno=456;
	A->bal=1000;
	A->deposite(2000);
	return 0;
}
