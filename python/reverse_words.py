def reverse_words_1(text):
    arr = text.split(' ')

    final = ''
    for w in arr:
        final += ' '
        for l in range(len(w) - 1, -1, -1):
            final += w[l]

    return final.strip()

# Best Practice from Solutions
def reverse_words_2(str):
    return ' '.join(s[::-1] for s in str.split(' '))
