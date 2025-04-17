def tokenize(src_code):
    src_code = src_code.replace(" ", "")
    new_lst = []
    operators = {"+": "add", "-":"subtract", "/":"divide", "*":"multiply", "(": "left_parenthesis", ")": "right_parenthesis"}
    numx = ""
    for i in src_code:
        if i in operators:
            if i == "(" or i == ")":
                new_lst.append([i, operators[i]])
            else:
                new_lst.append([numx, "Num"])
                numx = ""
                new_lst.append([i,operators[i]])
        else:
            numx += i
    new_lst.append([numx, "Num"])
    return new_lst

token = tokenize("((333*33+     4)        /2-55+)100")
for i in token:
    print(i)


