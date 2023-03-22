// dllmain.cpp : Определяет точку входа для приложения DLL.
//#include "pch.h"
#include "main.hpp"

extern "C"
{
    __declspec(dllexport) bool __cdecl CreatePatchFunction(const char* a)
    {
        std::string news = std::string(a);
        MainFunction(news);
        return true;
    }

};



BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call){
        
    case DLL_PROCESS_ATTACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

