#include<iostream>
using namespace std;
class Account
{
	public:
		int actno;
		int bal;
		virtual void deposite(int amt)=0;
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
	Account *A;
	saving s;
	current c;
	A=&s;
	A->actno=123;
	A->bal=2000;
	A->deposite(500);
	A=&c;
	A->actno=456;
	A->bal=5000;
	A->deposite(200);
	return 0;
}
