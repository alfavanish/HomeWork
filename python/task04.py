# Найти максимальное из трех чисел
def max(a,b,c):
    max=a
    if max<b:
        max=b
    if max<c:
        max=c
    return max
print(max(40,30,70))
    