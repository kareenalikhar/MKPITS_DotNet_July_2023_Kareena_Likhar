#include<iostream>
using namespace std;
class person
{
	public:
		string name;
		int mobileno;
	void getpersondata(string name,int mobileno)
	{
	this->name=name;
	this->mobileno=mobileno;
	}
};
class employee:public person
{
	public:
		int empno;
		int salary;
	void getempdata(int empno,int salary)
	{
	this->empno=empno;
	this->salary=salary;
	}
	void displaydata()
	{
		cout<<"Emp name:"<<name<<endl;
		cout<<"Emp mobile no:"<<mobileno<<endl;
		cout<<"Emp no:"<<empno<<endl;
		cout<<"Salary:"<<salary;
}
	};
	int main()
	{
		employee emp;
		cout<<"Employee name,mobile no,empno,salary:";
		cin>>emp.name>>emp.mobileno>>emp.empno>>emp.salary;
		emp.getpersondata(emp.name,emp.mobileno);
		emp.getempdata(emp.empno,emp.salary);
		emp.displaydata();
		return 0;
	}
