entrada = 0
num = 2002
while(entrada != num):
    entrada = int(input("Digite uma senha para tentar abrir o cofre!!!"))
    if entrada != num:
        print("Senha Incorreta!!!")
    elif entrada == num:
        print("Senha Correta!!!")
    