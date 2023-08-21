#include<iostream>
using namespace std;
class student
{
	private:
		int rno;
	public:
	void display()
	{
		cout<<"rollno:"<<rno;
	}
	void setdata(int r)
	{
		rno=r;
	}
};
int main()
{
	student s1;
	int rn;
	cout<<"Enter rollno:";
	cin>>rn;
	s1.setdata(rn);
	s1.display();
	return 0;
}
