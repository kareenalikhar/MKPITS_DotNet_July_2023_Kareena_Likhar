#include<iostream>
using namespace std;
class person
{
	protected:
		string name;
};
class student:public person
{
	public:
	void getdata(string s)
	{
		name=s;   
	}
	void display()
	{
		cout<<"Name:"<<name;
	}
};
int main()
{
	student s1;
	s1.getdata("kareena");
	s1.display();
	return 0;
}
