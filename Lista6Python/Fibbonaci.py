a = 0
b = 1
c = 0
x = 0
qtd = int(input("Digite a quantidade de valores da sequência que serão exibidos: "))
while (x != qtd):
    print(a)
    c = a +b
    b = c
    a = b
    x += 1 
    