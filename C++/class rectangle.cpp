#include<iostream>
using namespace std;
class rectangle
{
	public:
		int length,breadth;
		float calculatearea()
		{
			float a=length*breadth;
			return a;
	 }
		float calculateperimeter()
		{
			float perimeter=2*(length+breadth);
			return perimeter;
		}
};
int main()
{
	float result;
	rectangle r1;
	cout<<"Enter length and breadth:";
	cin>>r1.length>>r1.breadth;
	result=r1.calculatearea();
	cout<<"Area="<<result<<endl;
	result=r1.calculateperimeter();
	cout<<"Perimeter="<<result;
	return 0;
}
