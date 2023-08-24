#include<iostream>
using namespace std;
class Animals
{
	public:
		virtual void sound()
		{
			cout<<"Animals Sounds:"<<endl;
		}
};
class dog:public Animals
{
	public:
		void sound()
		{
			cout<<"dog sound is woof-woof"<<endl;
		}
};
class cat:public Animals
{
	public:
		void sound()
		{
			cout<<"cat sound is meow-meow"<<endl;
		}
};
class cow:public Animals
{
	public:
		void sound()
		{
			cout<<"cow sound is moo-moo"<<endl;
		}
};
int main()
{
	Animals *A;
	Animals a1;
	dog d;
	cat c;
	cow c1;
	A=&a1;
	A->sound();
	A=&d;
	A->sound();
	A=&c;
	A->sound();
	A=&c1;
	A->sound();
	return 0;
}
