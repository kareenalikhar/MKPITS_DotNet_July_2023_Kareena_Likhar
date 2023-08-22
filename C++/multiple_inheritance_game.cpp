#include<iostream>
using namespace std;
class Ability
{
	protected:
		string abilityname;
	public:
		void getaname(string an)
		{
			abilityname=an;
		}
	
};
class Equipment
{
	protected:
		string equipmentitem;
			public:
				void geteitem(string ei)
				{
					equipmentitem=ei;
				}
};
class character:public Ability,public Equipment
{
	protected:
		string charactername;
		public:
			void getcname(string cn)
			{
				charactername=cn;
			}
		void display()
		{
			cout<<"Character name:"<<charactername<<endl;
			cout<<"Ability:"<<abilityname<<endl;
			cout<<"Equipment item:"<<equipmentitem<<endl;
		}
};
int main()
{
	character c1;
	c1.getaname("Attack");
	c1.getcname("Alien");
	c1.geteitem("gun");
	c1.display();
	return 0;
}
