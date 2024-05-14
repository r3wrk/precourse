from math import log10, ceil


def num_len(n: int) -> int:
    return ceil(log10(n + 1))  # inaccurate for very large integers
