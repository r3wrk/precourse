from math import isqrt


def pythagorean_triplet_by_sum(s: int):
    for c in range(1, s):
        # a**2+(apb-a)**2=csq  => 2*a**2-2*apb*a+(apb**2-csq)=0
        # => a=(-2±sqrt(4*apb**2-4*2*(apb**2-csq))/(2*2)
        # => a=(-1±sqrt(2*csq - apb**2))/(2)
        apb = s - c
        csq = c ** 2
        d = 2 * csq - apb ** 2
        if d < 0:
            continue
        d_root = isqrt(d)
        if d_root ** 2 != d:
            continue
        if d_root >= apb:
            continue
        print((apb - d_root) // 2, (apb + d_root) // 2, c)


def pythagorean_triplet_by_sum_v0(s: int):
    for c in range(s):
        for b in range(1, c):
            a = s - c - b
            if 0 < a < b < c and a ** 2 + b ** 2 == c ** 2:
                print(a, b, c)
