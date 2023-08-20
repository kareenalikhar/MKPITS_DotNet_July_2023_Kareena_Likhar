#include<iostream>
using namespace std;
class employee
{
	public:
		int empno;
		string empname;
	employee(int empno,string empname)
	{
		this->empno=empno;
		this->empname=empname;
	}
	void display()
	{
		cout<<empno<<endl<<empname;
	}
};
int main()
{
	employee e1(123,"kareena");
	e1.display();
	return 0;
}
