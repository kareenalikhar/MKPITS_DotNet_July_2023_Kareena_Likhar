#include<iostream>
using namespace std;
class car
{
	public:
		string make;
		string model;
		int year;
	void startengine()
	{
		cout<<"Engine started"<<endl;
	}
	void brake()
	{
		cout<<"Break applied";
	}
};
int main()
{
	car c1;
	c1.make="maruti";
	c1.model="suv";
	c1.year=2022;
	cout<<"make"<<c1.make<<endl;
	cout<<"model"<<c1.model<<endl;
	cout<<"year"<<c1.year<<endl;
	c1.startengine();
	c1.brake();
	return 0;
}
