#include "pch.h"
#include "changer.h"

extern "C" __declspec(dllexport) void RBSwap(unsigned char* bitmap, int width, int height, int stride, int mode) {
	for (int i = 0; i < height; i++) {
		for (int j = 0; j < width; j++) {
			unsigned char* r = (bitmap + i * stride + j * (sizeof(unsigned char) * mode) + 0);
			unsigned char* b = (bitmap + i * stride + j * (sizeof(unsigned char) * mode) + 2);
			unsigned char temp = *r;
			*r = *b;
			*b = temp;
		}
	}
}