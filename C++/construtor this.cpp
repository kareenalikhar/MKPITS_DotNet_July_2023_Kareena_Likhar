#include<iostream>
using namespace std;
class rectangle
{
	public:
		int length,breadth;
		int a,peri;
	rectangle(int length,int breadth)
	{
		this->length=length;
		this->breadth=breadth;
	}
	float calculatearea()
	{
		float a=length*breadth;
		return a;
	}
	float calculateperi()
	{
		float peri=2*(length+breadth);
		return peri;
	}
};
int main()
{
	int result,length,breadth;
	rectangle r1(length,breadth);
	cout<<"Enter lenght and breadth:";
	cin>>r1.length>>r1.breadth;
	result=r1.calculatearea();
	cout<<"Area:"<<result<<endl;
	result=r1.calculateperi();
	cout<<"peri="<<result;
	return 0;
}
