int sum(int a, int b) {
    return a + b;
}

int subtract(int a, int b) {
    return a - b;
}

int multiply(int a, int b) {
    return a * b;
}

int divide(int a, int b) {
    return a / b;
}

int main(){
    int a = 100;
    int b = 200;

    int c = sum(a, b);

    int d = subtract(c, a);

    c = multiply(c, d);

    int e = divide(c, a);

    return 0;
}