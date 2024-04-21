#include <iostream>
#include <utility>

int main(){
    int a = 1;
    int b = 1;
    int c = a + b + 1;

    std::cout << c << std::endl;
    
    unsigned short d = 1u;
    double e = 1.0;
    e = e * e * e;

    std::cout << e << std::endl;

    double f = e / 2;

    float g = (float)(f * e / 2.0);

    std::cout << aboba(100, 200) << std::endl;

    std::string str1 = "aboba";
    std::string str2 = "   aboba   ";

    return 0;
}

void aboba(int a, int b) {
    return a + b;
}