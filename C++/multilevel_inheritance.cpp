#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		int mobileno;
};
class employee:public person
{
	public:
		int empno;
		int salary;
};
class parttimeemp:public employee
{
	public:
		int noofdays;
};
int main()
{
	employee e1;
	e1.name="kareena";
	e1.mobileno=1234567890;
	e1.empno=456;
	e1.salary=10000000;
	cout<<"Employee detail:"<<endl;
	cout<<e1.name<<endl<<e1.mobileno<<endl<<e1.empno<<endl<<e1.salary<<endl;
	parttimeemp p1;
	p1.name="Rohit";
	p1.mobileno=1234567890;
	p1.empno=789;
	p1.salary=12000000;
	p1.noofdays=5;
	cout<<endl<<"Part time employee:"<<endl;
	cout<<p1.name<<endl<<p1.mobileno<<endl<<p1.empno<<endl<<p1.salary<<endl<<p1.noofdays;
}
