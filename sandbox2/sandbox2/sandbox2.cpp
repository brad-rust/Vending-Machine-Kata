#include "stdafx.h"
#include <cstdio>
#include <iostream>
#include <string>
#include <stdio.h>



int main() {
	int n, spaces;
	std::cin >> n;
	spaces = n - 1;
	for (int i = 1; i <= n; ++i)
	{
		string pounds, poundsAndSpaces;
		pounds.insert(i, "#");
		if (spaces > 0)
			poundsAndSpaces.insert(spaces, " ");
		--spaces;
		std::cout << poundsAndSpaces << endl;
	}
	return 0;
}