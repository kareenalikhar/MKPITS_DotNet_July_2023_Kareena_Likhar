#include<iostream>
using namespace std;
class classA
{
	public:
	void display()
	{
		cout<<"display from classA"<<endl;
	}
};
class classB
{
	public:
		void display()
		{
			cout<<"display from classB";
		}
};
class classc:public classA,public classB
{
	public:
		void displayc()
		{
			classA::display();
			classB::display();
		}
};
int main()
{
	classc c1;
	c1.displayc();
	return 0;
}
