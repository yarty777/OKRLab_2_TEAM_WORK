#include <iostream>
#include <queue>
using namespace std;

int main()
{
	setlocale(LC_ALL, "ukr");

	queue<char> q;
	int k=0;
	char qwerty=' ';

	while (qwerty != '0')
	{
		cout << "Введіть " << k << " елемент:\n";
		cin >> qwerty;
		if(qwerty=='0')
		{

		}
		else
		{
			k++;
			q.push(qwerty);
		}
	}

	cout << "Початковий вміст черги\n";

	queue<char> qq=q;
	for (int i = 0; i < q.size()-1; i++) { cout << qq.front() << "  "; qq.pop(); };
	cout << endl;

	cout<<"Розмір черги: " << q.size()<<endl;
}
