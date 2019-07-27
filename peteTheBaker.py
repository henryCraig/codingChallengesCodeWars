#https://www.codewars.com/kata/525c65e51bf619685c000059/train/python

def cakes(recipe, available):
    recipeKeyList = recipe.keys()
    availableKeyList = available.keys()
    minimumNum = 0
    for ingredient in recipeKeyList:
        if ingredient in availableKeyList:
            amountPossible = int(available[ingredient]/recipe[ingredient])
            if (amountPossible <= 0):
                return 0
            else:
                if minimumNum == 0:
                    minimumNum = amountPossible
                elif amountPossible < minimumNum:
                    minimumNum = amountPossible
        else:
            return 0
    return minimumNum

print("returned:", cakes({"sugar": 400, "flour": 500}, {"sugar": 1200, "flour": 1500}))







#space
