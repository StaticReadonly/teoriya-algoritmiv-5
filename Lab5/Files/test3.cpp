class Aboba {
private:
    int x = 0;
    int y = 0;

public:
    Aboba(int x, int y) {
        this->x = x;
        this->y = y;
    }

    int getSum() {
        return x + y;
    }
};

int main(){
    Aboba a = new Aboba(100, 200);

    std::cout << a.getSum() << std::endl;

    return 0;
}