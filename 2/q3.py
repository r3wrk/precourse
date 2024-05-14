# s/polyndrom/palindrome?

def is_sorted_polyndrom(s: str) -> bool:
    return s == s[::-1] and sorted(s[:-((-len(s)) // 2)]) == list(s[:-((-len(s)) // 2)])
