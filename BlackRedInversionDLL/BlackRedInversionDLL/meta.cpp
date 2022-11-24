#include "pch.h"
#include "meta.h"
#include <string>

extern "C" __declspec(dllexport) void LibraryName(char* name, int length) {
	std::string libName = "Смена R и B канала";
	strcpy_s(name, sizeof(libName), libName.c_str());
}

extern "C" __declspec(dllexport) void FunctionName(char* name, int length) {
	std::string funcName = "RBSwap";
	strcpy_s(name, sizeof(funcName), funcName.c_str());
}