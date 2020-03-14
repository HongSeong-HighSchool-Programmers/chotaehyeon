
rare = ["a", "b", "c", "d"]
epic = ["a", "b", "c", "d"]
unique = ["a", "b", "c", "d"]

print("아이템 가치 판단 프로그래밍 시작!\n")

def rarity(price):

  if price < 1000:
    print("이 아이템은 %d원이므로 희귀입니다.\n" % price)
    if "a" in rare:
     rare[0] = price
    elif "b" in rare:
     rare[1] = price
    elif "c" in rare:
     rare[2] = price
    else :
     rare[3] = price

  elif price >= 1000 and price <=5000:
    print("이 아이템은 %d원이므로 에픽입니다.\n" % price)
    if "a" in epic:
     epic[0] = price
    elif "b" in epic:
     epic[1] = price
    elif "c" in epic:
     epic[2] = price
    else :
     epic[3] = price

  else:
    print("이 아이템은 %d원이므로 유니크입니다.\n" % price)
    if "a" in unique:
     unique[0] = price
    elif "b" in unique:
     unique[1] = price
    elif "c" in unique:
     unique[2] = price
    else :
     unique[3] = price

rarity(1000)
rarity(10)
rarity(10000)
rarity(3000)
rarity(1500)

print(rare)
print(epic)
print(unique)
