import sys

user1 = input("Enter Your Name : ")
user2 = input("And Your Name? : ")
user3 = input("And Who Are You? : ")
user1_answer = input("%s,what do you want to choose rock,paper,or scissor? : "%user1)
user2_answer = input("%s,What Do You want to choose rock,paper,or scissor? : "%user2)
user3_answer = input("%s,What Do You want to choose rock,paper,or scissor? : "%user3)

def compare(u1,u2,u3):
    if u1 == u2:
        return ("Match Is Tie!!")
    elif u1 == "rock":
        if u2 == "paper":
            return ("scissor win!!")
        else:
            return ("paper win!!")
    elif u1 == "paper":
        if u2 == "scissor":
            return ("scissor win!!")
        else:
            return ("rock win!")
    elif u1 == "scissor":
        if u2 == "rock":
            return ("paper win!!")
        else:
            return ("scissor win!!")

    if u2 == u3:
        return ("Match Is Tie!!")
    elif u2 == "paper":
        if u3 == "scissor":
            return ("rock win!!")
        else:
            return ("scissor win!!")
    elif u2 == "scissor":
        if u3 == "rock":
            return ("rock win!!")
        else:
            return ("paper win!")
    elif u2 == "rock":
        if u3 == "paper":
            return ("paper win!!")
        else:
            return ("scissor win!!")

    if u1 == u3:
        return ("Match Is Tie!!")
    elif u1 == "scissor":
        if u3 == "paper":
            return ("scissor win!!")
        else:
            return ("rock win!!")
    elif u1 == "rock":
        if u3 == "scissor":
            return ("rock win!!")
        else:
            return ("paper win!")
    elif u1 == "paper":
        if u3 == "rock":
            return ("paper win!!")
        else:
            return ("scissor win!!")


    else:
        return ("Invalid Input!!\ntry Agin!!")
        sys.exit()

print(compare(user1_answer,user2_answer,user3_answer))
