from statistics import fmean
from math import sqrt

nums = []

while True:
    num = float(input("Enter a number: "))
    if num != -1:
        nums.append(num)
    else:
        break

y_avg = fmean(nums)
print("Average:", y_avg)
print("Num of positive numbers:", len([n for n in nums if n > 0]))
print("All numbers:", sorted(nums))

x_avg = fmean(range(len(nums)))

p = sum((x - x_avg) * (y - y_avg) for (x, y) in zip(range(len(nums)), nums)) / sqrt(
    sum((x - x_avg) ** 2 for x in range(len(nums))) * sum((y - y_avg) ** 2 for y in nums))
print("Pearson correlation coefficient:", round(p, 4))
