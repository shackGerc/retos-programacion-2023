for i in range(1, 101):
    isAthreeMultiple = i%3 == 0
    isAFiveMultiple = i%5 == 0
    if(isAthreeMultiple and isAFiveMultiple):
        print("fizzbuzz")
    elif(isAthreeMultiple):
        print("fizz")
    elif(isAFiveMultiple):
        print("buzz")
    else:
        print(i)