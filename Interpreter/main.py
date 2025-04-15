def custom_strip():
    pass

def custom_split():
    pass

def tokenize(src_code):
    new_lst = []
    operators = {"+": "add", "-":"subtract", "/":"divide", "*":"multiply"}
    numx = ""
    for i in src_code:
        if i in operators:
            new_lst.append([numx, "Num"])
            numx = ""
            new_lst.append([i,operators[i]])
        else:
            numx += i
    new_lst.append([numx, "Num"])
    return new_lst



print(tokenize("12+1"))