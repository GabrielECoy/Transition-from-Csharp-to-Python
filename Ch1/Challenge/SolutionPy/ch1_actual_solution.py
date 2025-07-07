#Solution of the actual problem describged in the challenge

show_expected_result = False
show_hints = False

def get_longest_str_len(the_strs):
    if the_strs is None or not the_strs:
        return 0

    maxlength : int = 0
    for str in the_strs:
        maxlength = len(str) if len(str)>maxlength else maxlength

    return maxlength