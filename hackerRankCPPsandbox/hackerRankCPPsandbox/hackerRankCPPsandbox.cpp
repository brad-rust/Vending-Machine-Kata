// hackerRankCPPsandbox.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include<iostream>
#include <string>

using namespace std;

int main() {
	int n;
	std::cin >> n;
	string pyramid;
	for (int i = 0; i < n; ++i)
		pyramid.append(" ");
	for (int i = n; i --> 0;)
	{
		pyramid[i] = '#';
		cout << pyramid << endl;
	}
	return 0;
}

