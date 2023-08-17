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
		int noofhr;
};
int main()
{
	employee e1;
	cout<<"employee name,mobileno,empno,salary:";
	cin>>e1.name>>e1.mobileno>>e1.empno>>e1.salary;
	cout<<e1.name<<endl<<e1.mobileno<<endl<<e1.empno<<endl<<e1.salary<<endl;
	parttimeemp p1;
	cout<<"employee name,mobileno,empno,salary:";
	cin>>p1.name>>p1.mobileno>>p1.empno>>p1.salary>>p1.noofhr;
	cout<<p1.name<<endl<<p1.mobileno<<endl<<p1.empno<<endl<<p1.salary<<endl<<p1.noofhr;
	return 0;
}
