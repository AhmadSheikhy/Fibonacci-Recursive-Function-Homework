#include <iostream>
#include <cmath>

using namespace std;

int Fibo(int x)
{
	if (x < 3)
		return x-1;
		return Fibo(x - 1) + Fibo(x - 2);
}

int main()
{
	int x;
	cin >> x;
	cout << Fibo(x) << endl;
	return 0;
}
