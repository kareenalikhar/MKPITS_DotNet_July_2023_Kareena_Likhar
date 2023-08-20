#include<iostream>
using namespace std;
class employee
{
	public:
	int empno;
	string empname;
employee()
{
	empno=123;
	empname="kareena";
}
void display()
{
	cout<<"Employee no:"<<empno<<endl;
	cout<<"Employee name:"<<empname;
}
};
int main()
{
	employee emp1;
	emp1.display();
	return 0;
}
