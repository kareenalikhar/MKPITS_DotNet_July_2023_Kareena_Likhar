#include<iostream>
using namespace std;
class circle
{
	public:
	int radius;
cirle(int radius)
{
	this->radius=radius;
}
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
	float result,radius;
	circle c1;
	cout<<"Enter radius:";
	cin>>c1.radius;
	result=c1.calculatearea();
	cout<<"Area="<<result<<endl;
	result=c1.calculatecoc();
	cout<<"circumference of circle:"<<result<<endl;
	return 0;
}
