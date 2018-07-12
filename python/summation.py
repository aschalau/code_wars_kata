def summation(num):
    return_value = 0
    while num:
        return_value += num
        num -= 1
    return return_value

def summation2(num):
    return sum(range(0, num + 1))
