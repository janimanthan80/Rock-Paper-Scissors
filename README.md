        #rock-paper-scissors
def my_game(person,cpu):
  list1 = ["rock","paper","scissors","draw"]

  for i in range(0,4):
    person = str(input("My turn : ")) 
    cpu = str(input("cpu turn : ")) 

    if person == "rock" and cpu == "paper" or person == "paper" and cpu == "rock":
      return list1[1] 
    if person == "paper" and cpu == "paper":
      return list1[3] 

    if person == "paper" and cpu == "scissors" or person == "scissors" and cpu == "paper":
      return list1[2] 
    if person == "scissors" and cpu == "scissors":
      return list1[3]  

    if person == "scissors" and cpu == "rock" or person == "rock" and cpu == "scissors":
      return list1[0]
    if person == "rock" and cpu == "rock":
      return list1[3]  

    else:
      print("invalid option")

  

print(my_game("person","cpu"))
