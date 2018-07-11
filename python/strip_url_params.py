'''
Parse the URL and the PARAMETERS
Check params_to_strip to exclude those
'''
def strip_url_params(data, params_to_strip = []):
    print('Starting point: {}\n'.format(data))

    '''
    Don't waste any cycles if the only thing is the base url
    '''
    if '?' not in data:
        return data

    '''
    Parse out the base url and the params from the data
    '''
    base_url, params = data.split('?')

    '''
    There are no parameters, so return the base url
    '''
    if not params:
        return base_url

    '''
    Parse out the parameters into a list
    '''
    param_list = params.split('&')

    '''
    Parsing out the keys to check for duplicates
    '''
    keys = [param.split('=')[0] for param in param_list]

    '''
    Looping through the params from the back to keep the first occurance of any dup
    '''
    for i in range(len(param_list) - 1, 0, -1):
        '''
        Checking keys for dupes or filterig out keys, then delete them out of the list
        '''
        if keys[i] in params_to_strip or keys[i] in keys[:i]:
            param_list.pop(i)


    '''
    Check to see if there is a param_list left. If there is, return full URL
    '''
    if param_list:
        return base_url + '?' + '&'.join(param_list)

    '''
    Return base url if no params after filtering
    '''
    return base_url

url1 = 'www.codewars.com'
url2 = 'www.codewars.com?a=1&b=2&a=2'
url3 = 'www.codewars.com?'

'''
The final piece that I was stuck on came from
https://github.com/8fdafs2/Codewars-Solu-Python/blob/87952b4385114b26b483c05fe72b9eb9732cc02d/src/kyu4_Strip_Url_Params.py
> line 57 => ns[i] in ns[:1]
'''
