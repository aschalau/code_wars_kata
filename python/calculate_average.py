def find_average_1(array):
    if len(array) > 0:
        return sum(n for n in array) / len(array)
    return 0

# this was my original that I couldn't make work because I forgot
# to put the else in the check
def find_average_2(array):
    return sum(n for n in array) / len(array) if array else 0
