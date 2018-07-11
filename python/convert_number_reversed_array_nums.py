def digitize(n):
    nums = [int(data) for data in str(n)]
    return list(reversed(nums))

def digitize2(n):
    '''
    just wanted to see if it works all in one line and it does
    '''
    return list(reversed([int(data) for data in str(n)]))
