def count_sheep(n):
    sheep = ''
    for i in range(0, n):
        sheep += '{} sheep...'.format(i + 1)

    return sheep

def count_sheep_1(n):
    return ''.join('{} sheep...'.format(i) for i in range(1, n+1))
