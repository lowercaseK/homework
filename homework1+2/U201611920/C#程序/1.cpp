#include <iostream>
#include <iomanip>
using namespace std;
int isleap(int);
int week_of_newyear_day(int);
void showYear(int);
void showMon(int,int);
void showHead();
int week_of_newmonth_day(int year,int month);
int getLenOfMonth(int year,int month);
int main()
{
	int chioce;
	int year,mon;
	while(1)
	{
		cout<<"万年里显示程序"<<endl;
		cout<<"********************"<<endl;
		cout<<"1   按年输出"<<endl;
		cout<<"2   按月输出"<<endl;
		cout<<"0   退出"<<endl;
		cout<<"********************"<<endl;
		cout<<"请输入您的选择";
		cin>>chioce;
		switch(chioce)
		{
		case 1:     cout<<"请输入显示的年份";
			        cin>>year;
					showYear(year);
					break;
		case 2:     cout<<"请输入显示的年份及月份";
			        cin>>year>>mon;
					showMon(year,mon);
					break;
		case 0:   exit(0);
		}
	}
	return 0;
}
int isleap(int year)
{
	if(year%4==0&&year%100!=0||year%400==0)
		return 1;
	else 
		return 0;
}
int getLenOfMonth(int year,int month)
{
	int len_of_month;
	if(month==4||month==6||month==9||month==11)    len_of_month=30;
	else   if(month==2)
	{
		if(isleap(year))      len_of_month=29;
		else len_of_month=28;
	}
	else len_of_month=31;
	return len_of_month;
}
int week_of_newyear_day(int year)
{
	int n=year-1900;
	n=n+(n-1)/4+1;
	n=n%7;
	return n;
}
int week_of_newmonth_day(int year,int month)
{
	int n=year-1900;
    n=n+(n-1)/4+1;
	for(int i=1;i<month;i++)
	{
		n=n+getLenOfMonth(year,i);
	}
	n=n%7;
	return n;
}
void showHead()
{
	cout<<"--------------------------"<<endl;
	cout<<"SUN    MON    TUE    WED    THU    FRI    SAT"<<endl;
	cout<<"--------------------------"<<endl;
}
void showYear(int year)
{
	int month,day,weekday,len_of_month,i;
	cout<<endl<<year<<endl;
	weekday=week_of_newyear_day(year);
	for(month=1;month<=12;month++)
	{
		getchar();
			cout<<endl<<month<<endl;
		showHead();
		for(i=0;i<weekday;i++)cout<<"       ";
		len_of_month=getLenOfMonth(year,month);
		for(day=1;day<=len_of_month;day++)
		{
			cout<<setw(3)<<day<<"    ";
			weekday++;
			if(weekday==7)
			{
				weekday=0;
				cout<<endl;
			}
		}
		cout<<endl;
	}
}
void showMon(int year,int mon)
{
	int day,weekday,len_of_month,i;
	cout<<endl<<year<<endl;
	cout<<endl<<mon<<endl;
	weekday=week_of_newmonth_day(year,mon);
	getchar();
	showHead();
	for(i=0;i<weekday;i++)
		cout<<"       ";
	len_of_month=getLenOfMonth(year,mon);
	for(day=1;day<=len_of_month;day++)
	{
		cout<<setw(3)<<day<<"    ";
		weekday++;
		if(weekday==7)
		{
			weekday=0;
			cout<<endl;
		}
	}
	cout<<endl;
}
