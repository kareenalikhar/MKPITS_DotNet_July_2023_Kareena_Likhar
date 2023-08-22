#include<iostream>
using namespace std;
class classA
{
	protected:
		int n1;
	public:
		void getn1(int n)
		{
			n1=n;
		}
};
class classB
{
	protected:
		int n2;
	public:
		void getn2(int n)
		{
			n2=n;
		}
};
class classc:public classA,public classB
{
	public:
	void display()
	{
		cout<<"n1=";
		cin>>n1;
		cout<<"n2=";
		cin>>n2;
		cout<<"Total="<<n1+n2;
	}
};
int main()
{
	int n;
	classc c1;
	c1.getn1(n);
	c1.getn2(n);
	c1.display();
	return 0;
}
