#include<iostream>
using namespace std;
class Ability
{
	private:
		string abilityname;
	public:
		void getaname(string an)
		{
			abilityname=an;
		}
		void display()
		{
			cout<<"Ability:"<<abilityname<<endl;
		}
	
};
class Equipment
{
	private:
		string equipmentitem;
			public:
				void geteitem(string ei)
				{
					equipmentitem=ei;
				}
				void display()
				{
					cout<<"Equipment name:"<<equipmentitem<<endl;
				}
};
class character:public Ability,public Equipment
{
	private:
		string charactername;
		public:
			void getcname(string cn,string an,string ei)
			{
				charactername=cn;
				getaname(an);
				geteitem(ei);
			}
		void displayc()
		{
			cout<<"Character name:"<<charactername<<endl;
			Ability::display();
			Equipment::display();
		}
};
int main()
{
	string charactername,abilityname,equipmentitem;
	character c1;
	c1.getcname("Alien","Attack","Gun");
	c1.displayc();
	return 0;
}
