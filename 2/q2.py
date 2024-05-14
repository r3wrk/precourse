from math import isqrt


def pythagorean_triplet_by_sum(s):
    for c in range(1, s):
        # a**2+(apb-a)**2=csq  =>
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


def pythagorean_triplet_by_sum_v0(s):  ##
    for c in range(s):
        for b in range(max(1, (s - c) // 2 + ((s - c) % 2)), min(c, s - c)):
            a = s - c - b
            if a ** 2 + b ** 2 == c ** 2:
                print(a, b, c)
