from fractions import Fraction as Frac
from itertools import count


def reverse_n_pi_digits(n: int) -> str:
    pi = 0
    for k in count():
        # BBP formula
        pi += (Frac(4, 8 * k + 1) - Frac(2, 8 * k + 4) - Frac(1, 8 * k + 5) - Frac(1, 8 * k + 6)) / (16 ** k)
        # check if the rest of the series could possibly alter the first n digits
        if 1 - ((pi * (10 ** (n - 1))) % 1) > (10**(n-1))*Frac(16, 15)/(16**(k+1)):
            return str(int(pi * (10 ** (n - 1))))[::-1]
