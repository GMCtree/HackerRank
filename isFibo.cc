#include <iostream>
#include <unordered_set>

struct isFibo {
  std::unordered_set<uint64_t> fibo;
  uint64_t num1, num2;
  uint32_t i;

  isFibo() : num1(0), num2(1), i(0) {}

  bool operator()(uint64_t n) {
    auto iter = fibo.find(n);
    if (iter != fibo.end()) {
      return *iter;
    }

    uint64_t fib;
    do {
      fib = num1 + num2;
      num1 = num2;
      num2 = fib;
      ++i;
      fibo.insert(fib);
    } while (fib < n && i < 1000000);

    if (n == fib) {
      fibo.insert(n);
      return true;
    }
    return false;
  }
};

int main() {
  int32_t numcases;
  int64_t n;
  std::cin >> numcases;

  isFibo fibo;
  for (int32_t i = 0; i < numcases; ++i) {
    std::cin >> n;
    std::cout << (fibo(n) ? "IsFibo" : "IsNotFibo") << std::endl;
  }

  return 0;
}
