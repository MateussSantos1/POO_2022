mercados = int(input())
x = 0
menor = 1000000000
info = 0
reais = 0
gramas = 0
produto = 0
while x != mercados:
    x +=1
    info = input().split(" ")
    reais = float(info[0])
    gramas = float(info[1])
    produto = float(reais*gramas)
    if produto<= menor:
        menor = produto
if 1<=mercados<=100 and 0< reais<=1000.00 and 1<= gramas<=1000:
    print("{:.2f}".format(menor /10))