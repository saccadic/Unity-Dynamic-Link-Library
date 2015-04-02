#include "stdio.h"
#include <string.h>
#include <stdlib.h>

using namespace std;

extern "C" {
	static int number;
	static char *text;
	/*
	__declspec(dllexport) char hello_world(){
		return "Hello";
	}
	*/
	__declspec(dllexport) void _inputNum(int num){
		number = num;
	}
	
	__declspec(dllexport) int _outputNum(){
		return number;
	}

	__declspec(dllexport) int _inputString(const char *str){
		int num = strlen(str);
		return strlen(str);
	}

	__declspec(dllexport) char* _outputNumString(){
		char *str = new char(1000);
		strcat(str, text);
		strcat(str, ",hogehoge");

		return str;
	}
}