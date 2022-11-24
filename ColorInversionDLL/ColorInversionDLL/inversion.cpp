#include "pch.h"
#include "inversion.h"

extern "C" __declspec(dllexport) void ColorInversion(unsigned char* bitmap, int width, int height, int stride, int mode) {
	for (int i = 0; i < height; i++) {
		for (int j = 0; j < width; j++) {
			unsigned char* r = (bitmap + i * stride + j * (sizeof(unsigned char) * mode) + 0);
			unsigned char* g = (bitmap + i * stride + j * (sizeof(unsigned char) * mode) + 1);
			unsigned char* b = (bitmap + i * stride + j * (sizeof(unsigned char) * mode) + 2);
			*r = ~*r;
			*g = ~*g;
			*b = ~*b;
		}
	}
}