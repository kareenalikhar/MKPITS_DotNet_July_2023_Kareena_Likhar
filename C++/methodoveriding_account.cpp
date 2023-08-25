#include<iostream>
using namespace std;
class Account
{
	public:
		int actno;
		int bal;
		void deposite(int amt)
		{
			cout<<"hello from deposite account:"<<endl;
		}
};
class saving:public Account
{
	public:
		void deposite(int amt)
		{
			int interest=1000;
			bal=bal+amt+interest;
			cout<<"Balance with interest in saving acc:"<<bal<<endl;
		}
};
class current:public Account
{
	public:
		void deposite(int amt)
		{
			bal=bal+amt;
			cout<<"Balance without interest in current acc:"<<bal<<endl;
		}
};
int main()
{
	saving s;
	current c;
	s.actno=123;
	s.bal=2000;
	cout<<"Account no:"<<s.actno<<endl;
	s.deposite(500);
	c.actno=456;
	c.bal=5000;
	cout<<"Account no:"<<c.actno<<endl;
	c.deposite(200);
	return 0;
}
