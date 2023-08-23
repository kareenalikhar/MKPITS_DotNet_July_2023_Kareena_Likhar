#include<iostream>
using namespace std;
class calculation
{
	public: 
	int add(int n1,int n2)
	{
		return n1+n2;
	}
	float add(float n1,float n2)
	{
		return n1+n2;
	}
};
int main()
{
	calculation c;
	cout<<"Addition of int numbers:"<<c.add(2,3)<<endl;
	cout<<"Addition of float numbers:"<<c.add(2.2f,3.5f);
	return 0;
}
