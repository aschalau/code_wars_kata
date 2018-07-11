def alphabet_position(text):
    alpha = [letter for letter in 'abcdefghijklmnopqrstuvwxyz']
    sentence = [letter.lower() for letter in text]
    coded_sentence = ''

    for i in range(0, len(sentence)):
        if sentence[i] in alpha:
            coded_sentence += str(alpha.index(sentence[i]) + 1) + ' '

    return coded_sentence.strip()
