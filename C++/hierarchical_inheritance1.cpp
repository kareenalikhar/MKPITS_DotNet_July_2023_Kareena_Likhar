#include<iostream>
using namespace std;
class shape
{
	public:
		int x;
		int y;
	void getdata(int a,int b)
	{
	x=a;
	y=b;
	}
};
class rectangle:public shape
{
	public:
		int crarea()
		{
			int ra;
			ra=x*y;
			return ra;
		}
};
class triangle:public shape
{
	public:
		float ctarea()
		{
			float ta;
			ta=0.5*x*y;
			return ta;
		}
};
int main()
{
	rectangle r;
	triangle t;
	int length,breadth,base,height;
	int ra;
	float ta;
	cout<<"Enter length and breadth:";
	cin>>length>>breadth;
	r.getdata(length,breadth);
	ra=r.crarea();
	cout<<"Area of rectangle:"<<ra<<endl;
	cout<<"Enter base and height:";
	cin>>base>>height;
	t.getdata(base,height);
	ta=t.ctarea();
	cout<<"Area of triangle:"<<ta;
	return 0;
	
}
