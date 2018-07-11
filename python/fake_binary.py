def fake_bin(x):
    nums = [int(data) for data in str(x)]
    answer = ''
    
    for x in nums:
        if x < 5:
            answer += '0'
        else:
            answer += '1'
    return answer
