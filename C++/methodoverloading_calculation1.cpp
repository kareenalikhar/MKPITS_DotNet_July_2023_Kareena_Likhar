#include<iostream>
using namespace std;
class calculation
{
	public: 
	int add(int n1,int n2)
	{
		return n1+n2;
	}
	int add(int n1,int n2,int n3)
	{
		return n1+n2+n3;
	}
};
int main()
{
	int n1,n2,n3;
	cout<<"Enter 3 numbers";
	cin>>n1>>n2>>n3;
	calculation c;
	cout<<"Addition of 2 numbers:"<<c.add(n1,n2)<<endl;
	cout<<"Addition of 3 numbers:"<<c.add(n1,n2,n3);
	return 0;
}
