// hackerRankSandbox.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <sstream>
#include <vector>
#include <iostream>
using namespace std;

vector<int> parseInts(string str) {
	vector<int> myVec;
	int tmp;
	char c;
	stringstream ss(str);
	while (ss)
	{
		ss >> tmp;
		myVec.push_back(tmp);
		ss >> c;
	}
	return myVec;
}

int main() {
	string str;
	cin >> str;
	vector<int> integers = parseInts(str);
	for (int i = 0; i < integers.size(); i++) {
		cout << integers[i] << "\n";
	}

	return 0;
}

