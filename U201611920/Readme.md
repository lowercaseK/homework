# <center>Demo&nbsp;&nbsp;介绍
## <center>策划人：付国栋
### 功能介绍
    输出某一年或者某一个月份的日历
### 算法简介
     首先通过一个参考日期来确定星期几，进而通过给定年份或月份要求算出那一年或月的第一天是星期几。
     年份要判断是否为闰年，不同的月份要判断这一月的天数是多少。
### 代码简介
```C#
#include <iostream>
#include <iomanip>
using namespace std;
int isleap(int);                                //判断闰年
int week_of_newyear_day(int);                   //计算指定年份元旦星期几
void showYear(int);                             //按年显示
void showMon(int,int);                          //按月显示
void showHead();                                //显示表头
int week_of_newmonth_day(int year,int month);   //计算指定年及月的第一天是星期几
int getLenOfMonth(int year,int month);          //计算指定年及月的天数
int main()
{
	int chioce;
	int year,mon;
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
	return 0;
}
//判断给定的年份是否为闰年
int isleap(int year)
{
	if(year%4==0&&year%100!=0||year%400==0)
		return 1;
	else 
		return 0;
}
//计算指定年及月的天数
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
//计算给定年份元旦是星期几
int week_of_newyear_day(int year)
{
	int n=year-1900;
	n=n+(n-1)/4+1;
	n=n%7;
	return n;
}
//计算给定的年份及月份第一天是星期几
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
//显示表头
void showHead()
{
	cout<<"--------------------------"<<endl;
	cout<<"SUN    MON    TUE    WED    THU    FRI    SAT"<<endl;
	cout<<"--------------------------"<<endl;
}
//按年显示日历
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
//按月显示日历
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
```
### 结果展示
![万年历](/1.png "万年历展示")
![万年历](/2.png "万年历展示")
![万年历](/3.png "万年历展示")
![万年历](/4.png "万年历展示")
![万年历](/5.png "万年历展示")
![万年历](/6.png "万年历展示")