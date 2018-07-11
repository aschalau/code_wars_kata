def abbrevName(name):
    first, last = name.split(' ')
    return '{}.{}'.format(first[0].upper(), last[0].upper())

def abbrevName2(name):
    first, last = name.upper().split()
    return '{}.{}'.format(first[0], last[0])

def abbrevName3(name):
    return '.'.join(l[0] for l in name.upper().split())
