#include<iostream>
using namespace std;
class circle
{
	public:
		int radius;
		float calculatearea()
		{
			float a=3.14f*radius*radius;
			return a;
		}
		float calculatecoc()
		{
			float coc=2*3.14f*radius;
			return coc;
		}
};
int main()
{
	float result;
	circle c1;
	cout<<"Enter radius:";
	cin>>c1.radius;
	result=c1.calculatearea();
	cout<<"Area:"<<result<<endl;
	result=c1.calculatecoc();
	cout<<"Circumference of circle:"<<result;
	return 0;
}

