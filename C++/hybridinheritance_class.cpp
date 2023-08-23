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
				cout<<"Enter n1:";
				cin>>n1;
			}
};
class classB:public classA
{
	protected:
		int n2;
		public:
			void getn2(int n)
			{
				n2=n;
				cout<<"Enter n2:";
				cin>>n2;
			}
};
class classC
{
	protected:
		int n3;
			public:
				void getn3(int n)
				{
					n3=n;
					cout<<"Enter n3:";
					cin>>n3;
				}
};
class classD:public classB,public classC
{
	public:
		int multiply()
			{
				int m=n1*n2*n3;
				return m;
			}
};
int main()
{
	int result,n1,n2,n3;
	classD d;
	d.getn1(n1);
	d.getn2(n2);
	d.getn3(n3);
	result=d.multiply();
	cout<<"Multiplication:"<<result;
	return 0;
}
