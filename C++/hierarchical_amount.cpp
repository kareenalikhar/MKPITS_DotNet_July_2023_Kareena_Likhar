#include<iostream>
using namespace std;
class account
{
	public:
		int actno;
		int bal;
		int intrest;
	void getdata(int a,int b,int c)
	{
		actno=a;
		bal=b;
		intrest=c;
	}
};
class saving:public account
{
	public:
		int deposite(int amt)
		{
			bal=bal+intrest+amt;
			return bal;
		}
};
class current:public account
{
	public:
		int deposite(int amt)
		{
			bal=bal+amt;
			return bal;
		}
};
int main()
{
	saving s1;
	current c1;
	int result,actno,bal,intrest,amount;
	cout<<"Enter actno,bal,int,amount:";
	cin>>actno>>bal>>intrest>>amount;
	s1.getdata(actno,bal,intrest);
	result=s1.deposite(amount);
	cout<<"Saving amount with intrest:"<<result<<endl;
	c1.getdata(actno,bal,intrest);
	result=c1.deposite(amount);
	cout<<"Current amount:"<<result;
	return 0;
}
