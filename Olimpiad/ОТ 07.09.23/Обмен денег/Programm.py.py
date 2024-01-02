mas1=input().split(' ')
n1=int(mas1[0])
mas1.pop(0)
for i in range(len(mas1)):
    mas1[i]=int(mas1[i])
lst1=input().split(' ')
for i in range(len(lst1)):
    lst1[i]=int(lst1[i])
    
mas2=input().split(' ')
n2=int(mas2[0])
mas2.pop(0)
for i in range(len(mas2)):
    mas2[i]=int(mas2[i])
lst2=input().split(' ')
for i in range(len(lst2)):
    lst2[i]=int(lst2[i])
lst1.pop(0)
lst2.pop(0)
lst1.sort()
lst2.sort()
money=input().split(' ')

for i in range(len(money)):
    money[i]=int(money[i])

for i in range(len(money)):
    k=0
    for j in range(len(lst1)):
        if money[i]>=lst1[j]:
            k+=1
    money[i]-=k

for i in range(len(money)-1):
    money[i+1]=money[i]*mas1[i]+money[i+1]
money=[money[-1]]
    
for i in range(n2-1):
    money.append(money[i]//mas2[len(mas2)-i-1])
    money[i]%=mas2[len(mas2)-1-i]
money=money[::-1]

for i in range(len(money)):
    k=0
    for j in range(len(lst2)):
        if money[i]>=lst2[j]:
            money[i]+=1
    money[i]=str(money[i])
print(" ".join(money))
