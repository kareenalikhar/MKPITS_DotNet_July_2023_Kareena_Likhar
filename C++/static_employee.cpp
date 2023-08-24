#include<iostream>
using namespace std;
class Employee
{
	public:
		int empno;
		string ename;
		static string cname;
	Employee(int empno,string ename)
	{
	this->empno=empno;
	this->ename=ename;
	}
	void display()
	{
		cout<<"Employee no:"<<empno<<endl;
		cout<<"Employee name:"<<ename<<endl;
		cout<<"Company name:"<<cname<<endl;
	}
};
string Employee::cname="Fendhal";
int main()
{
	Employee e1=Employee(123,"kareena");
	Employee e2=Employee(456,"pooja");
	e1.display();
	e2.display();
	return 0;
}
